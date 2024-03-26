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
            // [Item_Code] in (2124, 2116, 13333) And[party_code] = 1572017
            FrmDevExReportViewer fmr = new("PurcDateWise", "[Item_Code] = 22112021", "Report with Filter String", "");
            fmr.Show();
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
