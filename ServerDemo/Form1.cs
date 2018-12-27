using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ServerDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       // DBHelper dbHelper = new DBHelper();
        
        /// <summary>
        /// 非空验证用户名与密码
        /// </summary>
        /// <returns></returns>
        public bool ValidateUser(String userName,String pwd)
        {
            bool isInput = false;
            if (userName.Length == 0)
            {
                MessageBox.Show("请输入用户名!");

            }else if(pwd.Length == 0)
            {
                MessageBox.Show("请输入密码!");
            }else
            {
                isInput = true;
            }

            return isInput;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            String userName = this.txtUserName.Text.Trim();
            String pwd = this.txtPwd.Text.Trim();
            if (ValidateUser(userName,pwd))
            {
                String sql = String.Format(@" select count(1) from admin_info where admin_name='{0}'
                        and admin_pwd='{1}'", userName, pwd);
                //SqlCommand command = new SqlCommand(sql, dbHelper.Connection);
                //dbHelper.Open();
                int count = DBHelper.ExecuteScalar(sql);
                if (count < 1)
                {
                    MessageBox.Show("用户名或者密码有误!");
                    return;
                }
                else
                {
                    FrmAdmin frmAdmin = new FrmAdmin();
                    frmAdmin.Show();
                    this.Hide();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
