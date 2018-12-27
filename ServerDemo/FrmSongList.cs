using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerDemo
{
    public partial class FrmSongList : Form
    {
        public FrmSongList()
        {
            InitializeComponent();
        }
        //private DataSet ds;
        //DBHelper dbHelper = new DBHelper();
        //private SqlDataAdapter da;
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSongList_Load(object sender, EventArgs e)
        {
            //绑定歌曲类型
            BindSongType();
        }
        /// <summary>
        /// 绑定歌曲类型
        /// </summary>
        public void BindSongType()
        {
            //ds = new DataSet();
            try
            {
                //dbHelper.Open();
                String sql = "select * from song_type";
                //da = new SqlDataAdapter(sql, dbHelper.Connection);
                //ds = new DataSet();
                //da.Fill(ds, "song_type");
                DataTable table = DBHelper.GetTable(sql);
                //添加一行
                DataRow row = table.NewRow();
                row["songtype_id"] = -1;
                row["songtype_name"] = "请选择";
                table.Rows.InsertAt(row, 0);
                this.cboSongType.ValueMember = "songtype_id";
                this.cboSongType.DisplayMember = "songtype_name";
                this.cboSongType.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("系统发生异常,异常类型为:" + e.Message);
            }

        }
        /// <summary>
        /// 查询事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindSearchSongList();
        }

        /// <summary>
        /// 绑定查询操作
        /// </summary>
        public void BindSearchSongList()
        {
            //ds = new DataSet();
            //dbHelper.Open();
            StringBuilder sql = new StringBuilder(@"select song_id,song_name,songtype_name,song_play_count
                         from song_info s inner join song_type t on s.songtype_id = t.songtype_id ");
            if (this.txtSongName.Text.Trim().Length != 0 && Convert.ToInt32(this.cboSongType.SelectedValue) != -1)
            {
                sql.AppendFormat(" where song_name like '%{0}%' and s.songtype_id = '{1}'",
                    this.txtSongName.Text.Trim(), this.cboSongType.SelectedValue.ToString());
            }
            else if (this.txtSongName.Text.Trim().Length != 0)
            {
                sql.AppendFormat("where song_name like '%{0}%'", txtSongName.Text.Trim());
            }
            else if (Convert.ToInt32(this.cboSongType.SelectedValue) != -1)
            {
                sql.AppendFormat("where s.songtype_id = '{0}'", this.cboSongType.SelectedValue.ToString());
            }
            //da = new SqlDataAdapter(sql.ToString(), dbHelper.Connection);
            //if (ds.Tables["song_info"] != null)
            //{
            //    ds.Tables["song_info"].Clear();
            //}
            //da.Fill(ds, "song_info");
            this.dgvSongList.DataSource = DBHelper.GetTable(sql.ToString());
        }

        /// <summary>
        /// 右键修改触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            FrmEditSongInfo fEditSong = new FrmEditSongInfo();
            //歌曲id
            fEditSong.songId = Convert.ToInt32(this.dgvSongList.SelectedCells[0].Value);
            fEditSong.Show();
        }
    }
}
