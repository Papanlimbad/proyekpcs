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
    public partial class FormAddPenerbit : Form
    {
        MySqlConnection conn;

        public FormAddPenerbit(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clearAll()
        {
            tbPenerbit.Text = "";
            tbAlamat.Text = "";
            tbTelp.Text = "";
        }


        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (tbPenerbit.Text == "" || tbTelp.Text == "" || tbAlamat.Text=="")
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
                    MySqlCommand cmd = new MySqlCommand("insert into penerbit(pt_name, pt_address, pt_telephone) values(?penerbit, ?address, ?telephone)", conn);
                    cmd.Parameters.Add(new MySqlParameter("penerbit", tbPenerbit.Text));
                    cmd.Parameters.Add(new MySqlParameter("address", tbAlamat.Text));
                    cmd.Parameters.Add(new MySqlParameter("telephone", tbTelp.Text));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    clearAll();
                    MessageBox.Show("Berhasil Tambah Penerbit!");
                }
            }
        }
    }
}
