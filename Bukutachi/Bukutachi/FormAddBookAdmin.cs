﻿using System;
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
using System.Data.SqlClient;
using System.Security;
using System.Diagnostics;
using System.ComponentModel;
using Bukutachi.Properties;
using System.IO;



namespace Bukutachi
{
    public partial class FormAddBookAdmin : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string sqlpenulis;
        string sqlgenre;
        string sqlpublisher;
        string sqllocation;
        string ambilpath;
        public static string iniauthor="";
        public static string inipenerbit;
        int ambilidgenre2;
        int idauthor2;
        public static string iniauthor2 = "";
        String[] user = new String[8];



        public FormAddBookAdmin(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.user = user;

            
            //LoadComboPenulis(sqlpenulis, "ps_name", "ps_id");
            LoadComboGenre(sqlgenre, "ge_name", "ge_id");
            //LoadComboPublisher(sqlpublisher, "pt_name", "pt_id");
            loadComboLocation(sqllocation, "rb_id", "rb_id");
            this.tbPublisher.Text = inipenerbit;
            cbGenre2.SelectedIndex = 0;
        }

        private void clearAll()
        {
            tbBookTitle.Text = "";
            tbAuthor.Text = "";
            cbGenre.Text = "";
            tbPublisher.Text = "";
            tbSynopsis.Text = "";
            cbLocation.Text = "";
        }

        private void FillComboBox1()
        {
           
        }

