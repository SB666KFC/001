using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;

using MAGAN_EOLT;


using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LaserAblation
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppValue.GetInstance().common.m_Camera = new bool[AppValue.GetInstance().common.xiangjishuliang];
            AppValue.GetInstance().common.cameraSN = new string[AppValue.GetInstance().common.xiangjishuliang];
            AppValue.GetInstance().common.exposure = new double[AppValue.GetInstance().common.xiangjishuliang];
            AppValue.GetInstance().common.xiangjiVPP = new string[AppValue.GetInstance().common.xiangjishuliang];
            AppValue.GetInstance().common.modelTB = new CogToolBlock[AppValue.GetInstance().common.xiangjishuliang];
            AppValue.GetInstance().common.myImage = new CogImage8Grey[AppValue.GetInstance().common.xiangjishuliang];
            AppValue.GetInstance().common.myFifo = new ICogAcqFifo[AppValue.GetInstance().common.xiangjishuliang];

            AppValue.GetInstance().common.myImage_baocun=new CogImage8Grey[AppValue.GetInstance().common.xiangjishuliang];

            AppValue.GetInstance().common.LB_1X = new double[AppValue.GetInstance().common.xiangjishuliang];
            AppValue.GetInstance().common.LB_1Y = new double[AppValue.GetInstance().common.xiangjishuliang];
            AppValue.GetInstance().common.LB_1A = new double[AppValue.GetInstance().common.xiangjishuliang];
            AppValue.GetInstance().common.LB_jieguo = new double[AppValue.GetInstance().common.xiangjishuliang];


            AppValue.GetInstance().common.xiangji_1zs = new double[AppValue.GetInstance().common.xiangjishuliang];
            AppValue.GetInstance().common.xiangji_1OK = new double[AppValue.GetInstance().common.xiangjishuliang];
            AppValue.GetInstance().common.xiangji_1NG = new double[AppValue.GetInstance().common.xiangjishuliang];
            AppValue.GetInstance().common.xiangji_1LY = new double[AppValue.GetInstance().common.xiangjishuliang];
            AppValue.GetInstance().common.xiangji_1SJ = new double[AppValue.GetInstance().common.xiangjishuliang];
            AppValue.GetInstance().common.elapsedTimeMilliseconds = new long[AppValue.GetInstance().common.xiangjishuliang];

            AppValue.GetInstance().common.xiangji_jieguo=new string[AppValue.GetInstance().common.xiangjishuliang];



            AppValue.GetInstance().common.cameraSN = new string[AppValue.GetInstance().common.xiangjishuliang];

            AppValue.GetInstance().common.plc_写入结果= new string[7];
            AppValue.GetInstance().common.plc_读取触发 = new string[7];
            AppValue.GetInstance().common.xiangji_角度 = new string[7];
            AppValue.GetInstance().common.xiangji_X = new string[7];
            AppValue.GetInstance().common.xiangji_Y = new string[7];
            AppValue.GetInstance().common.plc_读取数值 = new string[7];
            AppValue.GetInstance().common.plc_写入数值 = new int[7];
     
            AppValue.GetInstance().common.xiangji_角度数值 = new double[7];
            AppValue.GetInstance().common.xiangji_X数值 = new double[7];
            AppValue.GetInstance().common.xiangji_Y数值 = new double[7];

            AppValue.GetInstance().common.gongweiyitiaoshicanshu_1 = new string[6];
            AppValue.GetInstance().common.gongweiyitiaoshicanshu_2 = new string[6];
            AppValue.GetInstance().common.gongweiyitiaoshicanshu_3 = new string[6];
            AppValue.GetInstance().common.gongweiyitiaoshicanshu_4 = new string[6];






            AppValue.GetInstance().common.LoadParam();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //禁止文件多开
            bool isClosed;
            var m = new Mutex(true, "LaserAblation", out isClosed);
            if (!isClosed)
            {
                UIMessageBox.ShowError("LaserAblation程序已打开，不可重复打开！");
                Application.Exit();
                return;
            }


            //Mutex instance = new Mutex(true, "LaserAblation", out bool IsCreateNew);
            //if (!IsCreateNew)
            //{
            //    UIMessageBox.ShowError("LaserAblation程序已打开，不可重复打开！");
            //    Application.Exit();
            //    return;
            //}

            //Splash开机动画
            FormSplash splash = new FormSplash();
            splash.uiProcessBar1.Maximum = 10;
            splash.uiProcessBar1.Value = 0;
            splash.ClearInfo();
            splash.ShowInfo("启动......");

            //修改 AssemblyInfo.vb 中的信息改变程序版本号
            splash.uiLabel2.Text = "Version : " + "V" + Application.ProductVersion;
            splash.Show();
            splash.Update();

            bool flag = true;

            try
            {
                splash.ShowInfo("连接相机......");
                splash.uiProcessBar1.StepIt();
                splash.Update();
                #region 连接相机
                //读取相机信息

                //加载配置文件相机参数


                //连接相机

                AppValue.GetInstance().common.SetAcqFifo(AppValue.GetInstance().common.cameraSN, ref AppValue.GetInstance().common.m_Camera);
                #endregion

                splash.ShowInfo("初始化IO......");
                splash.uiProcessBar1.StepIt();
                splash.Update();


                splash.ShowInfo("加载VPP程序......");
                splash.uiProcessBar1.StepIt();
                splash.Update();
                #region 加载Vpp
                //读取产品型号


                string[] modelpath = new string[AppValue.GetInstance().xiangjishuliang];
                for (int i = 0; i < AppValue.GetInstance().xiangjishuliang; i++)
                {
                    //相机1vpp
                    modelpath[i] = AppValue.GetInstance().ParamPath +"//"+ AppValue.GetInstance().common.xiangjiVPP[i];
                    try
                    {

                        AppValue.GetInstance().common.modelTB[i] = CogSerializer.LoadObjectFromFile(modelpath[i]) as CogToolBlock;
                        splash.ShowInfo("加载VPP程序-" + modelpath[i] + "......");
                        splash.uiProcessBar1.StepIt();
                        splash.Update();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }






                #endregion

                splash.ShowInfo("连接PLC......");
                splash.uiProcessBar1.StepIt();
                splash.Update();

                AppValue.GetInstance().common.PLC_L连接(AppValue.GetInstance().common.PLC_ip);

                Thread.Sleep(100);
                flag = true;
            }
            catch (Exception ex)
            {
                flag = false;
                UIMessageBox.ShowError(ex.ToString());
            }

            if (flag == false)
            {
                splash.Close();
                //程序强制退出
                Application.Exit();
            }
            else
            {
                splash.ShowInfo("Complete");
                splash.uiProcessBar1.Value = splash.uiProcessBar1.Maximum;
                splash.Update();
                Thread.Sleep(20);
                splash.Close();
            }



            Application.Run(new FormMin());
        }
    }
}
