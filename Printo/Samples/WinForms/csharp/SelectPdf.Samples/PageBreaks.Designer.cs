namespace SelectPdf.Samples
{
    partial class PageBreaks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageBreaks));
            this.TxtHtmlCode = new System.Windows.Forms.TextBox();
            this.LblHtmlCode = new System.Windows.Forms.Label();
            this.TxtBaseUrl = new System.Windows.Forms.TextBox();
            this.LblBaseUrl = new System.Windows.Forms.Label();
            this.LblSampleCode = new System.Windows.Forms.Label();
            this.WBSampleCode = new System.Windows.Forms.WebBrowser();
            this.BtnCreatePdf = new System.Windows.Forms.Button();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtHtmlCode
            // 
            this.TxtHtmlCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtHtmlCode.Location = new System.Drawing.Point(30, 245);
            this.TxtHtmlCode.Multiline = true;
            this.TxtHtmlCode.Name = "TxtHtmlCode";
            this.TxtHtmlCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtHtmlCode.Size = new System.Drawing.Size(825, 110);
            this.TxtHtmlCode.TabIndex = 63;
            this.TxtHtmlCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtHtmlCode_KeyDown);
            // 
            // LblHtmlCode
            // 
            this.LblHtmlCode.AutoSize = true;
            this.LblHtmlCode.Location = new System.Drawing.Point(30, 225);
            this.LblHtmlCode.Name = "LblHtmlCode";
            this.LblHtmlCode.Size = new System.Drawing.Size(59, 13);
            this.LblHtmlCode.TabIndex = 62;
            this.LblHtmlCode.Text = "Html Code:";
            // 
            // TxtBaseUrl
            // 
            this.TxtBaseUrl.Location = new System.Drawing.Point(90, 367);
            this.TxtBaseUrl.Name = "TxtBaseUrl";
            this.TxtBaseUrl.Size = new System.Drawing.Size(532, 20);
            this.TxtBaseUrl.TabIndex = 52;
            // 
            // LblBaseUrl
            // 
            this.LblBaseUrl.AutoSize = true;
            this.LblBaseUrl.Location = new System.Drawing.Point(30, 370);
            this.LblBaseUrl.Name = "LblBaseUrl";
            this.LblBaseUrl.Size = new System.Drawing.Size(50, 13);
            this.LblBaseUrl.TabIndex = 51;
            this.LblBaseUrl.Text = "Base Url:";
            // 
            // LblSampleCode
            // 
            this.LblSampleCode.AutoSize = true;
            this.LblSampleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSampleCode.Location = new System.Drawing.Point(30, 408);
            this.LblSampleCode.Name = "LblSampleCode";
            this.LblSampleCode.Size = new System.Drawing.Size(114, 15);
            this.LblSampleCode.TabIndex = 50;
            this.LblSampleCode.Text = "Sample Code C#";
            // 
            // WBSampleCode
            // 
            this.WBSampleCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WBSampleCode.Location = new System.Drawing.Point(30, 438);
            this.WBSampleCode.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBSampleCode.Name = "WBSampleCode";
            this.WBSampleCode.Size = new System.Drawing.Size(825, 200);
            this.WBSampleCode.TabIndex = 49;
            // 
            // BtnCreatePdf
            // 
            this.BtnCreatePdf.Location = new System.Drawing.Point(650, 365);
            this.BtnCreatePdf.Name = "BtnCreatePdf";
            this.BtnCreatePdf.Size = new System.Drawing.Size(75, 23);
            this.BtnCreatePdf.TabIndex = 48;
            this.BtnCreatePdf.Text = "Create PDF";
            this.BtnCreatePdf.UseVisualStyleBackColor = true;
            this.BtnCreatePdf.Click += new System.EventHandler(this.BtnCreatePdf_Click);
            // 
            // LblDescription
            // 
            this.LblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(30, 53);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(825, 168);
            this.LblDescription.TabIndex = 47;
            this.LblDescription.Text = resources.GetString("LblDescription.Text");
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(30, 23);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(507, 17);
            this.LblTitle.TabIndex = 46;
            this.LblTitle.Text = "Select.Pdf for .NET - Control Page Breaks with Html to Pdf Converter";
            // 
            // PageBreaks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.TxtHtmlCode);
            this.Controls.Add(this.LblHtmlCode);
            this.Controls.Add(this.TxtBaseUrl);
            this.Controls.Add(this.LblBaseUrl);
            this.Controls.Add(this.LblSampleCode);
            this.Controls.Add(this.WBSampleCode);
            this.Controls.Add(this.BtnCreatePdf);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblTitle);
            this.Name = "PageBreaks";
            this.Text = "Select.Pdf for .NET - Control Page Breaks with Html to Pdf Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHtmlCode;
        private System.Windows.Forms.Label LblHtmlCode;
        private System.Windows.Forms.TextBox TxtBaseUrl;
        private System.Windows.Forms.Label LblBaseUrl;
        private System.Windows.Forms.Label LblSampleCode;
        private System.Windows.Forms.WebBrowser WBSampleCode;
        private System.Windows.Forms.Button BtnCreatePdf;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblTitle;
    }
}