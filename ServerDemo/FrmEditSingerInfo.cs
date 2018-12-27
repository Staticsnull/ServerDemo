using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerDemo
{
    public partial class FrmEditSingerInfo : Form
    {
        public FrmEditSingerInfo()
        {
            InitializeComponent();
        }
        //private DataSet ds;
        //DBHelper dbHelper = new DBHelper();
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEditSingerInfo_Load(object sender, EventArgs e)
        {
            //绑定歌手类型
            BindSingerType();
            //绑定歌手信息
        }
        public void BindSingerType()
        {
            //ds = new DataSet();
            String sql = "select * from singer_type";
            //SqlDataAdapter da = new SqlDataAdapter(sql,dbHelper.Connection);
           // da.Fill(ds, "singer_type");
            this.cboType.ValueMember = "singertype_id";
            this.cboType.DisplayMember = "singertype_name";
            this.cboType.DataSource = DBHelper.GetTable(sql);
        }

        /// <summary>
        /// 添加歌手信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            String name = this.txtName.Text.Trim();
            int typeId = Convert.ToInt32(this.cboType.SelectedValue);
            String gender = this.rboMale.Checked ? "男" : (this.rboFemale.Checked ? "女" : "组合");
            //得到照片路径
            String photoUrl = name + ".jpg";
            //得到详细描述信息
            String description = this.txtDescription.Text.Trim();
            //复制文件
            //MessageBox.Show(this.picPhoto.ImageLocation);原文件路径 新路径
            File.Copy(this.picPhoto.ImageLocation, "D:\\Program Files\\MyKTV\\singerPhoto\\" +photoUrl,true);
            String sql = String.Format(@"insert into singer_info 
                values('{0}',{1},'{2}','{3}','{4}') ;", name, typeId, gender, photoUrl, description);
            //dbHelper.Open();
            //SqlCommand command = new SqlCommand(sql, dbHelper.Connection);
            int count = DBHelper.ExecuteNonQuery(sql);
            if (count > 0)
            {
                MessageBox.Show("歌手信息保存成功");
                Clear();
            }

        }
        public void Clear()
        {
            this.txtDescription.Text = "";
            this.txtName.Text = "";
            this.rboMale.Checked = true;
            this.cboType.SelectedIndex = 0;
        }
        /// <summary>
        /// 验证用户输入
        /// </summary>
        /// <returns></returns>
        public bool ValidateInput()
        {
            bool isInput = false;
            if (this.txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入歌手姓名!");
            }
            else if(this.picPhoto.ImageLocation == null)
            {
                MessageBox.Show("请选择歌手图片!");
            }
            else
            {
                isInput = true;
            }
            return isInput;
        }
        /// <summary>
        /// 选择歌手图片路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBroswe_Click(object sender, EventArgs e)
        {
            this.ofdSingerPhoto.ShowDialog();
        }

        /// <summary>
        /// 选择图片绑定事件 双击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ofdSingerPhoto_FileOk(object sender, CancelEventArgs e)
        {
            //获取文件名 用来判断文件后缀是否符合要求
            String fileName = this.ofdSingerPhoto.SafeFileName;
            //获取完整文件名 包含路径 用来给picturebox控件赋值
            String fullName = this.ofdSingerPhoto.FileName;
            //判断文件后缀是否以jpg为结尾的文件
            int index = fileName.LastIndexOf(".");
            String fileType = fileName.Substring(index).ToLower();
            if(fileType == ".jpg" || fileType == ".png")
            {
                this.picPhoto.ImageLocation = fullName;
            }
            else
            {
                MessageBox.Show("文件类型有误!请选择后缀为jpg或者png格式的图片!");
                e.Cancel = true;//继续执行这个事件
            }

        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
