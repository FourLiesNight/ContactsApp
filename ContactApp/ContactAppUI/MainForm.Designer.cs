namespace ContactAppUI
{
    partial class MainForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.VKLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.BirthdayTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.EditButsPanel = new System.Windows.Forms.Panel();
            this.EditPicture = new System.Windows.Forms.PictureBox();
            this.MinusPicture = new System.Windows.Forms.PictureBox();
            this.PlusPicture = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.MenuStrip.SuspendLayout();
            this.DataPanel.SuspendLayout();
            this.EditButsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinusPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlusPicture)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1006, 30);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.deleteContactToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.addContactToolStripMenuItem_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.editContactToolStripMenuItem_Click);
            // 
            // deleteContactToolStripMenuItem
            // 
            this.deleteContactToolStripMenuItem.Name = "deleteContactToolStripMenuItem";
            this.deleteContactToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.deleteContactToolStripMenuItem.Text = "Delete Contact";
            this.deleteContactToolStripMenuItem.Click += new System.EventHandler(this.deleteContactToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(5, 6);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(36, 16);
            this.FindLabel.TabIndex = 2;
            this.FindLabel.Text = "Find:";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(47, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(200, 22);
            this.FindTextBox.TabIndex = 3;
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.ItemHeight = 16;
            this.ContactsListBox.Location = new System.Drawing.Point(12, 31);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.ScrollAlwaysVisible = true;
            this.ContactsListBox.Size = new System.Drawing.Size(262, 500);
            this.ContactsListBox.TabIndex = 4;
            this.ContactsListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContactsListBox_MouseClick);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(10, 18);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(64, 16);
            this.SurnameLabel.TabIndex = 5;
            this.SurnameLabel.Text = "Surname:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(27, 61);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(47, 16);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name:";
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(18, 240);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(56, 16);
            this.VKLabel.TabIndex = 7;
            this.VKLabel.Text = "VK.com:";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(15, 111);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(59, 16);
            this.BirthdayLabel.TabIndex = 8;
            this.BirthdayLabel.Text = "Birthday:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(25, 154);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(49, 16);
            this.PhoneLabel.TabIndex = 9;
            this.PhoneLabel.Text = "Phone:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(30, 197);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(44, 16);
            this.EmailLabel.TabIndex = 10;
            this.EmailLabel.Text = "Email:";
            // 
            // BirthdayTimePicker
            // 
            this.BirthdayTimePicker.Location = new System.Drawing.Point(80, 111);
            this.BirthdayTimePicker.Name = "BirthdayTimePicker";
            this.BirthdayTimePicker.Size = new System.Drawing.Size(185, 22);
            this.BirthdayTimePicker.TabIndex = 11;
            this.BirthdayTimePicker.Value = new System.DateTime(2024, 5, 24, 0, 0, 0, 0);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(80, 18);
            this.SurnameTextBox.MaxLength = 25643;
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.ReadOnly = true;
            this.SurnameTextBox.Size = new System.Drawing.Size(511, 22);
            this.SurnameTextBox.TabIndex = 12;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(80, 61);
            this.NameTextBox.MaxLength = 25643;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(511, 22);
            this.NameTextBox.TabIndex = 13;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(80, 151);
            this.PhoneTextBox.MaxLength = 25643;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.ReadOnly = true;
            this.PhoneTextBox.Size = new System.Drawing.Size(511, 22);
            this.PhoneTextBox.TabIndex = 14;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(80, 197);
            this.EmailTextBox.MaxLength = 25643;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(511, 22);
            this.EmailTextBox.TabIndex = 15;
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(80, 240);
            this.VKTextBox.MaxLength = 25643;
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.ReadOnly = true;
            this.VKTextBox.Size = new System.Drawing.Size(511, 22);
            this.VKTextBox.TabIndex = 16;
            // 
            // DataPanel
            // 
            this.DataPanel.AutoSize = true;
            this.DataPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DataPanel.Controls.Add(this.SurnameTextBox);
            this.DataPanel.Controls.Add(this.SurnameLabel);
            this.DataPanel.Controls.Add(this.VKTextBox);
            this.DataPanel.Controls.Add(this.NameLabel);
            this.DataPanel.Controls.Add(this.EmailTextBox);
            this.DataPanel.Controls.Add(this.VKLabel);
            this.DataPanel.Controls.Add(this.PhoneTextBox);
            this.DataPanel.Controls.Add(this.BirthdayLabel);
            this.DataPanel.Controls.Add(this.NameTextBox);
            this.DataPanel.Controls.Add(this.PhoneLabel);
            this.DataPanel.Controls.Add(this.EmailLabel);
            this.DataPanel.Controls.Add(this.BirthdayTimePicker);
            this.DataPanel.Location = new System.Drawing.Point(304, 58);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(594, 265);
            this.DataPanel.TabIndex = 21;
            // 
            // EditButsPanel
            // 
            this.EditButsPanel.Controls.Add(this.EditPicture);
            this.EditButsPanel.Controls.Add(this.MinusPicture);
            this.EditButsPanel.Controls.Add(this.PlusPicture);
            this.EditButsPanel.Location = new System.Drawing.Point(37, 570);
            this.EditButsPanel.Name = "EditButsPanel";
            this.EditButsPanel.Size = new System.Drawing.Size(151, 36);
            this.EditButsPanel.TabIndex = 23;
            // 
            // EditPicture
            // 
            this.EditPicture.Image = global::ContactAppUI.Properties.Resources._3597075;
            this.EditPicture.Location = new System.Drawing.Point(63, 8);
            this.EditPicture.Name = "EditPicture";
            this.EditPicture.Size = new System.Drawing.Size(25, 25);
            this.EditPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditPicture.TabIndex = 21;
            this.EditPicture.TabStop = false;
            // 
            // MinusPicture
            // 
            this.MinusPicture.Image = global::ContactAppUI.Properties.Resources.pngtree_minus_vector_icon_png_image_696413;
            this.MinusPicture.Location = new System.Drawing.Point(106, 8);
            this.MinusPicture.Name = "MinusPicture";
            this.MinusPicture.Size = new System.Drawing.Size(25, 25);
            this.MinusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinusPicture.TabIndex = 22;
            this.MinusPicture.TabStop = false;
            // 
            // PlusPicture
            // 
            this.PlusPicture.Image = global::ContactAppUI.Properties.Resources.images;
            this.PlusPicture.Location = new System.Drawing.Point(18, 8);
            this.PlusPicture.Name = "PlusPicture";
            this.PlusPicture.Size = new System.Drawing.Size(25, 25);
            this.PlusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlusPicture.TabIndex = 20;
            this.PlusPicture.TabStop = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.AutoSize = true;
            this.LeftPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LeftPanel.Controls.Add(this.FindLabel);
            this.LeftPanel.Controls.Add(this.EditButsPanel);
            this.LeftPanel.Controls.Add(this.ContactsListBox);
            this.LeftPanel.Controls.Add(this.FindTextBox);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 30);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(277, 643);
            this.LeftPanel.TabIndex = 24;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactApp";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.EditButsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinusPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlusPicture)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContactToolStripMenuItem;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.DateTimePicker BirthdayTimePicker;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.PictureBox PlusPicture;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Panel EditButsPanel;
        private System.Windows.Forms.PictureBox EditPicture;
        private System.Windows.Forms.PictureBox MinusPicture;
        private System.Windows.Forms.Panel LeftPanel;
    }
}