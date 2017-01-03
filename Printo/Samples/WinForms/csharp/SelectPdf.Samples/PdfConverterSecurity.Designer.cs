namespace SelectPdf.Samples
{
    partial class PdfConverterSecurity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfConverterSecurity));
            this.ChkCanPrint = new System.Windows.Forms.CheckBox();
            this.ChkCanFillFormFields = new System.Windows.Forms.CheckBox();
            this.ChkCanEditContent = new System.Windows.Forms.CheckBox();
            this.ChkCanEditAnnotations = new System.Windows.Forms.CheckBox();
            this.ChkCanCopyContent = new System.Windows.Forms.CheckBox();
            this.ChkCanAssembleDocument = new System.Windows.Forms.CheckBox();
            this.LblOwnerPassword = new System.Windows.Forms.Label();
            this.LblUserPassword = new System.Windows.Forms.Label();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.LblUrl = new System.Windows.Forms.Label();
            this.LblSampleCode = new System.Windows.Forms.Label();
            this.WBSampleCode = new System.Windows.Forms.WebBrowser();
            this.BtnCreatePdf = new System.Windows.Forms.Button();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtUserPassword = new System.Windows.Forms.TextBox();
            this.TxtOwnerPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChkCanPrint
            // 
            this.ChkCanPrint.AutoSize = true;
            this.ChkCanPrint.Checked = true;
            this.ChkCanPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkCanPrint.Location = new System.Drawing.Point(250, 270);
            this.ChkCanPrint.Name = "ChkCanPrint";
            this.ChkCanPrint.Size = new System.Drawing.Size(78, 17);
            this.ChkCanPrint.TabIndex = 61;
            this.ChkCanPrint.Text = "Allow Print ";
            this.ChkCanPrint.UseVisualStyleBackColor = true;
            // 
            // ChkCanFillFormFields
            // 
            this.ChkCanFillFormFields.AutoSize = true;
            this.ChkCanFillFormFields.Checked = true;
            this.ChkCanFillFormFields.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkCanFillFormFields.Location = new System.Drawing.Point(250, 250);
            this.ChkCanFillFormFields.Name = "ChkCanFillFormFields";
            this.ChkCanFillFormFields.Size = new System.Drawing.Size(125, 17);
            this.ChkCanFillFormFields.TabIndex = 60;
            this.ChkCanFillFormFields.Text = "Allow Fill Form Fields ";
            this.ChkCanFillFormFields.UseVisualStyleBackColor = true;
            // 
            // ChkCanEditContent
            // 
            this.ChkCanEditContent.AutoSize = true;
            this.ChkCanEditContent.Checked = true;
            this.ChkCanEditContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkCanEditContent.Location = new System.Drawing.Point(250, 230);
            this.ChkCanEditContent.Name = "ChkCanEditContent";
            this.ChkCanEditContent.Size = new System.Drawing.Size(115, 17);
            this.ChkCanEditContent.TabIndex = 59;
            this.ChkCanEditContent.Text = "Allow Edit Content ";
            this.ChkCanEditContent.UseVisualStyleBackColor = true;
            // 
            // ChkCanEditAnnotations
            // 
            this.ChkCanEditAnnotations.AutoSize = true;
            this.ChkCanEditAnnotations.Checked = true;
            this.ChkCanEditAnnotations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkCanEditAnnotations.Location = new System.Drawing.Point(250, 210);
            this.ChkCanEditAnnotations.Name = "ChkCanEditAnnotations";
            this.ChkCanEditAnnotations.Size = new System.Drawing.Size(134, 17);
            this.ChkCanEditAnnotations.TabIndex = 58;
            this.ChkCanEditAnnotations.Text = "Allow Edit Annotations ";
            this.ChkCanEditAnnotations.UseVisualStyleBackColor = true;
            // 
            // ChkCanCopyContent
            // 
            this.ChkCanCopyContent.AutoSize = true;
            this.ChkCanCopyContent.Checked = true;
            this.ChkCanCopyContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkCanCopyContent.Location = new System.Drawing.Point(250, 190);
            this.ChkCanCopyContent.Name = "ChkCanCopyContent";
            this.ChkCanCopyContent.Size = new System.Drawing.Size(121, 17);
            this.ChkCanCopyContent.TabIndex = 57;
            this.ChkCanCopyContent.Text = "Allow Copy Content ";
            this.ChkCanCopyContent.UseVisualStyleBackColor = true;
            // 
            // ChkCanAssembleDocument
            // 
            this.ChkCanAssembleDocument.AutoSize = true;
            this.ChkCanAssembleDocument.Checked = true;
            this.ChkCanAssembleDocument.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkCanAssembleDocument.Location = new System.Drawing.Point(250, 170);
            this.ChkCanAssembleDocument.Name = "ChkCanAssembleDocument";
            this.ChkCanAssembleDocument.Size = new System.Drawing.Size(151, 17);
            this.ChkCanAssembleDocument.TabIndex = 56;
            this.ChkCanAssembleDocument.Text = "Allow Assemble Document";
            this.ChkCanAssembleDocument.UseVisualStyleBackColor = true;
            // 
            // LblOwnerPassword
            // 
            this.LblOwnerPassword.AutoSize = true;
            this.LblOwnerPassword.Location = new System.Drawing.Point(30, 225);
            this.LblOwnerPassword.Name = "LblOwnerPassword";
            this.LblOwnerPassword.Size = new System.Drawing.Size(90, 13);
            this.LblOwnerPassword.TabIndex = 54;
            this.LblOwnerPassword.Text = "Owner Password:";
            // 
            // LblUserPassword
            // 
            this.LblUserPassword.AutoSize = true;
            this.LblUserPassword.Location = new System.Drawing.Point(30, 170);
            this.LblUserPassword.Name = "LblUserPassword";
            this.LblUserPassword.Size = new System.Drawing.Size(81, 13);
            this.LblUserPassword.TabIndex = 52;
            this.LblUserPassword.Text = "User Password:";
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(30, 133);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(532, 20);
            this.TxtUrl.TabIndex = 51;
            this.TxtUrl.Text = "http://selectpdf.com";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(30, 113);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(23, 13);
            this.LblUrl.TabIndex = 50;
            this.LblUrl.Text = "Url:";
            // 
            // LblSampleCode
            // 
            this.LblSampleCode.AutoSize = true;
            this.LblSampleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSampleCode.Location = new System.Drawing.Point(30, 360);
            this.LblSampleCode.Name = "LblSampleCode";
            this.LblSampleCode.Size = new System.Drawing.Size(114, 15);
            this.LblSampleCode.TabIndex = 49;
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
            this.WBSampleCode.TabIndex = 48;
            // 
            // BtnCreatePdf
            // 
            this.BtnCreatePdf.Location = new System.Drawing.Point(30, 300);
            this.BtnCreatePdf.Name = "BtnCreatePdf";
            this.BtnCreatePdf.Size = new System.Drawing.Size(75, 23);
            this.BtnCreatePdf.TabIndex = 47;
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
            this.LblDescription.TabIndex = 46;
            this.LblDescription.Text = resources.GetString("LblDescription.Text");
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(30, 25);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(515, 17);
            this.LblTitle.TabIndex = 45;
            this.LblTitle.Text = "Select.Pdf for .NET - Pdf Security Settings with Html To Pdf Converter";
            // 
            // TxtUserPassword
            // 
            this.TxtUserPassword.Location = new System.Drawing.Point(30, 190);
            this.TxtUserPassword.Name = "TxtUserPassword";
            this.TxtUserPassword.Size = new System.Drawing.Size(145, 20);
            this.TxtUserPassword.TabIndex = 62;
            // 
            // TxtOwnerPassword
            // 
            this.TxtOwnerPassword.Location = new System.Drawing.Point(30, 245);
            this.TxtOwnerPassword.Name = "TxtOwnerPassword";
            this.TxtOwnerPassword.Size = new System.Drawing.Size(145, 20);
            this.TxtOwnerPassword.TabIndex = 63;
            // 
            // PdfConverterSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.TxtOwnerPassword);
            this.Controls.Add(this.TxtUserPassword);
            this.Controls.Add(this.ChkCanPrint);
            this.Controls.Add(this.ChkCanFillFormFields);
            this.Controls.Add(this.ChkCanEditContent);
            this.Controls.Add(this.ChkCanEditAnnotations);
            this.Controls.Add(this.ChkCanCopyContent);
            this.Controls.Add(this.ChkCanAssembleDocument);
            this.Controls.Add(this.LblOwnerPassword);
            this.Controls.Add(this.LblUserPassword);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.LblSampleCode);
            this.Controls.Add(this.WBSampleCode);
            this.Controls.Add(this.BtnCreatePdf);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblTitle);
            this.Name = "PdfConverterSecurity";
            this.Text = "Select.Pdf for .NET - Pdf Security Settings with Html To Pdf Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkCanPrint;
        private System.Windows.Forms.CheckBox ChkCanFillFormFields;
        private System.Windows.Forms.CheckBox ChkCanEditContent;
        private System.Windows.Forms.CheckBox ChkCanEditAnnotations;
        private System.Windows.Forms.CheckBox ChkCanCopyContent;
        private System.Windows.Forms.CheckBox ChkCanAssembleDocument;
        private System.Windows.Forms.Label LblOwnerPassword;
        private System.Windows.Forms.Label LblUserPassword;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.Label LblSampleCode;
        private System.Windows.Forms.WebBrowser WBSampleCode;
        private System.Windows.Forms.Button BtnCreatePdf;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtUserPassword;
        private System.Windows.Forms.TextBox TxtOwnerPassword;
    }
}