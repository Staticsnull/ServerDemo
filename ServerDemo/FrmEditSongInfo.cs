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
    public partial class FrmEditSongInfo : Form
    {
        // private DataSet ds;
        //private DBHelper dbHelper = new DBHelper();
        //封装歌曲id 用于在窗体之间传值
        public int songId = -1;
        public int singerId = -1;
        public FrmEditSongInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEditSongInfo_Load(object sender, EventArgs e)
        {
            //绑定歌曲类型
            BindSongType();
            //显示编辑的歌曲信息
            ShowSongInfo();
        }

        public void ShowSongInfo()
        {
            //MessageBox.Show(singerId + "");
            if (songId == -1 ) return;
            String sql = String.Format(@"select a.singer_id singerId, s.song_name,s.song_ab,s.songtype_id,
                         a.singer_name ,s.song_url from song_info s inner 
                           join singer_info a on s.singer_id = a.singer_id 
                        where s.song_id='{0}'", songId);
            try
            {
                //dbHelper.Open();
                //SqlCommand command = new SqlCommand(sql, DBHelper.Connection);
                //DBHelper.Open();
                SqlDataReader reader = DBHelper.ExecuteReader(sql);
                if (reader.Read())
                {
                    this.singerId = Convert.ToInt32(reader["singerId"]);
                    this.txtSongName.Text = reader["song_name"].ToString();
                    this.txtSongNameAB.Text = reader["song_ab"].ToString();
                    this.txtSingerName.Text = reader["singer_name"].ToString();
                    this.txtSongFileName.Text = "D:\\Program Files\\SoftMgr\\"+ reader["song_url"].ToString();
                    this.cboSongType.SelectedValue = reader["songtype_id"];
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("系统异常,异常类型为:" + e.Message);
            }

        }
        /// <summary>
        /// 绑定歌曲类型
        /// </summary>
        public void BindSongType()
        {
            //dbHelper.Open();
            String sql = "select * from song_type";
            //SqlDataAdapter da = new SqlDataAdapter(sql, dbHelper.Connection);
            // ds = new DataSet();
            //da.Fill(ds, "song_type");
            //绑定歌曲到下拉列表中
            this.cboSongType.DisplayMember = "songtype_name";
            this.cboSongType.ValueMember = "songtype_id";
            this.cboSongType.DataSource = DBHelper.GetTable(sql);
        }
        /// <summary>
        /// 查询事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            FrmSingerList fsList = new FrmSingerList();
            fsList.fes = this;
            fsList.ShowDialog();
        }
        /// <summary>
        /// 浏览歌曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.ofdSongFileName.ShowDialog();
        }

        /// <summary>
        /// 保存歌曲信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            //获取要添加的值
            String songName = this.txtSongName.Text.Trim();
            String songNameAB = this.txtSongNameAB.Text.Trim();
            int songWordCount = this.txtSongName.Text.Trim().Length;
            String songTypeId = this.cboSongType.SelectedValue.ToString();
            String songUrl = songName + ".mkv";
            //获取文件名
            //String fileName = this.ofdSongFileName.SafeFileName;
            //获取完整文件名 包含路径
            String fullName = this.ofdSongFileName.FileName;
            //this.txtSongFileName.Text.Trim();
            //将歌曲文件复制到指定的地方
            //如果对话框在用户指定的文件名不存在时显示警告，则为 true；反之，则为 false。默认值为 true。
            String sql = "";
            if (songId != -1 )//修改
            {
                MessageBox.Show("修改时歌手id为:" + singerId);
                //修改操作
                sql = String.Format(@"update song_info set song_name='{0}',
                song_ab='{1}',song_word_count='{2}',songtype_id={3},singer_id='{4}',song_url='{5}'
                   where song_id='{6}'", songName, songNameAB, songWordCount,
                       songTypeId, singerId, songUrl,songId);
            }
            else
            {
                MessageBox.Show("保存时歌手id为:" + singerId);
                //保存 复制文件
                File.Copy(fullName, "D:\\Program Files\\MyKTV\\song\\" + songUrl, true);
                sql = String.Format(@"insert into song_info 
               (song_name,song_ab,song_word_count,songtype_id,singer_id,song_url)
              values ('{0}','{1}','{2}','{3}','{4}','{5}') ", songName, songNameAB, songWordCount,
                       songTypeId, singerId, songUrl);
            }
            try
            {
                int count = DBHelper.ExecuteNonQuery(sql);
                if (count > 0)
                {
                    MessageBox.Show("保存成功!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("系统异常,添加失败!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统异常!详细信息为:" + ex.Message);
            }

        }

        /// <summary>
        /// 清空输入
        /// </summary>
        public void ClearInput()
        {
            this.txtSongName.Clear();
            this.txtSongNameAB.Clear();
            this.txtSingerName.Clear();
            this.txtSongFileName.Clear();
        }
        /// <summary>
        /// 验证用户的输入
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {
            bool result = false;
            if (this.txtSongName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入歌曲名!");
            }
            else if (this.txtSongNameAB.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入歌曲名的拼音缩写!");
            }
            else if (this.txtSingerName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入歌手姓名!");
            }
            else if (this.txtSongFileName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择歌曲文件!");
            }
            else
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// 点击打开文件时 显示文件名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ofdSongFileName_FileOk(object sender, CancelEventArgs e)
        {
            //获取文件名
            String fileName = this.ofdSongFileName.SafeFileName;
            //获取完整文件名 包含路径
            String fullName = this.ofdSongFileName.FileName;
            //判断文件后缀是否以mp3为结尾的文件
            int index = fileName.LastIndexOf(".");
            String fileType = fileName.Substring(index).ToLower();
            if (fileType == ".mp3" || fileType == ".mkv")
            {
                this.txtSongFileName.Text = fullName;
            }
            else
            {
                MessageBox.Show("文件类型有误!请选择后缀为jpg或者png格式的图片!");
                e.Cancel = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
