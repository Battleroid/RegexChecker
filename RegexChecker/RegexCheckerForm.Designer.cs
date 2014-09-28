namespace RegexChecker
{
    partial class RegexCheckerForm
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
            this.contentBox = new System.Windows.Forms.RichTextBox();
            this.matchesList = new System.Windows.Forms.ListBox();
            this.regexBox = new System.Windows.Forms.TextBox();
            this.findMatchesBtn = new System.Windows.Forms.Button();
            this.saveExpressionBtn = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadExpressionToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoreCaseCheckbox = new System.Windows.Forms.CheckBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(12, 53);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(444, 394);
            this.contentBox.TabIndex = 0;
            this.contentBox.Text = "";
            // 
            // matchesList
            // 
            this.matchesList.FormattingEnabled = true;
            this.matchesList.Location = new System.Drawing.Point(461, 54);
            this.matchesList.Name = "matchesList";
            this.matchesList.Size = new System.Drawing.Size(150, 394);
            this.matchesList.TabIndex = 1;
            this.matchesList.SelectedIndexChanged += new System.EventHandler(this.matchesList_SelectedIndexChanged);
            // 
            // regexBox
            // 
            this.regexBox.Location = new System.Drawing.Point(12, 27);
            this.regexBox.Name = "regexBox";
            this.regexBox.Size = new System.Drawing.Size(252, 20);
            this.regexBox.TabIndex = 2;
            // 
            // findMatchesBtn
            // 
            this.findMatchesBtn.Location = new System.Drawing.Point(355, 25);
            this.findMatchesBtn.Name = "findMatchesBtn";
            this.findMatchesBtn.Size = new System.Drawing.Size(101, 21);
            this.findMatchesBtn.TabIndex = 3;
            this.findMatchesBtn.Text = "Find Matches";
            this.findMatchesBtn.UseVisualStyleBackColor = true;
            this.findMatchesBtn.Click += new System.EventHandler(this.findMatchesBtn_Click);
            // 
            // saveExpressionBtn
            // 
            this.saveExpressionBtn.Location = new System.Drawing.Point(462, 25);
            this.saveExpressionBtn.Name = "saveExpressionBtn";
            this.saveExpressionBtn.Size = new System.Drawing.Size(149, 21);
            this.saveExpressionBtn.TabIndex = 4;
            this.saveExpressionBtn.Text = "Save Expression";
            this.saveExpressionBtn.UseVisualStyleBackColor = true;
            this.saveExpressionBtn.Click += new System.EventHandler(this.saveExpressionBtn_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(623, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadExpressionToolStripMenu,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.saveToolStripMenuItem.Text = "Save As ...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadExpressionToolStripMenu
            // 
            this.loadExpressionToolStripMenu.Name = "loadExpressionToolStripMenu";
            this.loadExpressionToolStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadExpressionToolStripMenu.Size = new System.Drawing.Size(232, 22);
            this.loadExpressionToolStripMenu.Text = "Load from ...";
            this.loadExpressionToolStripMenu.Click += new System.EventHandler(this.loadExpressionToolStripMenu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.toolStripMenuItem1.Text = "Append from ...";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(229, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMatchesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewMatchesToolStripMenuItem
            // 
            this.viewMatchesToolStripMenuItem.Name = "viewMatchesToolStripMenuItem";
            this.viewMatchesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.viewMatchesToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.viewMatchesToolStripMenuItem.Text = "View Expressions";
            this.viewMatchesToolStripMenuItem.Click += new System.EventHandler(this.viewMatchesToolStripMenuItem_Click);
            // 
            // ignoreCaseCheckbox
            // 
            this.ignoreCaseCheckbox.AutoSize = true;
            this.ignoreCaseCheckbox.Location = new System.Drawing.Point(270, 29);
            this.ignoreCaseCheckbox.Name = "ignoreCaseCheckbox";
            this.ignoreCaseCheckbox.Size = new System.Drawing.Size(83, 17);
            this.ignoreCaseCheckbox.TabIndex = 6;
            this.ignoreCaseCheckbox.Text = "Ignore Case";
            this.ignoreCaseCheckbox.UseVisualStyleBackColor = true;
            // 
            // RegexCheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 457);
            this.Controls.Add(this.ignoreCaseCheckbox);
            this.Controls.Add(this.saveExpressionBtn);
            this.Controls.Add(this.findMatchesBtn);
            this.Controls.Add(this.regexBox);
            this.Controls.Add(this.matchesList);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "RegexCheckerForm";
            this.Text = "RegexChecker";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox contentBox;
        private System.Windows.Forms.ListBox matchesList;
        private System.Windows.Forms.Button findMatchesBtn;
        private System.Windows.Forms.Button saveExpressionBtn;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMatchesToolStripMenuItem;
        public System.Windows.Forms.TextBox regexBox;
        private System.Windows.Forms.ToolStripMenuItem loadExpressionToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.CheckBox ignoreCaseCheckbox;

    }
}

