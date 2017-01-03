namespace SelectPdf.Samples
{
    partial class AutomaticBookmarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomaticBookmarks));
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.LblUrl = new System.Windows.Forms.Label();
            this.LblSampleCode = new System.Windows.Forms.Label();
            this.WBSampleCode = new System.Windows.Forms.WebBrowser();
            this.BtnCreatePdf = new System.Windows.Forms.Button();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtElements = new System.Windows.Forms.TextBox();
            this.LblBookmarks = new System.Windows.Forms.Label();
            this.LblTestFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(30, 200);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(532, 20);
            this.TxtUrl.TabIndex = 18;
            this.TxtUrl.Text = "http://selectpdf.com";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(30, 180);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(23, 13);
            this.LblUrl.TabIndex = 17;
            this.LblUrl.Text = "Url:";
            // 
            // LblSampleCode
            // 
            this.LblSampleCode.AutoSize = true;
            this.LblSampleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSampleCode.Location = new System.Drawing.Point(27, 350);
            this.LblSampleCode.Name = "LblSampleCode";
            this.LblSampleCode.Size = new System.Drawing.Size(114, 15);
            this.LblSampleCode.TabIndex = 16;
            this.LblSampleCode.Text = "Sample Code C#";
            // 
            // WBSampleCode
            // 
            this.WBSampleCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WBSampleCode.Location = new System.Drawing.Point(30, 380);
            this.WBSampleCode.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBSampleCode.Name = "WBSampleCode";
            this.WBSampleCode.Size = new System.Drawing.Size(825, 250);
            this.WBSampleCode.TabIndex = 15;
            // 
            // BtnCreatePdf
            // 
            this.BtnCreatePdf.Location = new System.Drawing.Point(30, 300);
            this.BtnCreatePdf.Name = "BtnCreatePdf";
            this.BtnCreatePdf.Size = new System.Drawing.Size(75, 23);
            this.BtnCreatePdf.TabIndex = 14;
            this.BtnCreatePdf.Text = "Create PDF";
            this.BtnCreatePdf.UseVisualStyleBackColor = true;
            this.BtnCreatePdf.Click += new System.EventHandler(this.BtnCreatePdf_Click);
            // 
            // LblDescription
            // 
            this.LblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(30, 55);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(825, 122);
            this.LblDescription.TabIndex = 13;
            this.LblDescription.Text = resources.GetString("LblDescription.Text");
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(30, 25);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(513, 17);
            this.LblTitle.TabIndex = 12;
            this.LblTitle.Text = "Select.Pdf for .NET - Automatic Bookmarks with Html to Pdf Converter";
            // 
            // TxtElements
            // 
            this.TxtElements.Location = new System.Drawing.Point(30, 255);
            this.TxtElements.Name = "TxtElements";
            this.TxtElements.Size = new System.Drawing.Size(532, 20);
            this.TxtElements.TabIndex = 20;
            this.TxtElements.Text = "H1, H2";
            // 
            // LblBookmarks
            // 
            this.LblBookmarks.AutoSize = true;
            this.LblBookmarks.Location = new System.Drawing.Point(30, 235);
            this.LblBookmarks.Name = "LblBookmarks";
            this.LblBookmarks.Size = new System.Drawing.Size(165, 13);
            this.LblBookmarks.TabIndex = 19;
            this.LblBookmarks.Text = "Bookmark the following elements:";
            // 
            // LblTestFile
            // 
            this.LblTestFile.AutoSize = true;
            this.LblTestFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblTestFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestFile.Location = new System.Drawing.Point(580, 201);
            this.LblTestFile.Name = "LblTestFile";
            this.LblTestFile.Size = new System.Drawing.Size(88, 15);
            this.LblTestFile.TabIndex = 87;
            this.LblTestFile.Text = "Test document";
            this.LblTestFile.Click += new System.EventHandler(this.LblTestFile_Click);
            // 
            // AutomaticBookmarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.LblTestFile);
            this.Controls.Add(this.TxtElements);
            this.Controls.Add(this.LblBookmarks);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.LblSampleCode);
            this.Controls.Add(this.WBSampleCode);
            this.Controls.Add(this.BtnCreatePdf);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblTitle);
            this.Name = "AutomaticBookmarks";
            this.Text = "Select.Pdf for .NET - Automatic Bookmarks with Html to Pdf Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.Label LblSampleCode;
        private System.Windows.Forms.WebBrowser WBSampleCode;
        private System.Windows.Forms.Button BtnCreatePdf;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtElements;
        private System.Windows.Forms.Label LblBookmarks;
        private System.Windows.Forms.Label LblTestFile;
    }
}