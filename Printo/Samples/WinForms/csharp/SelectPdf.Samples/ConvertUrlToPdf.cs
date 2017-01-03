﻿using System;
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
    public partial class ConvertUrlToPdf : Form
    {
        private void BtnCreatePdf_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            VERPSEntities db = new VERPSEntities();

            var list = db.vwWHheaders.Where(x => x.RecYear == 2016 && x.RecMonth == 12).ToList();





            string txt = TxtUrl.Text;
            string[] lst = txt.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string url in lst)
            {
                MakeFile(@"Doc" + DateTime.Now.Millisecond.ToString() + ".pdf", url);
            }
        }

        private void MakeFile(string file, string url)
        {

            try
            {
                //// read parameters from the form
                //string url = TxtUrl.Text;

                string pdf_page_size = DdlPageSize.SelectedItem.ToString();
                PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                    pdf_page_size, true);

                string pdf_orientation = DdlPageOrientation.SelectedItem.ToString();
                PdfPageOrientation pdfOrientation =
                    (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                    pdf_orientation, true);

                int webPageWidth = 1024;
                try
                {
                    webPageWidth = Convert.ToInt32(TxtWidth.Text);
                }
                catch { }

                int webPageHeight = 0;
                try
                {
                    webPageHeight = Convert.ToInt32(TxtHeight.Text);
                }
                catch { }

                // instantiate a html to pdf converter object
                HtmlToPdf converter = new HtmlToPdf();

                // set converter options
                converter.Options.PdfPageSize = pageSize;
                converter.Options.PdfPageOrientation = pdfOrientation;
                converter.Options.WebPageWidth = webPageWidth;
                converter.Options.WebPageHeight = webPageHeight;

                // create a new pdf document converting an url
                PdfDocument doc = converter.ConvertUrl(url);

                // save pdf document

                file = @"D:\WHPrinto\" + file;  // folder location

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

        public ConvertUrlToPdf()
        {
            InitializeComponent();

            // initial values
            DdlPageSize.SelectedIndex = DdlPageSize.Items.IndexOf("A4");
            DdlPageOrientation.SelectedIndex = DdlPageOrientation.Items.IndexOf("Portrait");

            try
            {
                // display highlighted sample code
                string code = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory +
                    "/../../" + "ConvertUrlToPdf.cs");
                WBSampleCode.DocumentText = new CodeColorizer().Colorize(code, Languages.CSharp);
            }
            catch
            {
                WBSampleCode.DocumentText = "Sample code not available";
            }
        }

    }
}