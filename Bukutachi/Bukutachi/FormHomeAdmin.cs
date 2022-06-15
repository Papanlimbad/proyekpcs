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
    public partial class FormHomeAdmin : Form
    {
        MySqlConnection conn;
        public FormHomeAdmin()
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void FormHomeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void lbSeeMore1_Click(object sender, EventArgs e)
        {

        }
    }
}
