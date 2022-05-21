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
    public partial class HomeUser : Form
    {
        Point posDrag;
        MySqlConnection conn;
        String[] user = new string[8];
        public HomeUser(MySqlConnection conn, DataSet user)
        {
            InitializeComponent();
            this.conn = conn;
            this.user[0] = user.Tables[0].Rows[0][0].ToString();
            this.user[1] = user.Tables[0].Rows[0][1].ToString();
            this.user[2] = user.Tables[0].Rows[0][2].ToString();
            this.user[3] = user.Tables[0].Rows[0][3].ToString();
            this.user[4] = user.Tables[0].Rows[0][4].ToString();
            this.user[5] = user.Tables[0].Rows[0][5].ToString();
            this.user[6] = user.Tables[0].Rows[0][6].ToString();
            this.user[7] = user.Tables[0].Rows[0][7].ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void HomeUser_Load(object sender, EventArgs e)
        {
            lbHello.Text = "Hello, " + user[1];
        }

        private void panelBook_MouseClick(object sender, MouseEventArgs e)
        {
            panelHome.BackColor = Color.FromArgb(42, 33, 33);
            panelBook.BackColor = Color.FromArgb(37, 38, 62);
            panelHistory.BackColor = Color.FromArgb(42, 33, 33);
            panelBorrow.BackColor = Color.FromArgb(42, 33, 33);
            panelProfile.BackColor = Color.FromArgb(42, 33, 33);
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHome_MouseClick(object sender, MouseEventArgs e)
        {
            panelHome.BackColor = Color.FromArgb(37, 38, 62);
            panelBook.BackColor = Color.FromArgb(42, 33, 33);
            panelHistory.BackColor = Color.FromArgb(42, 33, 33);
            panelBorrow.BackColor = Color.FromArgb(42, 33, 33);
            panelProfile.BackColor = Color.FromArgb(42, 33, 33);
        }

        private void panelHistory_MouseClick(object sender, MouseEventArgs e)
        {
            panelHome.BackColor = Color.FromArgb(42, 33, 33);
            panelBook.BackColor = Color.FromArgb(42, 33, 3);
            panelHistory.BackColor = Color.FromArgb(37, 38, 62);
            panelBorrow.BackColor = Color.FromArgb(42, 33, 33);
            panelProfile.BackColor = Color.FromArgb(42, 33, 33);
        }

        private void panelBorrow_MouseClick(object sender, MouseEventArgs e)
        {
            panelHome.BackColor = Color.FromArgb(42, 33, 33);
            panelBook.BackColor = Color.FromArgb(42, 33, 33);
            panelHistory.BackColor = Color.FromArgb(42, 33, 33);
            panelBorrow.BackColor = Color.FromArgb(37, 38, 62);
            panelProfile.BackColor = Color.FromArgb(42, 33, 33);
        }

        private void panelProfile_MouseClick(object sender, MouseEventArgs e)
        {
            panelHome.BackColor = Color.FromArgb(42, 33, 33);
            panelBook.BackColor = Color.FromArgb(42, 33, 33);
            panelHistory.BackColor = Color.FromArgb(42, 33, 33);
            panelBorrow.BackColor = Color.FromArgb(42, 33, 33);
            panelProfile.BackColor = Color.FromArgb(37, 38, 62);
        }
    }
}
