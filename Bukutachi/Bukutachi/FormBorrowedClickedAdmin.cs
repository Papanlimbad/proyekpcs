using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Bukutachi
{
    public partial class FormBorrowedClickedAdmin : Form
    {
        Point posDrag;
        MySqlConnection conn;
        string id;
        int rowIdx=-1;
        public FormBorrowedClickedAdmin(MySqlConnection conn,string id)
        {
            InitializeComponent();
            this.conn = conn;
            this.id = id;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(MousePosition.X - posDrag.X, MousePosition.Y - posDrag.Y);
            }
        }

        private void pnTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            posDrag = new Point(e.X, e.Y);
        }

        private void FormBorrowedClickedAdmin_Load(object sender, EventArgs e)
        {
            lbIDPeminjam.Text = ": " + id;

            string sql = "select me_name from hpinjam, member where me_id=hp_me_id and hp_id=?id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", id);

            conn.Open();
            lbNamaPeminjam.Text = ": " + cmd.ExecuteScalar().ToString();
            conn.Close();

            loadDataGrid();
        }

        private void loadDataGrid()
        {
            String kueri = "SELECT dp_id AS 'Detail ID',bu_id as 'Book ID', bu_title AS 'Title', IF(bu_status=0,'Unavaible',IF(bu_status=1,'Available','Borrowed')) AS 'Status' FROM buku, hpinjam, dpinjam WHERE bu_id=dp_bu_id AND dp_hp_id=hp_id AND hp_id=?id;";
            MySqlCommand cmd = new MySqlCommand(kueri, conn);
            cmd.Parameters.AddWithValue("id", id);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dsBorrowed = new DataSet();
            da.Fill(dsBorrowed);
            dgvBorrow.DataSource = dsBorrowed.Tables[0].DefaultView;
        }

        private void dgvBorrow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIdx = e.RowIndex;
            btDelete.Enabled = true;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string idDpinjam = dgvBorrow.Rows[rowIdx].Cells[0].Value.ToString();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM dpinjam WHERE dp_id=?id", conn);
            cmd.Parameters.AddWithValue("id", idDpinjam);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            loadDataGrid();
            btDelete.Enabled = false;
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(dp_id) FROM dpinjam, hpinjam, MEMBER WHERE dp_hp_id = hp_id AND me_id = hp_me_id AND hp_id = ?id AND hp_status!= 2", conn);
            cmd.Parameters.AddWithValue("id", id);

            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            conn.Close();

            if (count>3)
            {
                MessageBox.Show("Jumlah Buku Yang Ingin/Sedang Dipinjam Melebihi Batas");
            }
            else
            {
                conn.Open();
                using (MySqlTransaction tr = conn.BeginTransaction())
                {
                    try
                    {
                        MySqlCommand cmd1 = new MySqlCommand("UPDATE hpinjam SET hp_status=1,hp_borrowedat=NOW() WHERE hp_id=?id", conn);
                        cmd1.Parameters.AddWithValue("id", id);
                        cmd1.ExecuteNonQuery();

                        MySqlCommand cmd2 = new MySqlCommand("UPDATE buku SET bu_status=2 WHERE bu_id IN (SELECT dp_bu_id FROM dpinjam WHERE dp_hp_id=?id);",conn);
                        cmd2.Parameters.AddWithValue("id", id);
                        cmd2.ExecuteNonQuery();

                        tr.Commit();

                        MessageBox.Show("Berhasil Melakukan Peminjaman!");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        tr.Rollback();
                    }
                }
                conn.Close();
            }
        }
    }
}
