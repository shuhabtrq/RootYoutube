namespace RootYoutube
{
    partial class YoutubeRooter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoutubeRooter));
            this.btnExtract = new System.Windows.Forms.Button();
            this.txtVideoUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVideoType = new System.Windows.Forms.ComboBox();
            this.cmbAudioType = new System.Windows.Forms.ComboBox();
            this.groupBoxDownload = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.linkOpenFolderPath = new System.Windows.Forms.LinkLabel();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProgressPercentage = new System.Windows.Forms.Label();
            this.pBarDownload = new System.Windows.Forms.ProgressBar();
            this.rdbAudio = new System.Windows.Forms.RadioButton();
            this.rdbVideo = new System.Windows.Forms.RadioButton();
            this.btnDownload = new System.Windows.Forms.Button();
            this.groupBoxExtract = new System.Windows.Forms.GroupBox();
            this.lblVideoTitle = new System.Windows.Forms.Label();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTipVideoUrl = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipOpenFolder = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDownload.SuspendLayout();
            this.groupBoxExtract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExtract
            // 
            this.btnExtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtract.Location = new System.Drawing.Point(463, 25);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(92, 39);
            this.btnExtract.TabIndex = 0;
            this.btnExtract.Text = "EXTRACT";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // txtVideoUrl
            // 
            this.txtVideoUrl.Location = new System.Drawing.Point(148, 43);
            this.txtVideoUrl.Name = "txtVideoUrl";
            this.txtVideoUrl.Size = new System.Drawing.Size(309, 20);
            this.txtVideoUrl.TabIndex = 2;
            this.txtVideoUrl.Enter += new System.EventHandler(this.txtVideoUrl_Enter);
            this.txtVideoUrl.Leave += new System.EventHandler(this.txtVideoUrl_Leave);
            this.txtVideoUrl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtVideoUrl_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter URL of the youtube video you want to download";
            // 
            // cmbVideoType
            // 
            this.cmbVideoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoType.FormattingEnabled = true;
            this.cmbVideoType.Items.AddRange(new object[] {
            "Mp4 - 720p ",
            "Mp4 - 360p",
            "WebM - 360p",
            "Mobile - 240p ",
            "Mobile - 144p"});
            this.cmbVideoType.Location = new System.Drawing.Point(74, 105);
            this.cmbVideoType.Name = "cmbVideoType";
            this.cmbVideoType.Size = new System.Drawing.Size(122, 21);
            this.cmbVideoType.TabIndex = 6;
            this.cmbVideoType.SelectedIndexChanged += new System.EventHandler(this.cmbVideoType_SelectedIndexChanged);
            // 
            // cmbAudioType
            // 
            this.cmbAudioType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAudioType.FormattingEnabled = true;
            this.cmbAudioType.Items.AddRange(new object[] {
            "Mp3 - .mp3",
            "Vorbis - .ogg",
            "Aac - .aac"});
            this.cmbAudioType.Location = new System.Drawing.Point(74, 76);
            this.cmbAudioType.Name = "cmbAudioType";
            this.cmbAudioType.Size = new System.Drawing.Size(122, 21);
            this.cmbAudioType.TabIndex = 8;
            this.cmbAudioType.SelectedIndexChanged += new System.EventHandler(this.cmbAudioType_SelectedIndexChanged);
            // 
            // groupBoxDownload
            // 
            this.groupBoxDownload.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDownload.Controls.Add(this.btnReset);
            this.groupBoxDownload.Controls.Add(this.linkOpenFolderPath);
            this.groupBoxDownload.Controls.Add(this.btnOpenFolder);
            this.groupBoxDownload.Controls.Add(this.label2);
            this.groupBoxDownload.Controls.Add(this.lblProgressPercentage);
            this.groupBoxDownload.Controls.Add(this.pBarDownload);
            this.groupBoxDownload.Controls.Add(this.rdbAudio);
            this.groupBoxDownload.Controls.Add(this.cmbAudioType);
            this.groupBoxDownload.Controls.Add(this.rdbVideo);
            this.groupBoxDownload.Controls.Add(this.cmbVideoType);
            this.groupBoxDownload.Controls.Add(this.btnDownload);
            this.groupBoxDownload.Location = new System.Drawing.Point(28, 189);
            this.groupBoxDownload.Name = "groupBoxDownload";
            this.groupBoxDownload.Size = new System.Drawing.Size(574, 143);
            this.groupBoxDownload.TabIndex = 10;
            this.groupBoxDownload.TabStop = false;
            this.groupBoxDownload.Text = "Download";
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(447, 76);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 50);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // linkOpenFolderPath
            // 
            this.linkOpenFolderPath.AutoSize = true;
            this.linkOpenFolderPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkOpenFolderPath.Location = new System.Drawing.Point(108, 51);
            this.linkOpenFolderPath.Name = "linkOpenFolderPath";
            this.linkOpenFolderPath.Size = new System.Drawing.Size(125, 13);
            this.linkOpenFolderPath.TabIndex = 13;
            this.linkOpenFolderPath.TabStop = true;
            this.linkOpenFolderPath.Text = "Open download directory";
            this.linkOpenFolderPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOpenFolderPath_LinkClicked);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFolder.Image")));
            this.btnOpenFolder.Location = new System.Drawing.Point(74, 45);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(28, 24);
            this.btnOpenFolder.TabIndex = 12;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Save to";
            // 
            // lblProgressPercentage
            // 
            this.lblProgressPercentage.AutoSize = true;
            this.lblProgressPercentage.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressPercentage.Location = new System.Drawing.Point(484, 15);
            this.lblProgressPercentage.Name = "lblProgressPercentage";
            this.lblProgressPercentage.Size = new System.Drawing.Size(71, 25);
            this.lblProgressPercentage.TabIndex = 10;
            this.lblProgressPercentage.Text = "00.00 %";
            // 
            // pBarDownload
            // 
            this.pBarDownload.Location = new System.Drawing.Point(148, 16);
            this.pBarDownload.Name = "pBarDownload";
            this.pBarDownload.Size = new System.Drawing.Size(326, 23);
            this.pBarDownload.TabIndex = 6;
            // 
            // rdbAudio
            // 
            this.rdbAudio.AutoSize = true;
            this.rdbAudio.Location = new System.Drawing.Point(16, 19);
            this.rdbAudio.Name = "rdbAudio";
            this.rdbAudio.Size = new System.Drawing.Size(52, 17);
            this.rdbAudio.TabIndex = 1;
            this.rdbAudio.TabStop = true;
            this.rdbAudio.Text = "Audio";
            this.rdbAudio.UseVisualStyleBackColor = true;
            this.rdbAudio.CheckedChanged += new System.EventHandler(this.rdbAudio_CheckedChanged);
            // 
            // rdbVideo
            // 
            this.rdbVideo.AutoSize = true;
            this.rdbVideo.Location = new System.Drawing.Point(74, 19);
            this.rdbVideo.Name = "rdbVideo";
            this.rdbVideo.Size = new System.Drawing.Size(52, 17);
            this.rdbVideo.TabIndex = 0;
            this.rdbVideo.TabStop = true;
            this.rdbVideo.Text = "Video";
            this.rdbVideo.UseVisualStyleBackColor = true;
            this.rdbVideo.CheckedChanged += new System.EventHandler(this.rdbVideo_CheckedChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownload.Location = new System.Drawing.Point(204, 76);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDownload.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDownload.Size = new System.Drawing.Size(235, 50);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "DOWNLOAD";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // groupBoxExtract
            // 
            this.groupBoxExtract.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxExtract.Controls.Add(this.lblVideoTitle);
            this.groupBoxExtract.Controls.Add(this.picBoxImage);
            this.groupBoxExtract.Controls.Add(this.label1);
            this.groupBoxExtract.Controls.Add(this.btnExtract);
            this.groupBoxExtract.Controls.Add(this.txtVideoUrl);
            this.groupBoxExtract.Location = new System.Drawing.Point(28, 49);
            this.groupBoxExtract.Name = "groupBoxExtract";
            this.groupBoxExtract.Size = new System.Drawing.Size(574, 134);
            this.groupBoxExtract.TabIndex = 11;
            this.groupBoxExtract.TabStop = false;
            this.groupBoxExtract.Text = "Extract Video";
            // 
            // lblVideoTitle
            // 
            this.lblVideoTitle.AutoSize = true;
            this.lblVideoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideoTitle.Location = new System.Drawing.Point(148, 70);
            this.lblVideoTitle.Name = "lblVideoTitle";
            this.lblVideoTitle.Size = new System.Drawing.Size(77, 13);
            this.lblVideoTitle.TabIndex = 4;
            this.lblVideoTitle.Text = "lblVideoTitle";
            // 
            // picBoxImage
            // 
            this.picBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("picBoxImage.Image")));
            this.picBoxImage.Location = new System.Drawing.Point(19, 25);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(120, 90);
            this.picBoxImage.TabIndex = 1;
            this.picBoxImage.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "About";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::RootYoutube.Properties.Resources.about;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.toolStripMenuItem1.Text = "About";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // YoutubeRooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(630, 358);
            this.Controls.Add(this.groupBoxExtract);
            this.Controls.Add(this.groupBoxDownload);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "YoutubeRooter";
            this.Text = "Youtube Video & Audio Downloader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.YoutubeRooter_FormClosed);
            this.Load += new System.EventHandler(this.YoutubeRooter_Load);
            this.groupBoxDownload.ResumeLayout(false);
            this.groupBoxDownload.PerformLayout();
            this.groupBoxExtract.ResumeLayout(false);
            this.groupBoxExtract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.PictureBox picBoxImage;
        private System.Windows.Forms.TextBox txtVideoUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ComboBox cmbVideoType;
        private System.Windows.Forms.ComboBox cmbAudioType;
        private System.Windows.Forms.GroupBox groupBoxDownload;
        private System.Windows.Forms.RadioButton rdbAudio;
        private System.Windows.Forms.RadioButton rdbVideo;
        private System.Windows.Forms.GroupBox groupBoxExtract;
        private System.Windows.Forms.ProgressBar pBarDownload;
        private System.Windows.Forms.Label lblProgressPercentage;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkOpenFolderPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTipVideoUrl;
        private System.Windows.Forms.ToolTip toolTipOpenFolder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblVideoTitle;
    }
}

