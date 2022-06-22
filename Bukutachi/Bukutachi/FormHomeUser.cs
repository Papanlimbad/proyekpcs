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
    public partial class FormHomeUser : Form
    {
        MySqlConnection conn;
        String[] user = new string[8];
        PictureBox[] news;
        PictureBox[] populars;
        PictureBox[] recommends;
        DataSet homeBooks;
        bool updated = true;


        public FormHomeUser(MySqlConnection conn, String[] user, DataSet homeBook)
        {
            InitializeComponent();
            this.conn = conn;
            this.user = user;
            this.homeBooks= homeBook;

            if(homeBook.Tables.Count == 0) {
                homeBooks.Tables.Add(new DataTable("Newest"));
                homeBook.Tables["Newest"].Columns.Add(new DataColumn("id", typeof(int)));
                homeBook.Tables["Newest"].Columns.Add(new DataColumn("image", typeof(Image)));

                homeBooks.Tables.Add(new DataTable("Popular"));
                homeBook.Tables["Popular"].Columns.Add(new DataColumn("id", typeof(int)));
                homeBook.Tables["Popular"].Columns.Add(new DataColumn("image", typeof(Image)));

                homeBooks.Tables.Add(new DataTable("Recommended"));
                homeBook.Tables["Recommended"].Columns.Add(new DataColumn("id", typeof(int)));
                homeBook.Tables["Recommended"].Columns.Add(new DataColumn("image", typeof(Image)));

                updated = false;
            }
        }

        private void FormHomeUser_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "Welcome, " + user[1];
            news = new PictureBox[7] { pbNew1, pbNew2, pbNew3, pbNew4, pbNew5, pbNew6, pbNew7 };
            populars = new PictureBox[7] { pbPopular1, pbPopular2, pbPopular3, pbPopular4, pbPopular5, pbPopular6, pbPopular7 };
            recommends = new PictureBox[7] { pbRecommend1, pbRecommend2, pbRecommend3, pbRecommend4, pbRecommend5, pbRecommend6, pbRecommend7 };
            
            for (int i = 0; i < 7; i++) {
                news[i].Click += FormHomeUser_Click;
                populars[i].Click += FormHomeUser_Click;
                recommends[i].Click += FormHomeUser_Click;
            }
            if (!updated) {
                getNewestBook();
                getPopularBook();
                getRecommendedBook();
                ((HomeUser)(this.Parent.Parent)).updateHomeImage(homeBooks);
                updated = true;
            }
           loadImageToPictureBox();
        }

        private void FormHomeUser_Click(object sender, EventArgs e) {
            Console.WriteLine($"Opening Book {((PictureBox)sender).Tag.ToString()}");
            ((HomeUser)(this.Parent.Parent)).loadForm(new FormBooksUserClicked(conn, Convert.ToInt32(((PictureBox)sender).Tag.ToString()), this));
        }

        private void getPopularBook() {
            MySqlCommand cmd = new MySqlCommand(@"
                SELECT bu.bu_id as 'id', bu.bu_image as 'image'
                FROM buku bu 
                LEFT JOIN rating ra ON bu.bu_id = ra.ra_bu_id 
                GROUP BY bu.bu_id
                ORDER BY AVG(ra.ra_value) DESC, RAND()
                LIMIT 7;
            ", conn);

            if (conn.State == ConnectionState.Open) {
                conn.Close();
            }
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            DataTable books = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(books);
            for (int i = 0; i < 7; i++) {
                DataRow r = homeBooks.Tables["Popular"].NewRow();
                r["id"] = books.Rows[i]["id"];
                r["image"] = WebImage.fromUrl(books.Rows[i]["image"].ToString());
                homeBooks.Tables["Popular"].Rows.Add(r);
                Console.WriteLine($"Loading from {books.Rows[i]["image"]}");
            }
        }

        private void getRecommendedBook() {
            MySqlCommand cmd = new MySqlCommand(@"SELECT COUNT(*) FROM hpinjam WHERE hp_me_id = ?membid", conn);
            cmd.Parameters.Add(new MySqlParameter("membid", user[0]));

            if (conn.State == ConnectionState.Open) {
                conn.Close();
            }
            conn.Open();
            int countPinjam = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            cmd = new MySqlCommand(@"SELECT bu_id as 'id', bu_image as 'image' FROM buku ORDER BY RAND() LIMIT 7", conn);

            if(countPinjam > 0) {
                cmd = new MySqlCommand(@"
                ((SELECT bu_id AS 'id', bu_title AS 'Title', bu_image AS 'image' FROM buku
                WHERE bu_id IN
                (SELECT DISTINCT gb_bu_id AS 'ID' FROM genre_buku WHERE gb_ge_id IN
                (SELECT DISTINCT gb_ge_id FROM genre_buku WHERE gb_bu_id IN
                (SELECT dp_bu_id FROM dpinjam WHERE dp_hp_id IN 
                (SELECT hp_id FROM hpinjam WHERE hp_me_id = ?membid)))
                EXCEPT
                SELECT dp_bu_id AS 'ID' FROM dpinjam WHERE dp_hp_id IN 
                (SELECT hp_id FROM hpinjam WHERE hp_me_id = ?membid)))
                ORDER BY RAND()
                LIMIT 7)
                UNION
                (SELECT bu_id AS 'id', bu_title AS 'Title', bu_image AS 'image' FROM buku
                ORDER BY RAND()
                LIMIT 7)
                LIMIT 7;
                ", conn);
                cmd.Parameters.Add(new MySqlParameter("membid", user[0]));
            }

            

            if(conn.State == ConnectionState.Open) {
                conn.Close();
            }
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            DataTable books = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(books);
            for (int i = 0; i < 7; i++) {
                DataRow r = homeBooks.Tables["Recommended"].NewRow();
                r["id"] = books.Rows[i]["id"];
                r["image"] = WebImage.fromUrl(books.Rows[i]["image"].ToString());
                homeBooks.Tables["Recommended"].Rows.Add(r);
                Console.WriteLine($"Loading from {books.Rows[i]["image"]}");
            }
        }

        private void getNewestBook() {
            MySqlCommand cmd = new MySqlCommand(@"
                SELECT bu_id as 'id', bu_image as 'image', bu_publishedat 
                FROM buku 
                ORDER BY bu_publishedat desc
                LIMIT 7;
            ", conn);

            if(conn.State == ConnectionState.Open) {
                conn.Close();
            }
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            
            DataTable books = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                
            da.Fill(books);
            for (int i = 0; i < 7; i++) {
                DataRow r = homeBooks.Tables["Newest"].NewRow();
                r["id"] = books.Rows[i]["id"];
                r["image"] = WebImage.fromUrl(books.Rows[i]["image"].ToString());
                homeBooks.Tables["Newest"].Rows.Add(r);
                Console.WriteLine($"Loading from {books.Rows[i]["image"]}");
            }
        }

        private void loadImageToPictureBox() {
            for (int i = 0; i < 7; i++) {
                news[i].Image = WebImage.resizeImage((Image)homeBooks.Tables["Newest"].Rows[i]["image"], news[i].Width, news[i].Height);
                news[i].Tag = homeBooks.Tables["Newest"].Rows[i]["id"];
                recommends[i].Image = WebImage.resizeImage((Image)homeBooks.Tables["Recommended"].Rows[i]["image"], news[i].Width, news[i].Height);
                recommends[i].Tag = homeBooks.Tables["Recommended"].Rows[i]["id"];
                populars[i].Image = WebImage.resizeImage((Image)homeBooks.Tables["Popular"].Rows[i]["image"], news[i].Width, news[i].Height);
                populars[i].Tag = homeBooks.Tables["Popular"].Rows[i]["id"];
            }
        }
    }
}
