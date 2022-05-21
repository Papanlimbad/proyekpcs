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
    public partial class FormBooksUser : Form
    {
        MySqlConnection conn;
        String[] user = new string[8];
        public FormBooksUser(MySqlConnection conn, String[] user)
        {
            InitializeComponent();
            this.conn = conn;
            this.user = user;
        }

        private void FormBooksUser_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            cbSortBy1.SelectedIndex = 0;
            cbSortBy2.SelectedIndex = 0;
        }
    }
}
