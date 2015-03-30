namespace Password_Generator
{
    partial class frmSettings
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
            this.chkListSymbols = new System.Windows.Forms.CheckedListBox();
            this.grpKeyboard = new System.Windows.Forms.GroupBox();
            this.lstLayouts = new System.Windows.Forms.ListBox();
            this.grpSymbols = new System.Windows.Forms.GroupBox();
            this.btnSelectNone = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpKeyboard.SuspendLayout();
            this.grpSymbols.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkListSymbols
            // 
            this.chkListSymbols.CheckOnClick = true;
            this.chkListSymbols.ColumnWidth = 90;
            this.chkListSymbols.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkListSymbols.Items.AddRange(new object[] {
            "\'",
            "-",
            "!",
            "\"",
            "#",
            "$",
            "%",
            "&",
            "(",
            ")",
            "*",
            ",",
            ".",
            "/",
            ":",
            ";",
            "?",
            "@",
            "[",
            "\\",
            "]",
            "^",
            "_",
            "`",
            "{",
            "|",
            "}",
            "~",
            "+",
            "<",
            "=",
            ">"});
            this.chkListSymbols.Location = new System.Drawing.Point(7, 23);
            this.chkListSymbols.MultiColumn = true;
            this.chkListSymbols.Name = "chkListSymbols";
            this.chkListSymbols.Size = new System.Drawing.Size(364, 148);
            this.chkListSymbols.TabIndex = 2;
            // 
            // grpKeyboard
            // 
            this.grpKeyboard.Controls.Add(this.lstLayouts);
            this.grpKeyboard.Location = new System.Drawing.Point(12, 12);
            this.grpKeyboard.Name = "grpKeyboard";
            this.grpKeyboard.Padding = new System.Windows.Forms.Padding(7);
            this.grpKeyboard.Size = new System.Drawing.Size(139, 219);
            this.grpKeyboard.TabIndex = 0;
            this.grpKeyboard.TabStop = false;
            this.grpKeyboard.Text = "Keyboard Layout";
            // 
            // lstLayouts
            // 
            this.lstLayouts.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstLayouts.FormattingEnabled = true;
            this.lstLayouts.ItemHeight = 16;
            this.lstLayouts.Items.AddRange(new object[] {
            "QWERTY"});
            this.lstLayouts.Location = new System.Drawing.Point(7, 23);
            this.lstLayouts.Name = "lstLayouts";
            this.lstLayouts.Size = new System.Drawing.Size(125, 180);
            this.lstLayouts.TabIndex = 2;
            // 
            // grpSymbols
            // 
            this.grpSymbols.Controls.Add(this.btnSelectNone);
            this.grpSymbols.Controls.Add(this.btnSelectAll);
            this.grpSymbols.Controls.Add(this.chkListSymbols);
            this.grpSymbols.Location = new System.Drawing.Point(157, 12);
            this.grpSymbols.Name = "grpSymbols";
            this.grpSymbols.Padding = new System.Windows.Forms.Padding(7);
            this.grpSymbols.Size = new System.Drawing.Size(378, 219);
            this.grpSymbols.TabIndex = 3;
            this.grpSymbols.TabStop = false;
            this.grpSymbols.Text = "Symbols to use";
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(116, 177);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(100, 25);
            this.btnSelectNone.TabIndex = 4;
            this.btnSelectNone.Text = "Select none";
            this.btnSelectNone.UseVisualStyleBackColor = true;
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(10, 177);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(100, 25);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "Select all";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(444, 237);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 31);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(320, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 280);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpSymbols);
            this.Controls.Add(this.grpKeyboard);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.grpKeyboard.ResumeLayout(false);
            this.grpSymbols.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListSymbols;
        private System.Windows.Forms.GroupBox grpKeyboard;
        private System.Windows.Forms.ListBox lstLayouts;
        private System.Windows.Forms.GroupBox grpSymbols;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelectNone;

    }
}