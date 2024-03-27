namespace DevExSlowReportQuestion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnShowReport = new DevExpress.XtraEditors.SimpleButton();
            BtnShowRerportWithFilterString = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // BtnShowReport
            // 
            BtnShowReport.Location = new System.Drawing.Point(12, 12);
            BtnShowReport.Name = "BtnShowReport";
            BtnShowReport.Size = new System.Drawing.Size(228, 120);
            BtnShowReport.TabIndex = 0;
            BtnShowReport.Text = "Show Report";
            BtnShowReport.Click += BtnShowReport_Click;
            // 
            // BtnShowRerportWithFilterString
            // 
            BtnShowRerportWithFilterString.Location = new System.Drawing.Point(277, 12);
            BtnShowRerportWithFilterString.Name = "BtnShowRerportWithFilterString";
            BtnShowRerportWithFilterString.Size = new System.Drawing.Size(228, 120);
            BtnShowRerportWithFilterString.TabIndex = 1;
            BtnShowRerportWithFilterString.Text = "Show Report With Filter String\r\n";
            BtnShowRerportWithFilterString.Click += BtnShowRerportWithFilterString_Click;
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new System.Drawing.Point(12, 138);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(228, 120);
            simpleButton1.TabIndex = 2;
            simpleButton1.Text = "Show Report With Filter Dict";
            simpleButton1.Click += SimpleButton1_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.Options.UseTextOptions = true;
            simpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            simpleButton2.Location = new System.Drawing.Point(277, 138);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(228, 120);
            simpleButton2.TabIndex = 3;
            simpleButton2.Text = "Show Report With Filter Dict with UnWanted Data ";
            simpleButton2.Click += SimpleButton2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(632, 278);
            Controls.Add(simpleButton2);
            Controls.Add(simpleButton1);
            Controls.Add(BtnShowRerportWithFilterString);
            Controls.Add(BtnShowReport);
            Name = "Form1";
            Text = "Slow Report Question";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnShowReport;
        private DevExpress.XtraEditors.SimpleButton BtnShowRerportWithFilterString;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}

