namespace ServerDemo
{
    partial class FrmAdmin
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
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.tsmiSinger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddSinger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFindSinger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFindSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiResourcePath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSingerPhotoPath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSongrPhotoPath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.msAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAdmin
            // 
            this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSinger,
            this.tsmiSong,
            this.tsmiResourcePath,
            this.tsmiHelp});
            this.msAdmin.Location = new System.Drawing.Point(0, 0);
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Size = new System.Drawing.Size(722, 25);
            this.msAdmin.TabIndex = 0;
            this.msAdmin.Text = "menuStrip1";
            // 
            // tsmiSinger
            // 
            this.tsmiSinger.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddSinger,
            this.tsmiFindSinger,
            this.tsmiExit});
            this.tsmiSinger.Name = "tsmiSinger";
            this.tsmiSinger.Size = new System.Drawing.Size(68, 21);
            this.tsmiSinger.Text = "歌手管理";
            // 
            // tsmiAddSinger
            // 
            this.tsmiAddSinger.Name = "tsmiAddSinger";
            this.tsmiAddSinger.Size = new System.Drawing.Size(148, 22);
            this.tsmiAddSinger.Text = "新增歌手";
            this.tsmiAddSinger.Click += new System.EventHandler(this.tsmiAddSinger_Click);
            // 
            // tsmiFindSinger
            // 
            this.tsmiFindSinger.Name = "tsmiFindSinger";
            this.tsmiFindSinger.Size = new System.Drawing.Size(148, 22);
            this.tsmiFindSinger.Text = "查找歌手信息";
            this.tsmiFindSinger.Click += new System.EventHandler(this.tsmiFindSinger_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(148, 22);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiSong
            // 
            this.tsmiSong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddSong,
            this.tsmiFindSong});
            this.tsmiSong.Name = "tsmiSong";
            this.tsmiSong.Size = new System.Drawing.Size(68, 21);
            this.tsmiSong.Text = "歌曲管理";
            // 
            // tsmiAddSong
            // 
            this.tsmiAddSong.Name = "tsmiAddSong";
            this.tsmiAddSong.Size = new System.Drawing.Size(148, 22);
            this.tsmiAddSong.Text = "新增歌曲";
            this.tsmiAddSong.Click += new System.EventHandler(this.tsmiAddSong_Click);
            // 
            // tsmiFindSong
            // 
            this.tsmiFindSong.Name = "tsmiFindSong";
            this.tsmiFindSong.Size = new System.Drawing.Size(148, 22);
            this.tsmiFindSong.Text = "查询歌曲信息";
            this.tsmiFindSong.Click += new System.EventHandler(this.tsmiFindSong_Click);
            // 
            // tsmiResourcePath
            // 
            this.tsmiResourcePath.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSingerPhotoPath,
            this.tsmiSongrPhotoPath});
            this.tsmiResourcePath.Name = "tsmiResourcePath";
            this.tsmiResourcePath.Size = new System.Drawing.Size(68, 21);
            this.tsmiResourcePath.Text = "资源路径";
            // 
            // tsmiSingerPhotoPath
            // 
            this.tsmiSingerPhotoPath.Name = "tsmiSingerPhotoPath";
            this.tsmiSingerPhotoPath.Size = new System.Drawing.Size(152, 22);
            this.tsmiSingerPhotoPath.Text = "歌手照片路径";
            this.tsmiSingerPhotoPath.Click += new System.EventHandler(this.tsmiSingerPhotoPath_Click);
            // 
            // tsmiSongrPhotoPath
            // 
            this.tsmiSongrPhotoPath.Name = "tsmiSongrPhotoPath";
            this.tsmiSongrPhotoPath.Size = new System.Drawing.Size(152, 22);
            this.tsmiSongrPhotoPath.Text = "歌曲路径";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 21);
            this.tsmiHelp.Text = "帮助";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(124, 22);
            this.tsmiAbout.Text = "关于我们";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 560);
            this.Controls.Add(this.msAdmin);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msAdmin;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTV后台管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiSinger;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddSinger;
        private System.Windows.Forms.ToolStripMenuItem tsmiFindSinger;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiFindSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiResourcePath;
        private System.Windows.Forms.ToolStripMenuItem tsmiSingerPhotoPath;
        private System.Windows.Forms.ToolStripMenuItem tsmiSongrPhotoPath;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
    }
}