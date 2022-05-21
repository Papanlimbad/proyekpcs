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
            lbHello.Location = new Point(this.Size.Width - lbHello.Size.Width - 20, 41);

            btHome.FillColor = Color.FromArgb(86, 100, 194);
            loadForm(new FormHomeUser(conn, user));
        }

        private void loadForm(object form)
        {
            if (this.pnMain.Controls.Count > 0)
            {
                this.pnMain.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(f);
            this.pnMain.Tag = f;
            f.Show();

            lbHello.Text = "Hello, " + user[1];
            lbHello.Location = new Point(this.Size.Width - lbHello.Size.Width - 20, 41);
        }

        private void clearButtonFill()
        {
            btHome.FillColor = Color.FromArgb(42, 33, 33);
            btBooks.FillColor = Color.FromArgb(42, 33, 33);
            btHistory.FillColor = Color.FromArgb(42, 33, 33);
            btBorrowed.FillColor = Color.FromArgb(42, 33, 33);
            btProfile.FillColor = Color.FromArgb(42, 33, 33);
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            clearButtonFill();
            btHome.FillColor = Color.FromArgb(86, 100, 194);
            loadForm(new FormHomeUser(conn,user));
        }

        private void btBooks_Click(object sender, EventArgs e)
        {
            clearButtonFill();
            btBooks.FillColor = Color.FromArgb(86, 100, 194);
            loadForm(new FormBooksUser(conn,user));
        }

        private void btHistory_Click(object sender, EventArgs e)
        {
            clearButtonFill();
            btHistory.FillColor = Color.FromArgb(86, 100, 194);
            loadForm(new FormHistoryUser());
        }

        private void btBorrowed_Click(object sender, EventArgs e)
        {
            clearButtonFill();
            btBorrowed.FillColor = Color.FromArgb(86, 100, 194);
            loadForm(new FormBorrowedUser());
        }

        private void btProfile_Click(object sender, EventArgs e)
        {
            clearButtonFill();
            btProfile.FillColor = Color.FromArgb(86, 100, 194);
            loadForm(new FormProfileUser(conn,user));
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
