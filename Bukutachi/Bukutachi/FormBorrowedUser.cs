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
                CONCAT('Shelf ', bu.bu_rb_id) as 'Book Location',
                bu.bu_status as 'Status'
                FROM
                buku bu 
                JOIN buku_penulis bp ON bp.bp_bu_id = bu.bu_id
                JOIN penulis ps ON bp.bp_ps_id = ps.ps_id
                {queryWhere}
                GROUP BY bu.bu_title
            ", conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvBorrowedBooks.DataSource = dt;
            if (!dgvBorrowedBooks.Columns.Contains("Action")) {
                DataGridViewDisableButtonColumn btncol = new DataGridViewDisableButtonColumn();
                btncol.DefaultCellStyle.Padding = new Padding(10);
                btncol.Text = "Cancel";
                btncol.Name = "Action";
                btncol.UseColumnTextForButtonValue = true;
                dgvBorrowedBooks.Columns.Add(btncol);
            }
            dgvBorrowedBooks.Columns["Status"].Visible = false;
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

        private void dgvBorrowedBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if(dgvBorrowedBooks.Columns[e.ColumnIndex].Name == "Action") {
                if(Convert.ToInt32(dgvBorrowedBooks.Rows[e.RowIndex].Cells["Status"].Value) == 2) {
                    ((DataGridViewDisableButtonCell)dgvBorrowedBooks.Rows[e.RowIndex].Cells["Action"]).Hide = true;

                    dgvBorrowedBooks.Invalidate();
                }
            }
        }

        public class DataGridViewDisableButtonColumn : DataGridViewButtonColumn {
            public DataGridViewDisableButtonColumn() {
                this.CellTemplate = new DataGridViewDisableButtonCell();
            }
        }

        public class DataGridViewDisableButtonCell : DataGridViewButtonCell {
            private bool hidaValue;

            public bool Hide {
                get {
                    return hidaValue;
                }
                set {
                    hidaValue = value;
                }
            }

            public DataGridViewDisableButtonCell() {
                this.hidaValue = false;
            }

            public override object Clone() {
                DataGridViewDisableButtonCell c = (DataGridViewDisableButtonCell)base.Clone();

                c.Hide = this.Hide;
                return c;
            }

            protected override void Paint(Graphics graphics,
              Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
              DataGridViewElementStates elementState, object value,
              object formattedValue, string errorText,
              DataGridViewCellStyle cellStyle,
              DataGridViewAdvancedBorderStyle advancedBorderStyle,
              DataGridViewPaintParts paintParts) {
                if (this.hidaValue) {
                    if ((paintParts & DataGridViewPaintParts.Background) == DataGridViewPaintParts.Background) {
                        SolidBrush cellBackground = new SolidBrush(cellStyle.BackColor);

                        graphics.FillRectangle(cellBackground, cellBounds);

                        cellBackground.Dispose();
                    }

                    if ((paintParts & DataGridViewPaintParts.Border) == DataGridViewPaintParts.Border) {
                        PaintBorder(graphics, clipBounds, cellBounds, cellStyle,advancedBorderStyle);
                    }

                }
                else {
                    base.Paint(graphics, clipBounds, cellBounds, rowIndex,elementState, value, formattedValue, errorText,cellStyle, advancedBorderStyle, paintParts);
                }
            }
        }
    }
}
