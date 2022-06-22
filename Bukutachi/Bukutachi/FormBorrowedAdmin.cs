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
    public partial class FormBorrowedAdmin : Form
    {
        MySqlConnection conn;
        public FormBorrowedAdmin(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void FormBorrowedAdmin_Load(object sender, EventArgs e)
        {
            cbFilter.Text = "Member's Name";
            cbStatus.Text = "Requesting";
            dtFrom.Value = DateTime.Now;
            dtTo.Value = DateTime.Now;
            loadDataGrid(true);
        }

        private void loadDataGrid(bool reset)
        {
            String kueri = "SELECT hp_id AS 'ID',me_name as 'Nama Peminjam', DATE_FORMAT(hp_borrowedat,'%d-%b-%Y') AS 'Borrowed Date', DATE_FORMAT(hp_returnat,'%d-%b-%Y') AS 'Return Date', DATE_FORMAT(DATE_ADD(hp_borrowedat,INTERVAL 7 DAY),'%d-%b-%Y') AS 'Expected Return Date', if(hp_status=0,'Requesting',if(hp_status=1,'Borrowing','Complete')) AS 'Status' FROM hpinjam, MEMBER, pegawai WHERE pe_id = hp_pe_id AND me_id = hp_me_id";
            if (!reset)
            {
                String dateFrom = dtFrom.Value.ToString("yyyy-MM-dd");
                String dateTo = dtTo.Value.ToString("yyyy-MM-dd");
                kueri += $" AND hp_borrowedat between '{dateFrom}' AND '{dateTo}'";

                if (cbStatus.Text.Equals("Requesting"))
                {
                    kueri += $" AND hp_status=0";
                }
                else if (cbStatus.Text.Equals("Borrowing"))
                {
                    kueri += $" AND hp_status=1";
                }
                else
                {
                    kueri += $" AND hp_status=2";
                }
            }

            if (!tbSearch.Text.Equals(""))
            {
                if (cbFilter.Text.Equals("Member's Name"))
                {
                    kueri += $" AND me_name like '%{tbSearch.Text}%'";
                }
                else
                {
                    kueri += $" AND bu_title like '%{tbSearch.Text}%'";
                }
            }

            Console.WriteLine(kueri);


            MySqlCommand cmd = new MySqlCommand(kueri, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dsBorrowed = new DataSet();
            da.Fill(dsBorrowed);
            dgvBorrow.DataSource = dsBorrowed.Tables[0].DefaultView;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            loadDataGrid(false);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            cbFilter.Text = "Member's Name";
            cbStatus.Text = "Requesting";
            dtFrom.Value = DateTime.Now;
            dtTo.Value = DateTime.Now;
            loadDataGrid(true);
        }

        private void dgvBorrow_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIdx = e.RowIndex;
            String id = dgvBorrow.Rows[rowIdx].Cells[0].Value.ToString();

            FormBorrowedClickedAdmin fb = new FormBorrowedClickedAdmin(conn, id, dgvBorrow.Rows[rowIdx].Cells[5].Value.ToString());
            fb.ShowDialog();
            fb.Dispose();

            loadDataGrid(true);
        }
    }
}
