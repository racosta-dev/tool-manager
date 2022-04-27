using Tool_Manager.Core;

namespace Tool_Manager.Forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            GetSettings();
            EnableButtons(false);
            Properties.Settings.Default.SettingsSaving += SetRunAtStartupCheckedState;
        }

        public void GetSettings()
        {
            cbRunAtStartup.Checked = Properties.Settings.Default.runAtStartup;
            cbMinimizeToTray.Checked = Properties.Settings.Default.minimizeToTray;
            cbStartMinimized.Checked = Properties.Settings.Default.startMinimized;
        }

        public void SaveSettings()
        {
            StartupManager.EnableStartup(cbRunAtStartup.Checked);
            Properties.Settings.Default.runAtStartup = cbRunAtStartup.Checked;
            Properties.Settings.Default.minimizeToTray = cbMinimizeToTray.Checked;
            Properties.Settings.Default.startMinimized = cbStartMinimized.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
            EnableButtons(false);
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            GetSettings();
            EnableButtons(false);
        }

        private void cbRunAtStartup_CheckedChanged(object sender, EventArgs e)
        {
            EnableButtons(true);
        }

        private void cbMinimizeToTray_CheckedChanged(object sender, EventArgs e)
        {
            EnableButtons(true);
        }

        private void cbStartMinimized_CheckedChanged(object sender, EventArgs e)
        {
            EnableButtons(true);
        }

        private void EnableButtons(bool enabled)
        {
            btnDiscard.Enabled = enabled;
            btnSave.Enabled = enabled;
        }

        private void SetRunAtStartupCheckedState(object sender, EventArgs e)
        {
            cbRunAtStartup.Checked = StartupManager.IsStartupSet();
        }
    }
}
