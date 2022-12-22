using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_Manager.Forms
{
    public partial class FormAbout : Form
    {
        ProcessStartInfo gitHub = new ProcessStartInfo("https://github.com/racosta-dev/tool-manager");
        ProcessStartInfo credits = new ProcessStartInfo("https://members.iracing.com/jforum/posts/list/3633292.page");

        public FormAbout()
        {
            InitializeComponent();
            gitHub.UseShellExecute = true;
            credits.UseShellExecute = true;
        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(gitHub);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(credits);
        }
    }
}