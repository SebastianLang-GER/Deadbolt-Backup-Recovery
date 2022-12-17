namespace DeadboltBackupRecovery
{
    partial class Recovery
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recovery));
            this.button_Run = new System.Windows.Forms.Button();
            this.groupBox_RecoveryBehaviour = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_RecoveryBehaviour = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_CopyMissingFiles = new System.Windows.Forms.ComboBox();
            this.label_CopyMissingFiles = new System.Windows.Forms.Label();
            this.comboBox_UnencryptedFilesExists = new System.Windows.Forms.ComboBox();
            this.label_UnencryptedFilesExists = new System.Windows.Forms.Label();
            this.comboBox_DeleteEncryptedFiles = new System.Windows.Forms.ComboBox();
            this.label_DeleteEncryptedFiles = new System.Windows.Forms.Label();
            this.progressBar_Recovery = new System.Windows.Forms.ProgressBar();
            this.tabControl_Recovery = new System.Windows.Forms.TabControl();
            this.tabPage_Settings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Folders = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_EncryptedFiles = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_EncryptedFiles = new System.Windows.Forms.TextBox();
            this.button_EncryptedFiles = new System.Windows.Forms.Button();
            this.treeView_EncryptedFiles = new System.Windows.Forms.TreeView();
            this.label_EncryptedFiles = new System.Windows.Forms.Label();
            this.label_BackupFiles = new System.Windows.Forms.Label();
            this.tableLayoutPanel_BackupFiles = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_BackupFiles = new System.Windows.Forms.TextBox();
            this.button_BackupFiles = new System.Windows.Forms.Button();
            this.treeView_BackupFiles = new System.Windows.Forms.TreeView();
            this.tabPage_Log = new System.Windows.Forms.TabPage();
            this.toolStripContainer_Log = new System.Windows.Forms.ToolStripContainer();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.toolStrip_Log = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_ClearLog = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_SaveLog = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_Log_01 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_AutoScroll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_AutoLineBreak = new System.Windows.Forms.ToolStripButton();
            this.label_CurrentFile = new System.Windows.Forms.Label();
            this.groupBox_RecoveryBehaviour.SuspendLayout();
            this.tableLayoutPanel_RecoveryBehaviour.SuspendLayout();
            this.tabControl_Recovery.SuspendLayout();
            this.tabPage_Settings.SuspendLayout();
            this.tableLayoutPanel_Folders.SuspendLayout();
            this.tableLayoutPanel_EncryptedFiles.SuspendLayout();
            this.tableLayoutPanel_BackupFiles.SuspendLayout();
            this.tabPage_Log.SuspendLayout();
            this.toolStripContainer_Log.ContentPanel.SuspendLayout();
            this.toolStripContainer_Log.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer_Log.SuspendLayout();
            this.toolStrip_Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Run
            // 
            this.button_Run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Run.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Run.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Run.Location = new System.Drawing.Point(751, 514);
            this.button_Run.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(120, 35);
            this.button_Run.TabIndex = 0;
            this.button_Run.Text = "Run recovery";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // groupBox_RecoveryBehaviour
            // 
            this.groupBox_RecoveryBehaviour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_RecoveryBehaviour.Controls.Add(this.tableLayoutPanel_RecoveryBehaviour);
            this.groupBox_RecoveryBehaviour.Location = new System.Drawing.Point(6, 361);
            this.groupBox_RecoveryBehaviour.Name = "groupBox_RecoveryBehaviour";
            this.groupBox_RecoveryBehaviour.Size = new System.Drawing.Size(864, 113);
            this.groupBox_RecoveryBehaviour.TabIndex = 2;
            this.groupBox_RecoveryBehaviour.TabStop = false;
            this.groupBox_RecoveryBehaviour.Text = "Recovery behaviour";
            // 
            // tableLayoutPanel_RecoveryBehaviour
            // 
            this.tableLayoutPanel_RecoveryBehaviour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_RecoveryBehaviour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_RecoveryBehaviour.ColumnCount = 2;
            this.tableLayoutPanel_RecoveryBehaviour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_RecoveryBehaviour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_RecoveryBehaviour.Controls.Add(this.comboBox_CopyMissingFiles, 1, 2);
            this.tableLayoutPanel_RecoveryBehaviour.Controls.Add(this.label_CopyMissingFiles, 0, 2);
            this.tableLayoutPanel_RecoveryBehaviour.Controls.Add(this.comboBox_UnencryptedFilesExists, 1, 1);
            this.tableLayoutPanel_RecoveryBehaviour.Controls.Add(this.label_UnencryptedFilesExists, 0, 1);
            this.tableLayoutPanel_RecoveryBehaviour.Controls.Add(this.comboBox_DeleteEncryptedFiles, 1, 0);
            this.tableLayoutPanel_RecoveryBehaviour.Controls.Add(this.label_DeleteEncryptedFiles, 0, 0);
            this.tableLayoutPanel_RecoveryBehaviour.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel_RecoveryBehaviour.Name = "tableLayoutPanel_RecoveryBehaviour";
            this.tableLayoutPanel_RecoveryBehaviour.RowCount = 3;
            this.tableLayoutPanel_RecoveryBehaviour.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_RecoveryBehaviour.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_RecoveryBehaviour.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_RecoveryBehaviour.Size = new System.Drawing.Size(852, 85);
            this.tableLayoutPanel_RecoveryBehaviour.TabIndex = 5;
            // 
            // comboBox_CopyMissingFiles
            // 
            this.comboBox_CopyMissingFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_CopyMissingFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CopyMissingFiles.FormattingEnabled = true;
            this.comboBox_CopyMissingFiles.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox_CopyMissingFiles.Location = new System.Drawing.Point(255, 61);
            this.comboBox_CopyMissingFiles.Name = "comboBox_CopyMissingFiles";
            this.comboBox_CopyMissingFiles.Size = new System.Drawing.Size(594, 23);
            this.comboBox_CopyMissingFiles.TabIndex = 5;
            this.comboBox_CopyMissingFiles.SelectedIndexChanged += new System.EventHandler(this.comboBox_CopyMissingFiles_SelectedIndexChanged);
            // 
            // label_CopyMissingFiles
            // 
            this.label_CopyMissingFiles.AutoSize = true;
            this.label_CopyMissingFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_CopyMissingFiles.Location = new System.Drawing.Point(3, 58);
            this.label_CopyMissingFiles.Name = "label_CopyMissingFiles";
            this.label_CopyMissingFiles.Size = new System.Drawing.Size(246, 29);
            this.label_CopyMissingFiles.TabIndex = 4;
            this.label_CopyMissingFiles.Text = "Copy missing files from backup";
            this.label_CopyMissingFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_UnencryptedFilesExists
            // 
            this.comboBox_UnencryptedFilesExists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_UnencryptedFilesExists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UnencryptedFilesExists.FormattingEnabled = true;
            this.comboBox_UnencryptedFilesExists.Items.AddRange(new object[] {
            "Ask for each file",
            "Skip file",
            "Overwrite file"});
            this.comboBox_UnencryptedFilesExists.Location = new System.Drawing.Point(255, 32);
            this.comboBox_UnencryptedFilesExists.Name = "comboBox_UnencryptedFilesExists";
            this.comboBox_UnencryptedFilesExists.Size = new System.Drawing.Size(594, 23);
            this.comboBox_UnencryptedFilesExists.TabIndex = 3;
            this.comboBox_UnencryptedFilesExists.SelectedIndexChanged += new System.EventHandler(this.comboBox_UnencryptedFilesExists_SelectedIndexChanged);
            // 
            // label_UnencryptedFilesExists
            // 
            this.label_UnencryptedFilesExists.AutoSize = true;
            this.label_UnencryptedFilesExists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_UnencryptedFilesExists.Location = new System.Drawing.Point(3, 29);
            this.label_UnencryptedFilesExists.Name = "label_UnencryptedFilesExists";
            this.label_UnencryptedFilesExists.Size = new System.Drawing.Size(246, 29);
            this.label_UnencryptedFilesExists.TabIndex = 2;
            this.label_UnencryptedFilesExists.Text = "Unencrypted file already exists";
            this.label_UnencryptedFilesExists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_DeleteEncryptedFiles
            // 
            this.comboBox_DeleteEncryptedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_DeleteEncryptedFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DeleteEncryptedFiles.FormattingEnabled = true;
            this.comboBox_DeleteEncryptedFiles.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox_DeleteEncryptedFiles.Location = new System.Drawing.Point(255, 3);
            this.comboBox_DeleteEncryptedFiles.Name = "comboBox_DeleteEncryptedFiles";
            this.comboBox_DeleteEncryptedFiles.Size = new System.Drawing.Size(594, 23);
            this.comboBox_DeleteEncryptedFiles.TabIndex = 0;
            this.comboBox_DeleteEncryptedFiles.SelectedIndexChanged += new System.EventHandler(this.comboBox_DeleteEncryptedFiles_SelectedIndexChanged);
            // 
            // label_DeleteEncryptedFiles
            // 
            this.label_DeleteEncryptedFiles.AutoSize = true;
            this.label_DeleteEncryptedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_DeleteEncryptedFiles.Location = new System.Drawing.Point(3, 0);
            this.label_DeleteEncryptedFiles.Name = "label_DeleteEncryptedFiles";
            this.label_DeleteEncryptedFiles.Size = new System.Drawing.Size(246, 29);
            this.label_DeleteEncryptedFiles.TabIndex = 1;
            this.label_DeleteEncryptedFiles.Text = "Delete encrypted Deadbolt files after recovery";
            this.label_DeleteEncryptedFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar_Recovery
            // 
            this.progressBar_Recovery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_Recovery.Location = new System.Drawing.Point(12, 514);
            this.progressBar_Recovery.Name = "progressBar_Recovery";
            this.progressBar_Recovery.Size = new System.Drawing.Size(732, 20);
            this.progressBar_Recovery.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_Recovery.TabIndex = 3;
            // 
            // tabControl_Recovery
            // 
            this.tabControl_Recovery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Recovery.Controls.Add(this.tabPage_Settings);
            this.tabControl_Recovery.Controls.Add(this.tabPage_Log);
            this.tabControl_Recovery.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Recovery.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabControl_Recovery.Name = "tabControl_Recovery";
            this.tabControl_Recovery.SelectedIndex = 0;
            this.tabControl_Recovery.Size = new System.Drawing.Size(884, 508);
            this.tabControl_Recovery.TabIndex = 4;
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.Controls.Add(this.tableLayoutPanel_Folders);
            this.tabPage_Settings.Controls.Add(this.groupBox_RecoveryBehaviour);
            this.tabPage_Settings.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Settings.Size = new System.Drawing.Size(876, 480);
            this.tabPage_Settings.TabIndex = 0;
            this.tabPage_Settings.Text = "Settings";
            this.tabPage_Settings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Folders
            // 
            this.tableLayoutPanel_Folders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Folders.ColumnCount = 2;
            this.tableLayoutPanel_Folders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Folders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Folders.Controls.Add(this.tableLayoutPanel_EncryptedFiles, 0, 1);
            this.tableLayoutPanel_Folders.Controls.Add(this.label_EncryptedFiles, 1, 0);
            this.tableLayoutPanel_Folders.Controls.Add(this.label_BackupFiles, 0, 0);
            this.tableLayoutPanel_Folders.Controls.Add(this.tableLayoutPanel_BackupFiles, 0, 1);
            this.tableLayoutPanel_Folders.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel_Folders.Name = "tableLayoutPanel_Folders";
            this.tableLayoutPanel_Folders.RowCount = 2;
            this.tableLayoutPanel_Folders.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Folders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Folders.Size = new System.Drawing.Size(864, 349);
            this.tableLayoutPanel_Folders.TabIndex = 3;
            // 
            // tableLayoutPanel_EncryptedFiles
            // 
            this.tableLayoutPanel_EncryptedFiles.ColumnCount = 2;
            this.tableLayoutPanel_EncryptedFiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_EncryptedFiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_EncryptedFiles.Controls.Add(this.textBox_EncryptedFiles, 0, 0);
            this.tableLayoutPanel_EncryptedFiles.Controls.Add(this.button_EncryptedFiles, 1, 0);
            this.tableLayoutPanel_EncryptedFiles.Controls.Add(this.treeView_EncryptedFiles, 0, 1);
            this.tableLayoutPanel_EncryptedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_EncryptedFiles.Location = new System.Drawing.Point(435, 18);
            this.tableLayoutPanel_EncryptedFiles.Name = "tableLayoutPanel_EncryptedFiles";
            this.tableLayoutPanel_EncryptedFiles.RowCount = 2;
            this.tableLayoutPanel_EncryptedFiles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_EncryptedFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_EncryptedFiles.Size = new System.Drawing.Size(426, 328);
            this.tableLayoutPanel_EncryptedFiles.TabIndex = 3;
            // 
            // textBox_EncryptedFiles
            // 
            this.textBox_EncryptedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_EncryptedFiles.Location = new System.Drawing.Point(3, 3);
            this.textBox_EncryptedFiles.Name = "textBox_EncryptedFiles";
            this.textBox_EncryptedFiles.Size = new System.Drawing.Size(390, 23);
            this.textBox_EncryptedFiles.TabIndex = 0;
            this.textBox_EncryptedFiles.DoubleClick += new System.EventHandler(this.textBox_EncryptedFiles_DoubleClick);
            // 
            // button_EncryptedFiles
            // 
            this.button_EncryptedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_EncryptedFiles.Image = ((System.Drawing.Image)(resources.GetObject("button_EncryptedFiles.Image")));
            this.button_EncryptedFiles.Location = new System.Drawing.Point(399, 3);
            this.button_EncryptedFiles.Name = "button_EncryptedFiles";
            this.button_EncryptedFiles.Size = new System.Drawing.Size(24, 24);
            this.button_EncryptedFiles.TabIndex = 1;
            this.button_EncryptedFiles.UseVisualStyleBackColor = true;
            this.button_EncryptedFiles.Click += new System.EventHandler(this.button_EncryptedFiles_Click);
            // 
            // treeView_EncryptedFiles
            // 
            this.tableLayoutPanel_EncryptedFiles.SetColumnSpan(this.treeView_EncryptedFiles, 2);
            this.treeView_EncryptedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_EncryptedFiles.Location = new System.Drawing.Point(3, 33);
            this.treeView_EncryptedFiles.Name = "treeView_EncryptedFiles";
            this.treeView_EncryptedFiles.Size = new System.Drawing.Size(420, 292);
            this.treeView_EncryptedFiles.TabIndex = 2;
            this.treeView_EncryptedFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_EncryptedFiles_AfterSelect);
            // 
            // label_EncryptedFiles
            // 
            this.label_EncryptedFiles.AutoSize = true;
            this.label_EncryptedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_EncryptedFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EncryptedFiles.Location = new System.Drawing.Point(435, 0);
            this.label_EncryptedFiles.Name = "label_EncryptedFiles";
            this.label_EncryptedFiles.Size = new System.Drawing.Size(426, 15);
            this.label_EncryptedFiles.TabIndex = 1;
            this.label_EncryptedFiles.Text = "Encrypted files";
            this.label_EncryptedFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_BackupFiles
            // 
            this.label_BackupFiles.AutoSize = true;
            this.label_BackupFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_BackupFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BackupFiles.Location = new System.Drawing.Point(3, 0);
            this.label_BackupFiles.Name = "label_BackupFiles";
            this.label_BackupFiles.Size = new System.Drawing.Size(426, 15);
            this.label_BackupFiles.TabIndex = 0;
            this.label_BackupFiles.Text = "Backup files";
            this.label_BackupFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_BackupFiles
            // 
            this.tableLayoutPanel_BackupFiles.ColumnCount = 2;
            this.tableLayoutPanel_BackupFiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_BackupFiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_BackupFiles.Controls.Add(this.textBox_BackupFiles, 0, 0);
            this.tableLayoutPanel_BackupFiles.Controls.Add(this.button_BackupFiles, 1, 0);
            this.tableLayoutPanel_BackupFiles.Controls.Add(this.treeView_BackupFiles, 0, 1);
            this.tableLayoutPanel_BackupFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_BackupFiles.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel_BackupFiles.Name = "tableLayoutPanel_BackupFiles";
            this.tableLayoutPanel_BackupFiles.RowCount = 2;
            this.tableLayoutPanel_BackupFiles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_BackupFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_BackupFiles.Size = new System.Drawing.Size(426, 328);
            this.tableLayoutPanel_BackupFiles.TabIndex = 2;
            // 
            // textBox_BackupFiles
            // 
            this.textBox_BackupFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_BackupFiles.Location = new System.Drawing.Point(3, 3);
            this.textBox_BackupFiles.Name = "textBox_BackupFiles";
            this.textBox_BackupFiles.Size = new System.Drawing.Size(390, 23);
            this.textBox_BackupFiles.TabIndex = 0;
            this.textBox_BackupFiles.DoubleClick += new System.EventHandler(this.textBox_BackupFiles_DoubleClick);
            // 
            // button_BackupFiles
            // 
            this.button_BackupFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_BackupFiles.Image = ((System.Drawing.Image)(resources.GetObject("button_BackupFiles.Image")));
            this.button_BackupFiles.Location = new System.Drawing.Point(399, 3);
            this.button_BackupFiles.Name = "button_BackupFiles";
            this.button_BackupFiles.Size = new System.Drawing.Size(24, 24);
            this.button_BackupFiles.TabIndex = 1;
            this.button_BackupFiles.UseVisualStyleBackColor = true;
            this.button_BackupFiles.Click += new System.EventHandler(this.button_BackupFiles_Click);
            // 
            // treeView_BackupFiles
            // 
            this.tableLayoutPanel_BackupFiles.SetColumnSpan(this.treeView_BackupFiles, 2);
            this.treeView_BackupFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_BackupFiles.Location = new System.Drawing.Point(3, 33);
            this.treeView_BackupFiles.Name = "treeView_BackupFiles";
            this.treeView_BackupFiles.Size = new System.Drawing.Size(420, 292);
            this.treeView_BackupFiles.TabIndex = 2;
            this.treeView_BackupFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_BackupFiles_AfterSelect);
            // 
            // tabPage_Log
            // 
            this.tabPage_Log.Controls.Add(this.toolStripContainer_Log);
            this.tabPage_Log.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Log.Name = "tabPage_Log";
            this.tabPage_Log.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Log.Size = new System.Drawing.Size(876, 480);
            this.tabPage_Log.TabIndex = 2;
            this.tabPage_Log.Text = "Log";
            this.tabPage_Log.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer_Log
            // 
            this.toolStripContainer_Log.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer_Log.ContentPanel
            // 
            this.toolStripContainer_Log.ContentPanel.Controls.Add(this.richTextBox_Log);
            this.toolStripContainer_Log.ContentPanel.Size = new System.Drawing.Size(870, 449);
            this.toolStripContainer_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer_Log.LeftToolStripPanelVisible = false;
            this.toolStripContainer_Log.Location = new System.Drawing.Point(3, 3);
            this.toolStripContainer_Log.Name = "toolStripContainer_Log";
            this.toolStripContainer_Log.RightToolStripPanelVisible = false;
            this.toolStripContainer_Log.Size = new System.Drawing.Size(870, 474);
            this.toolStripContainer_Log.TabIndex = 0;
            this.toolStripContainer_Log.Text = "Log";
            // 
            // toolStripContainer_Log.TopToolStripPanel
            // 
            this.toolStripContainer_Log.TopToolStripPanel.Controls.Add(this.toolStrip_Log);
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Log.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.ReadOnly = true;
            this.richTextBox_Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox_Log.Size = new System.Drawing.Size(870, 449);
            this.richTextBox_Log.TabIndex = 0;
            this.richTextBox_Log.Text = "";
            this.richTextBox_Log.WordWrap = false;
            // 
            // toolStrip_Log
            // 
            this.toolStrip_Log.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_Log.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_ClearLog,
            this.toolStripButton_SaveLog,
            this.toolStripSeparator_Log_01,
            this.toolStripButton_AutoScroll,
            this.toolStripButton_AutoLineBreak});
            this.toolStrip_Log.Location = new System.Drawing.Point(3, 0);
            this.toolStrip_Log.Name = "toolStrip_Log";
            this.toolStrip_Log.Size = new System.Drawing.Size(255, 25);
            this.toolStrip_Log.TabIndex = 0;
            // 
            // toolStripButton_ClearLog
            // 
            this.toolStripButton_ClearLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ClearLog.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ClearLog.Image")));
            this.toolStripButton_ClearLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ClearLog.Name = "toolStripButton_ClearLog";
            this.toolStripButton_ClearLog.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_ClearLog.Text = "Clear";
            this.toolStripButton_ClearLog.ToolTipText = "Clear log";
            this.toolStripButton_ClearLog.Click += new System.EventHandler(this.toolStripButton_ClearLog_Click);
            // 
            // toolStripButton_SaveLog
            // 
            this.toolStripButton_SaveLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_SaveLog.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_SaveLog.Image")));
            this.toolStripButton_SaveLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_SaveLog.Name = "toolStripButton_SaveLog";
            this.toolStripButton_SaveLog.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_SaveLog.Text = "Save";
            this.toolStripButton_SaveLog.ToolTipText = "Save log";
            this.toolStripButton_SaveLog.Click += new System.EventHandler(this.toolStripButton_SaveLog_Click);
            // 
            // toolStripSeparator_Log_01
            // 
            this.toolStripSeparator_Log_01.Name = "toolStripSeparator_Log_01";
            this.toolStripSeparator_Log_01.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_AutoScroll
            // 
            this.toolStripButton_AutoScroll.Checked = true;
            this.toolStripButton_AutoScroll.CheckOnClick = true;
            this.toolStripButton_AutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButton_AutoScroll.Image = global::DeadboltBackupRecovery.Properties.Resources.CheckBoxChecked;
            this.toolStripButton_AutoScroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_AutoScroll.Name = "toolStripButton_AutoScroll";
            this.toolStripButton_AutoScroll.Size = new System.Drawing.Size(84, 22);
            this.toolStripButton_AutoScroll.Text = "Auto scroll";
            this.toolStripButton_AutoScroll.ToolTipText = "Enable auto scroll";
            this.toolStripButton_AutoScroll.CheckedChanged += new System.EventHandler(this.toolStripButton_AutoScroll_CheckedChanged);
            // 
            // toolStripButton_AutoLineBreak
            // 
            this.toolStripButton_AutoLineBreak.CheckOnClick = true;
            this.toolStripButton_AutoLineBreak.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_AutoLineBreak.Image")));
            this.toolStripButton_AutoLineBreak.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_AutoLineBreak.Name = "toolStripButton_AutoLineBreak";
            this.toolStripButton_AutoLineBreak.Size = new System.Drawing.Size(107, 22);
            this.toolStripButton_AutoLineBreak.Text = "Auto line break";
            this.toolStripButton_AutoLineBreak.ToolTipText = "Enable auto line break";
            this.toolStripButton_AutoLineBreak.CheckedChanged += new System.EventHandler(this.toolStripButton_AutoLineBreak_CheckedChanged);
            // 
            // label_CurrentFile
            // 
            this.label_CurrentFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CurrentFile.AutoEllipsis = true;
            this.label_CurrentFile.Location = new System.Drawing.Point(12, 537);
            this.label_CurrentFile.Name = "label_CurrentFile";
            this.label_CurrentFile.Size = new System.Drawing.Size(732, 15);
            this.label_CurrentFile.TabIndex = 5;
            this.label_CurrentFile.Text = "Press \"Run recovery\" to start the process.";
            // 
            // Recovery
            // 
            this.AcceptButton = this.button_Run;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Run;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label_CurrentFile);
            this.Controls.Add(this.tabControl_Recovery);
            this.Controls.Add(this.progressBar_Recovery);
            this.Controls.Add(this.button_Run);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Recovery";
            this.Text = "Deadbolt Backup Recovery";
            this.Load += new System.EventHandler(this.Recovery_Load);
            this.groupBox_RecoveryBehaviour.ResumeLayout(false);
            this.tableLayoutPanel_RecoveryBehaviour.ResumeLayout(false);
            this.tableLayoutPanel_RecoveryBehaviour.PerformLayout();
            this.tabControl_Recovery.ResumeLayout(false);
            this.tabPage_Settings.ResumeLayout(false);
            this.tableLayoutPanel_Folders.ResumeLayout(false);
            this.tableLayoutPanel_Folders.PerformLayout();
            this.tableLayoutPanel_EncryptedFiles.ResumeLayout(false);
            this.tableLayoutPanel_EncryptedFiles.PerformLayout();
            this.tableLayoutPanel_BackupFiles.ResumeLayout(false);
            this.tableLayoutPanel_BackupFiles.PerformLayout();
            this.tabPage_Log.ResumeLayout(false);
            this.toolStripContainer_Log.ContentPanel.ResumeLayout(false);
            this.toolStripContainer_Log.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer_Log.TopToolStripPanel.PerformLayout();
            this.toolStripContainer_Log.ResumeLayout(false);
            this.toolStripContainer_Log.PerformLayout();
            this.toolStrip_Log.ResumeLayout(false);
            this.toolStrip_Log.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.GroupBox groupBox_RecoveryBehaviour;
        private System.Windows.Forms.ProgressBar progressBar_Recovery;
        private System.Windows.Forms.TabControl tabControl_Recovery;
        private System.Windows.Forms.TabPage tabPage_Settings;
        private System.Windows.Forms.Label label_CurrentFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Folders;
        private System.Windows.Forms.Label label_EncryptedFiles;
        private System.Windows.Forms.Label label_BackupFiles;
        private System.Windows.Forms.TabPage tabPage_Log;
        private System.Windows.Forms.ToolStripContainer toolStripContainer_Log;
        private System.Windows.Forms.ToolStrip toolStrip_Log;
        private System.Windows.Forms.ToolStripButton toolStripButton_ClearLog;
        private System.Windows.Forms.ToolStripButton toolStripButton_SaveLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_Log_01;
        private System.Windows.Forms.ToolStripButton toolStripButton_AutoScroll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_RecoveryBehaviour;
        private System.Windows.Forms.RichTextBox richTextBox_Log;
        private System.Windows.Forms.ToolStripButton toolStripButton_AutoLineBreak;
        private System.Windows.Forms.ComboBox comboBox_DeleteEncryptedFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_BackupFiles;
        private System.Windows.Forms.TextBox textBox_BackupFiles;
        private System.Windows.Forms.Button button_BackupFiles;
        private System.Windows.Forms.TreeView treeView_BackupFiles;
        private System.Windows.Forms.Label label_DeleteEncryptedFiles;
        private System.Windows.Forms.ComboBox comboBox_UnencryptedFilesExists;
        private System.Windows.Forms.Label label_UnencryptedFilesExists;
        private System.Windows.Forms.ComboBox comboBox_CopyMissingFiles;
        private System.Windows.Forms.Label label_CopyMissingFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_EncryptedFiles;
        private System.Windows.Forms.TextBox textBox_EncryptedFiles;
        private System.Windows.Forms.Button button_EncryptedFiles;
        private System.Windows.Forms.TreeView treeView_EncryptedFiles;
    }
}

