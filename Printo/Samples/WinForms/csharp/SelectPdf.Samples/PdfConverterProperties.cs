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
    public partial class PdfConverterProperties : Form
    {
        private void BtnCreatePdf_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string file = "Document.pdf";

            try
            {
                // instantiate a html to pdf converter object
                HtmlToPdf converter = new HtmlToPdf();

                // create a new pdf document converting an url
                PdfDocument doc = converter.ConvertUrl(TxtUrl.Text);

                // get conversion result (contains document info from the web page)
                HtmlToPdfResult result = converter.ConversionResult;

                // set the document properties
                doc.DocumentInformation.Title = result.WebPageInformation.Title;
                doc.DocumentInformation.Subject = result.WebPageInformation.Description;
                doc.DocumentInformation.Keywords = result.WebPageInformation.Keywords;

                doc.DocumentInformation.Author = "Select.Pdf Samples";
                doc.DocumentInformation.CreationDate = DateTime.Now;

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

        public PdfConverterProperties()
        {
            InitializeComponent();

            try
            {
                // display highlighted sample code
                string code = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory +
                    "/../../" + "PdfConverterProperties.cs");
                WBSampleCode.DocumentText = new CodeColorizer().Colorize(code, Languages.CSharp);
            }
            catch
            {
                WBSampleCode.DocumentText = "Sample code not available";
            }
        }

    }
}