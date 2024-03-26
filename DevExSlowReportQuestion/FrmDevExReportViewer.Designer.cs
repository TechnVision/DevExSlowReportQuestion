using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace DevExSlowReportQuestion.Report
{
    partial class FrmDevExReportViewer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevExReportViewer));
            documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            documentViewerBarManager1 = new DevExpress.XtraPrinting.Preview.DocumentViewerBarManager(components);
            previewBar1 = new DevExpress.XtraPrinting.Preview.PreviewBar();
            bbiPrint = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiPrintDirect = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiPageSetup = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiEditPageHF = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiScale = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiFind = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiHandTool = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiMagnifier = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiZoomOut = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiZoom = new DevExpress.XtraPrinting.Preview.ZoomBarEditItem();
            printPreviewRepositoryItemComboBox1 = new DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox();
            bbiZoomIn = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiShowFirstPage = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiShowPrevPage = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiShowNextPage = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiShowLastPage = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiMultiplePages = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiExportFile = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiSendFile = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            BBiWhatsApp = new BarButtonItem();
            previewBar2 = new DevExpress.XtraPrinting.Preview.PreviewBar();
            printPreviewStaticItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
            progressBarEditItem1 = new DevExpress.XtraPrinting.Preview.ProgressBarEditItem();
            repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            printPreviewBarItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            printPreviewStaticItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
            zoomTrackBarEditItem1 = new DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem();
            repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            previewBar3 = new DevExpress.XtraPrinting.Preview.PreviewBar();
            miFile = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
            bbiClosePreview = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            miView = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
            miPageLayout = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
            miPageLayoutFacing = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            miPageLayoutContinuous = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            miToolbars = new BarToolbarsListItem();
            barDockControlTop = new BarDockControl();
            barDockControlBottom = new BarDockControl();
            barDockControlLeft = new BarDockControl();
            barDockControlRight = new BarDockControl();
            bbiDocumentMap = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiParameters = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiThumbnails = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiHighlightEditingFields = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiCustomize = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiOpen = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            bbiSave = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            printPreviewBarCheckItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem3 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem4 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem5 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem6 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem7 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem8 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem9 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem10 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem11 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem12 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem13 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem14 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem15 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem16 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem17 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem18 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            printPreviewBarCheckItem19 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
            barButtonItem1 = new BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)documentViewerBarManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)printPreviewRepositoryItemComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemProgressBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemZoomTrackBar1).BeginInit();
            SuspendLayout();
            // 
            // documentViewer1
            // 
            documentViewer1.Dock = DockStyle.Fill;
            documentViewer1.IsMetric = false;
            documentViewer1.Location = new Point(0, 54);
            documentViewer1.Name = "documentViewer1";
            documentViewer1.Size = new Size(1156, 604);
            documentViewer1.TabIndex = 0;
            // 
            // documentViewerBarManager1
            // 
            documentViewerBarManager1.AllowQuickCustomization = false;
            documentViewerBarManager1.Bars.AddRange(new Bar[] { previewBar1, previewBar2, previewBar3 });
            documentViewerBarManager1.DockControls.Add(barDockControlTop);
            documentViewerBarManager1.DockControls.Add(barDockControlBottom);
            documentViewerBarManager1.DockControls.Add(barDockControlLeft);
            documentViewerBarManager1.DockControls.Add(barDockControlRight);
            documentViewerBarManager1.DocumentViewer = documentViewer1;
            documentViewerBarManager1.Form = this;
            documentViewerBarManager1.ImageStream = (ImageCollectionStreamer)resources.GetObject("documentViewerBarManager1.ImageStream");
            documentViewerBarManager1.Items.AddRange(new BarItem[] { printPreviewStaticItem1, progressBarEditItem1, printPreviewBarItem1, printPreviewStaticItem2, zoomTrackBarEditItem1, bbiDocumentMap, bbiParameters, bbiThumbnails, bbiFind, bbiHighlightEditingFields, bbiCustomize, bbiOpen, bbiSave, bbiPrint, bbiPrintDirect, bbiPageSetup, bbiEditPageHF, bbiScale, bbiHandTool, bbiMagnifier, bbiZoomOut, bbiZoom, bbiZoomIn, bbiShowFirstPage, bbiShowPrevPage, bbiShowNextPage, bbiShowLastPage, bbiMultiplePages, bbiExportFile, bbiSendFile, bbiClosePreview, miFile, miView, miPageLayout, miPageLayoutFacing, miPageLayoutContinuous, miToolbars, printPreviewBarCheckItem1, printPreviewBarCheckItem2, printPreviewBarCheckItem3, printPreviewBarCheckItem4, printPreviewBarCheckItem5, printPreviewBarCheckItem6, printPreviewBarCheckItem7, printPreviewBarCheckItem8, printPreviewBarCheckItem9, printPreviewBarCheckItem10, printPreviewBarCheckItem11, printPreviewBarCheckItem12, printPreviewBarCheckItem13, printPreviewBarCheckItem14, printPreviewBarCheckItem15, printPreviewBarCheckItem16, printPreviewBarCheckItem17, printPreviewBarCheckItem18, printPreviewBarCheckItem19, barButtonItem1, BBiWhatsApp });
            documentViewerBarManager1.MainMenu = previewBar3;
            documentViewerBarManager1.MaxItemId = 61;
            documentViewerBarManager1.PreviewBar = previewBar1;
            documentViewerBarManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemProgressBar1, repositoryItemZoomTrackBar1, printPreviewRepositoryItemComboBox1 });
            documentViewerBarManager1.ShowCloseButton = true;
            documentViewerBarManager1.ShowFullMenus = true;
            documentViewerBarManager1.ShowScreenTipsInMenus = true;
            documentViewerBarManager1.StatusBar = previewBar2;
            documentViewerBarManager1.TransparentEditorsMode = DefaultBoolean.True;
            // 
            // previewBar1
            // 
            previewBar1.BarName = "Toolbar";
            previewBar1.DockCol = 0;
            previewBar1.DockRow = 1;
            previewBar1.DockStyle = BarDockStyle.Top;
            previewBar1.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(bbiPrint, true), new LinkPersistInfo(bbiPrintDirect), new LinkPersistInfo(bbiPageSetup), new LinkPersistInfo(bbiEditPageHF), new LinkPersistInfo(bbiScale), new LinkPersistInfo(bbiFind), new LinkPersistInfo(bbiHandTool, true), new LinkPersistInfo(bbiMagnifier), new LinkPersistInfo(bbiZoomOut, true), new LinkPersistInfo(bbiZoom), new LinkPersistInfo(bbiZoomIn), new LinkPersistInfo(bbiShowFirstPage, true), new LinkPersistInfo(bbiShowPrevPage), new LinkPersistInfo(bbiShowNextPage), new LinkPersistInfo(bbiShowLastPage), new LinkPersistInfo(bbiMultiplePages, true), new LinkPersistInfo(bbiExportFile, true), new LinkPersistInfo(bbiSendFile), new LinkPersistInfo(BBiWhatsApp) });
            previewBar1.OptionsBar.DrawBorder = false;
            previewBar1.Text = "Toolbar";
            // 
            // bbiPrint
            // 
            bbiPrint.Caption = "&Print...";
            bbiPrint.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print;
            bbiPrint.Enabled = false;
            bbiPrint.Hint = "Print";
            bbiPrint.Id = 13;
            bbiPrint.Name = "bbiPrint";
            // 
            // bbiPrintDirect
            // 
            bbiPrintDirect.Caption = "P&rint";
            bbiPrintDirect.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect;
            bbiPrintDirect.Enabled = false;
            bbiPrintDirect.Hint = "Quick Print";
            bbiPrintDirect.Id = 14;
            bbiPrintDirect.Name = "bbiPrintDirect";
            // 
            // bbiPageSetup
            // 
            bbiPageSetup.Caption = "Page Set&up...";
            bbiPageSetup.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup;
            bbiPageSetup.Enabled = false;
            bbiPageSetup.Hint = "Page Setup";
            bbiPageSetup.Id = 15;
            bbiPageSetup.Name = "bbiPageSetup";
            // 
            // bbiEditPageHF
            // 
            bbiEditPageHF.Caption = "Header And Footer";
            bbiEditPageHF.Command = DevExpress.XtraPrinting.PrintingSystemCommand.EditPageHF;
            bbiEditPageHF.Enabled = false;
            bbiEditPageHF.Hint = "Header And Footer";
            bbiEditPageHF.Id = 16;
            bbiEditPageHF.Name = "bbiEditPageHF";
            // 
            // bbiScale
            // 
            bbiScale.ActAsDropDown = true;
            bbiScale.ButtonStyle = BarButtonStyle.DropDown;
            bbiScale.Caption = "Scale";
            bbiScale.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale;
            bbiScale.Enabled = false;
            bbiScale.Hint = "Scale";
            bbiScale.Id = 17;
            bbiScale.Name = "bbiScale";
            // 
            // bbiFind
            // 
            bbiFind.ButtonStyle = BarButtonStyle.Check;
            bbiFind.Caption = "Search";
            bbiFind.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Find;
            bbiFind.Enabled = false;
            bbiFind.Hint = "Search";
            bbiFind.Id = 8;
            bbiFind.Name = "bbiFind";
            // 
            // bbiHandTool
            // 
            bbiHandTool.ButtonStyle = BarButtonStyle.Check;
            bbiHandTool.Caption = "Hand Tool";
            bbiHandTool.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HandTool;
            bbiHandTool.Enabled = false;
            bbiHandTool.Hint = "Hand Tool";
            bbiHandTool.Id = 18;
            bbiHandTool.Name = "bbiHandTool";
            // 
            // bbiMagnifier
            // 
            bbiMagnifier.ButtonStyle = BarButtonStyle.Check;
            bbiMagnifier.Caption = "Magnifier";
            bbiMagnifier.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Magnifier;
            bbiMagnifier.Enabled = false;
            bbiMagnifier.Hint = "Magnifier";
            bbiMagnifier.Id = 19;
            bbiMagnifier.Name = "bbiMagnifier";
            // 
            // bbiZoomOut
            // 
            bbiZoomOut.Caption = "Zoom Out";
            bbiZoomOut.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomOut;
            bbiZoomOut.Enabled = false;
            bbiZoomOut.Hint = "Zoom Out";
            bbiZoomOut.Id = 20;
            bbiZoomOut.Name = "bbiZoomOut";
            // 
            // bbiZoom
            // 
            bbiZoom.Caption = "Zoom";
            bbiZoom.Edit = printPreviewRepositoryItemComboBox1;
            bbiZoom.EditValue = "100%";
            bbiZoom.EditWidth = 70;
            bbiZoom.Enabled = false;
            bbiZoom.Hint = "Zoom";
            bbiZoom.Id = 21;
            bbiZoom.Name = "bbiZoom";
            // 
            // printPreviewRepositoryItemComboBox1
            // 
            printPreviewRepositoryItemComboBox1.AutoComplete = false;
            printPreviewRepositoryItemComboBox1.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            printPreviewRepositoryItemComboBox1.DropDownRows = 11;
            printPreviewRepositoryItemComboBox1.Name = "printPreviewRepositoryItemComboBox1";
            // 
            // bbiZoomIn
            // 
            bbiZoomIn.Caption = "Zoom In";
            bbiZoomIn.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomIn;
            bbiZoomIn.Enabled = false;
            bbiZoomIn.Hint = "Zoom In";
            bbiZoomIn.Id = 22;
            bbiZoomIn.Name = "bbiZoomIn";
            // 
            // bbiShowFirstPage
            // 
            bbiShowFirstPage.Caption = "First Page";
            bbiShowFirstPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage;
            bbiShowFirstPage.Enabled = false;
            bbiShowFirstPage.Hint = "First Page";
            bbiShowFirstPage.Id = 23;
            bbiShowFirstPage.Name = "bbiShowFirstPage";
            // 
            // bbiShowPrevPage
            // 
            bbiShowPrevPage.Caption = "Previous Page";
            bbiShowPrevPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage;
            bbiShowPrevPage.Enabled = false;
            bbiShowPrevPage.Hint = "Previous Page";
            bbiShowPrevPage.Id = 24;
            bbiShowPrevPage.Name = "bbiShowPrevPage";
            // 
            // bbiShowNextPage
            // 
            bbiShowNextPage.Caption = "Next Page";
            bbiShowNextPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage;
            bbiShowNextPage.Enabled = false;
            bbiShowNextPage.Hint = "Next Page";
            bbiShowNextPage.Id = 25;
            bbiShowNextPage.Name = "bbiShowNextPage";
            // 
            // bbiShowLastPage
            // 
            bbiShowLastPage.Caption = "Last Page";
            bbiShowLastPage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage;
            bbiShowLastPage.Enabled = false;
            bbiShowLastPage.Hint = "Last Page";
            bbiShowLastPage.Id = 26;
            bbiShowLastPage.Name = "bbiShowLastPage";
            // 
            // bbiMultiplePages
            // 
            bbiMultiplePages.ButtonStyle = BarButtonStyle.DropDown;
            bbiMultiplePages.Caption = "Multiple Pages";
            bbiMultiplePages.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages;
            bbiMultiplePages.Enabled = false;
            bbiMultiplePages.Hint = "Multiple Pages";
            bbiMultiplePages.Id = 27;
            bbiMultiplePages.Name = "bbiMultiplePages";
            // 
            // bbiExportFile
            // 
            bbiExportFile.ButtonStyle = BarButtonStyle.DropDown;
            bbiExportFile.Caption = "Export Document...";
            bbiExportFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile;
            bbiExportFile.Enabled = false;
            bbiExportFile.Hint = "Export Document...";
            bbiExportFile.Id = 30;
            bbiExportFile.Name = "bbiExportFile";
            // 
            // bbiSendFile
            // 
            bbiSendFile.ButtonStyle = BarButtonStyle.DropDown;
            bbiSendFile.Caption = "Send via E-Mail...";
            bbiSendFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendFile;
            bbiSendFile.Enabled = false;
            bbiSendFile.Hint = "Send via E-Mail...";
            bbiSendFile.Id = 31;
            bbiSendFile.Name = "bbiSendFile";
            // 
            // BBiWhatsApp
            // 
            BBiWhatsApp.Caption = "WhatsApp";
            BBiWhatsApp.Id = 60;
            BBiWhatsApp.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BBiWhatsApp.ImageOptions.SvgImage");
            BBiWhatsApp.Name = "BBiWhatsApp";
            // 
            // previewBar2
            // 
            previewBar2.BarName = "Status Bar";
            previewBar2.CanDockStyle = BarCanDockStyle.Bottom;
            previewBar2.DockCol = 0;
            previewBar2.DockRow = 0;
            previewBar2.DockStyle = BarDockStyle.Bottom;
            previewBar2.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(printPreviewStaticItem1), new LinkPersistInfo(progressBarEditItem1), new LinkPersistInfo(printPreviewBarItem1), new LinkPersistInfo(printPreviewStaticItem2, true), new LinkPersistInfo(zoomTrackBarEditItem1) });
            previewBar2.OptionsBar.AllowQuickCustomization = false;
            previewBar2.OptionsBar.DrawDragBorder = false;
            previewBar2.OptionsBar.UseWholeRow = true;
            previewBar2.Text = "Status Bar";
            // 
            // printPreviewStaticItem1
            // 
            printPreviewStaticItem1.Border = BorderStyles.NoBorder;
            printPreviewStaticItem1.Caption = "Nothing";
            printPreviewStaticItem1.Id = 0;
            printPreviewStaticItem1.LeftIndent = 1;
            printPreviewStaticItem1.Name = "printPreviewStaticItem1";
            printPreviewStaticItem1.RightIndent = 1;
            printPreviewStaticItem1.Type = "PageOfPages";
            // 
            // progressBarEditItem1
            // 
            progressBarEditItem1.Edit = repositoryItemProgressBar1;
            progressBarEditItem1.EditHeight = 12;
            progressBarEditItem1.EditWidth = 150;
            progressBarEditItem1.Id = 1;
            progressBarEditItem1.Name = "progressBarEditItem1";
            progressBarEditItem1.Visibility = BarItemVisibility.Never;
            // 
            // repositoryItemProgressBar1
            // 
            repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // printPreviewBarItem1
            // 
            printPreviewBarItem1.Caption = "Stop";
            printPreviewBarItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding;
            printPreviewBarItem1.Enabled = false;
            printPreviewBarItem1.Hint = "Stop";
            printPreviewBarItem1.Id = 2;
            printPreviewBarItem1.Name = "printPreviewBarItem1";
            printPreviewBarItem1.Visibility = BarItemVisibility.Never;
            // 
            // printPreviewStaticItem2
            // 
            printPreviewStaticItem2.Alignment = BarItemLinkAlignment.Right;
            printPreviewStaticItem2.Border = BorderStyles.NoBorder;
            printPreviewStaticItem2.Caption = "100%";
            printPreviewStaticItem2.Id = 3;
            printPreviewStaticItem2.Name = "printPreviewStaticItem2";
            printPreviewStaticItem2.TextAlignment = StringAlignment.Far;
            printPreviewStaticItem2.Type = "ZoomFactor";
            // 
            // zoomTrackBarEditItem1
            // 
            zoomTrackBarEditItem1.Alignment = BarItemLinkAlignment.Right;
            zoomTrackBarEditItem1.Edit = repositoryItemZoomTrackBar1;
            zoomTrackBarEditItem1.EditValue = 90;
            zoomTrackBarEditItem1.EditWidth = 140;
            zoomTrackBarEditItem1.Enabled = false;
            zoomTrackBarEditItem1.Id = 4;
            zoomTrackBarEditItem1.Name = "zoomTrackBarEditItem1";
            zoomTrackBarEditItem1.Range = (new int[] { 10, 500 });
            // 
            // repositoryItemZoomTrackBar1
            // 
            repositoryItemZoomTrackBar1.Alignment = VertAlignment.Center;
            repositoryItemZoomTrackBar1.AllowFocused = false;
            repositoryItemZoomTrackBar1.BorderStyle = BorderStyles.NoBorder;
            repositoryItemZoomTrackBar1.Maximum = 180;
            repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            // 
            // previewBar3
            // 
            previewBar3.BarName = "Main Menu";
            previewBar3.DockCol = 0;
            previewBar3.DockRow = 0;
            previewBar3.DockStyle = BarDockStyle.Top;
            previewBar3.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(miFile), new LinkPersistInfo(miView) });
            previewBar3.OptionsBar.DrawDragBorder = false;
            previewBar3.OptionsBar.UseWholeRow = true;
            previewBar3.Text = "Main Menu";
            // 
            // miFile
            // 
            miFile.Caption = "&File";
            miFile.Command = DevExpress.XtraPrinting.PrintingSystemCommand.File;
            miFile.Id = 33;
            miFile.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(bbiPageSetup), new LinkPersistInfo(bbiPrint), new LinkPersistInfo(bbiPrintDirect), new LinkPersistInfo(bbiExportFile, true), new LinkPersistInfo(bbiSendFile), new LinkPersistInfo(bbiClosePreview, true) });
            miFile.Name = "miFile";
            // 
            // bbiClosePreview
            // 
            bbiClosePreview.Caption = "E&xit";
            bbiClosePreview.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview;
            bbiClosePreview.Enabled = false;
            bbiClosePreview.Hint = "Close Preview";
            bbiClosePreview.Id = 32;
            bbiClosePreview.Name = "bbiClosePreview";
            // 
            // miView
            // 
            miView.Caption = "&View";
            miView.Command = DevExpress.XtraPrinting.PrintingSystemCommand.View;
            miView.Id = 34;
            miView.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(miPageLayout, true), new LinkPersistInfo(miToolbars, true) });
            miView.Name = "miView";
            // 
            // miPageLayout
            // 
            miPageLayout.Caption = "&Page Layout";
            miPageLayout.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayout;
            miPageLayout.Id = 36;
            miPageLayout.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(miPageLayoutFacing), new LinkPersistInfo(miPageLayoutContinuous) });
            miPageLayout.Name = "miPageLayout";
            // 
            // miPageLayoutFacing
            // 
            miPageLayoutFacing.ButtonStyle = BarButtonStyle.Check;
            miPageLayoutFacing.Caption = "&Facing";
            miPageLayoutFacing.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutFacing;
            miPageLayoutFacing.Enabled = false;
            miPageLayoutFacing.GroupIndex = 100;
            miPageLayoutFacing.Id = 37;
            miPageLayoutFacing.Name = "miPageLayoutFacing";
            // 
            // miPageLayoutContinuous
            // 
            miPageLayoutContinuous.ButtonStyle = BarButtonStyle.Check;
            miPageLayoutContinuous.Caption = "&Continuous";
            miPageLayoutContinuous.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutContinuous;
            miPageLayoutContinuous.Enabled = false;
            miPageLayoutContinuous.GroupIndex = 100;
            miPageLayoutContinuous.Id = 38;
            miPageLayoutContinuous.Name = "miPageLayoutContinuous";
            // 
            // miToolbars
            // 
            miToolbars.Caption = "Bars";
            miToolbars.Id = 39;
            miToolbars.Name = "miToolbars";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = documentViewerBarManager1;
            barDockControlTop.Margin = new Padding(4, 3, 4, 3);
            barDockControlTop.Size = new Size(1156, 54);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 658);
            barDockControlBottom.Manager = documentViewerBarManager1;
            barDockControlBottom.Margin = new Padding(4, 3, 4, 3);
            barDockControlBottom.Size = new Size(1156, 24);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 54);
            barDockControlLeft.Manager = documentViewerBarManager1;
            barDockControlLeft.Margin = new Padding(4, 3, 4, 3);
            barDockControlLeft.Size = new Size(0, 604);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1156, 54);
            barDockControlRight.Manager = documentViewerBarManager1;
            barDockControlRight.Margin = new Padding(4, 3, 4, 3);
            barDockControlRight.Size = new Size(0, 604);
            // 
            // bbiDocumentMap
            // 
            bbiDocumentMap.ButtonStyle = BarButtonStyle.Check;
            bbiDocumentMap.Caption = "Document Map";
            bbiDocumentMap.Command = DevExpress.XtraPrinting.PrintingSystemCommand.DocumentMap;
            bbiDocumentMap.Enabled = false;
            bbiDocumentMap.Hint = "Document Map";
            bbiDocumentMap.Id = 5;
            bbiDocumentMap.Name = "bbiDocumentMap";
            // 
            // bbiParameters
            // 
            bbiParameters.ButtonStyle = BarButtonStyle.Check;
            bbiParameters.Caption = "Parameters";
            bbiParameters.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Parameters;
            bbiParameters.Enabled = false;
            bbiParameters.Hint = "Parameters";
            bbiParameters.Id = 6;
            bbiParameters.Name = "bbiParameters";
            // 
            // bbiThumbnails
            // 
            bbiThumbnails.ButtonStyle = BarButtonStyle.Check;
            bbiThumbnails.Caption = "Thumbnails";
            bbiThumbnails.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Thumbnails;
            bbiThumbnails.Enabled = false;
            bbiThumbnails.Hint = "Thumbnails";
            bbiThumbnails.Id = 7;
            bbiThumbnails.Name = "bbiThumbnails";
            // 
            // bbiHighlightEditingFields
            // 
            bbiHighlightEditingFields.ButtonStyle = BarButtonStyle.Check;
            bbiHighlightEditingFields.Caption = "Editing Fields";
            bbiHighlightEditingFields.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HighlightEditingFields;
            bbiHighlightEditingFields.Enabled = false;
            bbiHighlightEditingFields.Hint = "Highlight Editing Fields";
            bbiHighlightEditingFields.Id = 9;
            bbiHighlightEditingFields.Name = "bbiHighlightEditingFields";
            // 
            // bbiCustomize
            // 
            bbiCustomize.Caption = "Customize";
            bbiCustomize.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Customize;
            bbiCustomize.Enabled = false;
            bbiCustomize.Hint = "Customize";
            bbiCustomize.Id = 10;
            bbiCustomize.Name = "bbiCustomize";
            // 
            // bbiOpen
            // 
            bbiOpen.Caption = "Open";
            bbiOpen.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Open;
            bbiOpen.Enabled = false;
            bbiOpen.Hint = "Open a document";
            bbiOpen.Id = 11;
            bbiOpen.Name = "bbiOpen";
            // 
            // bbiSave
            // 
            bbiSave.Caption = "Save";
            bbiSave.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Save;
            bbiSave.Enabled = false;
            bbiSave.Hint = "Save the document";
            bbiSave.Id = 12;
            bbiSave.Name = "bbiSave";
            // 
            // printPreviewBarCheckItem1
            // 
            printPreviewBarCheckItem1.BindableChecked = true;
            printPreviewBarCheckItem1.Caption = "PDF File";
            printPreviewBarCheckItem1.Checked = true;
            printPreviewBarCheckItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf;
            printPreviewBarCheckItem1.Enabled = false;
            printPreviewBarCheckItem1.GroupIndex = 2;
            printPreviewBarCheckItem1.Hint = "PDF File";
            printPreviewBarCheckItem1.Id = 40;
            printPreviewBarCheckItem1.Name = "printPreviewBarCheckItem1";
            // 
            // printPreviewBarCheckItem2
            // 
            printPreviewBarCheckItem2.Caption = "HTML File";
            printPreviewBarCheckItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm;
            printPreviewBarCheckItem2.Enabled = false;
            printPreviewBarCheckItem2.GroupIndex = 2;
            printPreviewBarCheckItem2.Hint = "HTML File";
            printPreviewBarCheckItem2.Id = 41;
            printPreviewBarCheckItem2.Name = "printPreviewBarCheckItem2";
            // 
            // printPreviewBarCheckItem3
            // 
            printPreviewBarCheckItem3.Caption = "MHT File";
            printPreviewBarCheckItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht;
            printPreviewBarCheckItem3.Enabled = false;
            printPreviewBarCheckItem3.GroupIndex = 2;
            printPreviewBarCheckItem3.Hint = "MHT File";
            printPreviewBarCheckItem3.Id = 42;
            printPreviewBarCheckItem3.Name = "printPreviewBarCheckItem3";
            // 
            // printPreviewBarCheckItem4
            // 
            printPreviewBarCheckItem4.Caption = "RTF File";
            printPreviewBarCheckItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf;
            printPreviewBarCheckItem4.Enabled = false;
            printPreviewBarCheckItem4.GroupIndex = 2;
            printPreviewBarCheckItem4.Hint = "RTF File";
            printPreviewBarCheckItem4.Id = 43;
            printPreviewBarCheckItem4.Name = "printPreviewBarCheckItem4";
            // 
            // printPreviewBarCheckItem5
            // 
            printPreviewBarCheckItem5.Caption = "DOCX File";
            printPreviewBarCheckItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportDocx;
            printPreviewBarCheckItem5.Enabled = false;
            printPreviewBarCheckItem5.GroupIndex = 2;
            printPreviewBarCheckItem5.Hint = "DOCX File";
            printPreviewBarCheckItem5.Id = 44;
            printPreviewBarCheckItem5.Name = "printPreviewBarCheckItem5";
            // 
            // printPreviewBarCheckItem6
            // 
            printPreviewBarCheckItem6.Caption = "XLS File";
            printPreviewBarCheckItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls;
            printPreviewBarCheckItem6.Enabled = false;
            printPreviewBarCheckItem6.GroupIndex = 2;
            printPreviewBarCheckItem6.Hint = "XLS File";
            printPreviewBarCheckItem6.Id = 45;
            printPreviewBarCheckItem6.Name = "printPreviewBarCheckItem6";
            // 
            // printPreviewBarCheckItem7
            // 
            printPreviewBarCheckItem7.Caption = "XLSX File";
            printPreviewBarCheckItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx;
            printPreviewBarCheckItem7.Enabled = false;
            printPreviewBarCheckItem7.GroupIndex = 2;
            printPreviewBarCheckItem7.Hint = "XLSX File";
            printPreviewBarCheckItem7.Id = 46;
            printPreviewBarCheckItem7.Name = "printPreviewBarCheckItem7";
            // 
            // printPreviewBarCheckItem8
            // 
            printPreviewBarCheckItem8.Caption = "CSV File";
            printPreviewBarCheckItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv;
            printPreviewBarCheckItem8.Enabled = false;
            printPreviewBarCheckItem8.GroupIndex = 2;
            printPreviewBarCheckItem8.Hint = "CSV File";
            printPreviewBarCheckItem8.Id = 47;
            printPreviewBarCheckItem8.Name = "printPreviewBarCheckItem8";
            // 
            // printPreviewBarCheckItem9
            // 
            printPreviewBarCheckItem9.Caption = "Text File";
            printPreviewBarCheckItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt;
            printPreviewBarCheckItem9.Enabled = false;
            printPreviewBarCheckItem9.GroupIndex = 2;
            printPreviewBarCheckItem9.Hint = "Text File";
            printPreviewBarCheckItem9.Id = 48;
            printPreviewBarCheckItem9.Name = "printPreviewBarCheckItem9";
            // 
            // printPreviewBarCheckItem10
            // 
            printPreviewBarCheckItem10.Caption = "Image File";
            printPreviewBarCheckItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic;
            printPreviewBarCheckItem10.Enabled = false;
            printPreviewBarCheckItem10.GroupIndex = 2;
            printPreviewBarCheckItem10.Hint = "Image File";
            printPreviewBarCheckItem10.Id = 49;
            printPreviewBarCheckItem10.Name = "printPreviewBarCheckItem10";
            // 
            // printPreviewBarCheckItem11
            // 
            printPreviewBarCheckItem11.BindableChecked = true;
            printPreviewBarCheckItem11.Caption = "PDF File";
            printPreviewBarCheckItem11.Checked = true;
            printPreviewBarCheckItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf;
            printPreviewBarCheckItem11.Enabled = false;
            printPreviewBarCheckItem11.GroupIndex = 1;
            printPreviewBarCheckItem11.Hint = "PDF File";
            printPreviewBarCheckItem11.Id = 50;
            printPreviewBarCheckItem11.Name = "printPreviewBarCheckItem11";
            // 
            // printPreviewBarCheckItem12
            // 
            printPreviewBarCheckItem12.Caption = "MHT File";
            printPreviewBarCheckItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendMht;
            printPreviewBarCheckItem12.Enabled = false;
            printPreviewBarCheckItem12.GroupIndex = 1;
            printPreviewBarCheckItem12.Hint = "MHT File";
            printPreviewBarCheckItem12.Id = 51;
            printPreviewBarCheckItem12.Name = "printPreviewBarCheckItem12";
            // 
            // printPreviewBarCheckItem13
            // 
            printPreviewBarCheckItem13.Caption = "RTF File";
            printPreviewBarCheckItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf;
            printPreviewBarCheckItem13.Enabled = false;
            printPreviewBarCheckItem13.GroupIndex = 1;
            printPreviewBarCheckItem13.Hint = "RTF File";
            printPreviewBarCheckItem13.Id = 52;
            printPreviewBarCheckItem13.Name = "printPreviewBarCheckItem13";
            // 
            // printPreviewBarCheckItem14
            // 
            printPreviewBarCheckItem14.Caption = "DOCX File";
            printPreviewBarCheckItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendDocx;
            printPreviewBarCheckItem14.Enabled = false;
            printPreviewBarCheckItem14.GroupIndex = 1;
            printPreviewBarCheckItem14.Hint = "DOCX File";
            printPreviewBarCheckItem14.Id = 53;
            printPreviewBarCheckItem14.Name = "printPreviewBarCheckItem14";
            // 
            // printPreviewBarCheckItem15
            // 
            printPreviewBarCheckItem15.Caption = "XLS File";
            printPreviewBarCheckItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXls;
            printPreviewBarCheckItem15.Enabled = false;
            printPreviewBarCheckItem15.GroupIndex = 1;
            printPreviewBarCheckItem15.Hint = "XLS File";
            printPreviewBarCheckItem15.Id = 54;
            printPreviewBarCheckItem15.Name = "printPreviewBarCheckItem15";
            // 
            // printPreviewBarCheckItem16
            // 
            printPreviewBarCheckItem16.Caption = "XLSX File";
            printPreviewBarCheckItem16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx;
            printPreviewBarCheckItem16.Enabled = false;
            printPreviewBarCheckItem16.GroupIndex = 1;
            printPreviewBarCheckItem16.Hint = "XLSX File";
            printPreviewBarCheckItem16.Id = 55;
            printPreviewBarCheckItem16.Name = "printPreviewBarCheckItem16";
            // 
            // printPreviewBarCheckItem17
            // 
            printPreviewBarCheckItem17.Caption = "CSV File";
            printPreviewBarCheckItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv;
            printPreviewBarCheckItem17.Enabled = false;
            printPreviewBarCheckItem17.GroupIndex = 1;
            printPreviewBarCheckItem17.Hint = "CSV File";
            printPreviewBarCheckItem17.Id = 56;
            printPreviewBarCheckItem17.Name = "printPreviewBarCheckItem17";
            // 
            // printPreviewBarCheckItem18
            // 
            printPreviewBarCheckItem18.Caption = "Text File";
            printPreviewBarCheckItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt;
            printPreviewBarCheckItem18.Enabled = false;
            printPreviewBarCheckItem18.GroupIndex = 1;
            printPreviewBarCheckItem18.Hint = "Text File";
            printPreviewBarCheckItem18.Id = 57;
            printPreviewBarCheckItem18.Name = "printPreviewBarCheckItem18";
            // 
            // printPreviewBarCheckItem19
            // 
            printPreviewBarCheckItem19.Caption = "Image File";
            printPreviewBarCheckItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic;
            printPreviewBarCheckItem19.Enabled = false;
            printPreviewBarCheckItem19.GroupIndex = 1;
            printPreviewBarCheckItem19.Hint = "Image File";
            printPreviewBarCheckItem19.Id = 58;
            printPreviewBarCheckItem19.Name = "printPreviewBarCheckItem19";
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "barButtonItem1";
            barButtonItem1.Id = 59;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // FrmDevExReportViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            
            ClientSize = new Size(1156, 682);
            Controls.Add(documentViewer1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmDevExReportViewer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmDevExReportViewer";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)documentViewerBarManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)printPreviewRepositoryItemComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemProgressBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemZoomTrackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraPrinting.Preview.DocumentViewerBarManager documentViewerBarManager1;
        private DevExpress.XtraPrinting.Preview.PreviewBar previewBar1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiPrint;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiPrintDirect;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiPageSetup;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiEditPageHF;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiScale;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiFind;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiHandTool;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiMagnifier;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiZoomOut;
        private DevExpress.XtraPrinting.Preview.ZoomBarEditItem bbiZoom;
        private DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox printPreviewRepositoryItemComboBox1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiZoomIn;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiShowFirstPage;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiShowPrevPage;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiShowNextPage;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiShowLastPage;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiMultiplePages;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiExportFile;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiSendFile;
        private DevExpress.XtraPrinting.Preview.PreviewBar previewBar2;
        private DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem printPreviewStaticItem1;
        private DevExpress.XtraPrinting.Preview.ProgressBarEditItem progressBarEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem printPreviewBarItem1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem printPreviewStaticItem2;
        private DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem zoomTrackBarEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private DevExpress.XtraPrinting.Preview.PreviewBar previewBar3;
        private DevExpress.XtraPrinting.Preview.PrintPreviewSubItem miFile;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiClosePreview;
        private DevExpress.XtraPrinting.Preview.PrintPreviewSubItem miView;
        private DevExpress.XtraPrinting.Preview.PrintPreviewSubItem miPageLayout;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem miPageLayoutFacing;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem miPageLayoutContinuous;
        private BarToolbarsListItem miToolbars;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiDocumentMap;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiParameters;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiThumbnails;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiHighlightEditingFields;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiCustomize;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiOpen;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarItem bbiSave;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem2;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem3;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem4;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem5;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem6;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem7;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem8;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem9;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem10;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem11;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem12;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem13;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem14;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem15;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem16;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem17;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem18;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem printPreviewBarCheckItem19;
        private BarButtonItem barButtonItem1;
        private BarButtonItem BBiWhatsApp;
    }
}