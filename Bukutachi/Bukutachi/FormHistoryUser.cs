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
        int rowIdx;
        public FormHistoryUser(MySqlConnection conn, String[] user)
        {
            InitializeComponent();
            this.user = user;
            this.conn = conn;
        }

        private void FormHistoryUser_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select dp.dp_id AS 'ID', bu.bu_title AS 'Book Title', DATE_FORMAT(hp.hp_borrowedat,'%d-%b-%Y') AS 'Borrowed Date', DATE_FORMAT(hp.hp_returnat,'%d-%b-%Y') AS 'Return Date', IFNULL(ra.ra_value,'-') AS 'Rating' from member me, dpinjam dp left join hpinjam hp on hp.hp_id = dp.dp_hp_id left join buku bu on bu.bu_id = dp.dp_bu_id left join rating ra on ra.ra_me_id = hp.hp_me_id and ra.ra_bu_id = bu.bu_id where me.me_id=?id; ", conn);
            cmd.Parameters.Add(new MySqlParameter("id", user[0]));
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dsBorrowed = new DataSet();
            da.Fill(dsBorrowed);
            dgvHistory.DataSource = dsBorrowed.Tables[0].DefaultView;
        }

        private void dgvHistory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIdx = e.RowIndex;
            if (dgvHistory.Rows[rowIdx].Cells[4].Value.ToString().Equals("-"))
            {
                btAddRating.Enabled = true;
            }
            else
            {
                btAddRating.Enabled = false;
            }
        }

        private void btAddRating_Click(object sender, EventArgs e)
        {
            FormHistoryUserClicked fh = new FormHistoryUserClicked(conn, user,dgvHistory.Rows[rowIdx].Cells[0].Value.ToString());
            fh.ShowDialog();
            fh.Dispose();

            btAddRating.Enabled = false;

            FormHistoryUser_Load(sender, e);
        }
    }
}
