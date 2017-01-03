namespace SelectPdf.Samples
{
    partial class MediaTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaTypes));
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.DdlCssMediaType = new System.Windows.Forms.ComboBox();
            this.LblCssMediaType = new System.Windows.Forms.Label();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.LblUrl = new System.Windows.Forms.Label();
            this.LblSampleCode = new System.Windows.Forms.Label();
            this.WBSampleCode = new System.Windows.Forms.WebBrowser();
            this.BtnCreatePdf = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtDescription
            // 
            this.TxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescription.BackColor = System.Drawing.SystemColors.Control;
            this.TxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescription.Location = new System.Drawing.Point(34, 56);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.ReadOnly = true;
            this.TxtDescription.Size = new System.Drawing.Size(822, 134);
            this.TxtDescription.TabIndex = 100;
            this.TxtDescription.Text = resources.GetString("TxtDescription.Text");
            // 
            // DdlCssMediaType
            // 
            this.DdlCssMediaType.FormattingEnabled = true;
            this.DdlCssMediaType.Items.AddRange(new object[] {
            "Screen",
            "Print"});
            this.DdlCssMediaType.Location = new System.Drawing.Point(34, 292);
            this.DdlCssMediaType.Name = "DdlCssMediaType";
            this.DdlCssMediaType.Size = new System.Drawing.Size(121, 21);
            this.DdlCssMediaType.TabIndex = 99;
            // 
            // LblCssMediaType
            // 
            this.LblCssMediaType.AutoSize = true;
            this.LblCssMediaType.Location = new System.Drawing.Point(34, 273);
            this.LblCssMediaType.Name = "LblCssMediaType";
            this.LblCssMediaType.Size = new System.Drawing.Size(90, 13);
            this.LblCssMediaType.TabIndex = 95;
            this.LblCssMediaType.Text = "CSS Media Type:";
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(34, 233);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(532, 20);
            this.TxtUrl.TabIndex = 94;
            this.TxtUrl.Text = "http://selectpdf.com";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(34, 213);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(23, 13);
            this.LblUrl.TabIndex = 93;
            this.LblUrl.Text = "Url:";
            // 
            // LblSampleCode
            // 
            this.LblSampleCode.AutoSize = true;
            this.LblSampleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSampleCode.Location = new System.Drawing.Point(28, 408);
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
            this.WBSampleCode.Location = new System.Drawing.Point(31, 438);
            this.WBSampleCode.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBSampleCode.Name = "WBSampleCode";
            this.WBSampleCode.Size = new System.Drawing.Size(825, 200);
            this.WBSampleCode.TabIndex = 91;
            // 
            // BtnCreatePdf
            // 
            this.BtnCreatePdf.Location = new System.Drawing.Point(34, 339);
            this.BtnCreatePdf.Name = "BtnCreatePdf";
            this.BtnCreatePdf.Size = new System.Drawing.Size(75, 23);
            this.BtnCreatePdf.TabIndex = 90;
            this.BtnCreatePdf.Text = "Create PDF";
            this.BtnCreatePdf.UseVisualStyleBackColor = true;
            this.BtnCreatePdf.Click += new System.EventHandler(this.BtnCreatePdf_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(31, 23);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(478, 17);
            this.LblTitle.TabIndex = 89;
            this.LblTitle.Text = "Select.Pdf for .NET - Use media types with Html to Pdf Converter";
            // 
            // MediaTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.DdlCssMediaType);
            this.Controls.Add(this.LblCssMediaType);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.LblSampleCode);
            this.Controls.Add(this.WBSampleCode);
            this.Controls.Add(this.BtnCreatePdf);
            this.Controls.Add(this.LblTitle);
            this.Name = "MediaTypes";
            this.Text = "Select.Pdf for .NET - Use media types with Html to Pdf Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.ComboBox DdlCssMediaType;
        private System.Windows.Forms.Label LblCssMediaType;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.Label LblSampleCode;
        private System.Windows.Forms.WebBrowser WBSampleCode;
        private System.Windows.Forms.Button BtnCreatePdf;
        private System.Windows.Forms.Label LblTitle;

    }
}