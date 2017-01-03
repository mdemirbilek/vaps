using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SelectPdf.Samples
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = menuStrip.BackColor;
                    break;
                }
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://selectpdf.com/pdf-library-for-net/");
        }

        private void visitSelectPdf_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://selectpdf.com");
        }

        private void gettingStartedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HtmlToPdfConverter form = new HtmlToPdfConverter();
            form.MdiParent = this;
            form.Show();
        }

        private void convertUrlToPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertUrlToPdf form = new ConvertUrlToPdf();
            form.MdiParent = this;
            form.Show();
        }

        private void convertHtmlCodeToPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertHtmlCodeToPdf form = new ConvertHtmlCodeToPdf();
            form.MdiParent = this;
            form.Show();
        }

        private void pdfDocumentPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfConverterProperties form = new PdfConverterProperties();
            form.MdiParent = this;
            form.Show();
        }

        private void pdfViewerPreferencesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PdfConverterViewerPreferences form = new PdfConverterViewerPreferences();
            form.MdiParent = this;
            form.Show();
        }

        private void pdfSecuritySettingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PdfConverterSecurity form = new PdfConverterSecurity();
            form.MdiParent = this;
            form.Show();
        }

        private void conversionDelayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConversionDelay form = new ConversionDelay();
            form.MdiParent = this;
            form.Show();
        }

        private void headersAndFootersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HtmlToPdfHeadersAndFooters form = new HtmlToPdfHeadersAndFooters();
            form.MdiParent = this;
            form.Show();
        }

        private void pageBreaksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageBreaks form = new PageBreaks();
            form.MdiParent = this;
            form.Show();
        }

        private void automaticBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutomaticBookmarks form = new AutomaticBookmarks();
            form.MdiParent = this;
            form.Show();
        }

        private void hTTPHeadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HttpHeaders form = new HttpHeaders();
            form.MdiParent = this;
            form.Show();
        }

        private void hTTPCookiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HttpCookies form = new HttpCookies();
            form.MdiParent = this;
            form.Show();
        }

        private void mediaTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediaTypes form = new MediaTypes();
            form.MdiParent = this;
            form.Show();
        }

        private void internalAndExternalLinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HtmlToPdfConverterLinks form = new HtmlToPdfConverterLinks();
            form.MdiParent = this;
            form.Show();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://selectpdf.com/html-to-pdf/docs/");
        }

        private void pringWHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertUrlToPdf form = new ConvertUrlToPdf();
            form.MdiParent = this;
            form.Show();
        }
    }
}
