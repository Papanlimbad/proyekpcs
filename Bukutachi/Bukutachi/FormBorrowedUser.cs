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
    public partial class FormBorrowedUser : Form
    {
        List<Int32> cart;
        MySqlConnection conn;
        public FormBorrowedUser(MySqlConnection conn, List<Int32> cart)
        {
            InitializeComponent();
            this.cart = cart;
            this.conn = conn;
        }

        private void FormBorrowedUser_Load(object sender, EventArgs e) {
            loadBorrowed();
        }

        private void loadBorrowed() {
            string queryWhere = "WHERE ";
            for (int i = 0; i < cart.Count; i++) {
                queryWhere += $"bu.bu_id = {cart[i]}";
                if (i < cart.Count - 1) {
                    queryWhere += " OR ";
                }
            }
            if (cart.Count == 0) {
                queryWhere = "WHERE 0";
            }
            MySqlCommand cmd = new MySqlCommand($@"
                SELECT 
                bu.bu_id as 'ID',
                bu.bu_title as 'Title', 
                group_concat(DISTINCT ps.ps_name) as 'Author',
                CURRENT_DATE() + INTERVAL 7 DAY  as 'Return',
                CONCAT('Shelf ', bu.bu_rb_id) as 'Book Location'
                FROM
                buku bu 
                JOIN buku_penulis bp ON bp.bp_bu_id = bu.bu_id
                JOIN penulis ps ON bp.bp_ps_id = ps.ps_id
                {queryWhere}
                GROUP BY bu.bu_title
            ", conn);

            Console.WriteLine(cmd.CommandText);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvBorrowedBooks.DataSource = dt;
            if (!dgvBorrowedBooks.Columns.Contains("Action")) {
                DataGridViewButtonColumn btncol = new DataGridViewButtonColumn();
                btncol.DefaultCellStyle.Padding = new Padding(10);
                btncol.Text = "Cancel";
                btncol.Name = "Action";
                btncol.UseColumnTextForButtonValue = true;
                dgvBorrowedBooks.Columns.Add(btncol);
            }
        }

        private void btClear_Click(object sender, EventArgs e) {
            cart.Clear();
            loadBorrowed();
        }

        private void dgvBorrowedBooks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int bid = Convert.ToInt32(dgvBorrowedBooks.Rows[e.RowIndex].Cells["ID"].Value);
            cart.Remove(bid);
            loadBorrowed();
        }
    }
}
