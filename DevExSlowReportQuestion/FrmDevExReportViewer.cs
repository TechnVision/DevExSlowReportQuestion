using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Wizard.Services;
using DevExpress.Utils;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using DevExSlowReportQuestion;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection.Emit;

namespace DevExSlowReportQuestion.Report;

public partial class FrmDevExReportViewer : XtraForm
{
    private string Title = "", Range = "";

    private FrmDevExReportViewer(string Title, string Range)
    {
        InitializeComponent();
        Text = Title;
        this.Title = Title;
        this.Range = Range;
        documentViewer1.ShowPageMargins = false;
        documentViewer1.Zoom = 1.25F;
    }
    public static string XrRepotPath(string fileName)
    {
        if (File.Exists(fileName)) { return fileName; }
        else
            return !fileName.ToUpper().EndsWith("REPX")
                ? $@"{AppDomain.CurrentDomain.BaseDirectory}QuestionResources\{fileName}.REPX"
                : $@"{AppDomain.CurrentDomain.BaseDirectory}QuestionResources\{fileName}";
    }


    //46
    public FrmDevExReportViewer(string FilePath, string SelectionFormula, string Title, string Range) : this(Title, Range)
    {
        string FilePathX = XrRepotPath(FilePath);
        if (File.Exists(FilePathX))
        {
            XtraReport Report = XtraReport.FromFile(FilePathX, true);
            var rpr = DoReportAction(Report, SelectionFormula, Title, Range);
            documentViewer1.DocumentSource = rpr;
        }
        else
        {
            XtraMessageBox.Show($"\"{FilePath}\" not found");
        }
    }

    #region 
    private XtraReport DoReportAction(XtraReport Report, string SelectionFormula, string Title, string Range)
    {
        if (Report != null)
        {
            Text = Title + "(" + Report.Name + ")";

            if (SelectionFormula != "")
            {
                if (SelectionFormula.Trim().StartsWith("AND", StringComparison.InvariantCultureIgnoreCase))
                {
                    SelectionFormula = SelectionFormula.Trim().Substring(3, SelectionFormula.Trim().Length - 3);
                }

                Report.FilterString = SelectionFormula;
            }


            return SetDefaultValues(Report, Title, Range);
        }
        else
        {
            return null;
        }
    }

    private XtraReport SetDefaultValues(XtraReport Report, string Title, string Range)
    {
        Report.ShowPreviewMarginLines = false;
        try
        {
            Report.Bands.ForEach(s =>
            {
                SetTextFromCode(s);
            });
        }
        catch { }
        (Report as IServiceContainer).RemoveService(typeof(IConnectionProviderService));
        (Report as IServiceContainer).AddService(typeof(IConnectionProviderService), new CustomConnectionProviderService());
        return Report;
    }



    private void SetTextFromCode(Band s)
    {
        foreach (XRControl item in s.Controls)
        {
            if (item is Band ss)
                SetTextFromCode(ss);
            else
                SetTextFromCode(item);
        }
    }

