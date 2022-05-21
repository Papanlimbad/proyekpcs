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
    public partial class Login : Form
    {
        Point posDrag;
        MySqlConnection conn;
        public Login()
        {
            InitializeComponent();
            conn = new MySqlConnection("server = localhost; uid = root; database = bukutachi_db;");
            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Tidak Valid / Belum Di Import!");
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register(conn);
            this.Visible = false;
            register.ShowDialog();
            register.Dispose();
            this.Visible = true;
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

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Equals("") || tbPassword.Text.Equals(""))
            {
                MessageBox.Show("Field Harus Diisi Semua");
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("select count(*) from member where me_username=?username", conn);
                cmd.Parameters.Add(new MySqlParameter("username", tbUsername.Text));
                conn.Open();
                int adaUser = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                conn.Close();

                if (adaUser == 0)
                {
                    MessageBox.Show("Username Belum Terdaftar!");
                }
                else
                {
                    MySqlCommand cmd2 = new MySqlCommand("select count(*) from member where me_username=?username and me_password=md5(?password)", conn);
                    cmd2.Parameters.Add(new MySqlParameter("username", tbUsername.Text));
                    cmd2.Parameters.Add(new MySqlParameter("password", tbPassword.Text));
                    conn.Open();
                    int passwordBenar = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                    conn.Close();

                    if (passwordBenar == 0)
                    {
                        MessageBox.Show("Password Salah!");
                    }
                    else
                    {
                        MySqlCommand cmd3 = new MySqlCommand("select * from member where me_username=?username and me_password=md5(?password)", conn);
                        cmd3.Parameters.Add(new MySqlParameter("username", tbUsername.Text));
                        cmd3.Parameters.Add(new MySqlParameter("password", tbPassword.Text));
                        clearAll();
                        conn.Open();
                        cmd3.ExecuteReader();
                        conn.Close();
                        DataSet ds;
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd3);
                        ds = new DataSet();
                        da.Fill(ds);
                        HomeUser homeUser = new HomeUser(conn, ds);
                        this.Visible = false;
                        homeUser.ShowDialog();
                        homeUser.Dispose();
                        this.Visible = true;
                    }
                }
            }
        }

        private void clearAll()
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbUsername;
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(sender, e);
            }
        }
    }
}
