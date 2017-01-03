using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ColorCode;
using SelectPdf;

namespace SelectPdf.Samples
{
    public partial class PdfConverterViewerPreferences : Form
    {
        private void BtnCreatePdf_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string file = "Document.pdf";

            try
            {
                // read parameters from the webpage
                string url = TxtUrl.Text;

                string page_layout = DdlPageLayout.SelectedItem.ToString();
                PdfViewerPageLayout pageLayout = (PdfViewerPageLayout)Enum.Parse(
                    typeof(PdfViewerPageLayout), page_layout, true);

                string page_mode = DdlPageMode.SelectedItem.ToString();
                PdfViewerPageMode pageMode = (PdfViewerPageMode)Enum.Parse(
                    typeof(PdfViewerPageMode), page_mode, true);

                bool centerWindow = ChkCenterWindow.Checked;
                bool displayDocTitle = ChkDisplayDocTitle.Checked;
                bool fitWindow = ChkFitWindow.Checked;
                bool hideMenuBar = ChkHideMenuBar.Checked;
                bool hideToolbar = ChkHideToolbar.Checked;
                bool hideWindowUI = ChkHideWindowUI.Checked;

                // instantiate a html to pdf converter object
                HtmlToPdf converter = new HtmlToPdf();

                // set converter options
                converter.Options.ViewerPreferences.CenterWindow = centerWindow;
                converter.Options.ViewerPreferences.DisplayDocTitle = displayDocTitle;
                converter.Options.ViewerPreferences.FitWindow = fitWindow;
                converter.Options.ViewerPreferences.HideMenuBar = hideMenuBar;
                converter.Options.ViewerPreferences.HideToolbar = hideToolbar;
                converter.Options.ViewerPreferences.HideWindowUI = hideWindowUI;

                converter.Options.ViewerPreferences.PageLayout = pageLayout;
                converter.Options.ViewerPreferences.PageMode = pageMode;
                converter.Options.ViewerPreferences.NonFullScreenPageMode =
                    PdfViewerFullScreenExitMode.UseNone;

                // create a new pdf document converting an url
                PdfDocument doc = converter.ConvertUrl(url);

                // save pdf document
                doc.Save(file);

                // close pdf document
                doc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error: {0}", ex.Message),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                Cursor = Cursors.Arrow;
            }

            // open generated pdf
            try
            {
                System.Diagnostics.Process.Start(file);
            }
            catch
            {
                MessageBox.Show("Could not open generated pdf document",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public PdfConverterViewerPreferences()
        {
            InitializeComponent();

            DdlPageLayout.SelectedIndex = DdlPageLayout.Items.IndexOf("OneColumn");
            DdlPageMode.SelectedIndex = DdlPageMode.Items.IndexOf("UseNone");

            try
            {
                // display highlighted sample code
                string code = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory +
                    "/../../" + "PdfConverterViewerPreferences.cs");
                WBSampleCode.DocumentText = new CodeColorizer().Colorize(code, Languages.CSharp);
            }
            catch
            {
                WBSampleCode.DocumentText = "Sample code not available";
            }
        }

    }
}
