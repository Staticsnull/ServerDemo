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
    public partial class FrmSingerList : Form
    {
        //private int singerId;
        public FrmEditSongInfo fes;
        public FrmSingerList()
        {
            InitializeComponent();
        }
        //private DataSet ds;
        //private SqlDataAdapter da;
        //private DBHelper dbHelper = new DBHelper();
        private void FrmSingerList_Load(object sender, EventArgs e)
        {
            //绑定歌手类型
            BindSingerType();
            //BindFindSingerList();
        }
        public void BindSingerType()
        {

            //dbHelper.Open();
            //ds = new DataSet();
            String sql = "select * from singer_type";
            //da = new SqlDataAdapter(sql, dbHelper.Connection);
            //da.Fill(ds, "singer_type");
            //添加请选择一行
            DataTable table = DBHelper.GetTable(sql);
            DataRow row = table.NewRow();
            row["singertype_id"] = -1;
            row["singertype_name"] = "请选择";
            table.Rows.InsertAt(row, 0);
            this.cboType.DisplayMember = "singertype_name";
            this.cboType.ValueMember = "singertype_id";
            this.cboType.DataSource = table;
        }

        /// <summary>
        /// 点击查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            BindFindSingerList();
        }

        /// <summary>
        /// 绑定查询操作
        /// </summary>
        public void BindFindSingerList()
        {
            StringBuilder sql = new StringBuilder(@"select s.singer_id,s.singer_name,
                            t.singertype_name,s.singer_gender
                           from singer_info s join singer_type t 
                        on s.singertype_id = t.singertype_id ");
            if (this.txtName.Text.Trim() != "" && Convert.ToInt32(this.cboType.SelectedValue) != -1)
            {
                sql.AppendFormat(" where s.singer_name like '%{0}%' and s.singertype_id={1} ",
                    this.txtName.Text.Trim(), Convert.ToInt32(this.cboType.SelectedValue));
            }
            else if (this.txtName.Text.Trim() != "")
            {
                sql.AppendFormat(" where s.singer_name like '%{0}%'  ", this.txtName.Text.Trim());
            }
            else if (Convert.ToInt32(this.cboType.SelectedValue) != -1)
            {
                sql.AppendFormat("where s.singertype_id={0}", Convert.ToInt32(this.cboType.SelectedValue));
            }
            //ds = new DataSet();
            //dbHelper.Open();
            //if (ds.Tables["singer_info"] != null)
            //{
            //    ds.Tables.Clear();
            //}
            //da = new SqlDataAdapter(sql.ToString(), dbHelper.Connection);
            ////填充数据
            //da.Fill(ds, "singer_info");
            //绑定数据源
            this.dgvSingerList.DataSource = DBHelper.GetTable(sql.ToString());
        }

        /// <summary>
        /// 为歌手信息列表添加点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSingerList_Click(object sender, EventArgs e)
        {
            //判断是否选择了歌手
            if (dgvSingerList.SelectedRows[0] != null)
            {
                //获取歌手编号和姓名 传给新增歌曲窗体 注意修改DataGridView中的设计中的name属性 
                //修改为数据库中列的值                          
                int id = Convert.ToInt32(this.dgvSingerList.SelectedRows[0].Cells["singer_id"].Value);
                String name = this.dgvSingerList.SelectedRows[0].Cells["singer_name"].Value.ToString();
                if (this.fes != null)
                {
                    MessageBox.Show(id + ":" + name);
                    //((FrmEditSong)((FrmAdmin)this.Owner).ActiveMdiChild).singerId = id;
                    //((FrmEditSong)((FrmAdmin)this.Owner).ActiveMdiChild).txtSinger.Text = name;
                    //先找到owner的父窗体 frmadmin 然后找到活跃的子窗体,并将其转换为frmeditsong子窗体
                    fes.singerId = id;
                    fes.txtSingerName.Text = name;
                }
            }
        }
        //修改歌手
        private void tsmiUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
