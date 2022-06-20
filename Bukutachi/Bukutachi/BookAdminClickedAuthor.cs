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
    public partial class BookAdminClickedAuthor : Form
    {
        MySqlConnection conn;
        string ambilpenulis;
        public BookAdminClickedAuthor(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            loadDatagrid();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            loadDatagrid();
        }

        private void loadDatagrid()
        {
            string kueri = "SELECT * FROM penulis";

            if (tbAuthor.Text != "")
            {
                kueri += " WHERE ps_name LIKE '%" + tbAuthor.Text + "%'";
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

        private void BookAdminClickedAuthor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvAuthor.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void dgvPenerbit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ambilpenulis = dgvAuthor.Rows[e.RowIndex].Cells[1].Value.ToString();
            MessageBox.Show("Berhasil pilih penulis " + ambilpenulis);         
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            FormBooksAdminClicked.iniauthor = ambilpenulis;
            this.Dispose();
        }
    }
}
