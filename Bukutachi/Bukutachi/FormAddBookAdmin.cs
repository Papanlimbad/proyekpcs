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

        private void btAddBook_Click(object sender, EventArgs e)
        {
            if (tbBookTitle.Text.Equals("") || tbAuthor.Text.Equals("") || tbGenre.Text.Equals("") || tbPublisher.Text.Equals("") || tbPublishDate.Text.Equals("") || tbLocation.Text.Equals(""))
            {
                MessageBox.Show("Field Harus Diisi Semua!");
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("insert into buku(bu_title, bu_synopsis, bu_publishedat, bu_status, bu_pt_id)");
            }
        }
    }
}
