namespace CopyPasty
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerClipboardMonitor = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripClip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCurrentClip = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSettings = new System.Windows.Forms.TabControl();
            this.tabPageIntro = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelClips = new System.Windows.Forms.Panel();
            this.trackBarNClipboards = new System.Windows.Forms.TrackBar();
            this.labelNClipboards = new System.Windows.Forms.Label();
            this.LabelBy = new System.Windows.Forms.LinkLabel();
            this.contextMenuStripTray.SuspendLayout();
            this.contextMenuStripClip.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabPageIntro.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNClipboards)).BeginInit();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.contextMenuStripTray;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "CopyPasty";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStripTray
            // 
            this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.contextMenuStripTray.Name = "contextMenuStripTray";
            this.contextMenuStripTray.Size = new System.Drawing.Size(98, 32);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(94, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // timerClipboardMonitor
            // 
            this.timerClipboardMonitor.Tick += new System.EventHandler(this.timerClipboardMonitor_Tick);
            // 
            // contextMenuStripClip
            // 
            this.contextMenuStripClip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripClip.Name = "contextMenuStripClip";
            this.contextMenuStripClip.Size = new System.Drawing.Size(108, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // labelCurrentClip
            // 
            this.labelCurrentClip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelCurrentClip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCurrentClip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelCurrentClip.Location = new System.Drawing.Point(3, 94);
            this.labelCurrentClip.MinimumSize = new System.Drawing.Size(0, 50);
            this.labelCurrentClip.Name = "labelCurrentClip";
            this.labelCurrentClip.Padding = new System.Windows.Forms.Padding(3);
            this.labelCurrentClip.Size = new System.Drawing.Size(692, 50);
            this.labelCurrentClip.TabIndex = 2;
            this.labelCurrentClip.Text = "Current clipboard data:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "When you copy something to the clipboard it will appear here (if the content is s" +
    "upported). The easiest way to copy from these is by clicking on them in the syst" +
    "em tray menu.";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.tabPageIntro);
            this.tabPageSettings.Controls.Add(this.tabPage2);
            this.tabPageSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabPageSettings.Location = new System.Drawing.Point(3, 144);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.SelectedIndex = 0;
            this.tabPageSettings.Size = new System.Drawing.Size(692, 125);
            this.tabPageSettings.TabIndex = 5;
            // 
            // tabPageIntro
            // 
            this.tabPageIntro.Controls.Add(this.label1);
            this.tabPageIntro.Location = new System.Drawing.Point(4, 22);
            this.tabPageIntro.Name = "tabPageIntro";
            this.tabPageIntro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIntro.Size = new System.Drawing.Size(684, 74);
            this.tabPageIntro.TabIndex = 0;
            this.tabPageIntro.Text = "Intro";
            this.tabPageIntro.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelNClipboards);
            this.tabPage2.Controls.Add(this.trackBarNClipboards);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(684, 99);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelClips
            // 
            this.panelClips.AutoScroll = true;
            this.panelClips.AutoSize = true;
            this.panelClips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClips.Location = new System.Drawing.Point(3, 3);
            this.panelClips.Name = "panelClips";
            this.panelClips.Size = new System.Drawing.Size(692, 91);
            this.panelClips.TabIndex = 6;
            // 
            // trackBarNClipboards
            // 
            this.trackBarNClipboards.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackBarNClipboards.Location = new System.Drawing.Point(3, 3);
            this.trackBarNClipboards.Maximum = 100;
            this.trackBarNClipboards.Minimum = 1;
            this.trackBarNClipboards.Name = "trackBarNClipboards";
            this.trackBarNClipboards.Size = new System.Drawing.Size(104, 93);
            this.trackBarNClipboards.TabIndex = 0;
            this.trackBarNClipboards.Value = 20;
            this.trackBarNClipboards.Scroll += new System.EventHandler(this.trackBarNClipboards_Scroll);
            // 
            // labelNClipboards
            // 
            this.labelNClipboards.AutoSize = true;
            this.labelNClipboards.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNClipboards.Location = new System.Drawing.Point(107, 3);
            this.labelNClipboards.Name = "labelNClipboards";
            this.labelNClipboards.Size = new System.Drawing.Size(98, 13);
            this.labelNClipboards.TabIndex = 1;
            this.labelNClipboards.Text = "Keep 20 clipboards";
            // 
            // LabelBy
            // 
            this.LabelBy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelBy.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LabelBy.Location = new System.Drawing.Point(3, 269);
            this.LabelBy.Name = "LabelBy";
            this.LabelBy.Size = new System.Drawing.Size(692, 13);
            this.LabelBy.TabIndex = 4;
            this.LabelBy.TabStop = true;
            this.LabelBy.Text = "by www.manoli.se";
            this.LabelBy.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LabelBy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelBy_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 285);
            this.Controls.Add(this.panelClips);
            this.Controls.Add(this.labelCurrentClip);
            this.Controls.Add(this.tabPageSettings);
            this.Controls.Add(this.LabelBy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "CopyPasty";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStripTray.ResumeLayout(false);
            this.contextMenuStripClip.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageIntro.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNClipboards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Timer timerClipboardMonitor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripClip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label labelCurrentClip;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabPageSettings;
        private System.Windows.Forms.TabPage tabPageIntro;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelClips;
        private System.Windows.Forms.TrackBar trackBarNClipboards;
        private System.Windows.Forms.Label labelNClipboards;
        private System.Windows.Forms.LinkLabel LabelBy;
    }
}

