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
    public partial class FormAddBookAdmin : Form
    {
        MySqlConnection conn;

        public FormAddBookAdmin()
        {
            InitializeComponent();
            this.conn = conn;

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

                    MySqlCommand cmd = new MySqlCommand("insert into buku(bu_title, bu_synopsis, bu_publishedat, bu_pt_id, bu_rb_id) values(?title, ?synopsis, ?publishedate, ?penerbit , ?rakbuku)", conn);
                    cmd.Parameters.Add(new MySqlParameter("title", tbBookTitle.Text));
                    cmd.Parameters.Add(new MySqlParameter("synopsis", tbSynopsis.Text));
                    cmd.Parameters.Add(new MySqlParameter("publishedate", PublishDate.Value));
                    cmd.Parameters.Add(new MySqlParameter("penerbit", cbPublisher.Text));
                    cmd.Parameters.Add(new MySqlParameter("rakbuku", tbLocation.Text));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    clearAll();

                    MessageBox.Show("Berhasil Tambah Buku");
                }
            }
        }

        private void btAddAuthor_Click(object sender, EventArgs e)
        {

        }

        private void btAddPublisher_Click(object sender, EventArgs e)
        {
            FormAddAuthor author = new FormAddAuthor();
            author.ShowDialog();
            author.Dispose();
        }
    }
}
