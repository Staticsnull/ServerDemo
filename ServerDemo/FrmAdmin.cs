using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerDemo
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
           
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiAddSinger_Click(object sender, EventArgs e)
        {
            FrmEditSingerInfo fesi = new FrmEditSingerInfo();
            fesi.MdiParent = this;
            fesi.Show();
        }

        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 查找歌手信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiFindSinger_Click(object sender, EventArgs e)
        {
            FrmSingerList frmSingerList = new FrmSingerList();
            frmSingerList.MdiParent = this;
            frmSingerList.Show();
        }

        private void tsmiAddSong_Click(object sender, EventArgs e)
        {
            FrmEditSongInfo fei = new FrmEditSongInfo();
            fei.MdiParent = this;
            fei.Show();
        }

        private void tsmiFindSong_Click(object sender, EventArgs e)
        {
            FrmSongList fsl = new FrmSongList();
            fsl.Show();
        }

        /// <summary>
        /// 歌手照片路径触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSingerPhotoPath_Click(object sender, EventArgs e)
        {

        }
    }
}
