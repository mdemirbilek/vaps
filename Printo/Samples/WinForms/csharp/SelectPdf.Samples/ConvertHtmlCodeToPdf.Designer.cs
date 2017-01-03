namespace SelectPdf.Samples
{
    partial class ConvertHtmlCodeToPdf
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
            this.LblHeight2 = new System.Windows.Forms.Label();
            this.TxtHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtWidth = new System.Windows.Forms.TextBox();
            this.LblPageWidth = new System.Windows.Forms.Label();
            this.DdlPageOrientation = new System.Windows.Forms.ComboBox();
            this.LblPageOrientation = new System.Windows.Forms.Label();
            this.DdlPageSize = new System.Windows.Forms.ComboBox();
            this.LblPageSize = new System.Windows.Forms.Label();
            this.TxtBaseUrl = new System.Windows.Forms.TextBox();
            this.LblBaseUrl = new System.Windows.Forms.Label();
            this.LblSampleCode = new System.Windows.Forms.Label();
            this.WBSampleCode = new System.Windows.Forms.WebBrowser();
            this.BtnCreatePdf = new System.Windows.Forms.Button();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblHtmlCode = new System.Windows.Forms.Label();
            this.TxtHtmlCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblHeight2
            // 
            this.LblHeight2.AutoSize = true;
            this.LblHeight2.Location = new System.Drawing.Point(450, 346);
            this.LblHeight2.Name = "LblHeight2";
            this.LblHeight2.Size = new System.Drawing.Size(139, 13);
            this.LblHeight2.TabIndex = 43;
            this.LblHeight2.Text = "(leave empty to auto detect)";
            // 
            // TxtHeight
            // 
            this.TxtHeight.Location = new System.Drawing.Point(450, 321);
            this.TxtHeight.Name = "TxtHeight";
            this.TxtHeight.Size = new System.Drawing.Size(121, 20);
            this.TxtHeight.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Web Page Height:";
            // 
            // TxtWidth
            // 
            this.TxtWidth.Location = new System.Drawing.Point(310, 321);
            this.TxtWidth.Name = "TxtWidth";
            this.TxtWidth.Size = new System.Drawing.Size(121, 20);
            this.TxtWidth.TabIndex = 40;
            this.TxtWidth.Text = "1024";
            // 
            // LblPageWidth
            // 
            this.LblPageWidth.AutoSize = true;
            this.LblPageWidth.Location = new System.Drawing.Point(310, 301);
            this.LblPageWidth.Name = "LblPageWidth";
            this.LblPageWidth.Size = new System.Drawing.Size(92, 13);
            this.LblPageWidth.TabIndex = 39;
            this.LblPageWidth.Text = "Web Page Width:";
            // 
            // DdlPageOrientation
            // 
            this.DdlPageOrientation.FormattingEnabled = true;
            this.DdlPageOrientation.Items.AddRange(new object[] {
            "Portrait",
            "Landscape"});
            this.DdlPageOrientation.Location = new System.Drawing.Point(170, 321);
            this.DdlPageOrientation.Name = "DdlPageOrientation";
            this.DdlPageOrientation.Size = new System.Drawing.Size(121, 21);
            this.DdlPageOrientation.TabIndex = 38;
            // 
            // LblPageOrientation
            // 
            this.LblPageOrientation.AutoSize = true;
            this.LblPageOrientation.Location = new System.Drawing.Point(170, 301);
            this.LblPageOrientation.Name = "LblPageOrientation";
            this.LblPageOrientation.Size = new System.Drawing.Size(108, 13);
            this.LblPageOrientation.TabIndex = 37;
            this.LblPageOrientation.Text = "Pdf Page Orientation:";
            // 
            // DdlPageSize
            // 
            this.DdlPageSize.FormattingEnabled = true;
            this.DdlPageSize.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "Letter",
            "HalfLetter",
            "Ledger",
            "Legal"});
            this.DdlPageSize.Location = new System.Drawing.Point(30, 321);
            this.DdlPageSize.Name = "DdlPageSize";
            this.DdlPageSize.Size = new System.Drawing.Size(121, 21);
            this.DdlPageSize.TabIndex = 36;
            // 
            // LblPageSize
            // 
            this.LblPageSize.AutoSize = true;
            this.LblPageSize.Location = new System.Drawing.Point(30, 301);
            this.LblPageSize.Name = "LblPageSize";
            this.LblPageSize.Size = new System.Drawing.Size(77, 13);
            this.LblPageSize.TabIndex = 35;
            this.LblPageSize.Text = "Pdf Page Size:";
            // 
            // TxtBaseUrl
            // 
            this.TxtBaseUrl.Location = new System.Drawing.Point(30, 266);
            this.TxtBaseUrl.Name = "TxtBaseUrl";
            this.TxtBaseUrl.Size = new System.Drawing.Size(532, 20);
            this.TxtBaseUrl.TabIndex = 34;
            // 
            // LblBaseUrl
            // 
            this.LblBaseUrl.AutoSize = true;
            this.LblBaseUrl.Location = new System.Drawing.Point(30, 246);
            this.LblBaseUrl.Name = "LblBaseUrl";
            this.LblBaseUrl.Size = new System.Drawing.Size(50, 13);
            this.LblBaseUrl.TabIndex = 33;
            this.LblBaseUrl.Text = "Base Url:";
            // 
            // LblSampleCode
            // 
            this.LblSampleCode.AutoSize = true;
            this.LblSampleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSampleCode.Location = new System.Drawing.Point(30, 410);
            this.LblSampleCode.Name = "LblSampleCode";
            this.LblSampleCode.Size = new System.Drawing.Size(114, 15);
            this.LblSampleCode.TabIndex = 32;
            this.LblSampleCode.Text = "Sample Code C#";
            // 
            // WBSampleCode
            // 
            this.WBSampleCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WBSampleCode.Location = new System.Drawing.Point(30, 440);
            this.WBSampleCode.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBSampleCode.Name = "WBSampleCode";
            this.WBSampleCode.Size = new System.Drawing.Size(825, 200);
            this.WBSampleCode.TabIndex = 31;
            // 
            // BtnCreatePdf
            // 
            this.BtnCreatePdf.Location = new System.Drawing.Point(30, 361);
            this.BtnCreatePdf.Name = "BtnCreatePdf";
            this.BtnCreatePdf.Size = new System.Drawing.Size(75, 23);
            this.BtnCreatePdf.TabIndex = 30;
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
            this.LblDescription.Size = new System.Drawing.Size(825, 44);
            this.LblDescription.TabIndex = 29;
            this.LblDescription.Text = "This sample shows how to use Select.Pdf html to pdf converter to convert a raw ht" +
    "ml code to pdf, also setting a few properties. ";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(30, 25);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(384, 17);
            this.LblTitle.TabIndex = 28;
            this.LblTitle.Text = "Select.Pdf for .NET - Convert from Html Code to Pdf";
            // 
            // LblHtmlCode
            // 
            this.LblHtmlCode.AutoSize = true;
            this.LblHtmlCode.Location = new System.Drawing.Point(30, 100);
            this.LblHtmlCode.Name = "LblHtmlCode";
            this.LblHtmlCode.Size = new System.Drawing.Size(59, 13);
            this.LblHtmlCode.TabIndex = 44;
            this.LblHtmlCode.Text = "Html Code:";
            // 
            // TxtHtmlCode
            // 
            this.TxtHtmlCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtHtmlCode.Location = new System.Drawing.Point(30, 120);
            this.TxtHtmlCode.Multiline = true;
            this.TxtHtmlCode.Name = "TxtHtmlCode";
            this.TxtHtmlCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtHtmlCode.Size = new System.Drawing.Size(825, 110);
            this.TxtHtmlCode.TabIndex = 45;
            this.TxtHtmlCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtHtmlCode_KeyDown);
            // 
            // ConvertHtmlCodeToPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.TxtHtmlCode);
            this.Controls.Add(this.LblHtmlCode);
            this.Controls.Add(this.LblHeight2);
            this.Controls.Add(this.TxtHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtWidth);
            this.Controls.Add(this.LblPageWidth);
            this.Controls.Add(this.DdlPageOrientation);
            this.Controls.Add(this.LblPageOrientation);
            this.Controls.Add(this.DdlPageSize);
            this.Controls.Add(this.LblPageSize);
            this.Controls.Add(this.TxtBaseUrl);
            this.Controls.Add(this.LblBaseUrl);
            this.Controls.Add(this.LblSampleCode);
            this.Controls.Add(this.WBSampleCode);
            this.Controls.Add(this.BtnCreatePdf);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblTitle);
            this.Name = "ConvertHtmlCodeToPdf";
            this.Text = "Select.Pdf for .NET - Convert from Html Code to Pdf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHeight2;
        private System.Windows.Forms.TextBox TxtHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtWidth;
        private System.Windows.Forms.Label LblPageWidth;
        private System.Windows.Forms.ComboBox DdlPageOrientation;
        private System.Windows.Forms.Label LblPageOrientation;
        private System.Windows.Forms.ComboBox DdlPageSize;
        private System.Windows.Forms.Label LblPageSize;
        private System.Windows.Forms.TextBox TxtBaseUrl;
        private System.Windows.Forms.Label LblBaseUrl;
        private System.Windows.Forms.Label LblSampleCode;
        private System.Windows.Forms.WebBrowser WBSampleCode;
        private System.Windows.Forms.Button BtnCreatePdf;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblHtmlCode;
        private System.Windows.Forms.TextBox TxtHtmlCode;
    }
}