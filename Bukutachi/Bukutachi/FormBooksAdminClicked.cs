using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Bukutachi
{
    public partial class FormBooksAdminClicked : Form
    {
        int bookId;
        MySqlConnection conn;
        Form lastPage;
        HomeUser prog;
        public FormBooksAdminClicked(MySqlConnection conn, int id, Form lastPage)
        {
            InitializeComponent();
            bookId = id;
            this.conn = conn;
            this.lastPage = lastPage;
        }

        private void btEditData_Click(object sender, EventArgs e)
        {

        }
    }
}
