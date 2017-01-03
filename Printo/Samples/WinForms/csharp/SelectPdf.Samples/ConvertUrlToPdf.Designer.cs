namespace SelectPdf.Samples
{
    partial class ConvertUrlToPdf
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
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.LblUrl = new System.Windows.Forms.Label();
            this.LblSampleCode = new System.Windows.Forms.Label();
            this.WBSampleCode = new System.Windows.Forms.WebBrowser();
            this.BtnCreatePdf = new System.Windows.Forms.Button();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblPageSize = new System.Windows.Forms.Label();
            this.DdlPageSize = new System.Windows.Forms.ComboBox();
            this.DdlPageOrientation = new System.Windows.Forms.ComboBox();
            this.LblPageOrientation = new System.Windows.Forms.Label();
            this.LblPageWidth = new System.Windows.Forms.Label();
            this.TxtWidth = new System.Windows.Forms.TextBox();
            this.TxtHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblHeight2 = new System.Windows.Forms.Label();
            this.txtDocFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(100, 102);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(302, 20);
            this.TxtUrl.TabIndex = 18;
            this.TxtUrl.Text = "https://10.10.5.30:44444/whprinto/printo/";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(32, 105);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(23, 13);
            this.LblUrl.TabIndex = 17;
            this.LblUrl.Text = "Url:";
            // 
            // LblSampleCode
            // 
            this.LblSampleCode.AutoSize = true;
            this.LblSampleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSampleCode.Location = new System.Drawing.Point(27, 338);
            this.LblSampleCode.Name = "LblSampleCode";
            this.LblSampleCode.Size = new System.Drawing.Size(114, 15);
            this.LblSampleCode.TabIndex = 16;
            this.LblSampleCode.Text = "Sample Code C#";
            this.LblSampleCode.Visible = false;
            // 
            // WBSampleCode
            // 
            this.WBSampleCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WBSampleCode.Location = new System.Drawing.Point(30, 356);
            this.WBSampleCode.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBSampleCode.Name = "WBSampleCode";
            this.WBSampleCode.Size = new System.Drawing.Size(825, 179);
            this.WBSampleCode.TabIndex = 15;
            this.WBSampleCode.Visible = false;
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
            this.LblDescription.Size = new System.Drawing.Size(825, 44);
            this.LblDescription.TabIndex = 13;
            this.LblDescription.Text = "This sample shows how to use Select.Pdf html to pdf converter to convert an url t" +
    "o pdf, also setting a few properties. ";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(30, 25);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(331, 17);
            this.LblTitle.TabIndex = 12;
            this.LblTitle.Text = "Select.Pdf for .NET - Convert from Url to Pdf";
            // 
            // LblPageSize
            // 
            this.LblPageSize.AutoSize = true;
            this.LblPageSize.Location = new System.Drawing.Point(30, 240);
            this.LblPageSize.Name = "LblPageSize";
            this.LblPageSize.Size = new System.Drawing.Size(77, 13);
            this.LblPageSize.TabIndex = 19;
            this.LblPageSize.Text = "Pdf Page Size:";
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
            this.DdlPageSize.Location = new System.Drawing.Point(30, 260);
            this.DdlPageSize.Name = "DdlPageSize";
            this.DdlPageSize.Size = new System.Drawing.Size(121, 21);
            this.DdlPageSize.TabIndex = 20;
            // 
            // DdlPageOrientation
            // 
            this.DdlPageOrientation.FormattingEnabled = true;
            this.DdlPageOrientation.Items.AddRange(new object[] {
            "Portrait",
            "Landscape"});
            this.DdlPageOrientation.Location = new System.Drawing.Point(170, 260);
            this.DdlPageOrientation.Name = "DdlPageOrientation";
            this.DdlPageOrientation.Size = new System.Drawing.Size(121, 21);
            this.DdlPageOrientation.TabIndex = 22;
            // 
            // LblPageOrientation
            // 
            this.LblPageOrientation.AutoSize = true;
            this.LblPageOrientation.Location = new System.Drawing.Point(170, 240);
            this.LblPageOrientation.Name = "LblPageOrientation";
            this.LblPageOrientation.Size = new System.Drawing.Size(108, 13);
            this.LblPageOrientation.TabIndex = 21;
            this.LblPageOrientation.Text = "Pdf Page Orientation:";
            // 
            // LblPageWidth
            // 
            this.LblPageWidth.AutoSize = true;
            this.LblPageWidth.Location = new System.Drawing.Point(310, 240);
            this.LblPageWidth.Name = "LblPageWidth";
            this.LblPageWidth.Size = new System.Drawing.Size(92, 13);
            this.LblPageWidth.TabIndex = 23;
            this.LblPageWidth.Text = "Web Page Width:";
            // 
            // TxtWidth
            // 
            this.TxtWidth.Location = new System.Drawing.Point(310, 260);
            this.TxtWidth.Name = "TxtWidth";
            this.TxtWidth.Size = new System.Drawing.Size(121, 20);
            this.TxtWidth.TabIndex = 24;
            this.TxtWidth.Text = "1024";
            // 
            // TxtHeight
            // 
            this.TxtHeight.Location = new System.Drawing.Point(450, 260);
            this.TxtHeight.Name = "TxtHeight";
            this.TxtHeight.Size = new System.Drawing.Size(121, 20);
            this.TxtHeight.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Web Page Height:";
            // 
            // LblHeight2
            // 
            this.LblHeight2.AutoSize = true;
            this.LblHeight2.Location = new System.Drawing.Point(450, 285);
            this.LblHeight2.Name = "LblHeight2";
            this.LblHeight2.Size = new System.Drawing.Size(139, 13);
            this.LblHeight2.TabIndex = 27;
            this.LblHeight2.Text = "(leave empty to auto detect)";
            // 
            // txtDocFolder
            // 
            this.txtDocFolder.Location = new System.Drawing.Point(100, 136);
            this.txtDocFolder.Name = "txtDocFolder";
            this.txtDocFolder.Size = new System.Drawing.Size(302, 20);
            this.txtDocFolder.TabIndex = 29;
            this.txtDocFolder.Text = "D:\\WHPrinto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Doc Folder:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(100, 169);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(51, 20);
            this.txtYear.TabIndex = 31;
            this.txtYear.Text = "2017";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Year:";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(100, 202);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(51, 20);
            this.txtMonth.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Month:";
            // 
            // btnGetList
            // 
            this.btnGetList.Location = new System.Drawing.Point(327, 205);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(75, 23);
            this.btnGetList.TabIndex = 34;
            this.btnGetList.Text = "Get List";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Visible = false;
            // 
            // ConvertUrlToPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnGetList);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblHeight2);
            this.Controls.Add(this.TxtHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtWidth);
            this.Controls.Add(this.LblPageWidth);
            this.Controls.Add(this.DdlPageOrientation);
            this.Controls.Add(this.LblPageOrientation);
            this.Controls.Add(this.DdlPageSize);
            this.Controls.Add(this.LblPageSize);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.LblSampleCode);
            this.Controls.Add(this.WBSampleCode);
            this.Controls.Add(this.BtnCreatePdf);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblTitle);
            this.Name = "ConvertUrlToPdf";
            this.Text = "Select.Pdf for .NET - Convert from Url to Pdf";
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
        private System.Windows.Forms.Label LblPageSize;
        private System.Windows.Forms.ComboBox DdlPageSize;
        private System.Windows.Forms.ComboBox DdlPageOrientation;
        private System.Windows.Forms.Label LblPageOrientation;
        private System.Windows.Forms.Label LblPageWidth;
        private System.Windows.Forms.TextBox TxtWidth;
        private System.Windows.Forms.TextBox TxtHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblHeight2;
        private System.Windows.Forms.TextBox txtDocFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetList;
    }
}