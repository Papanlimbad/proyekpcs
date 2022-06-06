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
    public partial class FormBooksUserClicked : Form
    {
        int bookId;
        MySqlConnection conn;
        Form lastPage;
        HomeUser prog;
        public FormBooksUserClicked(MySqlConnection conn ,int id, Form lastPage)
        {
            InitializeComponent();
            bookId = id;
            this.conn = conn;
            this.lastPage = lastPage;
        }

        private void FormBooksUserClicked_Load(object sender, EventArgs e) {
            this.prog = ((HomeUser)(this.Parent.Parent));
            MySqlCommand cmd = new MySqlCommand(@"
                SELECT bu.bu_title as 'Title', group_concat(DISTINCT ps.ps_name) as 'Author', group_concat(DISTINCT ge.ge_name) as 'Genres', bu.bu_publishedat as 'Publish Date', pt.pt_name as 'Publisher', bu.bu_rb_id as 'Location', bu.bu_status as 'Status', bu.bu_synopsis as 'Description', bu.bu_large as 'Image'
                FROM buku bu 
                JOIN penerbit pt ON bu.bu_pt_id = pt.pt_id
                JOIN buku_penulis bp ON bu.bu_id = bp.bp_bu_id
                JOIN penulis ps ON ps.ps_id = bp.bp_ps_id
                JOIN genre_buku gb ON gb.gb_bu_id = bu.bu_id
                JOIN genre ge ON gb.gb_ge_id = ge.ge_id
                WHERE bu.bu_id = ?ID
                GROUP BY bu.bu_title
            ", conn);

            cmd.Parameters.Add(new MySqlParameter("ID", bookId));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lbBookTitle.Text = dt.Rows[0]["Title"].ToString();
            lbAuthor.Text = dt.Rows[0]["Author"].ToString();
            lbGenre.Text = dt.Rows[0]["Genres"].ToString();
            lbPublisher.Text = dt.Rows[0]["Publisher"].ToString();
            lbPublishDate.Text = dt.Rows[0]["Publish Date"].ToString();
            lbLocation.Text = $"Shelf {dt.Rows[0]["Location"]}";
            tbDescription.Text = dt.Rows[0]["Description"].ToString();
            pbCover.Image = WebImage.resizeImage(WebImage.fromUrl(dt.Rows[0]["Image"].ToString()), pbCover.Width, pbCover.Height);

            if(Convert.ToInt32(dt.Rows[0]["Status"]) == 0) {
                //Dipinjam
                lbAvailable.Text = "Borrowed";
                lbAvailable.ForeColor = Color.Red;
                btPinjam.Enabled = false;
                btCancel.Visible = false;
            }
            else if (Convert.ToInt32(dt.Rows[0]["Status"]) == 1) {
                //Available
                lbAvailable.Text = "Available";
                updateButtons();
            }
            else if (Convert.ToInt32(dt.Rows[0]["Status"]) == 2) {
                //Hilang / Rusak
                lbAvailable.Text = "Unavailable";
                lbAvailable.ForeColor = Color.Red;
                btPinjam.Enabled = false;
                btCancel.Visible = false;
            }
        }

        private void updateButtons() {
            btPinjam.Visible = !prog.isInCart(bookId);
            btCancel.Visible = prog.isInCart(bookId);
        }

        private void lbBack_Click(object sender, EventArgs e) {
            ((HomeUser)(this.Parent.Parent)).loadForm(lastPage);
        }

        private void btAddBook_Click(object sender, EventArgs e) {
            prog.addBookToCart(bookId);
            updateButtons();
        }

        private void btCancel_Click(object sender, EventArgs e) {
            prog.removeBookFromCart(bookId);
            updateButtons();
        }
    }
}
