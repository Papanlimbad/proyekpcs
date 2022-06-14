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
        string ambilpath;

        public FormAddBookAdmin(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;

            
            LoadComboPenulis(sqlpenulis, "ps_name", "ps_id");
            LoadComboGenre(sqlgenre, "ge_name", "ge_id");
            LoadComboPublisher(sqlpublisher, "pt_name", "pt_id");
        }

        private void clearAll()
        {
            tbBookTitle.Text = "";
            cbAuthor.Text = "";
            cbGenre.Text = "";
            cbPublisher.Text = "";
            PublishDate.Value = DateTime.Today;
            tbSynopsis.Text = "";
            tbLocation.Text = "";
        }

        private void FillComboBox1()
        {
           
        }

        private void btAddBook_Click(object sender, EventArgs e)
        {
            if (tbBookTitle.Text.Equals("") || cbAuthor.Text.Equals("") || cbGenre.Text.Equals("") || cbPublisher.Text.Equals("") || tbLocation.Text.Equals(""))
            {
                MessageBox.Show("Field Harus Diisi Semua!");
            }
            else
            {

                Regex re = new Regex("^[0-9]+$");
                if (!re.IsMatch(tbLocation.Text))
                {
                    MessageBox.Show("Lokasi Rak Buku Harus di isi Angka!");
                }
                else
                {
                    string ambiltahun = "yyyy";
                    int tes = 1;
                    int ambilid=-1;
                    string ambilnamabuku = tbBookTitle.Text;
                    string genreambil = cbGenre.Text;
                    MySqlCommand cmd2 = new MySqlCommand("select pt_id from penerbit where pt_name=?publisher",conn);
                    cmd2.Parameters.Add(new MySqlParameter("publisher", cbPublisher.Text));
                    MySqlCommand cmd3 = new MySqlCommand("select ps_id from penulis where ps_name=?author", conn);
                    cmd3.Parameters.Add(new MySqlParameter("author", cbAuthor.Text));
                
                    conn.Open();
                    int namapublisher = Convert.ToInt32(cmd2.ExecuteScalar());
                    int idauthor = Convert.ToInt32(cmd3.ExecuteScalar());
                    
                    conn.Close();
                    MySqlCommand cmd = new MySqlCommand("insert into buku(bu_title, bu_synopsis, bu_publishedat, bu_pt_id, bu_rb_id, bu_status, bu_image, bu_large) values(?title, ?synopsis, ?publishedate, ?penerbit , ?rakbuku, 1, ?gambar, ?gambar);", conn);


                    cmd.Parameters.Add(new MySqlParameter("title", tbBookTitle.Text));
                    cmd.Parameters.Add(new MySqlParameter("synopsis", tbSynopsis.Text));
                    cmd.Parameters.Add(new MySqlParameter("publishedate", PublishDate.Value.ToString(ambiltahun)));
                    cmd.Parameters.Add(new MySqlParameter("penerbit", namapublisher));
                    cmd.Parameters.Add(new MySqlParameter("rakbuku", tbLocation.Text));
                    cmd.Parameters.Add(new MySqlParameter("gambar",ambilpath));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MySqlCommand cmd4 = new MySqlCommand("select bu_id from buku where bu_title=?ambilbuku", conn);
                    MySqlCommand cmd5 = new MySqlCommand("select ge_id from genre where ge_name=?ambilgenre",conn);
                    cmd4.Parameters.Add(new MySqlParameter("ambilbuku", ambilnamabuku));
                    cmd5.Parameters.Add(new MySqlParameter("ambilgenre",genreambil));
                    conn.Open();
                    int ambilidbuku = Convert.ToInt32(cmd4.ExecuteScalar());
                    int ambilidgenre = Convert.ToInt32(cmd5.ExecuteScalar());
                    conn.Close();

                    MySqlCommand cmda = new MySqlCommand("insert into buku_penulis(bp_ps_id, bp_bu_id) values(?penulisid, ?bukuid);", conn);
                    MySqlCommand cmdb = new MySqlCommand("insert into genre_buku(gb_bu_id, gb_ge_id) values(?genrebuku, ?genre);", conn);
                    cmda.Parameters.Add(new MySqlParameter("penulisid", idauthor));
                    cmda.Parameters.Add(new MySqlParameter("bukuid", ambilidbuku));
                    cmdb.Parameters.Add(new MySqlParameter("genre", ambilidgenre));
                    cmdb.Parameters.Add(new MySqlParameter("genrebuku", ambilidbuku));
                    conn.Open();
                    cmda.ExecuteNonQuery();
                    cmdb.ExecuteNonQuery();
                    conn.Close();


                    clearAll();

                    MessageBox.Show("Berhasil Tambah Buku");
                }
            }
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
 
        }

        private void LoadComboPenulis(string sqlpenulis, string DisplayMember, string ValueMember)
        {
            sqlpenulis = "SELECT * FROM penulis ORDER BY ps_name ASC";
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlpenulis;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                cbAuthor.DataSource = dt;
                cbAuthor.DisplayMember = DisplayMember;
                cbAuthor.ValueMember = ValueMember;
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

        private void LoadComboPublisher(string sqlpublisher, string DisplayMember, string ValueMember)
        {
            sqlpublisher = "SELECT * FROM penerbit ORDER BY pt_name ASC";
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlpublisher;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                cbPublisher.DataSource = dt;
                cbPublisher.DisplayMember = DisplayMember;
                cbPublisher.ValueMember = ValueMember;
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

        private void btAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // ngambil gambar 
                guna2PictureBox1.Image = new Bitmap(open.FileName);

                ambilpath = open.FileName;
            }
        }
    }
}
