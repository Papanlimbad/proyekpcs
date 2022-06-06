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
            MySqlCommand cmd = new MySqlCommand("SELECT me_id AS 'ID Member', me_name AS 'Nama', me_username AS 'Username' FROM MEMBER;", conn);
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

            MySqlCommand cmd = new MySqlCommand("SELECT me_id AS 'ID Member', me_name AS 'Nama', me_username AS 'Username' FROM MEMBER;", conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dsBorrowed = new DataSet();
            da.Fill(dsBorrowed);
            dgvUser.DataSource = dsBorrowed.Tables[0].DefaultView;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            EditAccountAdmin ea = new EditAccountAdmin(conn);
            ea.ShowDialog();
            ea.Dispose();

            MySqlCommand cmd = new MySqlCommand("SELECT me_id AS 'ID Member', me_name AS 'Nama', me_username AS 'Username' FROM MEMBER;", conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dsBorrowed = new DataSet();
            da.Fill(dsBorrowed);
            dgvUser.DataSource = dsBorrowed.Tables[0].DefaultView;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
