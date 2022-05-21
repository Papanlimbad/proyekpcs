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
    public partial class FormHomeUser : Form
    {
        MySqlConnection conn;
        String[] user = new string[8];
        public FormHomeUser(MySqlConnection conn, String[] user)
        {
            InitializeComponent();
            this.conn = conn;
            this.user = user;
        }

        private void FormHomeUser_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "Welcome, " + user[1];
        }
    }
}
