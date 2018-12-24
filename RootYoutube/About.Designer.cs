namespace RootYoutube
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.linkAboutPackage = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkToMyWebsiteContactMePage = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkAboutPackage
            // 
            this.linkAboutPackage.AutoSize = true;
            this.linkAboutPackage.BackColor = System.Drawing.Color.Transparent;
            this.linkAboutPackage.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAboutPackage.LinkArea = new System.Windows.Forms.LinkArea(80, 14);
            this.linkAboutPackage.Location = new System.Drawing.Point(19, 20);
            this.linkAboutPackage.Name = "linkAboutPackage";
            this.linkAboutPackage.Size = new System.Drawing.Size(380, 56);
            this.linkAboutPackage.TabIndex = 6;
            this.linkAboutPackage.TabStop = true;
            this.linkAboutPackage.Text = "Youtube Video & Audio Downloader - Windows\r\nA freeware tool by Shuhab-u-Tariq | w" +
    "ww.shuhab.com\r\nVersion 1.0 (C)";
            this.linkAboutPackage.UseCompatibleTextRendering = true;
            this.linkAboutPackage.UseMnemonic = false;
            this.linkAboutPackage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAboutPackage_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(647, 216);
            this.label2.TabIndex = 7;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // linkToMyWebsiteContactMePage
            // 
            this.linkToMyWebsiteContactMePage.AutoSize = true;
            this.linkToMyWebsiteContactMePage.BackColor = System.Drawing.Color.Transparent;
            this.linkToMyWebsiteContactMePage.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkToMyWebsiteContactMePage.LinkArea = new System.Windows.Forms.LinkArea(122, 10);
            this.linkToMyWebsiteContactMePage.Location = new System.Drawing.Point(19, 313);
            this.linkToMyWebsiteContactMePage.Name = "linkToMyWebsiteContactMePage";
            this.linkToMyWebsiteContactMePage.Size = new System.Drawing.Size(552, 33);
            this.linkToMyWebsiteContactMePage.TabIndex = 8;
            this.linkToMyWebsiteContactMePage.TabStop = true;
            this.linkToMyWebsiteContactMePage.Text = "For any query, suggestions, comments or feedback about this tool, feel free to dr" +
    "op me a line at:\r\nshuhabtrq@gmail.com or click here to directly get in touch.";
            this.linkToMyWebsiteContactMePage.UseCompatibleTextRendering = true;
            this.linkToMyWebsiteContactMePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToMyWebsiteContactMePage_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(588, 323);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(127, 55);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(40, 18);
            this.lblYear.TabIndex = 10;
            this.lblYear.Text = "2017";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RootYoutube.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(688, 370);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linkToMyWebsiteContactMePage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkAboutPackage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkAboutPackage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkToMyWebsiteContactMePage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblYear;
    }
}