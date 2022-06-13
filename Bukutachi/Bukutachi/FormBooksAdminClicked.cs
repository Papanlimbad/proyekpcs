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
using System.Text.RegularExpressions;



namespace Bukutachi
{
    public partial class FormBooksAdminClicked : Form
    {
        int bookId;
        MySqlConnection conn;
        Form lastPage;
        HomeAdmin progadmin;
        string idpinjam;
        String[] user = new String[8];

        public FormBooksAdminClicked(MySqlConnection conn, int id, Form lastPage, String[] user)
        {
            InitializeComponent();
            bookId = id;
            this.conn = conn;
            this.lastPage = lastPage;
            this.idpinjam = idpinjam;
            this.user = user;
        }

        private void btEditData_Click(object sender, EventArgs e)
        {
          // string sql = "update buku set bu_title=?title, ";
        }

        private void FormBooksAdminClicked_Load(object sender, EventArgs e)
        {
            this.progadmin = ((HomeAdmin)(this.Parent.Parent));
            MySqlCommand cmd = new MySqlCommand(@"
                SELECT bu.bu_title AS 'Title', GROUP_CONCAT(DISTINCT ps.ps_name) AS 'Author', GROUP_CONCAT(DISTINCT ge.ge_name) AS 'Genres', bu.bu_publishedat AS 'Publish Date', pt.pt_name AS 'Publisher', bu.bu_rb_id AS 'Location', bu.bu_status AS 'Status', bu.bu_synopsis AS 'Description', bu.bu_large AS 'Image', h.hp_me_id AS 'Pinjam', me.me_name AS 'Member', h.hp_borrowedat AS 'borrowdate', h.hp_returnat AS 'returndate'
                FROM buku bu 
                JOIN penerbit pt ON bu.bu_pt_id = pt.pt_id
                JOIN buku_penulis bp ON bu.bu_id = bp.bp_bu_id
                JOIN penulis ps ON ps.ps_id = bp.bp_ps_id
                JOIN genre_buku gb ON gb.gb_bu_id = bu.bu_id
                JOIN genre ge ON gb.gb_ge_id = ge.ge_id
                LEFT JOIN hpinjam h ON hp_id=bu_id 
                LEFT JOIN MEMBER me ON me_id=hp_id
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

            tbBookTitle.Text= dt.Rows[0]["Title"].ToString();
            tbAuthor.Text = dt.Rows[0]["Author"].ToString();
            tbGenre.Text = dt.Rows[0]["Genres"].ToString();
            tbPublisher.Text = dt.Rows[0]["Publisher"].ToString();
            tbPublishDate.Text = dt.Rows[0]["Publish Date"].ToString();
            tbLocation.Text = $"Shelf {dt.Rows[0]["Location"]}";
            guna2PictureBox1.Image= WebImage.resizeImage(WebImage.fromUrl(dt.Rows[0]["Image"].ToString()), guna2PictureBox1.Width, guna2PictureBox1.Height);
            
           
           
            //Form Borrow

            tbBookName.Text= dt.Rows[0]["Title"].ToString();
            tbBorrowerUsername.Text = dt.Rows[0]["Member"].ToString();

            if (tbBorrowerUsername.Text != "")
            {
                DateBorrowed.Value = Convert.ToDateTime(dt.Rows[0]["borrowdate"]);
                DateReturned.Value = Convert.ToDateTime(dt.Rows[0]["returndate"]);
            }



            if (Convert.ToInt32(dt.Rows[0]["Status"]) == 0)
            {
                lbStock.Text = "Status : Lost";
            }
            else if (Convert.ToInt32(dt.Rows[0]["Status"]) == 1)
            {
                lbStock.Text = "Status : Avaible";
            }
            else if (Convert.ToInt32(dt.Rows[0]["Status"]) == 2)
            {
                lbStock.Text = "Status : Borrowed";
            }
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            ((HomeAdmin)(this.Parent.Parent)).loadadmin(lastPage);
        }

        private void btCreateForm_Click(object sender, EventArgs e)
        {

        }

        private void DateBorrow_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
