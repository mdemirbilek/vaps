namespace SelectPdf.Samples
{
    partial class HttpHeaders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HttpHeaders));
            this.LblTestPage = new System.Windows.Forms.Label();
            this.TxtName1 = new System.Windows.Forms.TextBox();
            this.LblHeaders = new System.Windows.Forms.Label();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.LblUrl = new System.Windows.Forms.Label();
            this.LblSampleCode = new System.Windows.Forms.Label();
            this.WBSampleCode = new System.Windows.Forms.WebBrowser();
            this.BtnCreatePdf = new System.Windows.Forms.Button();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblName1 = new System.Windows.Forms.Label();
            this.LblValue1 = new System.Windows.Forms.Label();
            this.TxtValue1 = new System.Windows.Forms.TextBox();
            this.LblValue2 = new System.Windows.Forms.Label();
            this.TxtValue2 = new System.Windows.Forms.TextBox();
            this.LblName2 = new System.Windows.Forms.Label();
            this.TxtName2 = new System.Windows.Forms.TextBox();
            this.LblValue3 = new System.Windows.Forms.Label();
            this.TxtValue3 = new System.Windows.Forms.TextBox();
            this.LblName3 = new System.Windows.Forms.Label();
            this.TxtName3 = new System.Windows.Forms.TextBox();
            this.LblValue4 = new System.Windows.Forms.Label();
            this.TxtValue4 = new System.Windows.Forms.TextBox();
            this.LblName4 = new System.Windows.Forms.Label();
            this.TxtName4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblTestPage
            // 
            this.LblTestPage.AutoSize = true;
            this.LblTestPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblTestPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestPage.Location = new System.Drawing.Point(581, 204);
            this.LblTestPage.Name = "LblTestPage";
            this.LblTestPage.Size = new System.Drawing.Size(61, 15);
            this.LblTestPage.TabIndex = 97;
            this.LblTestPage.Text = "Test page";
            this.LblTestPage.Click += new System.EventHandler(this.LblTestFile_Click);
            // 
            // TxtName1
            // 
            this.TxtName1.Location = new System.Drawing.Point(75, 265);
            this.TxtName1.Name = "TxtName1";
            this.TxtName1.Size = new System.Drawing.Size(135, 20);
            this.TxtName1.TabIndex = 96;
            this.TxtName1.Text = "Name1";
            // 
            // LblHeaders
            // 
            this.LblHeaders.AutoSize = true;
            this.LblHeaders.Location = new System.Drawing.Point(30, 240);
            this.LblHeaders.Name = "LblHeaders";
            this.LblHeaders.Size = new System.Drawing.Size(82, 13);
            this.LblHeaders.TabIndex = 95;
            this.LblHeaders.Text = "HTTP Headers:";
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(30, 205);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(532, 20);
            this.TxtUrl.TabIndex = 94;
            this.TxtUrl.Text = "http://selectpdf.com/demo/view-http-headers.aspx";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(30, 185);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(23, 13);
            this.LblUrl.TabIndex = 93;
            this.LblUrl.Text = "Url:";
            // 
            // LblSampleCode
            // 
            this.LblSampleCode.AutoSize = true;
            this.LblSampleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSampleCode.Location = new System.Drawing.Point(30, 405);
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
            this.WBSampleCode.Location = new System.Drawing.Point(30, 430);
            this.WBSampleCode.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBSampleCode.Name = "WBSampleCode";
            this.WBSampleCode.Size = new System.Drawing.Size(825, 200);
            this.WBSampleCode.TabIndex = 91;
            // 
            // BtnCreatePdf
            // 
            this.BtnCreatePdf.Location = new System.Drawing.Point(594, 340);
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
            this.LblTitle.Size = new System.Drawing.Size(529, 17);
            this.LblTitle.TabIndex = 88;
            this.LblTitle.Text = "Select.Pdf for .NET - Sending HTTP Headers with Html to Pdf Converter";
            // 
            // LblName1
            // 
            this.LblName1.AutoSize = true;
            this.LblName1.Location = new System.Drawing.Point(31, 268);
            this.LblName1.Name = "LblName1";
            this.LblName1.Size = new System.Drawing.Size(38, 13);
            this.LblName1.TabIndex = 98;
            this.LblName1.Text = "Name:";
            // 
            // LblValue1
            // 
            this.LblValue1.AutoSize = true;
            this.LblValue1.Location = new System.Drawing.Point(232, 268);
            this.LblValue1.Name = "LblValue1";
            this.LblValue1.Size = new System.Drawing.Size(37, 13);
            this.LblValue1.TabIndex = 100;
            this.LblValue1.Text = "Value:";
            // 
            // TxtValue1
            // 
            this.TxtValue1.Location = new System.Drawing.Point(276, 265);
            this.TxtValue1.Name = "TxtValue1";
            this.TxtValue1.Size = new System.Drawing.Size(135, 20);
            this.TxtValue1.TabIndex = 99;
            this.TxtValue1.Text = "Value1";
            // 
            // LblValue2
            // 
            this.LblValue2.AutoSize = true;
            this.LblValue2.Location = new System.Drawing.Point(232, 294);
            this.LblValue2.Name = "LblValue2";
            this.LblValue2.Size = new System.Drawing.Size(37, 13);
            this.LblValue2.TabIndex = 104;
            this.LblValue2.Text = "Value:";
            // 
            // TxtValue2
            // 
            this.TxtValue2.Location = new System.Drawing.Point(276, 291);
            this.TxtValue2.Name = "TxtValue2";
            this.TxtValue2.Size = new System.Drawing.Size(135, 20);
            this.TxtValue2.TabIndex = 103;
            this.TxtValue2.Text = "Value2";
            // 
            // LblName2
            // 
            this.LblName2.AutoSize = true;
            this.LblName2.Location = new System.Drawing.Point(31, 294);
            this.LblName2.Name = "LblName2";
            this.LblName2.Size = new System.Drawing.Size(38, 13);
            this.LblName2.TabIndex = 102;
            this.LblName2.Text = "Name:";
            // 
            // TxtName2
            // 
            this.TxtName2.Location = new System.Drawing.Point(75, 291);
            this.TxtName2.Name = "TxtName2";
            this.TxtName2.Size = new System.Drawing.Size(135, 20);
            this.TxtName2.TabIndex = 101;
            this.TxtName2.Text = "Name2";
            // 
            // LblValue3
            // 
            this.LblValue3.AutoSize = true;
            this.LblValue3.Location = new System.Drawing.Point(232, 320);
            this.LblValue3.Name = "LblValue3";
            this.LblValue3.Size = new System.Drawing.Size(37, 13);
            this.LblValue3.TabIndex = 108;
            this.LblValue3.Text = "Value:";
            // 
            // TxtValue3
            // 
            this.TxtValue3.Location = new System.Drawing.Point(276, 317);
            this.TxtValue3.Name = "TxtValue3";
            this.TxtValue3.Size = new System.Drawing.Size(135, 20);
            this.TxtValue3.TabIndex = 107;
            this.TxtValue3.Text = "Value3";
            // 
            // LblName3
            // 
            this.LblName3.AutoSize = true;
            this.LblName3.Location = new System.Drawing.Point(31, 320);
            this.LblName3.Name = "LblName3";
            this.LblName3.Size = new System.Drawing.Size(38, 13);
            this.LblName3.TabIndex = 106;
            this.LblName3.Text = "Name:";
            // 
            // TxtName3
            // 
            this.TxtName3.Location = new System.Drawing.Point(75, 317);
            this.TxtName3.Name = "TxtName3";
            this.TxtName3.Size = new System.Drawing.Size(135, 20);
            this.TxtName3.TabIndex = 105;
            this.TxtName3.Text = "Name3";
            // 
            // LblValue4
            // 
            this.LblValue4.AutoSize = true;
            this.LblValue4.Location = new System.Drawing.Point(232, 346);
            this.LblValue4.Name = "LblValue4";
            this.LblValue4.Size = new System.Drawing.Size(37, 13);
            this.LblValue4.TabIndex = 112;
            this.LblValue4.Text = "Value:";
            // 
            // TxtValue4
            // 
            this.TxtValue4.Location = new System.Drawing.Point(276, 343);
            this.TxtValue4.Name = "TxtValue4";
            this.TxtValue4.Size = new System.Drawing.Size(135, 20);
            this.TxtValue4.TabIndex = 111;
            this.TxtValue4.Text = "Value4";
            // 
            // LblName4
            // 
            this.LblName4.AutoSize = true;
            this.LblName4.Location = new System.Drawing.Point(31, 346);
            this.LblName4.Name = "LblName4";
            this.LblName4.Size = new System.Drawing.Size(38, 13);
            this.LblName4.TabIndex = 110;
            this.LblName4.Text = "Name:";
            // 
            // TxtName4
            // 
            this.TxtName4.Location = new System.Drawing.Point(75, 343);
            this.TxtName4.Name = "TxtName4";
            this.TxtName4.Size = new System.Drawing.Size(135, 20);
            this.TxtName4.TabIndex = 109;
            this.TxtName4.Text = "Name4";
            // 
            // HttpHeaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.LblValue4);
            this.Controls.Add(this.TxtValue4);
            this.Controls.Add(this.LblName4);
            this.Controls.Add(this.TxtName4);
            this.Controls.Add(this.LblValue3);
            this.Controls.Add(this.TxtValue3);
            this.Controls.Add(this.LblName3);
            this.Controls.Add(this.TxtName3);
            this.Controls.Add(this.LblValue2);
            this.Controls.Add(this.TxtValue2);
            this.Controls.Add(this.LblName2);
            this.Controls.Add(this.TxtName2);
            this.Controls.Add(this.LblValue1);
            this.Controls.Add(this.TxtValue1);
            this.Controls.Add(this.LblName1);
            this.Controls.Add(this.LblTestPage);
            this.Controls.Add(this.TxtName1);
            this.Controls.Add(this.LblHeaders);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.LblSampleCode);
            this.Controls.Add(this.WBSampleCode);
            this.Controls.Add(this.BtnCreatePdf);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblTitle);
            this.Name = "HttpHeaders";
            this.Text = "Select.Pdf for .NET - Sending HTTP Headers with Html to Pdf Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTestPage;
        private System.Windows.Forms.TextBox TxtName1;
        private System.Windows.Forms.Label LblHeaders;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.Label LblSampleCode;
        private System.Windows.Forms.WebBrowser WBSampleCode;
        private System.Windows.Forms.Button BtnCreatePdf;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblName1;
        private System.Windows.Forms.Label LblValue1;
        private System.Windows.Forms.TextBox TxtValue1;
        private System.Windows.Forms.Label LblValue2;
        private System.Windows.Forms.TextBox TxtValue2;
        private System.Windows.Forms.Label LblName2;
        private System.Windows.Forms.TextBox TxtName2;
        private System.Windows.Forms.Label LblValue3;
        private System.Windows.Forms.TextBox TxtValue3;
        private System.Windows.Forms.Label LblName3;
        private System.Windows.Forms.TextBox TxtName3;
        private System.Windows.Forms.Label LblValue4;
        private System.Windows.Forms.TextBox TxtValue4;
        private System.Windows.Forms.Label LblName4;
        private System.Windows.Forms.TextBox TxtName4;
    }
}