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
    public partial class EditPasswordUser : Form
    {
        Point posDrag;
        MySqlConnection conn;
        String[] user = new string[8];
        public EditPasswordUser(MySqlConnection conn, String[] user)
        {
            InitializeComponent();
            this.conn = conn;
            this.user = user;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(MousePosition.X - posDrag.X, MousePosition.Y - posDrag.Y);
            }
        }

        private void pnTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            posDrag = new Point(e.X, e.Y);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (tbOldPassword.Text.Equals("") || tbNewPassword.Text.Equals("") || tbConfirmPassword.Text.Equals(""))
            {
                MessageBox.Show("Field Harus Diisi Semua!");
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("select md5(?pass) from dual", conn);
                cmd.Parameters.Add(new MySqlParameter("pass", tbOldPassword.Text));
                conn.Open();
                String tempPass = cmd.ExecuteScalar().ToString();
                conn.Close();

                if (!tempPass.Equals(user[3]))
                {
                    MessageBox.Show("Password Lama Tidak Sesuai!");
                }
                else
                {
                    if (!tbNewPassword.Text.Equals(tbConfirmPassword.Text))
                    {
                        MessageBox.Show("New Password & Confirm Password Tidak Sesuai!");
                    }
                    else
                    {
                        MySqlCommand cmd2 = new MySqlCommand("update member set me_password=md5(?password) where me_id=?id", conn);
                        cmd2.Parameters.Add(new MySqlParameter("password", tbNewPassword.Text));
                        cmd2.Parameters.Add(new MySqlParameter("id", user[0]));
                        conn.Open();
                        cmd2.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Berhasil Mengganti Password!");
                        this.Dispose();
                    }
                }
            }
        }
    }
}
