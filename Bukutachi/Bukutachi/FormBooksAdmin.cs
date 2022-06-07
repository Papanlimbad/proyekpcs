using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bukutachi
{
    public partial class FormBooksAdmin : Form
    {
        MySqlConnection conn;
        String[] user = new string[8];
        public FormBooksAdmin()
        {
            InitializeComponent();
        }

        private void FormBooksAdmin_DoubleClick(object sender, EventArgs e)
        {
            InitializeComponent();
            foreach (DataGridViewColumn column in dgvBorrowedBooks.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.conn = conn;
            this.user = user;
            rbAsc.Checked = Enabled;
            cbFilter.SelectedIndex = 0;
            cbSearchBy.SelectedIndex = 0;
            cbSortBy.SelectedIndex = 0;
            loadDataGrid();
            loadcombobox();
        }

        private void loadDataGrid()
        {
            String kueri = @"SELECT bu.bu_id,
            bu.bu_title AS 'Title',
            GROUP_CONCAT(DISTINCT ge.ge_name) AS 'Genre',
            GROUP_CONCAT(DISTINCT ps.ps_name) AS 'Author',
            pt.pt_name AS 'Publisher',
            bu.bu_publishedat AS 'Published Year'
            FROM buku bu
            JOIN penerbit pt ON bu.bu_pt_id = pt.pt_id
            JOIN buku_penulis bp ON bu.bu_id = bp.bp_bu_id
            JOIN penulis ps ON ps.ps_id = bp.bp_ps_id
            JOIN genre_buku gb ON gb.gb_bu_id = bu.bu_id
            JOIN genre ge ON gb.gb_ge_id = ge.ge_id

            ";
            //search
            if (!cbSearchBy.Text.Equals("-"))
            {
                if (cbSearchBy.Text.Equals("Title"))
                {
                    kueri += "WHERE bu.bu_title LIKE '%" + tbUsername.Text + "%'";
                }
                else if (cbSearchBy.Text.Equals("Author"))
                {
                    kueri += "WHERE ps.ps_name LIKE '%" + tbUsername.Text + "%'";
                }
                else if (cbSearchBy.Text.Equals("Publisher"))
                {
                    kueri += "WHERE pt.pt_name LIKE '%" + tbUsername.Text + "%'";
                }
            }

            //genre
            if (!cbFilter.Text.Equals("All"))
            {
                kueri += " AND ge.ge_name = '" + cbFilter.Text + "'";
            }
            kueri += "            GROUP BY bu.bu_title";

            //tipe sort
            if (cbSortBy.Text.Equals("Title"))
            {
                kueri += " ORDER BY 1";
            }
            else if (cbSortBy.Text.Equals("Author"))
            {
                kueri += " ORDER BY 3";
            }
            else if (cbSortBy.Text.Equals("Published Date"))
            {
                kueri += " ORDER BY 5";
            }
            //asc desc
            if (rbAsc.Checked == true)
            {
                kueri += " ASC;";
            }
            else
            {
                kueri += " DESC;";
            }

            MySqlCommand cmd = new MySqlCommand(kueri, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dsBorrowed = new DataSet();
            da.Fill(dsBorrowed);
            dgvBorrowedBooks.DataSource = dsBorrowed.Tables[0].DefaultView;
            dgvBorrowedBooks.Columns[0].Visible = false;
        }
        private void loadcombobox()
        {
            string query = "SELECT ge_name AS \"Jenis\" FROM genre";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            conn.Open();
            cmd.ExecuteReader();
            conn.Close();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dtGenre = new DataTable();

            da.Fill(dtGenre);
            DataRow rowbaru;
            rowbaru = dtGenre.NewRow();
            rowbaru["Jenis"] = "All";
            dtGenre.Rows.InsertAt(rowbaru, 0);
            cbFilter.DisplayMember = "Jenis";
            cbFilter.DataSource = dtGenre.DefaultView;
            cbFilter.SelectedIndex = 0;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void dgvBorrowedBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ((HomeUser)(this.Parent.Parent)).loadForm(new FormBooksUserClicked(conn, Convert.ToInt32(dgvBorrowedBooks.Rows[e.RowIndex].Cells[0].Value), this));
        }
    }
}
