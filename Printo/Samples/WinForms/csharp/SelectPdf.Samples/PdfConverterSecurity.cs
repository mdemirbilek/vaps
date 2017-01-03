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
    public partial class PdfConverterSecurity : Form
    {
        private void BtnCreatePdf_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string file = "Document.pdf";

            try
            {
                // read parameters from the webpage
                string url = TxtUrl.Text;

                string userPassword = TxtUserPassword.Text.Trim();
                string ownerPassword = TxtOwnerPassword.Text.Trim();

                bool canAssembleDocument = ChkCanAssembleDocument.Checked;
                bool canCopyContent = ChkCanCopyContent.Checked;
                bool canEditAnnotations = ChkCanEditAnnotations.Checked;
                bool canEditContent = ChkCanEditContent.Checked;
                bool canFillFormFields = ChkCanFillFormFields.Checked;
                bool canPrint = ChkCanPrint.Checked;

                // instantiate a html to pdf converter object
                HtmlToPdf converter = new HtmlToPdf();

                // set document passwords
                if (!string.IsNullOrEmpty(userPassword))
                {
                    converter.Options.SecurityOptions.UserPassword = userPassword;
                }
                if (!string.IsNullOrEmpty(ownerPassword))
                {
                    converter.Options.SecurityOptions.OwnerPassword = ownerPassword;
                }

                //set document permissions
                converter.Options.SecurityOptions.CanAssembleDocument = canAssembleDocument;
                converter.Options.SecurityOptions.CanCopyContent = canCopyContent;
                converter.Options.SecurityOptions.CanEditAnnotations = canEditAnnotations;
                converter.Options.SecurityOptions.CanEditContent = canEditContent;
                converter.Options.SecurityOptions.CanFillFormFields = canFillFormFields;
                converter.Options.SecurityOptions.CanPrint = canPrint;

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

        public PdfConverterSecurity()
        {
            InitializeComponent();

            try
            {
                // display highlighted sample code
                string code = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory +
                    "/../../" + "PdfConverterSecurity.cs");
                WBSampleCode.DocumentText = new CodeColorizer().Colorize(code, Languages.CSharp);
            }
            catch
            {
                WBSampleCode.DocumentText = "Sample code not available";
            }
        }

    }
}
