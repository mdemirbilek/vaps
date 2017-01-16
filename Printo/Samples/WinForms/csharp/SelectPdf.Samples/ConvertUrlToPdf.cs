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
using System.Net.Mail;

namespace SelectPdf.Samples
{
    public partial class ConvertUrlToPdf : Form
    {
        private void BtnCreatePdf_Click(object sender, EventArgs e)
        {
            Process("makefile");
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            Process("sendemail");
        }

        private void Process(string action)
        {
            Cursor = Cursors.WaitCursor;
            int year = 0;
            int month = 0;
            try
            {
                year = int.Parse(txtYear.Text.Trim());
                month = int.Parse(txtMonth.Text.Trim());
            }
            catch (Exception)
            {
                year = 0;
                month = 0;
            }

            if (year == 0 || month == 0)
            {
                MessageBox.Show("Parametreler Yamuk!");
                Cursor = Cursors.Arrow;
            }
            else
            {
                VERPSEntities db = new VERPSEntities();
                var list = db.vwWHheaders.Where(x => x.RecYear == year && x.RecMonth == month).ToList();

                if (action == "makefile")
                {
                    foreach (var item in list)
                    {
                        vwWHheader header = (vwWHheader)item;
                        MakeFile(@"WH_" + item.FullName.Trim() + "_" + year.ToString() + "_" + month.ToString() + ".pdf", TxtUrl.Text.Trim() + item.Id.ToString());
                    }
                    MessageBox.Show("Yeah!");
                    Cursor = Cursors.Arrow;
                }
                else if (action == "sendemail")
                {
                    if (txtEmailSubject.Text.Trim() != "" && txtEmailText.Text.Trim() != "")
                    {
                        foreach (var item in list)
                        {
                            vwWHheader header = (vwWHheader)item;
                            string file = @"WH_" + item.FullName.Trim() + "_" + year.ToString() + "_" + month.ToString() + ".pdf";

                            //if (item.EmailAddress == "m.demirbilek@vistula.edu.pl")
                            //{
                            //    SendEmail(item.EmailAddress, file);
                            //}

                            SendEmail(item.EmailAddress, file);
                        }
                        MessageBox.Show("Yeah!");
                        Cursor = Cursors.Arrow;
                    }
                    else
                    {
                        MessageBox.Show("Please enter email subject and text!");
                        Cursor = Cursors.Arrow;
                    }
                }
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

                file = txtDocFolder.Text.Trim() + file;
                //file = @"D:\WHPrinto\" + file;  // folder location

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

        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {

            int i = 0;
            //throw new NotImplementedException();
        }

        private void SendEmail(string toEmail, string file)
        {
            file = txtDocFolder.Text.Trim() + file;
            string email = Properties.Settings.Default.e;
            string pass = Properties.Settings.Default.p;
            SmtpClient client = new SmtpClient("smtp.office365.com", 587);
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential(email, pass);
            MailAddress from = new MailAddress(email, String.Empty, System.Text.Encoding.UTF8);
            MailAddress to = new MailAddress(toEmail);
            MailMessage message = new MailMessage(from, to);
            message.Body = txtEmailText.Text.Trim();
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.Subject = txtEmailSubject.Text.Trim();
            message.SubjectEncoding = System.Text.Encoding.UTF8;

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(file);
            message.Attachments.Add(attachment);


            // Set the method that is called back when the send operation ends.
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            // The userState can be any object that allows your callback 
            // method to identify this send operation.
            // For this example, I am passing the message itself
            client.SendAsync(message, message);
        }

    }
}
