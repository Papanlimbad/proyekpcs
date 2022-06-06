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
    public partial class EditAccountAdmin : Form
    {
        Point posDrag;
        MySqlConnection conn;
        String id = "";
        public EditAccountAdmin(MySqlConnection conn, String id)
        {
            InitializeComponent();
            this.conn = conn;
            this.id = id;

            string sql = "select me_id,me_name,me_username,me_telephone,me_address,me_status from member where me_id=?id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", id);

            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            tbId.Text = reader[0].ToString();
            tbNama.Text = reader[1].ToString();
            tbUsername.Text = reader[2].ToString();
            tbTelephone.Text = reader[3].ToString();
            tbAddress.Text = reader[4].ToString();
            if (reader[5].ToString().Equals("1"))
            {
                rbActive.Checked = true;
            }
            else
            {
                rbBanned.Checked = true;
            }
            conn.Close();

            btReset.Enabled = true;

        }

        public EditAccountAdmin(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            label1.Text = "Bukutachi - Add Account";
            lbEditAccount.Text = "Add Account";
            lbEditAccount.Location = new Point(160,47);
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

        private void btReset_Click(object sender, EventArgs e)
        {
            string sql = "update member set me_password=md5('123') where me_id=?id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Password Telah di Reset!");
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd2 = new MySqlCommand("select count(*) from member where me_username=?username", conn);
            cmd2.Parameters.Add(new MySqlParameter("username", tbUsername.Text));
            conn.Open();
            int usernameTerpakai = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
            conn.Close();

            if (usernameTerpakai >= 1)
            {
                MessageBox.Show("Username Telah Terpakai!");
            }
            else
            {
                if (!id.Equals(""))
                {
                    string stat = "0";
                    if (rbActive.Checked)
                    {
                        stat = "1";
                    }

                    string sql = "update member set me_name=?nama, me_username=?username, me_telephone=?telephone, me_address=?address, me_status=?status where me_id=?id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("nama", tbNama.Text);
                    cmd.Parameters.AddWithValue("username", tbUsername.Text);
                    cmd.Parameters.AddWithValue("telephone", tbTelephone.Text);
                    cmd.Parameters.AddWithValue("address", tbAddress.Text);
                    cmd.Parameters.AddWithValue("status", stat);
                    cmd.Parameters.AddWithValue("id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data Telah di Update!");

                    this.Dispose();
                }
                else
                {
                    string stat = "0";
                    if (rbActive.Checked)
                    {
                        stat = "1";
                    }

                    string sql = "insert into member values(?id,?nama,?username,md5('123'),?telephone,?address,NOW(),?status)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("id", tbId.Text);
                    cmd.Parameters.AddWithValue("nama", tbNama.Text);
                    cmd.Parameters.AddWithValue("username", tbUsername.Text);
                    cmd.Parameters.AddWithValue("telephone", tbTelephone.Text);
                    cmd.Parameters.AddWithValue("address", tbAddress.Text);
                    cmd.Parameters.AddWithValue("status", stat);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data Telah di Tambah!");

                    this.Dispose();
                }
            }
        }

        private void generateID()
        {
            if (id.Equals(""))
            {
                string sql = "select max(me_id) from member";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                int tempId = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                tempId++;
                tbId.Text = tempId.ToString();
                conn.Close();
            }
        }
        private void tbNama_TextChanged(object sender, EventArgs e)
        {
            generateID();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            generateID();
        }

        private void tbTelephone_TextChanged(object sender, EventArgs e)
        {
            generateID();
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            generateID();
        }

        private void rbBanned_CheckedChanged(object sender, EventArgs e)
        {
            generateID();
        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            generateID();
        }
    }
}
