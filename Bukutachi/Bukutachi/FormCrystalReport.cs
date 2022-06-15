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
    public partial class FormCrystalReport : Form
    {
        public FormCrystalReport()
        {
            InitializeComponent();
            RptDenda rpt = new RptDenda();
            rpt.SetDatabaseLogon("root", "", "localhost", "bukutachi_db");
            crystalReportViewer2.ReportSource = rpt;
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
