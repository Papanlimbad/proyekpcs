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
    public partial class FormAddAuthor : Form
    {
        MySqlConnection conn;


        public FormAddAuthor(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearAll()
        {
            tbName.Text = "";
            tbTelp.Text = "";
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbTelp.Text == "")
            {
                MessageBox.Show("Field Harus Diisi Semua!");
            }
            else
            {
                Regex re = new Regex("^[0-9]+$");
                if (!re.IsMatch(tbTelp.Text))
                {
                    MessageBox.Show("No Telp harus di isi angka!");
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand("insert into penulis(ps_name, ps_telephone) values(?name, ?telephone)", conn);
                    cmd.Parameters.Add(new MySqlParameter("name", tbName.Text));
                    cmd.Parameters.Add(new MySqlParameter("telephone", tbTelp.Text));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    clearAll();
                    MessageBox.Show("Berhasil Tambah Author!");

                }
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
