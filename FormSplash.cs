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

namespace LaserAblation
{
    public partial class FormSplash : Form 
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void FormInitialization_Load(object sender, EventArgs e)
        {
            uiLabel2.Text = "Ver:0.0.0.1";
        }
        public void ShowInfo(string NewMessage)
        {
            uiLabel1.Text = NewMessage;
        }

        public void ClearInfo()
        {
            uiLabel1.Text = "";
            uiLabel3.Text = AppValue.GetInstance().common.gongzhanming;
        }



    }
}
