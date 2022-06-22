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
    public partial class BookAdminClickedPenerbit : Form
    {
        MySqlConnection conn;
        string ambilpenerbit;
        public BookAdminClickedPenerbit(MySqlConnection conn)
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
            string kueri = "SELECT * FROM penerbit";

            if (tbPenerbit.Text != "")
            {
                kueri += " WHERE pt_name LIKE '%" + tbPenerbit.Text + "%'";
            }
            MySqlCommand cmd = new MySqlCommand(kueri, conn);
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dsBorrowed = new DataSet();
            da.Fill(dsBorrowed);
            dgvPenerbit.DataSource = dsBorrowed.Tables[0].DefaultView;
            dgvPenerbit.Columns[0].Visible = false;
        }

        private void BookAdminClickedPenerbit_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvPenerbit.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void dgvPenerbit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            FormBooksAdminClicked.inipenerbit = ambilpenerbit;
            this.Dispose();
        }

        private void dgvPenerbit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ambilpenerbit = dgvPenerbit.Rows[e.RowIndex].Cells[1].Value.ToString();
            MessageBox.Show("Berhasil pilih penulis " + ambilpenerbit);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddPenerbit author = new FormAddPenerbit(conn);
            author.ShowDialog();
            loadDatagrid();
            author.Dispose();
        }
    }
}
