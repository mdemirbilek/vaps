namespace SelectPdf.Samples
{
    partial class ConversionDelay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversionDelay));
            this.TxtTimeout = new System.Windows.Forms.TextBox();
            this.LblTimeout = new System.Windows.Forms.Label();
            this.TxtDelay = new System.Windows.Forms.TextBox();
            this.LblDelay = new System.Windows.Forms.Label();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.LblUrl = new System.Windows.Forms.Label();
            this.LblSampleCode = new System.Windows.Forms.Label();
            this.WBSampleCode = new System.Windows.Forms.WebBrowser();
            this.BtnCreatePdf = new System.Windows.Forms.Button();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblSeconds1 = new System.Windows.Forms.Label();
            this.LblSeconds2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtTimeout
            // 
            this.TxtTimeout.Location = new System.Drawing.Point(170, 290);
            this.TxtTimeout.Name = "TxtTimeout";
            this.TxtTimeout.Size = new System.Drawing.Size(50, 20);
            this.TxtTimeout.TabIndex = 42;
            this.TxtTimeout.Text = "20";
            // 
            // LblTimeout
            // 
            this.LblTimeout.AutoSize = true;
            this.LblTimeout.Location = new System.Drawing.Point(170, 270);
            this.LblTimeout.Name = "LblTimeout";
            this.LblTimeout.Size = new System.Drawing.Size(73, 13);
            this.LblTimeout.TabIndex = 41;
            this.LblTimeout.Text = "Page Timeout";
            // 
            // TxtDelay
            // 
            this.TxtDelay.Location = new System.Drawing.Point(30, 290);
            this.TxtDelay.Name = "TxtDelay";
            this.TxtDelay.Size = new System.Drawing.Size(50, 20);
            this.TxtDelay.TabIndex = 40;
            this.TxtDelay.Text = "2";
            // 
            // LblDelay
            // 
            this.LblDelay.AutoSize = true;
            this.LblDelay.Location = new System.Drawing.Point(30, 270);
            this.LblDelay.Name = "LblDelay";
            this.LblDelay.Size = new System.Drawing.Size(93, 13);
            this.LblDelay.TabIndex = 39;
            this.LblDelay.Text = "Delay Conversion:";
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(30, 230);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(532, 20);
            this.TxtUrl.TabIndex = 34;
            this.TxtUrl.Text = "http://selectpdf.com";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(30, 210);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(23, 13);
            this.LblUrl.TabIndex = 33;
            this.LblUrl.Text = "Url:";
            // 
            // LblSampleCode
            // 
            this.LblSampleCode.AutoSize = true;
            this.LblSampleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSampleCode.Location = new System.Drawing.Point(27, 410);
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
            this.BtnCreatePdf.Location = new System.Drawing.Point(30, 330);
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
            this.LblDescription.Size = new System.Drawing.Size(825, 132);
            this.LblDescription.TabIndex = 29;
            this.LblDescription.Text = resources.GetString("LblDescription.Text");
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(30, 25);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(485, 17);
            this.LblTitle.TabIndex = 28;
            this.LblTitle.Text = "Select.Pdf for .NET - Conversion Delay with Html to Pdf Converter";
            // 
            // LblSeconds1
            // 
            this.LblSeconds1.AutoSize = true;
            this.LblSeconds1.Location = new System.Drawing.Point(86, 293);
            this.LblSeconds1.Name = "LblSeconds1";
            this.LblSeconds1.Size = new System.Drawing.Size(47, 13);
            this.LblSeconds1.TabIndex = 43;
            this.LblSeconds1.Text = "seconds";
            // 
            // LblSeconds2
            // 
            this.LblSeconds2.AutoSize = true;
            this.LblSeconds2.Location = new System.Drawing.Point(226, 293);
            this.LblSeconds2.Name = "LblSeconds2";
            this.LblSeconds2.Size = new System.Drawing.Size(47, 13);
            this.LblSeconds2.TabIndex = 44;
            this.LblSeconds2.Text = "seconds";
            // 
            // ConversionDelay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.LblSeconds2);
            this.Controls.Add(this.LblSeconds1);
            this.Controls.Add(this.TxtTimeout);
            this.Controls.Add(this.LblTimeout);
            this.Controls.Add(this.TxtDelay);
            this.Controls.Add(this.LblDelay);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.LblSampleCode);
            this.Controls.Add(this.WBSampleCode);
            this.Controls.Add(this.BtnCreatePdf);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblTitle);
            this.Name = "ConversionDelay";
            this.Text = "Select.Pdf for .NET - Conversion Delay with Html to Pdf Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTimeout;
        private System.Windows.Forms.Label LblTimeout;
        private System.Windows.Forms.TextBox TxtDelay;
        private System.Windows.Forms.Label LblDelay;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.Label LblSampleCode;
        private System.Windows.Forms.WebBrowser WBSampleCode;
        private System.Windows.Forms.Button BtnCreatePdf;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblSeconds1;
        private System.Windows.Forms.Label LblSeconds2;
    }
}