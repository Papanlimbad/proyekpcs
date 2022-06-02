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
            tbAuthor.Text = "";
            tbGenre.Text = "";
            tbPublisher.Text = "";
            tbPublishDate.Text = "";
            tbSynopsis.Text = "";
            tbLocation.Text = "";
        }

        private void btAddBook_Click(object sender, EventArgs e)
        {
            if (tbBookTitle.Text.Equals("") || tbAuthor.Text.Equals("") || tbGenre.Text.Equals("") || tbPublisher.Text.Equals("") || tbPublishDate.Text.Equals("") || tbLocation.Text.Equals(""))
            {
                MessageBox.Show("Field Harus Diisi Semua!");
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("insert into buku(bu_title, bu_synopsis, bu_publishedat, bu_pt_id, bu_rb_id) values(?title, ?synopsis, ?publishedate, ?penerbit , ?rakbuku)", conn);
                cmd.Parameters.Add(new MySqlParameter("title", tbBookTitle.Text));
                cmd.Parameters.Add(new MySqlParameter("synopsis", tbSynopsis.Text));
                cmd.Parameters.Add(new MySqlParameter("publishedate", tbPublishDate.Text));
                cmd.Parameters.Add(new MySqlParameter("penerbit", tbPublisher.Text));
                cmd.Parameters.Add(new MySqlParameter("rakbuku", tbLocation.Text));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                clearAll();

                MessageBox.Show("Berhasil Tambah Buku");
            }
        }
    }
}