    private void SetTextFromCode(XRControl item)
    {
        if (item is XRSubreport subrpt)
        {
            if (subrpt.ReportSourceUrl != "")
                try
                {
                    (subrpt.Report as IServiceContainer).RemoveService(typeof(IConnectionProviderService));
                    (subrpt.Report as IServiceContainer).AddService(typeof(IConnectionProviderService), new CustomConnectionProviderService());
                }
                catch { }
        }

        if (item.Name.ToUpper().Equals("COMPANY".ToUpper()) || item.Text.ToUpper().Equals("COMPANY".ToUpper()) ||
    item.Name.ToUpper().Equals("companyname".ToUpper()) || item.Text.ToUpper().Equals("companyname".ToUpper()) ||
    item.Name.ToUpper().Equals("companyname1".ToUpper()) || item.Text.ToUpper().Equals("companyname1".ToUpper()))
        {
            // item.Text = CommonLogics.Company_Master.Comp_Name;
        }

        if (item.Name.ToUpper().EndsWith("TITLE") || item.Text.ToUpper().EndsWith("TITLE"))
        {
            item.Text = Title;
        }

        if (item.Name.ToUpper().EndsWith("ADDRESS") || item.Text.ToUpper().EndsWith("ADDRESS"))
        {
            // item.Text = $@"{CommonLogics.Company_Master.Add1},{CommonLogics.Company_Master.Add2}, {CommonLogics.Company_Master.CityName}";
        }

        if (item.Name.ToUpper().EndsWith("ADD1") || item.Text.ToUpper().EndsWith("ADD 1"))
        {
            // item.Text = $@"{CommonLogics.Company_Master.Add1}";
        }

        if (item.Name.ToUpper().EndsWith("CompLogo".ToUpper()) || item.Text.ToUpper().EndsWith("CompLogo".ToUpper()))
        {
            if (item is XRPictureBox Pp)
            {
                // using var ms = new MemoryStream(CommonLogics.Company_Master.Logo);
                // Pp.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(Image.FromStream(ms));
            }
        }

        if (item.Name.ToUpper().EndsWith("ADD2") || item.Text.ToUpper().EndsWith("ADD 2"))
        {
            // item.Text = $@"{CommonLogics.Company_Master.Add2}";
        }

        if (item.Name.ToUpper().EndsWith("ADD3") || item.Text.ToUpper().EndsWith("ADD 3"))
        {
            // item.Text = $@"{CommonLogics.Company_Master.Add3}";
        }

        if (item.Name.ToUpper().EndsWith("FACTADD1") || item.Text.ToUpper().EndsWith("FACTADD 1"))
        {
            // item.Text = $@"{CommonLogics.Company_Master.Fact_Add1}";
        }

        if (item.Name.ToUpper().EndsWith("FACTADD2") || item.Text.ToUpper().EndsWith("FACTADD 2"))
        {
            // item.Text = $@"{CommonLogics.Company_Master.Fact_Add2}";
        }

        if (item.Name.ToUpper().EndsWith("FACTADD") || item.Text.ToUpper().EndsWith("FACTADD"))
        {
            // item.Text = $@"{CommonLogics.Company_Master.Fact_Add1}, {CommonLogics.Company_Master.Fact_Add2}, {CommonLogics.Company_Master.Fact_City}";
        }

        if (item.Name.ToUpper().EndsWith("RANGE") || item.Text.ToUpper().EndsWith("RANGE"))
        {
            item.Text = Range;
        }
    }

    /// <summary>
    /// Return a Tuple, Takes too much time for huge data
    /// </summary>
    /// <param name="FileName"></param>
    /// <returns>
    /// Return a Tuple where Item 1 is FilePath
    /// Item 2 is File Name --> Show it as FileName
    /// </returns>
    public Tuple<string, string> ExportExcelToDesktop(string FileName)
    {
        string FilePath = "";
        if (documentViewer1.DocumentSource is XtraReport Fle)
        {
            string Dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            FilePath = Dir + "\\" + FileName + ".Xlsx";
            if (File.Exists(FilePath))
            {
                try
                {
                    File.Delete(FilePath);
                }
                catch
                {
                    XtraMessageBox.Show(@$"Please check if {FilePath} is Closed then click OK");
                }
            }

            Fle.ExportToXlsx(FilePath, new XlsxExportOptions()
            {
                ShowGridLines = true,
                ExportHyperlinks = true,
                //TextExportMode = TextExportMode.Value,
                //ExportMode = XlsxExportMode.SingleFile,
            });
        }
        return new Tuple<string, string>(FilePath, FileName);
    }  
    #endregion
}


public class CustomConnectionProviderService : IConnectionProviderService
{
    public static string MainDbConStr(string ServerName, string dbName, string DatabaseUserID, string DatabaseUserPassword, string AppName)
    {
        var str = $"data source={ServerName}; initial catalog={dbName}; user id={DatabaseUserID}; password={DatabaseUserPassword}; MultipleActiveResultSets=True; App={AppName}; TrustServerCertificate=true; Timeout={int.MaxValue};";

        return str;
    }

    public SqlDataConnection LoadConnection(string connectionName)
    {
        var Con = new SqlDataConnection()
        {
            ConnectionString = MainDbConStr(Program.ServerName, Program.dbName, Program.DatabaseUserID, Program.DatabaseUserPassword, "DevExReportViewer"),
            Name = connectionName + "New_Connection",
        };
        return Con;
    }

    public string LoadConnection()
    {
        return MainDbConStr(Program.ServerName, Program.dbName, Program.DatabaseUserID, Program.DatabaseUserPassword, "DevExReportViewer");
    }
}
