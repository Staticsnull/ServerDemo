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
    public partial class FrmPlay : Form
    {
        public FrmPlay()
        {
            InitializeComponent();
        }
        String[] list = { "D:\\Program Files\\MyKTV\\song\\BEAT IT.mp3" ,
            "D:\\Program Files\\MyKTV\\song\\I do.mp3.mp3",
            "D:\\Program Files\\MyKTV\\song\\稻香.mp3","D:\\Program Files\\MyKTV\\song\\菊花台.wma"};
        private void FrmPlay_Load(object sender, EventArgs e)
        {
            int index = new Random().Next(4);
            //使用控件AXWindowsMediaPaly url
            this.wmpSong.URL = list[index];
        }
    }
}
