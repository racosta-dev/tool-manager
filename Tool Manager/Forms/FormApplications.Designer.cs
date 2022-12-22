namespace Tool_Manager.Forms
{
    partial class FormApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApplications));
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMainAppContainer = new System.Windows.Forms.Panel();
            this.panelMainApp = new System.Windows.Forms.Panel();
            this.tbMainApp = new System.Windows.Forms.TextBox();
            this.panelActionsContainer = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanelActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.flowLayoutPanelTools = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAppTool = new System.Windows.Forms.Panel();
            this.panelAppStart = new System.Windows.Forms.Panel();
            this.buttonStartApp = new System.Windows.Forms.Button();
            this.domDelayedStop = new System.Windows.Forms.DomainUpDown();
            this.labelAppDelayedStop = new System.Windows.Forms.Label();
            this.domDelayedStart = new System.Windows.Forms.DomainUpDown();
            this.labelAppDelayedStart = new System.Windows.Forms.Label();
            this.labelAppArguments = new System.Windows.Forms.Label();
            this.tbAppArguments = new System.Windows.Forms.TextBox();
            this.buttonBrowseApp = new System.Windows.Forms.Button();
            this.labelAppPath = new System.Windows.Forms.Label();
            this.labelAppName = new System.Windows.Forms.Label();
            this.picAppIcon = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            this.panelMainAppContainer.SuspendLayout();
            this.panelMainApp.SuspendLayout();
            this.panelActionsContainer.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.tableLayoutPanelActions.SuspendLayout();
            this.panelAppTool.SuspendLayout();
            this.panelAppStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.Control;
            this.panelContent.Controls.Add(this.panelMainAppContainer);
            //this.panelContent.Controls.Add(this.panelActionsContainer);
            this.panelContent.Controls.Add(this.flowLayoutPanelTools);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Size = new System.Drawing.Size(823, 615);
            this.panelContent.TabIndex = 0;
            // 
            // panelMainAppContainer
            // 
            this.panelMainAppContainer.Controls.Add(this.panelMainApp);
            this.panelMainAppContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainAppContainer.Location = new System.Drawing.Point(10, 505);
            this.panelMainAppContainer.Name = "panelMainAppContainer";
            this.panelMainAppContainer.Size = new System.Drawing.Size(803, 50);
            this.panelMainAppContainer.TabIndex = 1;
            // 
            // panelMainApp
            // 
            this.panelMainApp.Controls.Add(this.tbMainApp);
            this.panelMainApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainApp.Location = new System.Drawing.Point(0, 0);
            this.panelMainApp.Name = "panelMainApp";
            this.panelMainApp.Size = new System.Drawing.Size(803, 50);
            this.panelMainApp.TabIndex = 7;
            // 
            // tbMainApp
            // 
            this.tbMainApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbMainApp.Location = new System.Drawing.Point(0, 27);
            this.tbMainApp.Name = "tbMainApp";
            this.tbMainApp.ReadOnly = true;
            this.tbMainApp.Size = new System.Drawing.Size(803, 23);
            this.tbMainApp.TabIndex = 5;
            this.tbMainApp.Text = appPath;
            // 
            // panelActionsContainer
            // 
            this.panelActionsContainer.Controls.Add(this.panelButtons);
            this.panelActionsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionsContainer.Location = new System.Drawing.Point(10, 555);
            this.panelActionsContainer.Name = "panelActionsContainer";
            this.panelActionsContainer.Size = new System.Drawing.Size(803, 50);
            this.panelActionsContainer.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Controls.Add(this.tableLayoutPanelActions);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(803, 50);
            this.panelButtons.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(44, 44);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanelActions
            // 
            this.tableLayoutPanelActions.ColumnCount = 2;
            this.tableLayoutPanelActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelActions.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanelActions.Controls.Add(this.btnDiscard, 0, 0);
            this.tableLayoutPanelActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanelActions.Location = new System.Drawing.Point(503, 0);
            this.tableLayoutPanelActions.MaximumSize = new System.Drawing.Size(360, 50);
            this.tableLayoutPanelActions.Name = "tableLayoutPanelActions";
            this.tableLayoutPanelActions.RowCount = 1;
            this.tableLayoutPanelActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelActions.Size = new System.Drawing.Size(300, 50);
            this.tableLayoutPanelActions.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(153, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 44);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDiscard
            // 
            this.btnDiscard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiscard.Location = new System.Drawing.Point(3, 3);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(144, 44);
            this.btnDiscard.TabIndex = 1;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelTools
            // 
            this.flowLayoutPanelTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelTools.AutoScroll = true;
            this.flowLayoutPanelTools.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelTools.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanelTools.Name = "flowLayoutPanelTools";
            this.flowLayoutPanelTools.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelTools.Size = new System.Drawing.Size(803, 526);
            this.flowLayoutPanelTools.TabIndex = 0;
            // 
            // panelAppTool
            // 
            this.panelAppTool.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAppTool.Controls.Add(this.panelAppStart);
            this.panelAppTool.Controls.Add(this.domDelayedStop);
            this.panelAppTool.Controls.Add(this.labelAppDelayedStop);
            this.panelAppTool.Controls.Add(this.domDelayedStart);
            this.panelAppTool.Controls.Add(this.labelAppDelayedStart);
            this.panelAppTool.Controls.Add(this.labelAppArguments);
            this.panelAppTool.Controls.Add(this.tbAppArguments);
            this.panelAppTool.Controls.Add(this.buttonBrowseApp);
            this.panelAppTool.Controls.Add(this.labelAppPath);
            this.panelAppTool.Controls.Add(this.labelAppName);
            this.panelAppTool.Controls.Add(this.picAppIcon);
            this.panelAppTool.Location = new System.Drawing.Point(25, 25);
            this.panelAppTool.Margin = new System.Windows.Forms.Padding(20);
            this.panelAppTool.Name = "panelAppTool";
            this.panelAppTool.Size = new System.Drawing.Size(400, 280);
            this.panelAppTool.TabIndex = 0;
            // 
            // panelAppStart
            // 
            this.panelAppStart.Controls.Add(this.buttonStartApp);
            this.panelAppStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAppStart.Location = new System.Drawing.Point(0, 210);
            this.panelAppStart.Name = "panelAppStart";
            this.panelAppStart.Padding = new System.Windows.Forms.Padding(60, 10, 60, 25);
            this.panelAppStart.Size = new System.Drawing.Size(400, 70);
            this.panelAppStart.TabIndex = 11;
            // 
            // buttonStartApp
            // 
            this.buttonStartApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonStartApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStartApp.FlatAppearance.BorderSize = 0;
            this.buttonStartApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartApp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStartApp.Location = new System.Drawing.Point(60, 10);
            this.buttonStartApp.Name = "buttonStartApp";
            this.buttonStartApp.Size = new System.Drawing.Size(280, 35);
            this.buttonStartApp.TabIndex = 0;
            this.buttonStartApp.Text = "START";
            this.buttonStartApp.UseVisualStyleBackColor = true;
            // 
            // domDelayedStop
            // 
            this.domDelayedStop.Location = new System.Drawing.Point(220, 170);
            this.domDelayedStop.Name = "domDelayedStop";
            this.domDelayedStop.Size = new System.Drawing.Size(137, 23);
            this.domDelayedStop.TabIndex = 10;
            this.domDelayedStop.Text = "0";
            // 
            // labelAppDelayedStop
            // 
            this.labelAppDelayedStop.AutoSize = true;
            this.labelAppDelayedStop.Location = new System.Drawing.Point(220, 152);
            this.labelAppDelayedStop.Name = "labelAppDelayedStop";
            this.labelAppDelayedStop.Size = new System.Drawing.Size(132, 15);
            this.labelAppDelayedStop.TabIndex = 9;
            this.labelAppDelayedStop.Text = "Delayed stop (seconds):";
            // 
            // domDelayedStart
            // 
            this.domDelayedStart.Location = new System.Drawing.Point(39, 170);
            this.domDelayedStart.Name = "domDelayedStart";
            this.domDelayedStart.Size = new System.Drawing.Size(132, 23);
            this.domDelayedStart.TabIndex = 1;
            this.domDelayedStart.Text = "0";
            // 
            // labelAppDelayedStart
            // 
            this.labelAppDelayedStart.AutoSize = true;
            this.labelAppDelayedStart.Location = new System.Drawing.Point(39, 152);
            this.labelAppDelayedStart.Name = "labelAppDelayedStart";
            this.labelAppDelayedStart.Size = new System.Drawing.Size(132, 15);
            this.labelAppDelayedStart.TabIndex = 7;
            this.labelAppDelayedStart.Text = "Delayed start (seconds):";
            // 
            // labelAppArguments
            // 
            this.labelAppArguments.AutoSize = true;
            this.labelAppArguments.Location = new System.Drawing.Point(39, 91);
            this.labelAppArguments.Name = "labelAppArguments";
            this.labelAppArguments.Size = new System.Drawing.Size(69, 15);
            this.labelAppArguments.TabIndex = 6;
            this.labelAppArguments.Text = "Arguments:";
            // 
            // tbAppArguments
            // 
            this.tbAppArguments.Location = new System.Drawing.Point(39, 109);
            this.tbAppArguments.Name = "tbAppArguments";
            this.tbAppArguments.Size = new System.Drawing.Size(318, 23);
            this.tbAppArguments.TabIndex = 5;
            // 
            // buttonBrowseApp
            // 
            this.buttonBrowseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseApp.FlatAppearance.BorderSize = 0;
            this.buttonBrowseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseApp.Location = new System.Drawing.Point(372, 3);
            this.buttonBrowseApp.Name = "buttonBrowseApp";
            this.buttonBrowseApp.Size = new System.Drawing.Size(25, 25);
            this.buttonBrowseApp.TabIndex = 4;
            this.buttonBrowseApp.Text = "...";
            this.buttonBrowseApp.UseVisualStyleBackColor = true;
            // 
            // labelAppPath
            // 
            this.labelAppPath.AutoEllipsis = true;
            this.labelAppPath.Location = new System.Drawing.Point(95, 50);
            this.labelAppPath.MaximumSize = new System.Drawing.Size(290, 0);
            this.labelAppPath.Name = "labelAppPath";
            this.labelAppPath.Size = new System.Drawing.Size(262, 20);
            this.labelAppPath.TabIndex = 2;
            this.labelAppPath.Text = "C:\\Users\\igneo\\AppData\\Local\\racelabapps\\RacelabApps.exe";
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAppName.Location = new System.Drawing.Point(95, 20);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(122, 25);
            this.labelAppName.TabIndex = 1;
            this.labelAppName.Text = "RacelabApps";
            // 
            // picAppIcon
            // 
            this.picAppIcon.BackColor = System.Drawing.Color.White;
            this.picAppIcon.Image = ((System.Drawing.Image)(resources.GetObject("picAppIcon.Image")));
            this.picAppIcon.Location = new System.Drawing.Point(39, 20);
            this.picAppIcon.Name = "picAppIcon";
            this.picAppIcon.Padding = new System.Windows.Forms.Padding(5);
            this.picAppIcon.Size = new System.Drawing.Size(50, 50);
            this.picAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAppIcon.TabIndex = 0;
            this.picAppIcon.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.MaximumSize = new System.Drawing.Size(360, 50);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 50);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(103, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 44);
            this.button3.TabIndex = 0;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 44);
            this.button4.TabIndex = 1;
            this.button4.Text = "Discard";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 615);
            this.Controls.Add(this.panelContent);
            this.Name = "FormApplications";
            this.Text = "FormApplications";
            this.Load += new System.EventHandler(this.FormApplications_Load);
            this.panelContent.ResumeLayout(false);
            this.panelMainAppContainer.ResumeLayout(false);
            this.panelMainApp.ResumeLayout(false);
            this.panelMainApp.PerformLayout();
            this.panelActionsContainer.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.tableLayoutPanelActions.ResumeLayout(false);
            this.panelAppTool.ResumeLayout(false);
            this.panelAppTool.PerformLayout();
            this.panelAppStart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContent;

        private Panel panelMainAppContainer;
        private Panel panelMainApp;
        private TextBox tbMainApp;

        private TableLayoutPanel tableLayoutPanelActions;
        private Button btnSave;
        private Button btnDiscard;
        private Button buttonAdd;

        private Panel panelActionsContainer;
        private Panel panelButtons;

        private FlowLayoutPanel flowLayoutPanelTools;
        private Panel panelAppTool;
        private Label labelAppPath;
        private Label labelAppName;
        private PictureBox picAppIcon;
        private Button buttonBrowseApp;
        private Label labelAppArguments;
        private TextBox tbAppArguments;
        private OpenFileDialog openFileDialog;
        private Label labelAppDelayedStop;
        private Label labelAppDelayedStart;
        private DomainUpDown domDelayedStart;
        private Panel panelAppStart;
        private Button buttonStartApp;
        private DomainUpDown domDelayedStop;
        private Panel panel3;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button3;
        private Button button4;
    }
}