using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace RootYoutube
{
    public partial class YoutubeRooter : Form
    {
        public YoutubeRooter()
        {
            InitializeComponent();
        }

        private string _youtubeVideoType;

        private int _youtubeVideoResolution;

        private string _youtubeAudioExtension;

        public string YoutubeVideoType
        {
            get
            {
                return _youtubeVideoType; // Gives Video Type
            }
            set
            {
                _youtubeVideoType = value;
            }
        }

        public int YoutubeVideoResolution
        {
            get
            {
                return _youtubeVideoResolution; // Gives Video Resolution
            }
            set
            {
                _youtubeVideoResolution = value;
            }
        }

        public string YoutubeAudioExtension
        {
            get
            {
                return _youtubeAudioExtension; // Gives Audio Extension
            }
            set
            {
                _youtubeAudioExtension = value;
            }
        }

        public string YoutubeVideoUrl
        {
            get
            {
                return txtVideoUrl.Text.Trim();
            }
        }

        public string SaveToDirectoryLocation
        {
            get
            {
                return linkOpenFolderPath.Text.Trim();
            }
            set
            {
                linkOpenFolderPath.Text = value;
            }
        }

        public string ApplicationTitle
        {
            get
            {
                return "Youtube Video & Audio Downloader";
            }
        }       

        private void InitializeProgressBar()
        {
            pBarDownload.Visible = true;
            pBarDownload.Style = ProgressBarStyle.Continuous;
            pBarDownload.Minimum = 0;
            pBarDownload.Maximum = 100;           
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {           
            try
            {
                if(!Helpers.ValidateYoutubeVideoUrl(YoutubeVideoUrl))
                {
                    MessageBox.Show("Please enter a valid youtube video url.", ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                ExtractVideo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void ExtractVideo()
        {
            try
            {
                btnExtract.Enabled = false;

                if (!Helpers.ValidateYoutubeVideoUrl(YoutubeVideoUrl))
                {
                    btnExtract.Enabled = true;
                    return;
                }

                // Extract Thumbnail
                DisplayPictureBoxImage(YoutubeVideoUrl);

                // Extract Video Info
                IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(YoutubeVideoUrl, false);

                VideoInfo video = videoInfos.First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);

                lblVideoTitle.Visible = true;
                lblVideoTitle.Text = video.Title;

                //   pBarDownload.PerformStep();
                if (!rdbAudio.Checked && !rdbVideo.Checked)
                {
                    groupBoxDownload.Enabled = true;
                    rdbAudio.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("This is an out of date version of Youtube Video & Audio downloader and has been temporarily locked by administrator. Please get in touch: http://shuhab.com/ContactMe.aspx for an up to date copy of this software.", ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            finally
            {
                btnExtract.Enabled = true;
            }
        }

        public void DisplayPictureBoxImage(string youtubeVideoUrl)
        {
            picBoxImage.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxImage.BackColor = Color.LightGray;

            try
            {
                picBoxImage.Load(Helpers.GetYouTubeImageUrl(youtubeVideoUrl));
            }
           
            catch (Exception ex)
            {
                picBoxImage.Image = Properties.Resources.video;
            }
        }
        
        private void YoutubeRooter_Load(object sender, EventArgs e)
        {
            lblVideoTitle.Font = new Font("Trebuchet MS", 9, FontStyle.Bold);
            lblVideoTitle.MaximumSize = new Size(409, 60);
            lblVideoTitle.AutoSize = true;             
            lblVideoTitle.Visible = false;

            cmbVideoType.SelectedIndex = 0;
            cmbAudioType.SelectedIndex = 0;

            txtVideoUrl.Text = Helpers.ExampleVideoUrl;
            txtVideoUrl.ForeColor = Color.Gray;
        
            SetAllToolTips();
            
            folderBrowserDialog1.Description = "Choose download directory.";

            groupBoxDownload.Enabled = false;
            pBarDownload.Visible = false;
            lblProgressPercentage.Visible = false;

            PasteClipboardText();

            ExtractVideo();

            if(groupBoxDownload.Enabled == true)
            {
                btnDownload.Select();
            }
            else
            {
                btnExtract.Select();
            }

            SaveToDirectoryLocation = Helpers.RetrieveSavedDirectoryPath();

            if(SaveToDirectoryLocation == string.Empty)
            {
                SaveToDirectoryLocation = "Open download directory";
            }
        }

        private void SetAllToolTips()
        {
            toolTipVideoUrl.SetToolTip(txtVideoUrl, "Enter URL of the youtube video you want to download");
            toolTipOpenFolder.SetToolTip(btnOpenFolder, "Choose download directory");
        }

        private void PasteClipboardText()
        {
            // Determine if there is any text in the Clipboard to paste into the text box.
            var dataObject = Clipboard.GetDataObject();
            if (dataObject != null && dataObject.GetDataPresent(DataFormats.Text))
            {
                if (Clipboard.ContainsText(TextDataFormat.Text) && Clipboard.GetText().Contains("youtube.com"))
                {
                    if (txtVideoUrl.Text.Trim() == string.Empty || txtVideoUrl.Text.Trim() == Helpers.ExampleVideoUrl)
                    {
                        txtVideoUrl.Text = string.Empty;
                        txtVideoUrl.ForeColor = Color.Black;
                        txtVideoUrl.Paste();
                    }
                }
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (!IsDownloadDirectorySet())
            {
                MessageBox.Show("Please choose download directory.", ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btnOpenFolder.Select();
                OpenSaveFolderLocation();
                return;
            }

            try
            {
                pBarDownload.Visible = true;
                lblProgressPercentage.Visible = true;

                groupBoxDownload.Enabled = false;

                if (rdbVideo.Checked)
                {
                    // Download Video
                    await DownloadVideoAsync(YoutubeVideoUrl, YoutubeVideoType, YoutubeVideoResolution, SaveToDirectoryLocation);
                }
                else if(rdbAudio.Checked)
                {
                    // Download Audio
                    await DownloadAudioAsync(YoutubeVideoUrl, YoutubeAudioExtension, SaveToDirectoryLocation);
                }

                MessageBox.Show("Download Complete!", ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Process.Start(SaveToDirectoryLocation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
            finally
            {
                groupBoxDownload.Enabled = true;
            }         
        }

        public Task DownloadVideoAsync(string videoLink, string youtubeVideoType, int youtubeVideoResolution, string saveToFolderPath)
        {
            return Task.Run(() =>
            { 
                // 1. Get the available video formats.
                IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(videoLink, false);

                // 2. Download the video. Select the first video with selected VideoType & Resolution.
                VideoInfo video;

                switch (youtubeVideoType.ToUpper())
                {
                    case "MP4":
                        video = videoInfos.First(info => info.VideoType == VideoType.Mp4 && info.Resolution == youtubeVideoResolution);
                        break;
                    case "WEBM":
                        video = videoInfos.First(info => info.VideoType == VideoType.WebM && info.Resolution == youtubeVideoResolution);
                        break;
                    case "MOBILE":
                        video = videoInfos.First(info => info.VideoType == VideoType.Mobile && info.Resolution == youtubeVideoResolution);
                        break;
                    case "FLASH":
                        video = videoInfos.First(info => info.VideoType == VideoType.Flash && info.Resolution == youtubeVideoResolution);
                        break;
                    default:
                        video = videoInfos.First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);
                        break;
                }

                // 3. If the video has a decrypted signature, decipher it.
                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                }

                string videoFilenameWithExtension = string.Concat(Helpers.VideoTitle(video.Title), video.VideoExtension);
                
                // 4. Create the video downloader. The first argument is the video to download. The second argument is the path to save the video file.
                var videoDownloader = new VideoDownloader(video, Path.Combine(saveToFolderPath, videoFilenameWithExtension));

                // 5. Register the ProgressChanged event and print the current progress
                // videoDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage);
                videoDownloader.DownloadProgressChanged += videoDownloader_DownloadProgressChanged;

                // 6. Execute the video downloader. For GUI applications note that this method runs synchronously.             
                videoDownloader.Execute();
            });
        }

        private void videoDownloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {           
            BeginInvoke((Action)(() => {
                double progressPercentage = e.ProgressPercentage;
                pBarDownload.Value = (int)progressPercentage;
                lblProgressPercentage.Text = string.Format("{0:F} %", progressPercentage);
            }));
        }

        public Task DownloadAudioAsync(string videoLink, string youtubeAudioExtension, string saveToFolderPath)
        {
            return Task.Run(() =>
            {
                // 1. Get the available video formats.
                IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(videoLink, false);

                // 2. Download the video. Select the first .mp4 video with 360p resolution. (Option: set resolutions)
                //VideoInfo video = videoInfos.First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 0);
                VideoInfo video = videoInfos.Where(info => info.AudioBitrate > 0 && info.AdaptiveType == AdaptiveType.Audio)
                                                .OrderByDescending(info => info.AudioBitrate).FirstOrDefault();

                // 3. If the video has a decrypted signature, decipher it.
                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                }

                string audioFilenameWithExtension = string.Concat(Helpers.VideoTitle(video.Title), youtubeAudioExtension);

                // 4. Create the video downloader. The first argument is the video to download. The second argument is the path to save the video file.
                var videoDownloader = new VideoDownloader(video, Path.Combine(saveToFolderPath, audioFilenameWithExtension));

                // 5. Register the ProgressChanged event and print the current progress
                // videoDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage);
                videoDownloader.DownloadProgressChanged += videoDownloader_DownloadProgressChanged;

                // 6. Execute the video downloader. For GUI applications note that this method runs synchronously.             
                videoDownloader.Execute();
            });
        }

        private void rdbAudio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAudio.Checked)
            {
                btnDownload.Text = "DOWNLOAD AUDIO";
                cmbAudioType.Enabled = true;
                cmbVideoType.Enabled = false;
            }
        }

        private void rdbVideo_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbVideo.Checked)
            {
                btnDownload.Text = "DOWNLOAD VIDEO";
                cmbVideoType.Enabled = true;
                cmbAudioType.Enabled = false;
            }          
        }      

        private void txtVideoUrl_Enter(object sender, EventArgs e)
        {
            if (txtVideoUrl.Text == Helpers.ExampleVideoUrl)
            {
                txtVideoUrl.Text = string.Empty;
                txtVideoUrl.ForeColor = Color.Black;
            }
        }

        private void txtVideoUrl_Leave(object sender, EventArgs e)
        {
            if (txtVideoUrl.Text == string.Empty)
            {
                txtVideoUrl.Text = Helpers.ExampleVideoUrl;
                txtVideoUrl.ForeColor = Color.Gray;
            }
        }        

        private void YoutubeRooter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            OpenSaveFolderLocation();
        }

        private void OpenSaveFolderLocation()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveToDirectoryLocation = folderBrowserDialog1.SelectedPath;

                Helpers.CreateAppPathAndSaveFolderLocation(SaveToDirectoryLocation);
            }

            btnOpenFolder.TabStop = false;
            linkOpenFolderPath.Focus();
        }        

        private void linkOpenFolderPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(IsDownloadDirectorySet())
            {
                Process.Start(SaveToDirectoryLocation);
            }
            else
            {
                MessageBox.Show("Please choose download directory.", ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btnOpenFolder.Select();
                OpenSaveFolderLocation();
            }           
        }

        private bool IsDownloadDirectorySet()
        {
            if (string.Equals(SaveToDirectoryLocation, "Open download directory", StringComparison.OrdinalIgnoreCase))
            {                
                return false;
            }

            return true;
        }
        
        private void cmbVideoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            YoutubeVideoType = cmbVideoType.Text.Split('-')[0].Trim(); // Gives Video Type
            YoutubeVideoResolution = Convert.ToInt32(cmbVideoType.Text.Split('-')[1].Trim().Substring(0, 3)); // Gives Video Resolution
        }

        private void cmbAudioType_SelectedIndexChanged(object sender, EventArgs e)
        {
            YoutubeAudioExtension = cmbAudioType.Text.Split('-')[1].Trim();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtVideoUrl.Text = Helpers.ExampleVideoUrl;
            txtVideoUrl.ForeColor = Color.Gray;
            btnExtract.Focus();

            lblVideoTitle.Text = string.Empty;
            lblVideoTitle.Visible = false;
            picBoxImage.Image = Properties.Resources.youNoImage;

            pBarDownload.Visible = false;
            lblProgressPercentage.Visible = false;

            rdbAudio.Checked = false;
            rdbVideo.Checked = false;

            cmbAudioType.SelectedIndex = 0;
            cmbVideoType.SelectedIndex = 0;
            groupBoxDownload.Enabled = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About formAbout = new About();
            formAbout.Show();
        }

        private void txtVideoUrl_MouseMove(object sender, MouseEventArgs e)
        {
            PasteClipboardText();
        }
    }
}
