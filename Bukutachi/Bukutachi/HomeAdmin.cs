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
    public partial class HomeAdmin : Form
    {
        Point posDrag;
        MySqlConnection conn;
        public HomeAdmin()
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

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void clearbuttonadmin()
        {
            btHomeAdmin.BackColor= Color.FromArgb(42, 33, 33);
            btBooksAdmin.BackColor=Color.FromArgb(42, 33, 33);
            btBorrowedAdmin.BackColor= Color.FromArgb(42, 33, 33);
            btAddBook.BackColor= Color.FromArgb(42, 33, 33);
            btEditUsers.BackColor= Color.FromArgb(42, 33, 33);
        }

        private void loadadmin(object form)
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

            lbHelloAdmin.Location = new Point(this.Size.Width - lbHelloAdmin.Size.Width - 20, 41);
        }
        private void btHomeAdmin_Click(object sender, EventArgs e)
        {
            clearbuttonadmin();
            btHomeAdmin.BackColor = Color.FromArgb(86, 100, 194);
        }

        private void btBooksAdmin_Click(object sender, EventArgs e)
        {
            clearbuttonadmin();
            btBooksAdmin.BackColor = Color.FromArgb(86, 100, 194);
        }

        private void btBorrowedAdmin_Click(object sender, EventArgs e)
        {
            clearbuttonadmin();
            btBorrowedAdmin.BackColor = Color.FromArgb(86, 100, 194);

        }

        private void btAddBook_Click(object sender, EventArgs e)
        {
            clearbuttonadmin();
            btAddBook.BackColor = Color.FromArgb(86, 100, 194);
        }

        private void btEditUsers_Click(object sender, EventArgs e)
        {
            clearbuttonadmin();
            btEditUsers.BackColor = Color.FromArgb(86, 100, 194);
        }
    }
}
