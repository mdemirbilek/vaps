namespace SelectPdf.Samples
{
    partial class HtmlToPdfConverterLinks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HtmlToPdfConverterLinks));
            this.LblTestFile = new System.Windows.Forms.Label();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.LblUrl = new System.Windows.Forms.Label();
            this.LblSampleCode = new System.Windows.Forms.Label();
            this.WBSampleCode = new System.Windows.Forms.WebBrowser();
            this.BtnCreatePdf = new System.Windows.Forms.Button();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.ChkInternalLinks = new System.Windows.Forms.CheckBox();
            this.ChkExternalLinks = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblTestFile
            // 
            this.LblTestFile.AutoSize = true;
            this.LblTestFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblTestFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestFile.Location = new System.Drawing.Point(581, 204);
            this.LblTestFile.Name = "LblTestFile";
            this.LblTestFile.Size = new System.Drawing.Size(88, 15);
            this.LblTestFile.TabIndex = 97;
            this.LblTestFile.Text = "Test document";
            this.LblTestFile.Click += new System.EventHandler(this.LblTestFile_Click);
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(31, 203);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(532, 20);
            this.TxtUrl.TabIndex = 94;
            this.TxtUrl.Text = "http://selectpdf.com";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(31, 183);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(23, 13);
            this.LblUrl.TabIndex = 93;
            this.LblUrl.Text = "Url:";
            // 
            // LblSampleCode
            // 
            this.LblSampleCode.AutoSize = true;
            this.LblSampleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSampleCode.Location = new System.Drawing.Point(28, 472);
            this.LblSampleCode.Name = "LblSampleCode";
            this.LblSampleCode.Size = new System.Drawing.Size(114, 15);
            this.LblSampleCode.TabIndex = 92;
            this.LblSampleCode.Text = "Sample Code C#";
            // 
            // WBSampleCode
            // 
            this.WBSampleCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WBSampleCode.Location = new System.Drawing.Point(31, 504);
            this.WBSampleCode.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBSampleCode.Name = "WBSampleCode";
            this.WBSampleCode.Size = new System.Drawing.Size(825, 129);
            this.WBSampleCode.TabIndex = 91;
            // 
            // BtnCreatePdf
            // 
            this.BtnCreatePdf.Location = new System.Drawing.Point(31, 303);
            this.BtnCreatePdf.Name = "BtnCreatePdf";
            this.BtnCreatePdf.Size = new System.Drawing.Size(75, 23);
            this.BtnCreatePdf.TabIndex = 90;
            this.BtnCreatePdf.Text = "Create PDF";
            this.BtnCreatePdf.UseVisualStyleBackColor = true;
            this.BtnCreatePdf.Click += new System.EventHandler(this.BtnCreatePdf_Click);
            // 
            // LblDescription
            // 
            this.LblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(31, 58);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(825, 122);
            this.LblDescription.TabIndex = 89;
            this.LblDescription.Text = resources.GetString("LblDescription.Text");
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(31, 28);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(559, 17);
            this.LblTitle.TabIndex = 88;
            this.LblTitle.Text = "Select.Pdf for .NET - Pdf Internal and External Links - Html to Pdf Converter";
            // 
            // ChkInternalLinks
            // 
            this.ChkInternalLinks.AutoSize = true;
            this.ChkInternalLinks.Checked = true;
            this.ChkInternalLinks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkInternalLinks.Location = new System.Drawing.Point(31, 241);
            this.ChkInternalLinks.Name = "ChkInternalLinks";
            this.ChkInternalLinks.Size = new System.Drawing.Size(146, 17);
            this.ChkInternalLinks.TabIndex = 98;
            this.ChkInternalLinks.Text = "Convert with internal links";
            this.ChkInternalLinks.UseVisualStyleBackColor = true;
            // 
            // ChkExternalLinks
            // 
            this.ChkExternalLinks.AutoSize = true;
            this.ChkExternalLinks.Checked = true;
            this.ChkExternalLinks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkExternalLinks.Location = new System.Drawing.Point(31, 264);
            this.ChkExternalLinks.Name = "ChkExternalLinks";
            this.ChkExternalLinks.Size = new System.Drawing.Size(149, 17);
            this.ChkExternalLinks.TabIndex = 99;
            this.ChkExternalLinks.Text = "Convert with external links";
            this.ChkExternalLinks.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 348);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(532, 111);
            this.textBox1.TabIndex = 100;
            // 
            // HtmlToPdfConverterLinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ChkExternalLinks);
            this.Controls.Add(this.ChkInternalLinks);
            this.Controls.Add(this.LblTestFile);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.LblSampleCode);
            this.Controls.Add(this.WBSampleCode);
            this.Controls.Add(this.BtnCreatePdf);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblTitle);
            this.Name = "HtmlToPdfConverterLinks";
            this.Text = "Select.Pdf for .NET - Pdf Internal and External Links - Html to Pdf Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTestFile;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.Label LblSampleCode;
        private System.Windows.Forms.WebBrowser WBSampleCode;
        private System.Windows.Forms.Button BtnCreatePdf;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.CheckBox ChkInternalLinks;
        private System.Windows.Forms.CheckBox ChkExternalLinks;
        private System.Windows.Forms.TextBox textBox1;
    }
}