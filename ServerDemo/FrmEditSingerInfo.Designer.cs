namespace ServerDemo
{
    partial class FrmEditSingerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditSingerInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pnGender = new System.Windows.Forms.Panel();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnBroswe = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rboMale = new System.Windows.Forms.RadioButton();
            this.rboFemale = new System.Windows.Forms.RadioButton();
            this.rboTeam = new System.Windows.Forms.RadioButton();
            this.ofdSingerPhoto = new System.Windows.Forms.OpenFileDialog();
            this.pnGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(61, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(61, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "性别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(21, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "歌手类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(21, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "歌手描述";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(139, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 30);
            this.txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(139, 206);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(260, 159);
            this.txtDescription.TabIndex = 4;
            // 
            // pnGender
            // 
            this.pnGender.Controls.Add(this.rboTeam);
            this.pnGender.Controls.Add(this.rboFemale);
            this.pnGender.Controls.Add(this.rboMale);
            this.pnGender.Location = new System.Drawing.Point(139, 74);
            this.pnGender.Name = "pnGender";
            this.pnGender.Size = new System.Drawing.Size(218, 45);
            this.pnGender.TabIndex = 2;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(139, 138);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(218, 28);
            this.cboType.TabIndex = 3;
            // 
            // picPhoto
            // 
            this.picPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picPhoto.Image = ((System.Drawing.Image)(resources.GetObject("picPhoto.Image")));
            this.picPhoto.InitialImage = null;
            this.picPhoto.Location = new System.Drawing.Point(386, 32);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(170, 118);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 4;
            this.picPhoto.TabStop = false;
            // 
            // btnBroswe
            // 
            this.btnBroswe.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBroswe.Location = new System.Drawing.Point(423, 168);
            this.btnBroswe.Name = "btnBroswe";
            this.btnBroswe.Size = new System.Drawing.Size(84, 36);
            this.btnBroswe.TabIndex = 5;
            this.btnBroswe.Text = "浏览";
            this.btnBroswe.UseVisualStyleBackColor = true;
            this.btnBroswe.Click += new System.EventHandler(this.btnBroswe_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(315, 399);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(445, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 36);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rboMale
            // 
            this.rboMale.AutoSize = true;
            this.rboMale.Checked = true;
            this.rboMale.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rboMale.Location = new System.Drawing.Point(14, 9);
            this.rboMale.Name = "rboMale";
            this.rboMale.Size = new System.Drawing.Size(47, 24);
            this.rboMale.TabIndex = 0;
            this.rboMale.TabStop = true;
            this.rboMale.Text = "男";
            this.rboMale.UseVisualStyleBackColor = true;
            // 
            // rboFemale
            // 
            this.rboFemale.AutoSize = true;
            this.rboFemale.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rboFemale.Location = new System.Drawing.Point(77, 9);
            this.rboFemale.Name = "rboFemale";
            this.rboFemale.Size = new System.Drawing.Size(47, 24);
            this.rboFemale.TabIndex = 0;
            this.rboFemale.Text = "女";
            this.rboFemale.UseVisualStyleBackColor = true;
            // 
            // rboTeam
            // 
            this.rboTeam.AutoSize = true;
            this.rboTeam.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rboTeam.Location = new System.Drawing.Point(141, 9);
            this.rboTeam.Name = "rboTeam";
            this.rboTeam.Size = new System.Drawing.Size(67, 24);
            this.rboTeam.TabIndex = 0;
            this.rboTeam.Text = "组合";
            this.rboTeam.UseVisualStyleBackColor = true;
            // 
            // ofdSingerPhoto
            // 
            this.ofdSingerPhoto.DefaultExt = "jpg";
            this.ofdSingerPhoto.InitialDirectory = "D:";
            this.ofdSingerPhoto.Title = "请选择歌手图像";
            this.ofdSingerPhoto.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdSingerPhoto_FileOk);
            // 
            // FrmEditSingerInfo
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 447);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBroswe);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.pnGender);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditSingerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑歌手信息";
            this.Load += new System.EventHandler(this.FrmEditSingerInfo_Load);
            this.pnGender.ResumeLayout(false);
            this.pnGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel pnGender;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnBroswe;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rboTeam;
        private System.Windows.Forms.RadioButton rboFemale;
        private System.Windows.Forms.RadioButton rboMale;
        private System.Windows.Forms.OpenFileDialog ofdSingerPhoto;
    }
}