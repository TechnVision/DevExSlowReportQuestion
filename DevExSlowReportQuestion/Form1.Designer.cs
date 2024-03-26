﻿namespace DevExSlowReportQuestion
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
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(632, 278);
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
    }
}

