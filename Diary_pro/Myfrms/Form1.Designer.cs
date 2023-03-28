namespace Diary_pro
{
    partial class LashonsDiary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LashonsDiary));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dropdownBackground = new System.Windows.Forms.ComboBox();
            this.lblVersion2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lockCM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lockApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tsbtnAddMemo = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnTools = new System.Windows.Forms.ToolStripDropDownButton();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnAbout = new System.Windows.Forms.ToolStripDropDownButton();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDay2 = new System.Windows.Forms.Label();
            this.lblDayOfWeek2 = new System.Windows.Forms.Label();
            this.lblMonth2 = new System.Windows.Forms.Label();
            this.lblYear2 = new System.Windows.Forms.Label();
            this.btnShowDsk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.lockCM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.btnShowDsk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 572);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblName);
            this.panel4.Controls.Add(this.lblUserName);
            this.panel4.Controls.Add(this.ImageBox2);
            this.panel4.Location = new System.Drawing.Point(-1, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 147);
            this.panel4.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(94, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(14, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "-";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(3, 122);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 16);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name:";
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Black;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTimer.Location = new System.Drawing.Point(-1, 30);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(200, 50);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "12:33:20";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dropdownBackground);
            this.panel2.Controls.Add(this.lblVersion2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblVersion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 47);
            this.panel2.TabIndex = 0;
            // 
            // dropdownBackground
            // 
            this.dropdownBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropdownBackground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropdownBackground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownBackground.FormattingEnabled = true;
            this.dropdownBackground.Location = new System.Drawing.Point(458, 21);
            this.dropdownBackground.Name = "dropdownBackground";
            this.dropdownBackground.Size = new System.Drawing.Size(117, 21);
            this.dropdownBackground.TabIndex = 1;
            this.dropdownBackground.SelectedIndexChanged += new System.EventHandler(this.dropdownBackground_SelectedIndexChanged);
            // 
            // lblVersion2
            // 
            this.lblVersion2.Location = new System.Drawing.Point(94, 22);
            this.lblVersion2.Name = "lblVersion2";
            this.lblVersion2.Size = new System.Drawing.Size(199, 23);
            this.lblVersion2.TabIndex = 0;
            this.lblVersion2.Text = "-";
            this.lblVersion2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(367, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Background:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(3, 22);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(85, 23);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Version:";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddMemo,
            this.tsbtnSearch,
            this.tsbtnSettings,
            this.tsbtnTools,
            this.tsbtnAbout});
            this.toolStrip1.Location = new System.Drawing.Point(200, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(635, 60);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lockCM
            // 
            this.lockCM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockApplicationToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.lockCM.Name = "lockCM";
            this.lockCM.Size = new System.Drawing.Size(164, 48);
            // 
            // lockApplicationToolStripMenuItem
            // 
            this.lockApplicationToolStripMenuItem.Name = "lockApplicationToolStripMenuItem";
            this.lockApplicationToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.lockApplicationToolStripMenuItem.Text = "Lock Application";
            this.lockApplicationToolStripMenuItem.Click += new System.EventHandler(this.lockApplicationToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(785, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(27, 23);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(812, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tsbtnAddMemo
            // 
            this.tsbtnAddMemo.AutoSize = false;
            this.tsbtnAddMemo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddMemo.Image")));
            this.tsbtnAddMemo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAddMemo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddMemo.Name = "tsbtnAddMemo";
            this.tsbtnAddMemo.Size = new System.Drawing.Size(110, 57);
            this.tsbtnAddMemo.Text = "Add Memo F2";
            this.tsbtnAddMemo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAddMemo.Click += new System.EventHandler(this.tsbtnAddMemo_Click);
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.AutoSize = false;
            this.tsbtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearch.Image")));
            this.tsbtnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(110, 57);
            this.tsbtnSearch.Text = "Search Memo F3";
            this.tsbtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSearch.Click += new System.EventHandler(this.tsbtnSearch_Click);
            // 
            // tsbtnSettings
            // 
            this.tsbtnSettings.AutoSize = false;
            this.tsbtnSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.tsbtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSettings.Image")));
            this.tsbtnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSettings.Name = "tsbtnSettings";
            this.tsbtnSettings.Size = new System.Drawing.Size(110, 57);
            this.tsbtnSettings.Text = "Settings F4";
            this.tsbtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSettings.Click += new System.EventHandler(this.tsbtnSettings_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // tsbtnTools
            // 
            this.tsbtnTools.AutoSize = false;
            this.tsbtnTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.tsbtnTools.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnTools.Image")));
            this.tsbtnTools.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTools.Name = "tsbtnTools";
            this.tsbtnTools.Size = new System.Drawing.Size(110, 57);
            this.tsbtnTools.Text = "Tools F5";
            this.tsbtnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // tsbtnAbout
            // 
            this.tsbtnAbout.AutoSize = false;
            this.tsbtnAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutUsToolStripMenuItem1});
            this.tsbtnAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAbout.Image")));
            this.tsbtnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAbout.Name = "tsbtnAbout";
            this.tsbtnAbout.Size = new System.Drawing.Size(110, 57);
            this.tsbtnAbout.Text = "About F6";
            this.tsbtnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutUsToolStripMenuItem1
            // 
            this.aboutUsToolStripMenuItem1.Name = "aboutUsToolStripMenuItem1";
            this.aboutUsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutUsToolStripMenuItem1.Text = "About Us";
            this.aboutUsToolStripMenuItem1.Click += new System.EventHandler(this.aboutUsToolStripMenuItem1_Click);
            // 
            // ImageBox2
            // 
            this.ImageBox2.Location = new System.Drawing.Point(32, 3);
            this.ImageBox2.Name = "ImageBox2";
            this.ImageBox2.Size = new System.Drawing.Size(135, 106);
            this.ImageBox2.TabIndex = 0;
            this.ImageBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblDay2);
            this.panel3.Controls.Add(this.lblDayOfWeek2);
            this.panel3.Controls.Add(this.lblMonth2);
            this.panel3.Controls.Add(this.lblYear2);
            this.panel3.Location = new System.Drawing.Point(-1, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 131);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblDay2
            // 
            this.lblDay2.AutoSize = true;
            this.lblDay2.BackColor = System.Drawing.Color.Transparent;
            this.lblDay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay2.Location = new System.Drawing.Point(72, 54);
            this.lblDay2.Name = "lblDay2";
            this.lblDay2.Size = new System.Drawing.Size(36, 37);
            this.lblDay2.TabIndex = 3;
            this.lblDay2.Text = "9";
            // 
            // lblDayOfWeek2
            // 
            this.lblDayOfWeek2.AutoSize = true;
            this.lblDayOfWeek2.BackColor = System.Drawing.Color.Transparent;
            this.lblDayOfWeek2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayOfWeek2.Location = new System.Drawing.Point(111, 22);
            this.lblDayOfWeek2.Name = "lblDayOfWeek2";
            this.lblDayOfWeek2.Size = new System.Drawing.Size(69, 20);
            this.lblDayOfWeek2.TabIndex = 2;
            this.lblDayOfWeek2.Text = "Sunday";
            // 
            // lblMonth2
            // 
            this.lblMonth2.AutoSize = true;
            this.lblMonth2.BackColor = System.Drawing.Color.Transparent;
            this.lblMonth2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth2.Location = new System.Drawing.Point(11, 22);
            this.lblMonth2.Name = "lblMonth2";
            this.lblMonth2.Size = new System.Drawing.Size(91, 20);
            this.lblMonth2.TabIndex = 1;
            this.lblMonth2.Text = "December";
            // 
            // lblYear2
            // 
            this.lblYear2.BackColor = System.Drawing.Color.Transparent;
            this.lblYear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear2.ForeColor = System.Drawing.Color.Black;
            this.lblYear2.Location = new System.Drawing.Point(14, 97);
            this.lblYear2.Name = "lblYear2";
            this.lblYear2.Size = new System.Drawing.Size(88, 23);
            this.lblYear2.TabIndex = 0;
            this.lblYear2.Text = "2022";
            this.lblYear2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowDsk
            // 
            this.btnShowDsk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowDsk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowDsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDsk.Image = ((System.Drawing.Image)(resources.GetObject("btnShowDsk.Image")));
            this.btnShowDsk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowDsk.Location = new System.Drawing.Point(-1, 524);
            this.btnShowDsk.Name = "btnShowDsk";
            this.btnShowDsk.Size = new System.Drawing.Size(200, 47);
            this.btnShowDsk.TabIndex = 0;
            this.btnShowDsk.Text = "Show Desktop";
            this.btnShowDsk.UseVisualStyleBackColor = true;
            this.btnShowDsk.Click += new System.EventHandler(this.btnShowDsk_Click);
            // 
            // LashonsDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 572);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LashonsDiary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lashons Diary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LashonsDiary_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LashonsDiary_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.lockCM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripButton tsbtnAddMemo;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnSettings;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnTools;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnAbout;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnShowDsk;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDay2;
        private System.Windows.Forms.Label lblDayOfWeek2;
        private System.Windows.Forms.Label lblMonth2;
        private System.Windows.Forms.Label lblYear2;
        private System.Windows.Forms.Label lblVersion2;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ComboBox dropdownBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox ImageBox2;
        private System.Windows.Forms.ContextMenuStrip lockCM;
        private System.Windows.Forms.ToolStripMenuItem lockApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}

