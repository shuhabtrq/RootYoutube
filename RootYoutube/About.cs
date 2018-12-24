using System;
using System.Windows.Forms;

namespace RootYoutube
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkAboutPackage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "iexplore";
            proc.StartInfo.Arguments = "http://www.shuhab.com";
            proc.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            lblYear.Text = DateTime.Now.Year.ToString();
        }

        private void linkToMyWebsiteContactMePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "iexplore";
            proc.StartInfo.Arguments = "http://www.shuhab.com/ContactMe.aspx";
            proc.Start();
        }
    }
}
