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
using System.Text.RegularExpressions;

namespace Bukutachi
{
    public partial class Register : Form
    {
        Point posDrag;
        MySqlConnection conn;
        public Register(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void btRegister_Click(object sender, EventArgs e)
        {
            if (tbFullName.Text.Equals("") || tbUsername.Text.Equals("") || tbTelephone.Text.Equals("") || tbAddress.Text.Equals("") || tbPassword.Text.Equals("") || tbConfirmPassword.Text.Equals(""))
            {
                MessageBox.Show("Field Harus Diisi Semua!");
            }
            else
            {
                if (tbUsername.Text.Contains(" "))
                {
                    MessageBox.Show("Username Tidak Boleh Mengandung Spasi!");
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand("select count(*) from member where me_username=?username", conn);
                    cmd.Parameters.Add(new MySqlParameter("username", tbUsername.Text));
                    conn.Open();
                    int usernameTerpakai = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    conn.Close();

                    if (usernameTerpakai >= 1)
                    {
                        MessageBox.Show("Username Telah Terpakai!");
                    }
                    else
                    {
                        Regex re = new Regex("^[0-9]+$");
                        if (!re.IsMatch(tbTelephone.Text))
                        {
                            MessageBox.Show("Telephone Hanya Boleh Diisi Angka!");
                        }
                        else
                        {
                            if (!tbPassword.Text.Equals(tbConfirmPassword.Text))
                            {
                                MessageBox.Show("Password & Confirm Password Tidak Sama!");
                            }
                            else
                            {
                                MySqlCommand cmd2 = new MySqlCommand("insert into member(me_name,me_username,me_password,me_telephone,me_address,me_registeredat,me_status) values(?name,?username,md5(?password),?telephone,?address,?registeredat,?status)", conn);
                                cmd2.Parameters.Add(new MySqlParameter("name", tbFullName.Text));
                                cmd2.Parameters.Add(new MySqlParameter("username", tbUsername.Text));
                                cmd2.Parameters.Add(new MySqlParameter("password", tbPassword.Text));
                                cmd2.Parameters.Add(new MySqlParameter("telephone", tbTelephone.Text));
                                cmd2.Parameters.Add(new MySqlParameter("address", tbAddress.Text));
                                cmd2.Parameters.Add(new MySqlParameter("registeredat", DateTime.Now));
                                cmd2.Parameters.Add(new MySqlParameter("status", 1));
                                conn.Open();
                                cmd2.ExecuteNonQuery();
                                conn.Close();

                                clearAll();
                                MessageBox.Show("Berhasil Register!");
                                this.Dispose();
                            }
                        }
                    }
                }
            }
        }

        private void clearAll()
        {
            tbFullName.Text = "";
            tbUsername.Text = "";
            tbTelephone.Text = "";
            tbAddress.Text = "";
            tbPassword.Text = "";
            tbConfirmPassword.Text = "";
        }

        private void tbConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btRegister_Click(sender, e);
            }
        }
    }
}