        private void btAddBook_Click(object sender, EventArgs e)
        {
            if (tbBookTitle.Text.Equals("") || tbAuthor.Text.Equals("") || cbGenre.Text.Equals("") || tbPublisher.Text.Equals("") || cbLocation.Text.Equals(""))
            {
                MessageBox.Show("Field Harus Diisi Semua!");
            }
            else
            {

                Regex re = new Regex("^[0-9]+$");
                if (!re.IsMatch(cbLocation.Text))
                {
                    MessageBox.Show("Lokasi Rak Buku Harus di isi Angka!");
                }
                else if (cbGenre2.Text==cbGenre.Text)
                {
                    MessageBox.Show("Genre tidak boleh kembar!");
                }
                else if (tbAuthor2.Text == tbAuthor.Text)
                {
                    MessageBox.Show("Author tidak boleh kembar!");
                }
                else
                {
                    string filepath = $@"./../../res/covers/{String.Join("_", tbBookTitle.Text.Split(' '))}.jpeg";
                    Image tempimg = Image.FromFile(guna2PictureBox1.Tag.ToString());
                    tempimg.Save(filepath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    string ambiltahun = "yyyy";
                    int tes = 1;
                    int ambilid=-1;
                    string ambilnamabuku = tbBookTitle.Text;
                    string genreambil = cbGenre.Text;
                    string genreambil2 = cbGenre2.Text;
                    MySqlCommand cmd2 = new MySqlCommand("select pt_id from penerbit where pt_name=?publisher",conn);
                    cmd2.Parameters.Add(new MySqlParameter("publisher", tbPublisher.Text));
                    MySqlCommand cmd3 = new MySqlCommand("select ps_id from penulis where ps_name=?author", conn);
                    cmd3.Parameters.Add(new MySqlParameter("author", tbAuthor.Text));
                    MySqlCommand cmd7 = new MySqlCommand("select ps_id from penulis where ps_name=?author2", conn);
                    cmd7.Parameters.Add(new MySqlParameter("author2", tbAuthor2.Text));
                
                    conn.Open();
                    int namapublisher = Convert.ToInt32(cmd2.ExecuteScalar());
                    int idauthor = Convert.ToInt32(cmd3.ExecuteScalar());
                    if (tbAuthor2.Text != "")
                    {
                        idauthor2 = Convert.ToInt32(cmd7.ExecuteScalar());
                    }
                    conn.Close();
                    MySqlCommand cmd = new MySqlCommand("insert into buku(bu_title, bu_synopsis, bu_publishedat, bu_pt_id, bu_rb_id, bu_status, bu_image, bu_large) values(?title, ?synopsis, ?publishedate, ?penerbit , ?rakbuku, 1, ?gambar, ?gambar);", conn);


                    cmd.Parameters.Add(new MySqlParameter("title", tbBookTitle.Text));
                    cmd.Parameters.Add(new MySqlParameter("synopsis", tbSynopsis.Text));
                    cmd.Parameters.Add(new MySqlParameter("publishedate", guna2NumericUpDown1.Value));
                    cmd.Parameters.Add(new MySqlParameter("penerbit", namapublisher));
                    cmd.Parameters.Add(new MySqlParameter("rakbuku", cbLocation.Text));
                    cmd.Parameters.Add(new MySqlParameter("gambar",filepath));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MySqlCommand cmd4 = new MySqlCommand("select bu_id from buku where bu_title=?ambilbuku", conn);
                    MySqlCommand cmd5 = new MySqlCommand("select ge_id from genre where ge_name=?ambilgenre",conn);
                    MySqlCommand cmd6 = new MySqlCommand("select ge_id from genre where ge_name=?ambilgenre2", conn);
                    cmd4.Parameters.Add(new MySqlParameter("ambilbuku", ambilnamabuku));
                    cmd5.Parameters.Add(new MySqlParameter("ambilgenre",genreambil));
                    cmd6.Parameters.Add(new MySqlParameter("ambilgenre2", genreambil2));
                    conn.Open();
                    int ambilidbuku = Convert.ToInt32(cmd4.ExecuteScalar());
                    int ambilidgenre = Convert.ToInt32(cmd5.ExecuteScalar());
                    if (cbGenre2.Text != "None")
                    {
                       ambilidgenre2 = Convert.ToInt32(cmd6.ExecuteScalar());
                    }
                    conn.Close();

                    MySqlCommand cmda = new MySqlCommand("insert into buku_penulis(bp_ps_id, bp_bu_id) values(?penulisid, ?bukuid);", conn);
                    MySqlCommand cmdb = new MySqlCommand("insert into genre_buku(gb_bu_id, gb_ge_id) values(?genrebuku, ?genre);", conn);
                    MySqlCommand cmdc = new MySqlCommand("insert into genre_buku(gb_bu_id, gb_ge_id) values(?genrebuku, ?genre2)",conn);
                    MySqlCommand cmdd = new MySqlCommand("insert into buku_penulis(bp_ps_id, bp_bu_id) values(?penulisid2, ?bukuid);", conn);
                    cmda.Parameters.Add(new MySqlParameter("penulisid", idauthor));
                    cmda.Parameters.Add(new MySqlParameter("bukuid", ambilidbuku));
                    cmdb.Parameters.Add(new MySqlParameter("genre", ambilidgenre));
                    cmdb.Parameters.Add(new MySqlParameter("genrebuku", ambilidbuku));
                    cmdc.Parameters.Add(new MySqlParameter("genre2", ambilidgenre2));
                    cmdc.Parameters.Add(new MySqlParameter("genrebuku", ambilidbuku));
                    cmdd.Parameters.Add(new MySqlParameter("penulisid2", idauthor2));
                    cmdd.Parameters.Add(new MySqlParameter("bukuid", ambilidbuku));
                    conn.Open();
                    cmda.ExecuteNonQuery();
                    cmdb.ExecuteNonQuery();
                    if (cbGenre2.Text != "None")
                    {
                        cmdc.ExecuteNonQuery();                       
                    }
                    if (tbAuthor2.Text != "")
                    {
                        cmdd.ExecuteNonQuery();
                    }
                    conn.Close();


                    clearAll();

                    MessageBox.Show("Berhasil Tambah Buku");
                }
            }
        }

        internal void populate()
        {
            tbPublisher.Text = inipenerbit;
        }

        private void btAddAuthor_Click(object sender, EventArgs e)
        {
            FormAddAuthor author = new FormAddAuthor(conn);
            author.ShowDialog();
            author.Dispose();
        }

        private void btAddPublisher_Click(object sender, EventArgs e)
        {
            FormAddPenerbit penerbit = new FormAddPenerbit(conn);
            penerbit.ShowDialog();
            penerbit.Dispose();
        }

        private void FormAddBookAdmin_Load(object sender, EventArgs e)
        {
            if (inipenerbit != "")
            {
                tbPublisher.Text = inipenerbit;
            }
        }

        private void LoadComboGenre(string sqlpengarang, string DisplayMember, string ValueMember)
        {
            sqlgenre = "SELECT * FROM genre ORDER BY ge_name ASC";
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlgenre;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                cbGenre.DataSource = dt;
                cbGenre.DisplayMember = DisplayMember;
                cbGenre.ValueMember = ValueMember;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void loadComboLocation(string sqllocation, string DisplayMember, string ValueMember)
        {
            sqllocation = "SELECT * FROM rak_buku";
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqllocation;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                cbLocation.DataSource = dt;
                cbLocation.DisplayMember = DisplayMember;
                cbLocation.ValueMember = ValueMember;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public string TextBoxValue
        {
            get { return tbPublisher.Text; }
            set { tbPublisher.Text = value; }
        }

        private void btAddImage_Click(object sender, EventArgs e)
        {
            //string path = File.ReadAllText("Cover\\star.png");


            // string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            //Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            // path = r.Replace(path, "");
            // MessageBox.Show(path);

            //guna2PictureBox1.Image = Properties.Resources.star1;
            //string tespath = guna2PictureBox1.ToString();
            //MessageBox.Show(tespath);

            //// ambilpath = path;
            /* OpenFileDialog open = new OpenFileDialog();
              // image filters  
               open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
              if (open.ShowDialog() == DialogResult.OK)
              {
                  // ngambil gambar 
                  //C:\Users\Anderson\Documents\GitHub\proyekpcs\Bukutachi\Bukutachi\res\Logo\star.png
                 guna2PictureBox1.Image = new Bitmap(open.FileName);
                 //Uri uri = new Uri(open.FileName, UriKind.Relative);
                // PngBitmapDecoder decoder2 = new PngBitmapDecoder(uri, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
                 //string vPath = open.FileName.Replace(@"q:\quotewerks", "~").Replace(@"\", "/");
                 ambilpath = open.FileName;

              }*/

            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp *.png ";
            if(od.ShowDialog() == DialogResult.OK) {
                guna2PictureBox1.Image = WebImage.resizeImage(Image.FromFile(od.FileName), guna2PictureBox1.Width, guna2PictureBox1.Height);
                guna2PictureBox1.Tag = od.FileName;
            }
        }

        private void btAuthor_Click(object sender, EventArgs e)
        {
            AddBookAdminPenulis author = new AddBookAdminPenulis(conn);
            author.ShowDialog();
            author.Dispose();
        }
        public void refresh()
        {
            tbAuthor.Text = iniauthor;
            tbPublisher.Text = inipenerbit;
            tbAuthor2.Text = iniauthor2;
        }


        private void btRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btPenerbit_Click(object sender, EventArgs e)
        {
            AddBookAdminPenerbit pt = new AddBookAdminPenerbit(conn,this,user);
            pt.ShowDialog();
            pt.Dispose();
        }

        private void btSearchAuthor2_Click(object sender, EventArgs e)
        {
            AddBookAdminPenulis2 f = new AddBookAdminPenulis2(conn);
            f.ShowDialog();
            f.Dispose();
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
