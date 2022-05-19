using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bukutachi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
            Register register = new Register();
            this.Visible = false;
            register.ShowDialog();
            register.Dispose();
            this.Visible = true;
        }
    }
}
