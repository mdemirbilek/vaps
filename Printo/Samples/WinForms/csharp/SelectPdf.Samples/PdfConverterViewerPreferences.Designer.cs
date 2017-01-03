namespace SelectPdf.Samples
{
    partial class PdfConverterViewerPreferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfConverterViewerPreferences));
            this.DdlPageMode = new System.Windows.Forms.ComboBox();
            this.LblPageMode = new System.Windows.Forms.Label();
            this.DdlPageLayout = new System.Windows.Forms.ComboBox();
            this.LblPageLayout = new System.Windows.Forms.Label();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.LblUrl = new System.Windows.Forms.Label();
            this.LblSampleCode = new System.Windows.Forms.Label();
            this.WBSampleCode = new System.Windows.Forms.WebBrowser();
            this.BtnCreatePdf = new System.Windows.Forms.Button();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.ChkCenterWindow = new System.Windows.Forms.CheckBox();
            this.ChkDisplayDocTitle = new System.Windows.Forms.CheckBox();
            this.ChkFitWindow = new System.Windows.Forms.CheckBox();
            this.ChkHideMenuBar = new System.Windows.Forms.CheckBox();
            this.ChkHideToolbar = new System.Windows.Forms.CheckBox();
            this.ChkHideWindowUI = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DdlPageMode
            // 
            this.DdlPageMode.FormattingEnabled = true;
            this.DdlPageMode.Items.AddRange(new object[] {
            "UseNone",
            "UseOutlines",
            "UseThumbs",
            "FullScreen",
            "UseOC",
            "UseAttachments"});
            this.DdlPageMode.Location = new System.Drawing.Point(30, 245);
            this.DdlPageMode.Name = "DdlPageMode";
            this.DdlPageMode.Size = new System.Drawing.Size(121, 21);
            this.DdlPageMode.TabIndex = 38;
            // 
            // LblPageMode
            // 
            this.LblPageMode.AutoSize = true;
            this.LblPageMode.Location = new System.Drawing.Point(30, 225);
            this.LblPageMode.Name = "LblPageMode";
            this.LblPageMode.Size = new System.Drawing.Size(65, 13);
            this.LblPageMode.TabIndex = 37;
            this.LblPageMode.Text = "Page Mode:";
            // 
            // DdlPageLayout
            // 
            this.DdlPageLayout.FormattingEnabled = true;
            this.DdlPageLayout.Items.AddRange(new object[] {
            "SinglePage",
            "OneColumn",
            "TwoColumnLeft",
            "TwoColumnRight"});
            this.DdlPageLayout.Location = new System.Drawing.Point(30, 190);
            this.DdlPageLayout.Name = "DdlPageLayout";
            this.DdlPageLayout.Size = new System.Drawing.Size(121, 21);
            this.DdlPageLayout.TabIndex = 36;
            // 
            // LblPageLayout
            // 
            this.LblPageLayout.AutoSize = true;
            this.LblPageLayout.Location = new System.Drawing.Point(30, 170);
            this.LblPageLayout.Name = "LblPageLayout";
            this.LblPageLayout.Size = new System.Drawing.Size(70, 13);
            this.LblPageLayout.TabIndex = 35;
            this.LblPageLayout.Text = "Page Layout:";
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(30, 133);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(532, 20);
            this.TxtUrl.TabIndex = 34;
            this.TxtUrl.Text = "http://selectpdf.com";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(30, 113);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(23, 13);
            this.LblUrl.TabIndex = 33;
            this.LblUrl.Text = "Url:";
            // 
            // LblSampleCode
            // 
            this.LblSampleCode.AutoSize = true;
            this.LblSampleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSampleCode.Location = new System.Drawing.Point(30, 360);
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
            this.WBSampleCode.Location = new System.Drawing.Point(30, 385);
            this.WBSampleCode.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBSampleCode.Name = "WBSampleCode";
            this.WBSampleCode.Size = new System.Drawing.Size(825, 250);
            this.WBSampleCode.TabIndex = 31;
            // 
            // BtnCreatePdf
            // 
            this.BtnCreatePdf.Location = new System.Drawing.Point(30, 300);
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
            this.LblDescription.Text = resources.GetString("LblDescription.Text");
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(30, 25);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(612, 17);
            this.LblTitle.TabIndex = 28;
            this.LblTitle.Text = "Select.Pdf for .NET - Setting Pdf Viewer Preferences with the Html to Pdf Convert" +
    "er";
            // 
            // ChkCenterWindow
            // 
            this.ChkCenterWindow.AutoSize = true;
            this.ChkCenterWindow.Location = new System.Drawing.Point(250, 170);
            this.ChkCenterWindow.Name = "ChkCenterWindow";
            this.ChkCenterWindow.Size = new System.Drawing.Size(99, 17);
            this.ChkCenterWindow.TabIndex = 39;
            this.ChkCenterWindow.Text = "Center Window";
            this.ChkCenterWindow.UseVisualStyleBackColor = true;
            // 
            // ChkDisplayDocTitle
            // 
            this.ChkDisplayDocTitle.AutoSize = true;
            this.ChkDisplayDocTitle.Location = new System.Drawing.Point(250, 190);
            this.ChkDisplayDocTitle.Name = "ChkDisplayDocTitle";
            this.ChkDisplayDocTitle.Size = new System.Drawing.Size(106, 17);
            this.ChkDisplayDocTitle.TabIndex = 40;
            this.ChkDisplayDocTitle.Text = "Display Doc Title";
            this.ChkDisplayDocTitle.UseVisualStyleBackColor = true;
            // 
            // ChkFitWindow
            // 
            this.ChkFitWindow.AutoSize = true;
            this.ChkFitWindow.Location = new System.Drawing.Point(250, 210);
            this.ChkFitWindow.Name = "ChkFitWindow";
            this.ChkFitWindow.Size = new System.Drawing.Size(79, 17);
            this.ChkFitWindow.TabIndex = 41;
            this.ChkFitWindow.Text = "Fit Window";
            this.ChkFitWindow.UseVisualStyleBackColor = true;
            // 
            // ChkHideMenuBar
            // 
            this.ChkHideMenuBar.AutoSize = true;
            this.ChkHideMenuBar.Location = new System.Drawing.Point(250, 230);
            this.ChkHideMenuBar.Name = "ChkHideMenuBar";
            this.ChkHideMenuBar.Size = new System.Drawing.Size(97, 17);
            this.ChkHideMenuBar.TabIndex = 42;
            this.ChkHideMenuBar.Text = "Hide Menu Bar";
            this.ChkHideMenuBar.UseVisualStyleBackColor = true;
            // 
            // ChkHideToolbar
            // 
            this.ChkHideToolbar.AutoSize = true;
            this.ChkHideToolbar.Location = new System.Drawing.Point(250, 250);
            this.ChkHideToolbar.Name = "ChkHideToolbar";
            this.ChkHideToolbar.Size = new System.Drawing.Size(87, 17);
            this.ChkHideToolbar.TabIndex = 43;
            this.ChkHideToolbar.Text = "Hide Toolbar";
            this.ChkHideToolbar.UseVisualStyleBackColor = true;
            // 
            // ChkHideWindowUI
            // 
            this.ChkHideWindowUI.AutoSize = true;
            this.ChkHideWindowUI.Location = new System.Drawing.Point(250, 270);
            this.ChkHideWindowUI.Name = "ChkHideWindowUI";
            this.ChkHideWindowUI.Size = new System.Drawing.Size(104, 17);
            this.ChkHideWindowUI.TabIndex = 44;
            this.ChkHideWindowUI.Text = "Hide Window UI";
            this.ChkHideWindowUI.UseVisualStyleBackColor = true;
            // 
            // PdfConverterViewerPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.ChkHideWindowUI);
            this.Controls.Add(this.ChkHideToolbar);
            this.Controls.Add(this.ChkHideMenuBar);
            this.Controls.Add(this.ChkFitWindow);
            this.Controls.Add(this.ChkDisplayDocTitle);
            this.Controls.Add(this.ChkCenterWindow);
            this.Controls.Add(this.DdlPageMode);
            this.Controls.Add(this.LblPageMode);
            this.Controls.Add(this.DdlPageLayout);
            this.Controls.Add(this.LblPageLayout);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.LblSampleCode);
            this.Controls.Add(this.WBSampleCode);
            this.Controls.Add(this.BtnCreatePdf);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblTitle);
            this.Name = "PdfConverterViewerPreferences";
            this.Text = "Select.Pdf for .NET - Setting Pdf Viewer Preferences with the Html to Pdf Convert" +
    "er";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DdlPageMode;
        private System.Windows.Forms.Label LblPageMode;
        private System.Windows.Forms.ComboBox DdlPageLayout;
        private System.Windows.Forms.Label LblPageLayout;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.Label LblSampleCode;
        private System.Windows.Forms.WebBrowser WBSampleCode;
        private System.Windows.Forms.Button BtnCreatePdf;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.CheckBox ChkCenterWindow;
        private System.Windows.Forms.CheckBox ChkDisplayDocTitle;
        private System.Windows.Forms.CheckBox ChkFitWindow;
        private System.Windows.Forms.CheckBox ChkHideMenuBar;
        private System.Windows.Forms.CheckBox ChkHideToolbar;
        private System.Windows.Forms.CheckBox ChkHideWindowUI;
    }
}