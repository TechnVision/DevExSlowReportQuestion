using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExSlowReportQuestion.Report;

namespace DevExSlowReportQuestion
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnShowReport_Click(object sender, EventArgs e)
        {
            FrmDevExReportViewer fmr = new("PurcDateWise", "", "Report with out any filter", "");
            fmr.Show();
        }

        private void BtnShowRerportWithFilterString_Click(object sender, EventArgs e)
        {
            FrmDevExReportViewer fmr = new("PurcDateWise", "[Item_Code] = 22112021", "Report with Filter String", "");
            fmr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> map = new Dictionary<string, string>()
            {
                { "Store_Transaction", "[Item_Code] = 22112021" },
            };
            FrmDevExReportViewer fmr = new("PurcDateWise", map, "Report with Filter String", "");
            fmr.Show();
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> map = new Dictionary<string, string>()
            {
                { "Account_Master", "[Ac_Code] = 822022" }
            };
            FrmDevExReportViewer fmr = new("PurcDateWise", map, "Report with Filter String", "");
            fmr.Show();
        }
    }
}
