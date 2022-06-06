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
    public partial class FormHistoryUser : Form
    {
        MySqlConnection conn;
        String[] user = new string[8];
        public FormHistoryUser(MySqlConnection conn, String[] user)
        {
            InitializeComponent();
            this.user = user;
            this.conn = conn;
        }

        private void FormHistoryUser_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT bu_title AS 'Book Title', DATE_FORMAT(hp_borrowedat,'%d-%b-%Y') AS 'Borrowed Date', DATE_FORMAT(hp_returnat,'%d-%b-%Y') AS 'Return Date' FROM hpinjam, dpinjam, buku, MEMBER WHERE hp_id = dp_hp_id AND bu_id = dp_bu_id AND me_id = hp_me_id AND me_id = ?id AND hp_status = 1;", conn);
            cmd.Parameters.Add(new MySqlParameter("id", user[0]));
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dsBorrowed = new DataSet();
            da.Fill(dsBorrowed);
            dgvHistory.DataSource = dsBorrowed.Tables[0].DefaultView;
        }
    }
}
