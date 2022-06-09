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
            cbStatus.Text = "Standby";
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            String kueri = "SELECT hp_id AS 'ID', DATE_FORMAT(hp_borrowedat,'%d-%b-%Y') AS 'Borrowed Date', DATE_FORMAT(hp_returnat,'%d-%b-%Y') AS 'Return Date', DATE_FORMAT(DATE_ADD(hp_borrowedat,INTERVAL 7 DAY),'%d-%b-%Y') AS 'Expected Return Date', hp_status AS 'Status' FROM hpinjam, MEMBER, pegawai WHERE pe_id = hp_pe_id AND me_id = hp_me_id";
            kueri += $" AND hp_borrowedat >= {dtFrom.Value.ToShortDateString()} AND hp_borrowedat <= {dtTo.Value.ToShortDateString()}";

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

            if (cbStatus.Text.Equals("Standby"))
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
            loadDataGrid();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            cbFilter.Text = "Member's Name";
            cbStatus.Text = "Standby";
            dtFrom.Value = DateTime.Now;
            dtTo.Value = DateTime.Now;
            loadDataGrid();
        }
    }
}
