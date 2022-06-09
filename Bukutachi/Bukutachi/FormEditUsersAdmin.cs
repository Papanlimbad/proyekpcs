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
    public partial class FormEditUsersAdmin : Form
    {
        MySqlConnection conn;
        public FormEditUsersAdmin(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void FormEditUsersAdmin_Load(object sender, EventArgs e)
        {
            cbFilter.Text = "Name";
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            String kueri = "SELECT me_id AS 'ID Member', me_name AS 'Nama', me_username AS 'Username', DATE_FORMAT(me_registeredat,'%d-%b-%Y') as 'Register Date' FROM MEMBER";
            //search

            if (!tbUsername.Text.Equals(""))
            {
                if (cbFilter.Text.Equals("Name"))
                {
                    kueri += $" WHERE me_name like '%{tbUsername.Text}%'";
                }
                else
                {
                    kueri += $" WHERE me_username like '%{tbUsername.Text}%'";
                }
            }

            if (rbAsc.Checked)
            {
                kueri += " ORDER BY me_id ASC";
            }
            else
            {
                kueri += " ORDER BY me_id DESC";
            }
            MySqlCommand cmd = new MySqlCommand(kueri, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dsBorrowed = new DataSet();
            da.Fill(dsBorrowed);
            dgvUser.DataSource = dsBorrowed.Tables[0].DefaultView;
        }

        private void dgvUser_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIdx = e.RowIndex;
            String id = dgvUser.Rows[rowIdx].Cells[0].Value.ToString();
            EditAccountAdmin ea = new EditAccountAdmin(conn, id);
            ea.ShowDialog();
            ea.Dispose();

            loadDataGrid();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            EditAccountAdmin ea = new EditAccountAdmin(conn);
            ea.ShowDialog();
            ea.Dispose();

            loadDataGrid();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            cbFilter.Text = "Name";
            rbAsc.Checked = true;
            tbUsername.Text = "";

            loadDataGrid();
        }
    }
}
