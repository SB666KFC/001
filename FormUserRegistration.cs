using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserAblation.ActionBar
{
    public partial class FormUserRegistration : UIForm
    {
        public FormUserRegistration()
        {
            InitializeComponent();
        }

        private void uiHeaderButton_Original_Click(object sender, EventArgs e)
        {
            UIHeaderButton uibutten=(UIHeaderButton)sender;
            string name=uibutten.Name;
            if (name == "uiHeaderButton_Original")
            {
                if (uiHeaderButton_Original.Symbol==61552)
                {
                    uiHeaderButton_Original.Symbol = 61550;
                    tbx_Original.UseSystemPasswordChar = false;
                }
                else 
                {
                    uiHeaderButton_Original.Symbol = 61552;
                    tbx_Original.UseSystemPasswordChar = true;
                }
            }
            if (name == "uiHeaderButton_New")
            {
                if (uiHeaderButton_New.Symbol == 61552)
                {
                    uiHeaderButton_New.Symbol = 61550;
                    tbx_New.UseSystemPasswordChar = false;
                }
                else
                {
                    uiHeaderButton_New.Symbol = 61552;
                    tbx_New.UseSystemPasswordChar = true;
                }
            }
            if (name == "uiHeaderButton_Verify")
            {
                if (uiHeaderButton_Verify.Symbol == 61552)
                {
                    uiHeaderButton_Verify.Symbol = 61550;
                    tbx_Verify.UseSystemPasswordChar = false;
                }
                else
                {
                    uiHeaderButton_Verify.Symbol = 61552;
                    tbx_Verify.UseSystemPasswordChar = true;
                }
            }

        }
    }
}
