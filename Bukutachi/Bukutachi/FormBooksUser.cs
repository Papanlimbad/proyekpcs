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
    public partial class FormBooksUser : Form
    {
        public FormBooksUser()
        {
            InitializeComponent();
        }

        private void FormBooksUser_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            cbSortBy1.SelectedIndex = 0;
            cbSortBy2.SelectedIndex = 0;
        }
    }
}
