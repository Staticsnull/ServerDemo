namespace ServerDemo
{
    partial class FrmPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlay));
            this.wmpSong = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSong)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpSong
            // 
            this.wmpSong.Enabled = true;
            this.wmpSong.Location = new System.Drawing.Point(12, 12);
            this.wmpSong.Name = "wmpSong";
            this.wmpSong.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSong.OcxState")));
            this.wmpSong.Size = new System.Drawing.Size(251, 178);
            this.wmpSong.TabIndex = 0;
            // 
            // FrmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.wmpSong);
            this.Name = "FrmPlay";
            this.Text = "FrmPlay";
            this.Load += new System.EventHandler(this.FrmPlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpSong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpSong;
    }
}