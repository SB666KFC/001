
using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.ToolBlock;
using MAGAN_EOLT;

using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace LaserAblation
{
    public partial class FormDisplayImage : UIForm
    {
        public FormDisplayImage()
        {
            InitializeComponent();
        }
        CogImage8Grey myImage;//定义照片类型（这里是黑白的）
        public CogImage8Grey myImage1;
        public CogImage8Grey myImage2;
        public CogImage8Grey myImage3;
        /// <summary>
        /// 相机切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiComboBox_SelectCam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                uiDoubleUpDown_Exposure.Value = Convert.ToDouble(AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex]);
                uiComboBox_VppModel.Text = AppValue.GetInstance().common.xiangjiVPP[uiComboBox_SelectCam.SelectedIndex];


            }
            catch (Exception)
            {
                MessageBox.Show("工位属性参数加载错误！", "错误信息提示");
            }
        }
        /// <summary>
        /// 单采集图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton_Once_Click(object sender, EventArgs e)
        {
            int se_1t1 = 0;
            cogRecordDisplay1.InteractiveGraphics.Clear();
            try
            {
                AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex] = uiDoubleUpDown_Exposure.Value;

                if (uiComboBox_SelectCam.SelectedIndex==0)
                {
                    se_1t1 = 0;
                    if (AppValue.GetInstance().common.myFifo[se_1t1] != null)
                    {

                        AppValue.GetInstance().common.ConfigureExposure(AppValue.GetInstance().common.myFifo[se_1t1], AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex]);

                        AppValue.GetInstance().common.GrabImage(se_1t1, out AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex]);
                        myImage = (CogImage8Grey)AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex];
                        cogRecordDisplay1.Image = myImage;

                        cogRecordDisplay1.Fit(true);
                    }
                    else
                    {
                        this.ShowWarningDialog(uiComboBox_SelectCam.Text + "未连接");
                    }
                }
                if (uiComboBox_SelectCam.SelectedIndex == 1)
                {
                    se_1t1 = 0;
                    if (AppValue.GetInstance().common.myFifo[se_1t1] != null)
                    {

                        AppValue.GetInstance().common.ConfigureExposure(AppValue.GetInstance().common.myFifo[se_1t1], AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex]);

                        AppValue.GetInstance().common.GrabImage(se_1t1, out AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex]);
                        myImage = (CogImage8Grey)AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex];
                        cogRecordDisplay1.Image = myImage;

                        cogRecordDisplay1.Fit(true);
                    }
                    else
                    {
                        this.ShowWarningDialog(uiComboBox_SelectCam.Text + "未连接");
                    }
                }

                if (uiComboBox_SelectCam.SelectedIndex == 2)
                {
                    se_1t1 = 1;
                    if (AppValue.GetInstance().common.myFifo[se_1t1] != null)
                    {

                        AppValue.GetInstance().common.ConfigureExposure(AppValue.GetInstance().common.myFifo[se_1t1], AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex]);

                        AppValue.GetInstance().common.GrabImage(se_1t1, out AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex]);
                        myImage = (CogImage8Grey)AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex];
                        cogRecordDisplay1.Image = myImage;

                        cogRecordDisplay1.Fit(true);
                    }
                    else
                    {
                        this.ShowWarningDialog(uiComboBox_SelectCam.Text + "未连接");
                    }
                }
                if (uiComboBox_SelectCam.SelectedIndex == 3)
                {
                    se_1t1 = 1;
                    if (AppValue.GetInstance().common.myFifo[se_1t1] != null)
                    {

                        AppValue.GetInstance().common.ConfigureExposure(AppValue.GetInstance().common.myFifo[se_1t1], AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex]);

                        AppValue.GetInstance().common.GrabImage(se_1t1, out AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex]);
                        myImage = (CogImage8Grey)AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex];
                        cogRecordDisplay1.Image = myImage;

                        cogRecordDisplay1.Fit(true);
                    }
                    else
                    {
                        this.ShowWarningDialog(uiComboBox_SelectCam.Text + "未连接");
                    }
                }
                if (uiComboBox_SelectCam.SelectedIndex == 4)
                {
                    se_1t1 = 2;
                    if (AppValue.GetInstance().common.myFifo[se_1t1] != null)
                    {

                        AppValue.GetInstance().common.ConfigureExposure(AppValue.GetInstance().common.myFifo[se_1t1], AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex]);

                        AppValue.GetInstance().common.GrabImage(se_1t1, out AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex]);
                        myImage = (CogImage8Grey)AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex];
                        cogRecordDisplay1.Image = myImage;

                        cogRecordDisplay1.Fit(true);
                    }
                    else
                    {
                        this.ShowWarningDialog(uiComboBox_SelectCam.Text + "未连接");
                    }
                }
                if (uiComboBox_SelectCam.SelectedIndex == 5)
                {
                    se_1t1 = 3;
                    if (AppValue.GetInstance().common.myFifo[se_1t1] != null)
                    {

                        AppValue.GetInstance().common.ConfigureExposure(AppValue.GetInstance().common.myFifo[se_1t1], AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex]);

                        AppValue.GetInstance().common.GrabImage(se_1t1, out AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex]);
                        myImage = (CogImage8Grey)AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex];
                        cogRecordDisplay1.Image = myImage;

                        cogRecordDisplay1.Fit(true);
                    }
                    else
                    {
                        this.ShowWarningDialog(uiComboBox_SelectCam.Text + "未连接");
                    }
                }
                if (uiComboBox_SelectCam.SelectedIndex == 6)
                {
                    se_1t1 = 4;
                    if (AppValue.GetInstance().common.myFifo[se_1t1] != null)
                    {

                        AppValue.GetInstance().common.ConfigureExposure(AppValue.GetInstance().common.myFifo[se_1t1], AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex]);

                        AppValue.GetInstance().common.GrabImage(se_1t1, out AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex]);
                        myImage = (CogImage8Grey)AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex];
                        cogRecordDisplay1.Image = myImage;

                        cogRecordDisplay1.Fit(true);
                    }
                    else
                    {
                        this.ShowWarningDialog(uiComboBox_SelectCam.Text + "未连接");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "错误信息提示");
            }
        }
        /// <summary>
        /// 实时拍照相机状态
        /// </summary>
        public int tingzhi_1;

        public int tingzhi_2;

        /// <summary>
        /// 相机分量
        /// </summary>
       public int se_1t1;
        /// <summary>
        /// 实时采集图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton_Live_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (uiButton_Live.Text == "实时采集")
                {
                    tingzhi_2 = uiComboBox_SelectCam.SelectedIndex;


                    tingzhi_1 = 0;
                    uiButton_Live.Text = "停止";
                    AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex] = uiDoubleUpDown_Exposure.Value;


                    if (uiComboBox_SelectCam.SelectedIndex == 0)
                    {
                        se_1t1 = 0;
                        if (AppValue.GetInstance().common.myFifo[se_1t1] != null)
                        {
                            AppValue.GetInstance().common.ConfigureExposure(AppValue.GetInstance().common.myFifo[se_1t1], AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex]);



                            if (AppValue.GetInstance().common.myFifo[se_1t1].CameraPort >= 0)
                            {

                                
                                Thread thread10 = new Thread(new ThreadStart(xiangji1shishi1));//创建线程

                                thread10.IsBackground = true;//设置线程为后台线程
                                thread10.Start();
                            }
                        }
                        else
                        {
                            this.ShowWarningDialog(uiComboBox_SelectCam.Text + "未连接");
                        }
                    }
                    if (uiComboBox_SelectCam.SelectedIndex == 1)
                    {
                        se_1t1 = 0;
                        if (AppValue.GetInstance().common.myFifo[se_1t1] != null)
                        {
                            AppValue.GetInstance().common.ConfigureExposure(AppValue.GetInstance().common.myFifo[se_1t1], AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex]);



                            if (AppValue.GetInstance().common.myFifo[se_1t1].CameraPort >= 0)
                            {


                                Thread thread10 = new Thread(new ThreadStart(xiangji1shishi1));//创建线程

                                thread10.IsBackground = true;//设置线程为后台线程
                                thread10.Start();
                            }
                        }
                        else
                        {
                            this.ShowWarningDialog(uiComboBox_SelectCam.Text + "未连接");
                        }
                    }
                    if (uiComboBox_SelectCam.SelectedIndex == 2)
                    {
                        se_1t1 = 1;
                        if (AppValue.GetInstance().common.myFifo[se_1t1] != null)
                        {
                            AppValue.GetInstance().common.ConfigureExposure(AppValue.GetInstance().common.myFifo[se_1t1], AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex]);



                            if (AppValue.GetInstance().common.myFifo[se_1t1].CameraPort >= 0)
                            {


                                Thread thread10 = new Thread(new ThreadStart(xiangji1shishi1));//创建线程

                                thread10.IsBackground = true;//设置线程为后台线程
                                thread10.Start();
                            }
                        }
                        else
                        {
                            this.ShowWarningDialog(uiComboBox_SelectCam.Text + "未连接");
                        }
                    }
                    if (uiComboBox_SelectCam.SelectedIndex == 3)
                    {
                        se_1t1 = 1;
                        if (AppValue.GetInstance().common.myFifo[se_1t1] != null)
                        {
                            AppValue.GetInstance().common.ConfigureExposure(AppValue.GetInstance().common.myFifo[se_1t1], AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex]);



                            if (AppValue.GetInstance().common.myFifo[se_1t1].CameraPort >= 0)
                            {


                                Thread thread10 = new Thread(new ThreadStart(xiangji1shishi1));//创建线程

                                thread10.IsBackground = true;//设置线程为后台线程
                                thread10.Start();
                            }
                        }
                        else
                        {
                            this.ShowWarningDialog(uiComboBox_SelectCam.Text + "未连接");
                        }
                    }
                    if (uiComboBox_SelectCam.SelectedIndex == 4)
                    {
                        se_1t1 = 2;
                        if (AppValue.GetInstance().common.myFifo[se_1t1] != null)
                        {
                            AppValue.GetInstance().common.ConfigureExposure(AppValue.GetInstance().common.myFifo[se_1t1], AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex]);



                            if (AppValue.GetInstance().common.myFifo[se_1t1].CameraPort >= 0)
                            {


                                Thread thread10 = new Thread(new ThreadStart(xiangji1shishi1));//创建线程

                                thread10.IsBackground = true;//设置线程为后台线程
                                thread10.Start();
                            }
                        }
                        else
                        {
                            this.ShowWarningDialog(uiComboBox_SelectCam.Text + "未连接");
                        }
                    }
                    if (uiComboBox_SelectCam.SelectedIndex == 5)
                    {
                        se_1t1 = 3;
                        if (AppValue.GetInstance().common.myFifo[se_1t1] != null)
                        {
                            AppValue.GetInstance().common.ConfigureExposure(AppValue.GetInstance().common.myFifo[se_1t1], AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex]);



                            if (AppValue.GetInstance().common.myFifo[se_1t1].CameraPort >= 0)
                            {


                                Thread thread10 = new Thread(new ThreadStart(xiangji1shishi1));//创建线程

                                thread10.IsBackground = true;//设置线程为后台线程
                                thread10.Start();
                            }
                        }
                        else
                        {
                            this.ShowWarningDialog(uiComboBox_SelectCam.Text + "未连接");
                        }
                    }
                    if (uiComboBox_SelectCam.SelectedIndex == 6)
                    {
                        se_1t1 = 4;
                        if (AppValue.GetInstance().common.myFifo[se_1t1] != null)
                        {
                            AppValue.GetInstance().common.ConfigureExposure(AppValue.GetInstance().common.myFifo[se_1t1], AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex]);



                            if (AppValue.GetInstance().common.myFifo[se_1t1].CameraPort >= 0)
                            {


                                Thread thread10 = new Thread(new ThreadStart(xiangji1shishi1));//创建线程

                                thread10.IsBackground = true;//设置线程为后台线程
                                thread10.Start();
                            }
                        }
                        else
                        {
                            this.ShowWarningDialog(uiComboBox_SelectCam.Text + "未连接");
                        }
                    }
                }
                else
                {
                    uiButton_Live.Text = "实时采集";
                    tingzhi_1 = 1;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "错误信息提示");
            }

        }

        /// <summary>
        /// 相机1实时
        /// </summary>
        public void xiangji1shishi1()
        {
            while (true)
            {
                // UInt16 active_level = 0;
                UInt16 bitno = 0;
                int sleep_body = 50;
                AppValue.GetInstance().common.GrabImage(se_1t1, out AppValue.GetInstance().common.myImage[tingzhi_2]);
                myImage = (CogImage8Grey)AppValue.GetInstance().common.myImage[tingzhi_2];
                cogRecordDisplay1.Image = myImage;

                cogRecordDisplay1.Fit(true);

                Thread.Sleep(sleep_body); //睡眠xxx毫秒，元件持续时间
                if (tingzhi_1 == 1)
                {
                    break;
                }
            }

        }







        //  CogToolBlock TB = new CogToolBlock();
        private void FormDisplayImage_Load(object sender, EventArgs e)
        {
            uiComboBox_SelectCam.SelectedIndex = 0;

            List<string> ProductsName = new List<string>();// 存放所有产品名称
            string[] filesWithExtension = System.IO.Directory.GetFiles(AppValue.GetInstance().ParamPath, "*" + "vpp").Where(file => !string.IsNullOrEmpty(file)).ToArray();
            ProductsName.Clear();
            if (filesWithExtension.Length > 0)
            {
                foreach (var item in filesWithExtension)
                {
                    string[] mName = item.Split('\\');
                    uiComboBox_VppModel.Items.Add(mName[mName.Length - 1]);
                }

            }

            uiDoubleUpDown_Exposure.Value = AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex];
            uiComboBox_VppModel.Text = AppValue.GetInstance().common.xiangjiVPP[uiComboBox_SelectCam.SelectedIndex];



            uiComboBox_SelectCam.SelectedIndex = 0;




        }

        private void uiButton_vpp_Click(object sender, EventArgs e)
        {
            AppValue.GetInstance().common.ParamPath_vpp = uiComboBox_VppModel.Text;
            AppValue.GetInstance().common.myImage_vpp = uiComboBox_SelectCam.SelectedIndex;
            FormVpp frmvpp = new FormVpp();
            frmvpp.Model = uiComboBox_VppModel.Text.ToString();
            frmvpp.ShowDialog();

        }

        private void uiButton_SaverCamParas_Click(object sender, EventArgs e)
        {


        }





        private void uiButton1_Click(object sender, EventArgs e)
        {
            AppValue.GetInstance().common.openimage(out AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex]);
            cogRecordDisplay1.Image = AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex];

            cogRecordDisplay1.Fit(true);

        }
        /// <summary>
        /// 曝光调整
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void uiDoubleUpDown_Exposure_ValueChanged(object sender, double value)
        {
            AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex] = uiDoubleUpDown_Exposure.Value;
        }
        /// <summary>
        /// 相机绑定的VPP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton3_Click(object sender, EventArgs e)
        {

            try
            {
                AppValue.GetInstance().common.exposure[uiComboBox_SelectCam.SelectedIndex] = uiDoubleUpDown_Exposure.Value;
                AppValue.GetInstance().common.xiangjiVPP[uiComboBox_SelectCam.SelectedIndex] = uiComboBox_VppModel.Text;

                AppValue.GetInstance().common.baocun();
            }
            catch (Exception)
            {
                MessageBox.Show("相机属性参数加载错误！", "错误信息提示");
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            try
            {
               

            //  

                //TB.Inputs["Image1"].Value = MyCommon.myImage1;
                AppValue.GetInstance().common.modelTB[uiComboBox_SelectCam.SelectedIndex].Inputs["OutputImage"].Value = AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex];

                AppValue.GetInstance().common.modelTB[uiComboBox_SelectCam.SelectedIndex].Run();

                AppValue.GetInstance().common.LB_1X[AppValue.GetInstance().common.myImage_vpp] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[uiComboBox_SelectCam.SelectedIndex].Outputs["X1"].Value.ToString());
                AppValue.GetInstance().common.LB_1Y[AppValue.GetInstance().common.myImage_vpp] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[uiComboBox_SelectCam.SelectedIndex].Outputs["Y1"].Value.ToString());
                AppValue.GetInstance().common.LB_1A[AppValue.GetInstance().common.myImage_vpp] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[uiComboBox_SelectCam.SelectedIndex].Outputs["A1"].Value.ToString());
                AppValue.GetInstance().common.LB_jieguo[AppValue.GetInstance().common.myImage_vpp] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[uiComboBox_SelectCam.SelectedIndex].Outputs["jieguo"].Value.ToString());

                if (AppValue.GetInstance().common.LB_jieguo[AppValue.GetInstance().common.myImage_vpp] != -999999)
                {
                    cogRecordDisplay1.Record = AppValue.GetInstance().common.modelTB[uiComboBox_SelectCam.SelectedIndex].CreateLastRunRecord().SubRecords[0];
                    cogRecordDisplay1.Fit(true);
                }
                else
                {
                    cogRecordDisplay1.Record = AppValue.GetInstance().common.modelTB[uiComboBox_SelectCam.SelectedIndex].CreateLastRunRecord().SubRecords[0];
                    cogRecordDisplay1.Fit(true);
                }





            }
            catch (Exception)
            {
                MessageBox.Show("没有当前视觉处理程序配方");
                this.Close();


            }
        }
        public string[] B_files;

        public int B_subDirectoryCount;
        CogImageFileTool mImageFileTool = new CogImageFileTool();
        private void uiButton16_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dlg = new FolderBrowserDialog();

            if (Dlg.ShowDialog() == DialogResult.OK)
            {

                //获取文件夹子目录数量
                B_subDirectoryCount = Directory.GetFiles(Dlg.SelectedPath).Length;

                B_files = Directory.GetFiles(Dlg.SelectedPath);

                uiLabel134.Text = "0/" + B_subDirectoryCount;
                uiTrackBar1.Maximum = B_subDirectoryCount - 1;



                mImageFileTool.Operator.Open(B_files[0], CogImageFileModeConstants.Read);
                mImageFileTool.Run();
                AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex] = mImageFileTool.OutputImage as CogImage8Grey;

            }
        }

        private void uiTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                uiLabel134.Text = uiTrackBar1.Value + "/" + B_subDirectoryCount;
                mImageFileTool.Operator.Open(B_files[uiTrackBar1.Value], CogImageFileModeConstants.Read);
                mImageFileTool.Run();
                AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex] = mImageFileTool.OutputImage as CogImage8Grey;

                cogRecordDisplay1.Image = AppValue.GetInstance().common.myImage[uiComboBox_SelectCam.SelectedIndex];

                cogRecordDisplay1.Fit(true);
            }
            catch (Exception)
            {
                this.ShowWarningDialog("请先访问追溯文件");
            }
        }

        private void uiSymbolButton9_Click(object sender, EventArgs e)
        {
            uiTrackBar1.Value = uiTrackBar1.Value - 1;
        }

        private void uiSymbolButton5_Click(object sender, EventArgs e)
        {
            uiTrackBar1.Value = uiTrackBar1.Value + 1;
        }
    }
}
