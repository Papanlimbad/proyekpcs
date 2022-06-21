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
    public partial class FormCrystalReport : Form
    {
        MySqlConnection conn;
        public FormCrystalReport(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            cbSearchBy.SelectedIndex = 0;
            deactive(0);
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (cbSearchBy.Text.Equals("Borrowed"))
            {
                RptPinjamAktif rpt = new RptPinjamAktif();
                rpt.SetDatabaseLogon("root", "", "localhost", "bukutachi_db");
                rpt.SetParameterValue("Limit", cbFind.Text);
                crystalReportViewer2.ReportSource = rpt;
            }
            else if (cbSearchBy.Text.Equals("History"))
            {
                RptHistory rpt = new RptHistory();
                rpt.SetDatabaseLogon("root", "", "localhost", "bukutachi_db");
                rpt.SetParameterValue("Limit", cbFind.Text);
                crystalReportViewer2.ReportSource = rpt;
            }
            else if (cbSearchBy.Text.Equals("Fine"))
            {
                if (dtFrom.Value < dtTo.Value)
                {
                    RptDenda rpt = new RptDenda();
                    rpt.SetDatabaseLogon("root", "", "localhost", "bukutachi_db");
                    //String temp1 = dtFrom.Value.ToString("dd-MMMM-yyyy");
                    //String temp2 = dtTo.Value.ToString("dd-MMMM-yyyy");
                    rpt.SetParameterValue("Limit", dtFrom.Value);
                    rpt.SetParameterValue("Limit2", dtTo.Value);
                    crystalReportViewer2.ReportSource = rpt;
                }
                else
                {
                    MessageBox.Show("Tanggal invalid");
                }
            }
        }

        private void loadcombobox(int tipe)
        {
            string query = "";
            if (tipe == 0)
            {
                query = @"SELECT me_name as 'Jenis'
                        FROM dpinjam dp
                        INNER JOIN hpinjam hp ON dp.dp_hp_id = hp.hp_id
                        INNER JOIN MEMBER me ON hp.hp_me_id = me.me_id
                        INNER JOIN buku bu ON bu.bu_id = dp.dp_bu_id
                        WHERE hp.hp_status = 1
                        GROUP BY me_name;";
            }else
            {
                query = @"SELECT bu_title as 'Jenis'
                        FROM dpinjam dp
                        INNER JOIN hpinjam hp ON dp.dp_hp_id = hp.hp_id
                        INNER JOIN MEMBER me ON hp.hp_me_id = me.me_id
                        INNER JOIN buku bu ON bu.bu_id = dp.dp_bu_id
                        WHERE hp.hp_status = 2
                        GROUP BY bu_title;";
            }
          
            MySqlCommand cmd = new MySqlCommand(query, conn);

            conn.Open();
            cmd.ExecuteReader();
            conn.Close();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dtGenre = new DataTable();

            da.Fill(dtGenre);
            //DataRow rowbaru;
            //rowbaru = dtGenre.NewRow();
            //rowbaru["Jenis"] = "All";
            //dtGenre.Rows.InsertAt(rowbaru, 0);
            cbFind.DisplayMember = "Jenis";
            cbFind.DataSource = dtGenre.DefaultView;
            cbFind.SelectedIndex = 0;
        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
   
            if (cbSearchBy.Text.Equals("Borrowed"))
            {
                deactive(0);
                loadcombobox(0);
            }
            else if (cbSearchBy.Text.Equals("History"))
            {
                deactive(0);
                loadcombobox(1);
            }
            else if (cbSearchBy.Text.Equals("Fine"))
            {
                deactive(1);
            }
        }
        private void deactive(int tipe)
        {
            if (tipe==0)
            {
                dtFrom.Visible = false;
                dtFrom.Enabled = false;
                dtTo.Visible = false;
                dtTo.Enabled = false;
                labelhide.Visible = false;
                cbFind.Enabled = true;
                cbFind.Visible = true;
            }
            else
            {
                dtFrom.Visible = true;
                dtFrom.Enabled = true;
                dtTo.Visible = true;
                dtTo.Enabled = true;
                labelhide.Visible = true;
                cbFind.Enabled = false;
                cbFind.Visible = false;
            }
        }
    }
}
