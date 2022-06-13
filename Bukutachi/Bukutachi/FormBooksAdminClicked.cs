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
    public partial class FormBooksAdminClicked : Form
    {
        int bookId;
        MySqlConnection conn;
        Form lastPage;
        HomeAdmin progadmin;
        public FormBooksAdminClicked(MySqlConnection conn, int id, Form lastPage)
        {
            InitializeComponent();
            bookId = id;
            this.conn = conn;
            this.lastPage = lastPage;
        }

        private void btEditData_Click(object sender, EventArgs e)
        {
           // string sql = "update buku set bu_title=?title, ";
        }

        private void FormBooksAdminClicked_Load(object sender, EventArgs e)
        {
            this.progadmin = ((HomeAdmin)(this.Parent.Parent));
            MySqlCommand cmd = new MySqlCommand(@"
                 SELECT bu.bu_title as 'Title', group_concat(DISTINCT ps.ps_name) as 'Author', group_concat(DISTINCT ge.ge_name) as 'Genres', bu.bu_publishedat as 'Publish Date', pt.pt_name as 'Publisher', bu.bu_rb_id as 'Location', bu.bu_status as 'Status', bu.bu_synopsis as 'Description', bu.bu_large as 'Image', IFNULL(floor(avg(ra_value)),'0') as 'Rating', COUNT(DISTINCT ra_id) as 'ReviewCount'
                FROM buku bu 
                JOIN penerbit pt ON bu.bu_pt_id = pt.pt_id
                JOIN buku_penulis bp ON bu.bu_id = bp.bp_bu_id
                JOIN penulis ps ON ps.ps_id = bp.bp_ps_id
                JOIN genre_buku gb ON gb.gb_bu_id = bu.bu_id
                JOIN genre ge ON gb.gb_ge_id = ge.ge_id
                LEFT JOIN rating ra ON ra.ra_bu_id = bu.bu_id
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

            if (Convert.ToInt32(dt.Rows[0]["Status"]) == 0)
            {
                lbStock.Text = "Status : Borrowed";
            }
            else if (Convert.ToInt32(dt.Rows[0]["Status"]) == 1)
            {
                lbStock.Text = "Status : Avaible";
            }
            else if (Convert.ToInt32(dt.Rows[0]["Status"]) == 2)
            {
                lbStock.Text = "Status : Unavaible";
            }
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            ((HomeAdmin)(this.Parent.Parent)).loadadmin(lastPage);
        }
    }
}
