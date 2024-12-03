using MAGNA_LaserAblation;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionBird.Core;

namespace LaserAblation.ActionBar
{
    public partial class FormUserLogin : UIForm
    {
        public FormUserLogin()
        {
            InitializeComponent();
        }

        private void uiHeaderButton_Password_Click(object sender, EventArgs e)
        {
            if (uiHeaderButton_Password.Symbol==61550)
            {
                uiHeaderButton_Password.Symbol = 61552;
                txtPWD.UseSystemPasswordChar = true;    
            }
            else 
            {
                uiHeaderButton_Password.Symbol = 61550;
                txtPWD.UseSystemPasswordChar = false;
            }
        }

        private void comboBox_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_user.SelectedIndex==0)
            {
                INIUtils.Path = Application.StartupPath + @"\Settings\UserControl.ini";
                Dictionary<string, string> user = INIUtils.GetAllKeyValues("Operator");
               txtPWD.Text = user["Password"];
                
            }
            else if (comboBox_user.SelectedIndex == 1)
            {
                txtPWD.Text = "";
            }
            else if(comboBox_user.SelectedIndex == 2)
            {
                txtPWD.Text = "";
            }
        }

        private void FormUserLogin_Load(object sender, EventArgs e)
        {
            comboBox_user.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPWD.Text.Length>0) 
            {
                INIUtils.Path = Application.StartupPath + @"\Settings\UserControl.ini";
                if (comboBox_user.SelectedIndex == 1)
                {
                    Dictionary<string, string> user = INIUtils.GetAllKeyValues("Engineer");
                    if (txtPWD.Text == user["Password"])
                    {
                        MyCommon.m_User = "工程师";
                        this.Close();
                    }
                    else
                    {
                        UIMessageBox.ShowError("密码错误，请重新输入！");
                    }
                }
                else if (comboBox_user.SelectedIndex == 2)
                {
                    Dictionary<string, string> user = INIUtils.GetAllKeyValues("Administrator");
                    if (txtPWD.Text == user["Password"])
                    {
                        MyCommon.m_User = "管理员";
                        this.Close();
                    }
                    else
                    {
                        UIMessageBox.ShowError("密码错误，请重新输入！");
                    }
                }
                else if (comboBox_user.SelectedIndex == 0)
                {
                    MyCommon.m_User = "操作员";
                    this.Close();
                }
            }
            else 
            {
                UIMessageBox.ShowInfo("密码不能为空，请输入正确密码！");
            }
            
        }
    }
}
