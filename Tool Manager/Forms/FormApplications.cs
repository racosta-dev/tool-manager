using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool_Manager.Core.Util;
using Tool_Manager.Model;

namespace Tool_Manager.Forms
{
    public partial class FormApplications : Form
    {
        protected string appPath = Properties.Settings.Default.appPath;
        protected List<Panel> panelAppTools = new List<Panel>();

        public FormApplications()
        {
            InitializeComponent();
            Init();
            EnableButtons(false);
        }

        private void Init()
        {
            AppTools appTools = Properties.Settings.Default.apps;

            if (appTools != null)
            {
                foreach (AppTool appTool in appTools)
                {
                    panelAppTools.Add(CreateAppTile(appTool));
                }
            }
        }

        private void FormApplications_Load(object sender, EventArgs e)
        {
            if (panelAppTools != null)
                foreach (Panel panelAppTool in panelAppTools)
                {
                    this.flowLayoutPanelTools.Controls.Add(panelAppTool);
                }
        }

        private void EnableButtons(bool enabled)
        {
            btnDiscard.Enabled = enabled;
            btnSave.Enabled = enabled;
        }

        private Panel CreateAppTile(AppTool appTool)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormApplications));

            Panel panelAppTool = new Panel();

            PictureBox picAppIcon = new PictureBox();
            Label labelAppName = new Label();
            Label labelAppPath = new Label();
            Button buttonBrowseApp = new Button();

            Label labelAppArguments = new Label();
            TextBox tbAppArguments = new TextBox();

            Label labelAppDelayedStart = new Label();
            DomainUpDown domDelayedStart = new DomainUpDown();

            Label labelAppDelayedStop = new Label();
            DomainUpDown domDelayedStop = new DomainUpDown();

            Panel panelAppStart = new Panel();
            Button buttonStartApp = new Button();

            //panelAppTool.SuspendLayout();
            //panelAppStart.SuspendLayout();

            // panelAppTool
            panelAppTool.BackColor = System.Drawing.Color.WhiteSmoke;
            //panelAppTool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            panelAppTool.Controls.Add(panelAppStart);
            panelAppTool.Controls.Add(domDelayedStop);
            panelAppTool.Controls.Add(labelAppDelayedStop);
            panelAppTool.Controls.Add(domDelayedStart);
            panelAppTool.Controls.Add(labelAppDelayedStart);
            panelAppTool.Controls.Add(labelAppArguments);
            panelAppTool.Controls.Add(tbAppArguments);
            panelAppTool.Controls.Add(buttonBrowseApp);
            panelAppTool.Controls.Add(labelAppPath);
            panelAppTool.Controls.Add(labelAppName);
            panelAppTool.Controls.Add(picAppIcon);
            panelAppTool.Location = new System.Drawing.Point(25, 25);
            panelAppTool.Margin = new System.Windows.Forms.Padding(20);
            panelAppTool.Name = "panelAppTool";
            panelAppTool.Size = new System.Drawing.Size(400, 280);
            panelAppTool.TabIndex = 0;

            // panelAppStart
            panelAppStart.Controls.Add(buttonStartApp);
            panelAppStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelAppStart.Location = new System.Drawing.Point(0, 210);
            panelAppStart.Name = "panelAppStart";
            panelAppStart.Padding = new System.Windows.Forms.Padding(60, 10, 60, 25);
            panelAppStart.Size = new System.Drawing.Size(400, 70);
            panelAppStart.TabIndex = 11;

            // buttonStartApp
            buttonStartApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            buttonStartApp.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonStartApp.FlatAppearance.BorderSize = 0;
            buttonStartApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonStartApp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            buttonStartApp.Location = new System.Drawing.Point(60, 10);
            buttonStartApp.Name = "buttonStartApp";
            buttonStartApp.Size = new System.Drawing.Size(280, 35);
            buttonStartApp.TabIndex = 0;
            buttonStartApp.Text = "START";
            buttonStartApp.UseVisualStyleBackColor = true;

            // domDelayedStop
            domDelayedStop.Location = new System.Drawing.Point(220, 170);
            domDelayedStop.Name = "domDelayedStop";
            domDelayedStop.Size = new System.Drawing.Size(137, 23);
            domDelayedStop.TabIndex = 10;
            domDelayedStop.Text = appTool.DelayedStop.ToString();

            // labelAppDelayedStop
            labelAppDelayedStop.AutoSize = true;
            labelAppDelayedStop.Location = new System.Drawing.Point(220, 152);
            labelAppDelayedStop.Name = "labelAppDelayedStop";
            labelAppDelayedStop.Size = new System.Drawing.Size(132, 15);
            labelAppDelayedStop.TabIndex = 9;
            labelAppDelayedStop.Text = "Delayed stop (seconds):";

            // domDelayedStart
            domDelayedStart.Location = new System.Drawing.Point(39, 170);
            domDelayedStart.Name = "domDelayedStart";
            domDelayedStart.Size = new System.Drawing.Size(132, 23);
            domDelayedStart.TabIndex = 1;
            domDelayedStart.Text = appTool.DelayedStart.ToString();

            // labelAppDelayedStart
            labelAppDelayedStart.AutoSize = true;
            labelAppDelayedStart.Location = new System.Drawing.Point(39, 152);
            labelAppDelayedStart.Name = "labelAppDelayedStart";
            labelAppDelayedStart.Size = new System.Drawing.Size(132, 15);
            labelAppDelayedStart.TabIndex = 7;
            labelAppDelayedStart.Text = "Delayed start (seconds):";

            // labelAppArguments
            labelAppArguments.AutoSize = true;
            labelAppArguments.Location = new System.Drawing.Point(39, 91);
            labelAppArguments.Name = "labelAppArguments";
            labelAppArguments.Size = new System.Drawing.Size(69, 15);
            labelAppArguments.TabIndex = 6;
            labelAppArguments.Text = "Arguments:";

            // tbAppArguments
            tbAppArguments.Location = new System.Drawing.Point(39, 109);
            tbAppArguments.Name = "tbAppArguments";
            tbAppArguments.Size = new System.Drawing.Size(318, 23);
            tbAppArguments.Text = appTool.Arguments;
            tbAppArguments.TabIndex = 5;

            // buttonBrowseApp
            buttonBrowseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            buttonBrowseApp.FlatAppearance.BorderSize = 0;
            buttonBrowseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBrowseApp.Location = new System.Drawing.Point(372, 3);
            buttonBrowseApp.Name = "buttonBrowseApp";
            buttonBrowseApp.Size = new System.Drawing.Size(25, 25);
            buttonBrowseApp.TabIndex = 4;
            buttonBrowseApp.Text = "...";
            buttonBrowseApp.UseVisualStyleBackColor = true;

            // labelAppPath
            labelAppPath.AutoEllipsis = true;
            labelAppPath.Location = new System.Drawing.Point(95, 50);
            labelAppPath.MaximumSize = new System.Drawing.Size(290, 0);
            labelAppPath.Name = "labelAppPath";
            labelAppPath.Size = new System.Drawing.Size(262, 20);
            labelAppPath.TabIndex = 2;
            labelAppPath.Text = appTool.Path;

            // labelAppName
            labelAppName.AutoSize = true;
            labelAppName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelAppName.Location = new System.Drawing.Point(95, 20);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new System.Drawing.Size(122, 25);
            labelAppName.TabIndex = 1;
            labelAppName.Text = StringUtil.ExtractProcessNameFromPath(appTool.Path);

            // picAppIcon
            picAppIcon.BackColor = System.Drawing.Color.White;
            picAppIcon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            picAppIcon.Image = (System.Drawing.Image)(resources.GetObject("picAppIcon.Image"));
            picAppIcon.Location = new System.Drawing.Point(39, 20);
            picAppIcon.Name = "picAppIcon";
            picAppIcon.Padding = new System.Windows.Forms.Padding(5);
            picAppIcon.Size = new System.Drawing.Size(50, 50);
            picAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picAppIcon.TabIndex = 0;
            picAppIcon.TabStop = false;

            //panelAppTool.ResumeLayout(false);
            //panelAppTool.PerformLayout();
            //panelAppStart.ResumeLayout(false);

            return panelAppTool;
        }
    }
}
