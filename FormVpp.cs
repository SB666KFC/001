using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;

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
    public partial class FormVpp : UIForm
    {
        public FormVpp()
        {
            InitializeComponent();
        }
        CogToolBlock TB = new CogToolBlock();
        string model;

        public string Model
        {
            //get { return model; }
            set
            {
                if ("型号识别" == value)
                {
                    model = "SelectPlatemodel";
                }
                else { model = value; }

            }
        }
        public string path;

        private void FormVpp_Load(object sender, EventArgs e)
        {
            try
            {
                 path = AppValue.GetInstance().common.ParamPath + "//"+ AppValue.GetInstance().common.ParamPath_vpp;

              

                //TB.Inputs["Image1"].Value = MyCommon.myImage1;
                AppValue.GetInstance().common.modelTB[AppValue.GetInstance().common.myImage_vpp].Inputs["OutputImage"].Value = AppValue.GetInstance().common.myImage[AppValue.GetInstance().common.myImage_vpp];
                AppValue.GetInstance().common.modelTB[AppValue.GetInstance().common.myImage_vpp].Run();

                AppValue.GetInstance().common.LB_1X[AppValue.GetInstance().common.myImage_vpp] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[AppValue.GetInstance().common.myImage_vpp].Outputs["X1"].Value.ToString());
                AppValue.GetInstance().common.LB_1Y[AppValue.GetInstance().common.myImage_vpp] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[AppValue.GetInstance().common.myImage_vpp].Outputs["Y1"].Value.ToString());
                AppValue.GetInstance().common.LB_1A[AppValue.GetInstance().common.myImage_vpp] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[AppValue.GetInstance().common.myImage_vpp].Outputs["A1"].Value.ToString());
                AppValue.GetInstance().common.LB_jieguo[AppValue.GetInstance().common.myImage_vpp] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[AppValue.GetInstance().common.myImage_vpp].Outputs["jieguo"].Value.ToString());

                uiLabel_X1.Text = AppValue.GetInstance().common.LB_1X[AppValue.GetInstance().common.myImage_vpp].ToString("f3");
                uiLabel_Y1.Text = AppValue.GetInstance().common.LB_1Y[AppValue.GetInstance().common.myImage_vpp].ToString("f3");
                uiLabel_A1.Text = AppValue.GetInstance().common.LB_1A[AppValue.GetInstance().common.myImage_vpp].ToString("f3");
                uiLabel_jieguo.Text = AppValue.GetInstance().common.LB_jieguo[AppValue.GetInstance().common.myImage_vpp].ToString();



                cogToolBlockEditV21.Subject = AppValue.GetInstance().common.modelTB[AppValue.GetInstance().common.myImage_vpp];
                uiLabel_Location.Text = path;
            }
            catch (Exception)
            {
                MessageBox.Show("没有当前视觉处理程序配方");
                this.Close();

            }
        }

   

        private void uiButton_WriteVpp_Click(object sender, EventArgs e)
        {
            try
            {
                 path = AppValue.GetInstance().common.ParamPath + "//" + AppValue.GetInstance().common.ParamPath_vpp; ;

                uiButton_WriteVpp.Text = "vpp程序保存中.........";
                uiButton_WriteVpp.Enabled = false;
                CogSerializer.SaveObjectToFile(cogToolBlockEditV21.Subject, path);
                AppValue.GetInstance().common.modelTB[AppValue.GetInstance().common.myImage_vpp] = CogSerializer.LoadObjectFromFile(path) as CogToolBlock;



                UIMessageBox.ShowSuccess("vpp保存成功");
                uiButton_WriteVpp.Text = "保存更新后程序";
                uiButton_WriteVpp.Enabled = true;
                this.Close();

            }
            catch (Exception ex)
            {
                uiButton_WriteVpp.Enabled = true;
                uiButton_WriteVpp.Text = "保存更新后程序";
                UIMessageBox.ShowError("vpp保存失败---" + ex.Message);

            }


        }

       
    }
}
