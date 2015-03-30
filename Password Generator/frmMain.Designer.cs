namespace Password_Generator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblNumOfChars = new System.Windows.Forms.Label();
            this.numericUpDownChars = new System.Windows.Forms.NumericUpDown();
            this.chkDigits = new System.Windows.Forms.CheckBox();
            this.chkUpperCaseLetters = new System.Windows.Forms.CheckBox();
            this.chkLowerCaseLetters = new System.Windows.Forms.CheckBox();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.grpCharsToUse = new System.Windows.Forms.GroupBox();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.grpRules = new System.Windows.Forms.GroupBox();
            this.pnlRules = new System.Windows.Forms.Panel();
            this.chkNoAdjacents = new System.Windows.Forms.CheckBox();
            this.chkNoRepeats = new System.Windows.Forms.CheckBox();
            this.chkCharOnce = new System.Windows.Forms.CheckBox();
            this.pnlNumberOfChars = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpMinimums = new System.Windows.Forms.GroupBox();
            this.numericUpDownSymbols = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownUpper = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLower = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDigits = new System.Windows.Forms.NumericUpDown();
            this.workerGeneratePassword = new System.ComponentModel.BackgroundWorker();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChars)).BeginInit();
            this.grpCharsToUse.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.grpRules.SuspendLayout();
            this.pnlRules.SuspendLayout();
            this.pnlNumberOfChars.SuspendLayout();
            this.grpMinimums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSymbols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigits)).BeginInit();
            this.statusMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumOfChars
            // 
            this.lblNumOfChars.AutoSize = true;
            this.lblNumOfChars.Location = new System.Drawing.Point(1, 7);
            this.lblNumOfChars.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumOfChars.Name = "lblNumOfChars";
            this.lblNumOfChars.Size = new System.Drawing.Size(148, 16);
            this.lblNumOfChars.TabIndex = 0;
            this.lblNumOfChars.Text = "Number of characters:";
            // 
            // numericUpDownChars
            // 
            this.numericUpDownChars.Location = new System.Drawing.Point(154, 5);
            this.numericUpDownChars.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDownChars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownChars.Name = "numericUpDownChars";
            this.numericUpDownChars.Size = new System.Drawing.Size(58, 23);
            this.numericUpDownChars.TabIndex = 1;
            this.numericUpDownChars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownChars.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkDigits
            // 
            this.chkDigits.AutoSize = true;
            this.chkDigits.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkDigits.Location = new System.Drawing.Point(2, 19);
            this.chkDigits.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkDigits.Name = "chkDigits";
            this.chkDigits.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkDigits.Size = new System.Drawing.Size(149, 26);
            this.chkDigits.TabIndex = 2;
            this.chkDigits.Text = "Digits";
            this.chkDigits.UseVisualStyleBackColor = true;
            this.chkDigits.CheckedChanged += new System.EventHandler(this.chkCharsToUse_CheckedChanged);
            // 
            // chkUpperCaseLetters
            // 
            this.chkUpperCaseLetters.AutoSize = true;
            this.chkUpperCaseLetters.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkUpperCaseLetters.Location = new System.Drawing.Point(2, 71);
            this.chkUpperCaseLetters.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkUpperCaseLetters.Name = "chkUpperCaseLetters";
            this.chkUpperCaseLetters.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkUpperCaseLetters.Size = new System.Drawing.Size(149, 26);
            this.chkUpperCaseLetters.TabIndex = 3;
            this.chkUpperCaseLetters.Text = "Upper case letters";
            this.chkUpperCaseLetters.UseVisualStyleBackColor = true;
            this.chkUpperCaseLetters.CheckedChanged += new System.EventHandler(this.chkCharsToUse_CheckedChanged);
            // 
            // chkLowerCaseLetters
            // 
            this.chkLowerCaseLetters.AutoSize = true;
            this.chkLowerCaseLetters.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkLowerCaseLetters.Location = new System.Drawing.Point(2, 45);
            this.chkLowerCaseLetters.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkLowerCaseLetters.Name = "chkLowerCaseLetters";
            this.chkLowerCaseLetters.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkLowerCaseLetters.Size = new System.Drawing.Size(149, 26);
            this.chkLowerCaseLetters.TabIndex = 4;
            this.chkLowerCaseLetters.Text = "Lower case letters";
            this.chkLowerCaseLetters.UseVisualStyleBackColor = true;
            this.chkLowerCaseLetters.CheckedChanged += new System.EventHandler(this.chkCharsToUse_CheckedChanged);
            // 
            // chkSymbols
            // 
            this.chkSymbols.AutoSize = true;
            this.chkSymbols.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkSymbols.Location = new System.Drawing.Point(2, 97);
            this.chkSymbols.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkSymbols.Size = new System.Drawing.Size(149, 26);
            this.chkSymbols.TabIndex = 5;
            this.chkSymbols.Text = "Symbols";
            this.chkSymbols.UseVisualStyleBackColor = true;
            this.chkSymbols.CheckedChanged += new System.EventHandler(this.chkCharsToUse_CheckedChanged);
            // 
            // grpCharsToUse
            // 
            this.grpCharsToUse.Controls.Add(this.chkSymbols);
            this.grpCharsToUse.Controls.Add(this.chkUpperCaseLetters);
            this.grpCharsToUse.Controls.Add(this.chkLowerCaseLetters);
            this.grpCharsToUse.Controls.Add(this.chkDigits);
            this.grpCharsToUse.Location = new System.Drawing.Point(11, 30);
            this.grpCharsToUse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpCharsToUse.Name = "grpCharsToUse";
            this.grpCharsToUse.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpCharsToUse.Size = new System.Drawing.Size(153, 138);
            this.grpCharsToUse.TabIndex = 6;
            this.grpCharsToUse.TabStop = false;
            this.grpCharsToUse.Text = "Characters to use";
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(509, 24);
            this.menuMain.TabIndex = 7;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(162, 11);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(325, 26);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(2, 6);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(153, 37);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.EnabledChanged += new System.EventHandler(this.btnGenerate_EnabledChanged);
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // grpRules
            // 
            this.grpRules.Controls.Add(this.pnlRules);
            this.grpRules.Controls.Add(this.pnlNumberOfChars);
            this.grpRules.Location = new System.Drawing.Point(280, 30);
            this.grpRules.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpRules.Name = "grpRules";
            this.grpRules.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpRules.Size = new System.Drawing.Size(222, 138);
            this.grpRules.TabIndex = 10;
            this.grpRules.TabStop = false;
            this.grpRules.Text = "Rules";
            // 
            // pnlRules
            // 
            this.pnlRules.Controls.Add(this.chkNoAdjacents);
            this.pnlRules.Controls.Add(this.chkNoRepeats);
            this.pnlRules.Controls.Add(this.chkCharOnce);
            this.pnlRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRules.Location = new System.Drawing.Point(2, 53);
            this.pnlRules.Name = "pnlRules";
            this.pnlRules.Size = new System.Drawing.Size(218, 82);
            this.pnlRules.TabIndex = 8;
            // 
            // chkNoAdjacents
            // 
            this.chkNoAdjacents.AutoSize = true;
            this.chkNoAdjacents.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkNoAdjacents.Location = new System.Drawing.Point(0, 52);
            this.chkNoAdjacents.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkNoAdjacents.Name = "chkNoAdjacents";
            this.chkNoAdjacents.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkNoAdjacents.Size = new System.Drawing.Size(218, 26);
            this.chkNoAdjacents.TabIndex = 6;
            this.chkNoAdjacents.Text = "No adjacent characters";
            this.toolTip.SetToolTip(this.chkNoAdjacents, "E.g. no \"1qaz2wsx\" or \"654#@!\"");
            this.chkNoAdjacents.UseVisualStyleBackColor = true;
            this.chkNoAdjacents.CheckedChanged += new System.EventHandler(this.chkNoAdjacents_CheckedChanged);
            // 
            // chkNoRepeats
            // 
            this.chkNoRepeats.AutoSize = true;
            this.chkNoRepeats.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkNoRepeats.Location = new System.Drawing.Point(0, 26);
            this.chkNoRepeats.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkNoRepeats.Name = "chkNoRepeats";
            this.chkNoRepeats.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkNoRepeats.Size = new System.Drawing.Size(218, 26);
            this.chkNoRepeats.TabIndex = 4;
            this.chkNoRepeats.Text = "No consecutive characters";
            this.toolTip.SetToolTip(this.chkNoRepeats, "E.g. no \"kn2222m\"");
            this.chkNoRepeats.UseVisualStyleBackColor = true;
            // 
            // chkCharOnce
            // 
            this.chkCharOnce.AutoSize = true;
            this.chkCharOnce.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkCharOnce.Location = new System.Drawing.Point(0, 0);
            this.chkCharOnce.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkCharOnce.Name = "chkCharOnce";
            this.chkCharOnce.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkCharOnce.Size = new System.Drawing.Size(218, 26);
            this.chkCharOnce.TabIndex = 7;
            this.chkCharOnce.Text = "Each character once only";
            this.toolTip.SetToolTip(this.chkCharOnce, "E.g. no \"AkAqAtA\"");
            this.chkCharOnce.UseVisualStyleBackColor = true;
            this.chkCharOnce.CheckedChanged += new System.EventHandler(this.chkCharOnce_CheckedChanged);
            // 
            // pnlNumberOfChars
            // 
            this.pnlNumberOfChars.Controls.Add(this.lblNumOfChars);
            this.pnlNumberOfChars.Controls.Add(this.numericUpDownChars);
            this.pnlNumberOfChars.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNumberOfChars.Location = new System.Drawing.Point(2, 19);
            this.pnlNumberOfChars.Name = "pnlNumberOfChars";
            this.pnlNumberOfChars.Size = new System.Drawing.Size(218, 34);
            this.pnlNumberOfChars.TabIndex = 5;
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // grpMinimums
            // 
            this.grpMinimums.Controls.Add(this.numericUpDownSymbols);
            this.grpMinimums.Controls.Add(this.numericUpDownUpper);
            this.grpMinimums.Controls.Add(this.numericUpDownLower);
            this.grpMinimums.Controls.Add(this.numericUpDownDigits);
            this.grpMinimums.Location = new System.Drawing.Point(178, 30);
            this.grpMinimums.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpMinimums.Name = "grpMinimums";
            this.grpMinimums.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpMinimums.Size = new System.Drawing.Size(87, 138);
            this.grpMinimums.TabIndex = 11;
            this.grpMinimums.TabStop = false;
            this.grpMinimums.Text = "Minimums";
            // 
            // numericUpDownSymbols
            // 
            this.numericUpDownSymbols.Location = new System.Drawing.Point(13, 99);
            this.numericUpDownSymbols.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDownSymbols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSymbols.Name = "numericUpDownSymbols";
            this.numericUpDownSymbols.Size = new System.Drawing.Size(58, 23);
            this.numericUpDownSymbols.TabIndex = 5;
            this.numericUpDownSymbols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownSymbols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSymbols.Visible = false;
            this.numericUpDownSymbols.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownUpper
            // 
            this.numericUpDownUpper.Location = new System.Drawing.Point(13, 73);
            this.numericUpDownUpper.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDownUpper.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownUpper.Name = "numericUpDownUpper";
            this.numericUpDownUpper.Size = new System.Drawing.Size(58, 23);
            this.numericUpDownUpper.TabIndex = 4;
            this.numericUpDownUpper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownUpper.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownUpper.Visible = false;
            this.numericUpDownUpper.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownLower
            // 
            this.numericUpDownLower.Location = new System.Drawing.Point(13, 47);
            this.numericUpDownLower.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDownLower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLower.Name = "numericUpDownLower";
            this.numericUpDownLower.Size = new System.Drawing.Size(58, 23);
            this.numericUpDownLower.TabIndex = 3;
            this.numericUpDownLower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownLower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLower.Visible = false;
            this.numericUpDownLower.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownDigits
            // 
            this.numericUpDownDigits.Location = new System.Drawing.Point(13, 21);
            this.numericUpDownDigits.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDownDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDigits.Name = "numericUpDownDigits";
            this.numericUpDownDigits.Size = new System.Drawing.Size(58, 23);
            this.numericUpDownDigits.TabIndex = 2;
            this.numericUpDownDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDigits.Visible = false;
            this.numericUpDownDigits.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // workerGeneratePassword
            // 
            this.workerGeneratePassword.WorkerSupportsCancellation = true;
            this.workerGeneratePassword.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerGeneratePassword_DoWork);
            this.workerGeneratePassword.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerGeneratePassword_RunWorkerCompleted);
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusMain.Location = new System.Drawing.Point(0, 224);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(509, 22);
            this.statusMain.TabIndex = 12;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = " Ready";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Location = new System.Drawing.Point(11, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 49);
            this.panel1.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 246);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.grpMinimums);
            this.Controls.Add(this.grpRules);
            this.Controls.Add(this.grpCharsToUse);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChars)).EndInit();
            this.grpCharsToUse.ResumeLayout(false);
            this.grpCharsToUse.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.grpRules.ResumeLayout(false);
            this.pnlRules.ResumeLayout(false);
            this.pnlRules.PerformLayout();
            this.pnlNumberOfChars.ResumeLayout(false);
            this.pnlNumberOfChars.PerformLayout();
            this.grpMinimums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSymbols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigits)).EndInit();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumOfChars;
        private System.Windows.Forms.NumericUpDown numericUpDownChars;
        private System.Windows.Forms.CheckBox chkDigits;
        private System.Windows.Forms.CheckBox chkUpperCaseLetters;
        private System.Windows.Forms.CheckBox chkLowerCaseLetters;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.GroupBox grpCharsToUse;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox grpRules;
        private System.Windows.Forms.CheckBox chkNoRepeats;
        private System.Windows.Forms.Panel pnlNumberOfChars;
        private System.Windows.Forms.CheckBox chkNoAdjacents;
        private System.Windows.Forms.CheckBox chkCharOnce;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlRules;
        private System.Windows.Forms.GroupBox grpMinimums;
        private System.Windows.Forms.NumericUpDown numericUpDownSymbols;
        private System.Windows.Forms.NumericUpDown numericUpDownUpper;
        private System.Windows.Forms.NumericUpDown numericUpDownLower;
        private System.Windows.Forms.NumericUpDown numericUpDownDigits;
        private System.ComponentModel.BackgroundWorker workerGeneratePassword;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

