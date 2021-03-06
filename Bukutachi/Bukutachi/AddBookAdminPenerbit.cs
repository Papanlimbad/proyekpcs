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
    public partial class AddBookAdminPenerbit : Form
    {
        MySqlConnection conn;
        public string ambilpenerbit;
        String[] user = new String[8];
        Form lastPage;
        Point posDrag;

        public AddBookAdminPenerbit(MySqlConnection conn, Form lastPage, String[] User)
        {
            InitializeComponent();
            this.conn = conn;
            this.user = user;
            this.lastPage = lastPage ;
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

        private void AddBookAdminPenerbit_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvPenerbit.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            loadDatagrid();
        }

        private void dgvPenerbit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            ((HomeAdmin)(lastPage.Parent.Parent)).loadadmin(lastPage);
            
            this.Dispose();
        }

        private void dgvPenerbit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            ambilpenerbit = dgvPenerbit.Rows[e.RowIndex].Cells[1].Value.ToString();
            MessageBox.Show("Berhasil pilih penerbit " + ambilpenerbit);
            FormAddBookAdmin f = new FormAddBookAdmin(conn);
            FormAddBookAdmin.inipenerbit = ambilpenerbit;
            f.tbPublisher.Text = FormAddBookAdmin.inipenerbit;
            /*FormAddBookAdmin f = new FormAddBookAdmin(conn);
            TextBox tb = (TextBox)f.Controls["tbPenerbit"];
            tb.Text = ambilpenerbit;*/
        }

        private void btAddPublisher_Click(object sender, EventArgs e) {
            FormAddPenerbit penerbit = new FormAddPenerbit(conn);
            penerbit.ShowDialog();
            penerbit.Dispose();
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ambilpenerbit = "";
            FormAddBookAdmin.inipenerbit = ambilpenerbit;
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ambilpenerbit = "";
            FormAddBookAdmin.inipenerbit = ambilpenerbit;
        }

        private void pnTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            posDrag = new Point(e.X, e.Y);
        }

        private void pnTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(MousePosition.X - posDrag.X, MousePosition.Y - posDrag.Y);
            }
        }
    }
}
