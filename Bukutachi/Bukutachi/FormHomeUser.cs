using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
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
        public FormHomeUser(MySqlConnection conn, String[] user)
        {
            InitializeComponent();
            this.conn = conn;
            this.user = user;
        }

        private void FormHomeUser_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "Welcome, " + user[1];
            news = new PictureBox[7] { pbNew1, pbNew2, pbNew3, pbNew4, pbNew5, pbNew6, pbNew7};
            populars = new PictureBox[7] { pbNew1, pbNew2, pbNew3, pbNew4, pbNew5, pbNew6, pbNew7 };
            recommends = new PictureBox[7] { pbNew1, pbNew2, pbNew3, pbNew4, pbNew5, pbNew6, pbNew7 };
            Console.WriteLine(conn);
            getNewestBook();
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

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < 7; i++) {
                Console.WriteLine(dt.Rows[i]["image"].ToString());
                news[i].Image = WebImage.resizeImage(WebImage.fromUrl(dt.Rows[i]["image"].ToString()),120);
            }
        }
    }
}
