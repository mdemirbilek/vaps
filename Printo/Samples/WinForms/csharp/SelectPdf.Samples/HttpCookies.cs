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
    public partial class HttpCookies : Form
    {
        string url = "http://selectpdf.com/demo/view-http-cookies.aspx";

        private void BtnCreatePdf_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string file = "Document.pdf";

            try
            {
                // instantiate a html to pdf converter object
                HtmlToPdf converter = new HtmlToPdf();

                // set the HTTP cookies
                converter.Options.HttpCookies.Add(TxtName1.Text, TxtValue1.Text);
                converter.Options.HttpCookies.Add(TxtName2.Text, TxtValue2.Text);
                converter.Options.HttpCookies.Add(TxtName3.Text, TxtValue3.Text);
                converter.Options.HttpCookies.Add(TxtName4.Text, TxtValue4.Text);

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

        public HttpCookies()
        {
            InitializeComponent();

            TxtUrl.Text = url;

            try
            {
                // display highlighted sample code
                string code = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory +
                    "/../../" + "HttpCookies.cs");
                WBSampleCode.DocumentText = new CodeColorizer().Colorize(code, Languages.CSharp);
            }
            catch
            {
                WBSampleCode.DocumentText = "Sample code not available";
            }
        }

        private void LblTestPage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(url);
        }
    }
}
