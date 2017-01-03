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
    public partial class HtmlToPdfHeadersAndFooters : Form
    {
        string headerUrl = AppDomain.CurrentDomain.BaseDirectory + "/../../files/header.html";
        string footerUrl = AppDomain.CurrentDomain.BaseDirectory + "/../../files/footer.html";

        private void BtnCreatePdf_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string file = "Document.pdf";

            try
            {
                // get parameters
                bool showHeaderOnFirstPage = ChkHeaderFirstPage.Checked;
                bool showHeaderOnOddPages = ChkHeaderOddPages.Checked;
                bool showHeaderOnEvenPages = ChkHeaderEvenPages.Checked;

                int headerHeight = 50;
                try
                {
                    headerHeight = Convert.ToInt32(TxtHeaderHeight.Text);
                }
                catch { }


                bool showFooterOnFirstPage = ChkFooterFirstPage.Checked;
                bool showFooterOnOddPages = ChkFooterOddPages.Checked;
                bool showFooterOnEvenPages = ChkFooterEvenPages.Checked;

                int footerHeight = 50;
                try
                {
                    footerHeight = Convert.ToInt32(TxtFooterHeight.Text);
                }
                catch { }

                // instantiate a html to pdf converter object
                HtmlToPdf converter = new HtmlToPdf();

                // header settings
                converter.Options.DisplayHeader = showHeaderOnFirstPage ||
                    showHeaderOnOddPages || showHeaderOnEvenPages;
                converter.Header.DisplayOnFirstPage = showHeaderOnFirstPage;
                converter.Header.DisplayOnOddPages = showHeaderOnOddPages;
                converter.Header.DisplayOnEvenPages = showHeaderOnEvenPages;
                converter.Header.Height = headerHeight;

                PdfHtmlSection headerHtml = new PdfHtmlSection(Path.GetFullPath(headerUrl));
                headerHtml.AutoFitHeight = HtmlToPdfPageFitMode.AutoFit;
                converter.Header.Add(headerHtml);

                // footer settings
                converter.Options.DisplayFooter = showFooterOnFirstPage ||
                    showFooterOnOddPages || showFooterOnEvenPages;
                converter.Footer.DisplayOnFirstPage = showFooterOnFirstPage;
                converter.Footer.DisplayOnOddPages = showFooterOnOddPages;
                converter.Footer.DisplayOnEvenPages = showFooterOnEvenPages;
                converter.Footer.Height = footerHeight;

                PdfHtmlSection footerHtml = new PdfHtmlSection(Path.GetFullPath(footerUrl));
                footerHtml.AutoFitHeight = HtmlToPdfPageFitMode.AutoFit;
                converter.Footer.Add(footerHtml);

                // add page numbering element to the footer
                if (ChkPageNumbering.Checked)
                {
                    // page numbers can be added using a PdfTextSection object
                    PdfTextSection text = new PdfTextSection(0, 10,
                        "Page: {page_number} of {total_pages}  ",
                        new System.Drawing.Font("Arial", 8));
                    text.HorizontalAlign = PdfTextHorizontalAlign.Right;
                    converter.Footer.Add(text);
                }

                // create a new pdf document converting an url
                PdfDocument doc = converter.ConvertUrl(TxtUrl.Text);

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

        public HtmlToPdfHeadersAndFooters()
        {
            InitializeComponent();

            try
            {
                // display highlighted sample code
                string code = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory +
                    "/../../" + "HtmlToPdfHeadersAndFooters.cs");
                WBSampleCode.DocumentText = new CodeColorizer().Colorize(code, Languages.CSharp);
            }
            catch
            {
                WBSampleCode.DocumentText = "Sample code not available";
            }
        }

        private void LblSampleHeader_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Path.GetFullPath(headerUrl));
        }

        private void LblSampleFooter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Path.GetFullPath(footerUrl));
        }

    }
}
