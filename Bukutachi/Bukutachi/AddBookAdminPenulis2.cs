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
    public partial class AddBookAdminPenulis2 : Form
    {
        MySqlConnection conn;

        public AddBookAdminPenulis2(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            loadDatagrid();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadDatagrid();
        }

        private void loadDatagrid()
        {
            string kueri = "SELECT * FROM penulis";

            if (tbUsername.Text != "")
            {
                kueri += " WHERE ps_name LIKE '%" + tbUsername.Text + "%'";
            }
            MySqlCommand cmd = new MySqlCommand(kueri, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dsBorrowed = new DataSet();
            da.Fill(dsBorrowed);
            dgvAuthor.DataSource = dsBorrowed.Tables[0].DefaultView;
            dgvAuthor.Columns[0].Visible = false;
        }

        private void AddBookAdminPenulis2_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvAuthor.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvAuthor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ambilauthor2 = dgvAuthor.Rows[e.RowIndex].Cells[1].Value.ToString();
            MessageBox.Show("Berhasil pilih author pertama " + ambilauthor2);
            FormAddBookAdmin.iniauthor2 = ambilauthor2;
        }
    }
}
