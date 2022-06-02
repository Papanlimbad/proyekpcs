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
    public partial class FormProfileUser : Form
    {
        MySqlConnection conn;
        String[] user = new string[8];
        public FormProfileUser(MySqlConnection conn,String[] user)
        {
            InitializeComponent();
            this.conn = conn;
            this.user = user;
        }

        private void FormProfileUser_Load(object sender, EventArgs e)
        {
            tbFullName.Text = user[1];
            tbUsername.Text = user[2];
            tbAdress.Text = user[5];
            tbTelephone.Text = user[4];

            MySqlCommand cmd = new MySqlCommand("SELECT bu_title AS 'Book Title', DATE_FORMAT(hp_returnat,'%d-%b-%Y') AS 'Return Date' FROM buku, hpinjam, dpinjam, MEMBER WHERE bu_id = dp_bu_id AND hp_id = dp_hp_id AND hp_status=0 AND me_id = ?id;", conn);
            cmd.Parameters.Add(new MySqlParameter("id", user[0]));
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dsBorrowed = new DataSet();
            da.Fill(dsBorrowed);
            dgvBorrowedBooks.DataSource = dsBorrowed.Tables[0].DefaultView;

            MySqlCommand cmd2 = new MySqlCommand("SELECT bu_title AS 'Book Title', DATE_FORMAT(hp_borrowedat,'%d-%b-%Y') AS 'Borrowed Date' FROM buku, hpinjam, dpinjam, MEMBER WHERE bu_id = dp_bu_id AND hp_id = dp_hp_id AND hp_status=1 AND me_id = ?id;", conn);
            cmd2.Parameters.Add(new MySqlParameter("id", user[0]));
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            DataSet dsHistory = new DataSet();
            da.Fill(dsHistory);
            dgvHistory.DataSource = dsHistory.Tables[0].DefaultView;
        }

        private void btEditProfile_Click(object sender, EventArgs e)
        {
            if (btEditProfile.Text.Equals("Edit Profile"))
            {
                btEditPassword.Enabled = false;
                tbFullName.Enabled = true;
                tbUsername.Enabled = true;
                tbAdress.Enabled = true;
                tbTelephone.Enabled = true;
                tbPassword.Enabled = true;

                btEditProfile.Text = "Confirm";
            }
            else
            {
                if (tbFullName.Text.Equals("") || tbUsername.Text.Equals("") || tbTelephone.Text.Equals("") || tbAdress.Text.Equals("") || tbPassword.Text.Equals(""))
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

                        if (usernameTerpakai >= 1 && !tbUsername.Text.Equals(user[2]))
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
                                MySqlCommand cmd3 = new MySqlCommand("select md5(?pass) from dual",conn);
                                cmd3.Parameters.Add(new MySqlParameter("pass", tbPassword.Text));
                                conn.Open();
                                String tempPass = cmd3.ExecuteScalar().ToString();
                                conn.Close();

                                if (!tempPass.Equals(user[3]))
                                {
                                    MessageBox.Show("Password Tidak Sesuai!");
                                }
                                else
                                {
                                    MySqlCommand cmd2 = new MySqlCommand("update member set me_name=?name,me_username=?username,me_telephone=?telephone,me_address=?address where me_id=?id", conn);
                                    cmd2.Parameters.Add(new MySqlParameter("name", tbFullName.Text));
                                    cmd2.Parameters.Add(new MySqlParameter("username", tbUsername.Text));
                                    cmd2.Parameters.Add(new MySqlParameter("telephone", tbTelephone.Text));
                                    cmd2.Parameters.Add(new MySqlParameter("address", tbAdress.Text));
                                    cmd2.Parameters.Add(new MySqlParameter("id", user[0]));
                                    conn.Open();
                                    cmd2.ExecuteNonQuery();
                                    conn.Close();

                                    MessageBox.Show("Berhasil Update!");

                                    user[1] = tbFullName.Text;
                                    user[2] = tbUsername.Text;
                                    user[4] = tbAdress.Text;
                                    user[5] = tbTelephone.Text;

                                    btEditPassword.Enabled = true;
                                    tbFullName.Enabled = false;
                                    tbUsername.Enabled = false;
                                    tbAdress.Enabled = false;
                                    tbTelephone.Enabled = false;
                                    tbPassword.Enabled = false;
                                    tbPassword.Text = "";

                                    btEditProfile.Text = "Edit Profile";
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btEditPassword_Click(object sender, EventArgs e)
        {
            EditPasswordUser editPasswordUser = new EditPasswordUser(conn, user);
            editPasswordUser.ShowDialog();
            editPasswordUser.Dispose();
        }
    }
}
