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
    public partial class FormHistoryUserClicked : Form
    {
        MySqlConnection conn;
        String[] user;
        String id;
        Point posDrag;
        int rating = 1;
        public FormHistoryUserClicked(MySqlConnection conn, String[] user, String id)
        {
            InitializeComponent();
            this.conn = conn;
            this.user = user;
            this.id = id;

            MySqlCommand cmd = new MySqlCommand("SELECT bu_title, ps_name, bu_image FROM buku, penulis, buku_penulis, dpinjam WHERE dp_bu_id = bu_id AND bp_ps_id = ps_id AND bp_bu_id = bu_id AND dp_id = ?id;", conn);
            cmd.Parameters.AddWithValue("id", id);

            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            lbBookTitle.Text = reader[0].ToString();
            lbAuthor.Text = reader[1].ToString();
            pbCover.Image = WebImage.resizeImage(WebImage.fromUrl(reader[2].ToString()), pbCover.Width, pbCover.Height);
            conn.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btPlus_Click(object sender, EventArgs e)
        {
            if (rating!=5)
            {
                rating++;
                if (rating == 2)
                {
                    pbStar2.Visible = true;
                }
                else if (rating == 3)
                {
                    pbStar3.Visible = true;
                }
                else if (rating == 4)
                {
                    pbStar4.Visible = true;
                }
                else if (rating == 5)
                {
                    pbStar5.Visible = true;
                }
            }
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            if (rating != 1)
            {
                rating--;
                if (rating == 1)
                {
                    pbStar2.Visible = false;
                }
                else if (rating == 2)
                {
                    pbStar3.Visible = false;
                }
                else if (rating == 3)
                {
                    pbStar4.Visible = false;
                }
                else if (rating == 4)
                {
                    pbStar5.Visible = false;
                }
            }
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd1 = new MySqlCommand("select dp_bu_id from dpinjam where dp_id=?id", conn);
            cmd1.Parameters.AddWithValue("id", id);
            conn.Open();
            int idbuku = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
            conn.Close();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO rating(ra_value,ra_bu_id,ra_me_id) VALUES(?val,?buid,?meid);", conn);
            cmd.Parameters.AddWithValue("val", rating);
            cmd.Parameters.AddWithValue("buid", idbuku);
            cmd.Parameters.AddWithValue("meid", user[0]);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Dispose();
        }
    }
}
