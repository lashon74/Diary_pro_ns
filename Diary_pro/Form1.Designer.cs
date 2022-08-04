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
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddMemo = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnTools = new System.Windows.Forms.ToolStripDropDownButton();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnAbout = new System.Windows.Forms.ToolStripDropDownButton();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnShowDsk = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.btnShowDsk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 47);
            this.panel2.TabIndex = 0;
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
            this.toolStrip1.Size = new System.Drawing.Size(567, 60);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAddMemo
            // 
            this.tsbtnAddMemo.AutoSize = false;
            this.tsbtnAddMemo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddMemo.Image")));
            this.tsbtnAddMemo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAddMemo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddMemo.Name = "tsbtnAddMemo";
            this.tsbtnAddMemo.Size = new System.Drawing.Size(80, 57);
            this.tsbtnAddMemo.Text = "Add Memo";
            this.tsbtnAddMemo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.AutoSize = false;
            this.tsbtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearch.Image")));
            this.tsbtnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(80, 57);
            this.tsbtnSearch.Text = "Search Memo";
            this.tsbtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.tsbtnSettings.Size = new System.Drawing.Size(80, 57);
            this.tsbtnSettings.Text = "Settings";
            this.tsbtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
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
            this.tsbtnTools.Size = new System.Drawing.Size(80, 57);
            this.tsbtnTools.Text = "Tools";
            this.tsbtnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.usersToolStripMenuItem.Text = "Users";
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
            this.tsbtnAbout.Size = new System.Drawing.Size(80, 57);
            this.tsbtnAbout.Text = "About";
            this.tsbtnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutUsToolStripMenuItem1
            // 
            this.aboutUsToolStripMenuItem1.Name = "aboutUsToolStripMenuItem1";
            this.aboutUsToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.aboutUsToolStripMenuItem1.Text = "About Us";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(744, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(717, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(27, 23);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnShowDsk
            // 
            this.btnShowDsk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowDsk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowDsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDsk.Image = ((System.Drawing.Image)(resources.GetObject("btnShowDsk.Image")));
            this.btnShowDsk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowDsk.Location = new System.Drawing.Point(-1, 402);
            this.btnShowDsk.Name = "btnShowDsk";
            this.btnShowDsk.Size = new System.Drawing.Size(200, 47);
            this.btnShowDsk.TabIndex = 0;
            this.btnShowDsk.Text = "Show Desktop";
            this.btnShowDsk.UseVisualStyleBackColor = true;
            this.btnShowDsk.Click += new System.EventHandler(this.btnShowDsk_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Black;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTimer.Location = new System.Drawing.Point(-1, 72);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(200, 50);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "12:33:20";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LashonsDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
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
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
    }
}

