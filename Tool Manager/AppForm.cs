using Tool_Manager.Core;

namespace Tool_Manager
{
    public partial class AppForm : Form
    {
        private Button currentButton;
        private Form activeForm;

        public AppForm()
        {
            InitializeComponent();
            SetRunAtStartupCheckedState(runAtStartup, EventArgs.Empty);
            ActivateButton(this.buttonApps);
            OpenChildForm(new Forms.FormApplications(), buttonApps);
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;

            if (Properties.Settings.Default.startMinimized)
            {
                WindowState = FormWindowState.Minimized;
                
                if (Properties.Settings.Default.minimizeToTray)
                {
                    this.Hide();
                    notifyIcon.Visible = true;
                    this.ShowInTaskbar = false;
                }
                else
                    this.ShowInTaskbar = true;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }

            Properties.Settings.Default.SettingsSaving += SetRunAtStartupCheckedState;

            ProcessMonitor.Run();
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
            this.ShowInTaskbar = true;
        }

        private void AppForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                if (Properties.Settings.Default.minimizeToTray)
                {
                    this.Hide();
                    notifyIcon.Visible = true;
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProcessMonitor.Stop();
        }

        private void ActivateButton(object sender)
        {
            if (sender != null && sender is Button button && button != currentButton)
            {
                DeactivateButton(currentButton);
                currentButton = button;
                currentButton.BackColor = Color.FromArgb(205, 50, 50);
            }
        }

        private void DeactivateButton(object sender)
        {
            if (sender != null && sender is Button button)
            {
                button.BackColor = Color.FromArgb(50, 50, 50);
            }
        }

        private void RunAtStartup_Click(object sender, EventArgs e)
        {
            StartupManager.EnableStartup(runAtStartup.Checked);
            Properties.Settings.Default.runAtStartup = runAtStartup.Checked;
            Properties.Settings.Default.Save();
        }

        private void SetRunAtStartupCheckedState(object sender, EventArgs e)
        {
            runAtStartup.Checked = StartupManager.IsStartupSet();
        }

        private void buttonApps_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormApplications(), sender);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSettings(), sender);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAbout(), sender);
        }

        private void OpenChildForm(Form childForm, object sender)
        {
            activeForm?.Close();

            ActivateButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}