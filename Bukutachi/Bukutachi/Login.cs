using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bukutachi {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        Point posDrag;

        private void Login_Load(object sender, EventArgs e) {
            titleBar.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                this.Location = new Point(MousePosition.X - posDrag.X, MousePosition.Y - posDrag.Y);
            }
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e) {
            posDrag = new Point(e.X, e.Y);
        }

        private void roundedButton1_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
