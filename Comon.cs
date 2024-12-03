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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;


namespace LaserAblation
{
    public class Comon
    {

        //Log日志显示类型

        // public object m_lock = new object();

        //public Dictionary<string, string> m_CompensationParam = new Dictionary<string, string>();//补偿值
        //public Dictionary<string, string> m_StandardParam = new Dictionary<string, string>();//标准值
        //public Dictionary<string, string> m_LasearRecipe = new Dictionary<string, string>();//刻印配方

        #region 相机连接

        /// <summary>
        /// 相机数量
        /// </summary>
        public int xiangjishuliang = 7;

        #region   PLC通讯
        /// <summary>
        /// PLC连接对象
        /// </summary>
        public Plc siemens;
        /// <summary>
        /// plcIP
        /// </summary>
        public string PLC_ip;



        /// <summary>
        /// 读取数值
        /// </summary>
        public string[] plc_读取触发;
        /// <summary>
        /// plc写入结果
        /// </summary>
        public string[] plc_写入结果;

        public string[] xiangji_角度;

        public string[] xiangji_X;

        public string[] xiangji_Y;






        /// <summary>
        /// plc读取数值
        /// </summary>
        public string[] plc_读取数值;

        /// <summary>
        /// plc写入数值
        /// </summary>
        public int[] plc_写入数值;

        public double[] xiangji_角度数值;

        public double[] xiangji_X数值;

        public double[] xiangji_Y数值;


        /// <summary>
        /// PLC_状态
        /// </summary>
        public bool PLC_状态;



        #endregion

        //public string guanbi = "false";//关闭程序




        //public string ParamPathBC;//保存路径
        public string ParamPath;





        public void PLC_L连接(string se)
        {
            try
            {

                AppValue.GetInstance().common.siemens = new Plc(CpuType.S71200, se, 0, 1);


                // 连接对象
                AppValue.GetInstance().common.siemens.Open();
                if (!AppValue.GetInstance().common.siemens.IsConnected)
                {
                    AppValue.GetInstance().common.PLC_状态 = false;
                }
                else
                {
                    AppValue.GetInstance().common.PLC_状态 = true;

                }
            }
            catch
            {

                AppValue.GetInstance().common.PLC_状态 = false;
            }
        }

        /// <summary>
        /// PLC_断开
        /// </summary>
        /// <param name="se"></param>
        /// <param name="z3"></param>
        public void PLC_断开()
        {
            if (AppValue.GetInstance().common.PLC_状态 == true)
            {
                try
                {
                    AppValue.GetInstance().common.siemens.Close();
                    AppValue.GetInstance().common.PLC_状态 = false;

                }
                catch
                {

                }
            }
            else
            {
                AppValue.GetInstance().common.PLC_状态 = false;
            }

        }


        /// <summary>
        /// VPP中转路径
        /// </summary>
        public string ParamPath_vpp;//参数保存路径
        /// <summary>
        /// VPP中转图像标签
        /// </summary>
        public int myImage_vpp;//参数保存路径
                               //图像采集变量的定义
        public CogFrameGrabbers fgs;


        /// <summary>
        /// 相机图片对象
        /// </summary>
        public ICogAcqFifo[] myFifo;

        #region 相机参数
        /// <summary>
        /// 相机状态
        /// </summary>
        public bool[] m_Camera;


        /// <summary>
        /// 相机SN号
        /// </summary>
        public string[] cameraSN;

        /// <summary>
        /// 相机曝光
        /// </summary>
        public double[] exposure;
        /// <summary>
        /// 相机名称
        /// </summary>
        public string[] xiangjiVPP;

        /// <summary>
        /// 相机VPP对象
        /// </summary>
        public CogToolBlock[] modelTB;

        /// <summary>
        /// 相机图片对象
        /// </summary>
        public CogImage8Grey[] myImage;

        /// <summary>
        /// 相机图片对象保存中转
        /// </summary>
        public CogImage8Grey[] myImage_baocun;



        #endregion

        #region 工位结果参数
        /// <summary>
        /// 工位参数名称
        /// </summary>
        public string canshumingc;


        /// <summary>
        /// 工位号
        /// </summary>
        public int gongweihao;


        /// <summary>
        /// 工位参数1
        /// </summary>
        public string[] gongweiyitiaoshicanshu_1;
        /// <summary>
        /// 工位参数2
        /// </summary>
        public string[] gongweiyitiaoshicanshu_2;
        /// <summary>
        /// 工位参数3
        /// </summary>
        public string[] gongweiyitiaoshicanshu_3;
        /// <summary>
        /// 工位参数4
        /// </summary>
        public string[] gongweiyitiaoshicanshu_4;





        //相机1
        /// <summary>
        /// 输出X坐标值
        /// </summary>
        public double[] LB_1X;
        /// <summary>
        /// 输出Y坐标值
        /// </summary>
        public double[] LB_1Y;
        /// <summary>
        /// 输出角度值
        /// </summary>
        public double[] LB_1A;
        /// <summary>
        /// 输出结果数组
        /// </summary>
        public double[] LB_jieguo;

        #endregion

        #region  系统功能参数
        /// <summary>
        /// 中转限权
        /// </summary>
        public string xianquan;

        /// <summary>
        /// 管理员
        /// </summary>
        public string guangliyuan;

        /// <summary>
        /// 工程师
        /// </summary>
        public string gongcshi;
        /// <summary>
        /// 消耗时间
        /// </summary>
        public long[] elapsedTimeMilliseconds;


        /// <summary>
        /// 保存路径
        /// </summary>
        public string zaopiancunchulujing;

        /// <summary>
        /// 工站名称
        /// </summary>
        public string gongzhanming;

        /// <summary>
        /// 在产型号
        /// </summary>
        public string xianyouchanpin;

        /// <summary>
        /// 图片保存数量
        /// </summary>
        public int zaopiancunchushuliang;

        /// <summary>
        /// 图片保存天数
        /// </summary>
        public int zaopiancunchutianshu;

        #endregion


        #region 生产信息
        /// <summary>
        /// 相机总数
        /// </summary>
        public double[] xiangji_1zs;
        /// <summary>
        /// 相机OK
        /// </summary>
        public double[] xiangji_1OK;
        /// <summary>
        /// 相机NG
        /// </summary>
        public double[] xiangji_1NG;
        /// <summary>
        /// 相机良率
        /// </summary>
        public double[] xiangji_1LY;
        /// <summary>
        /// 处理时间
        /// </summary>
        public double[] xiangji_1SJ;

        /// <summary>
        /// 处理结果
        /// </summary>
        public string[] xiangji_jieguo;




        #endregion






        //public CogImage24PlanarColor colorImage;


        //字段
        public double _mexposure;
        public double _mbright;
        public double _mconstrast;



        /// <summary>
        /// Configures a GigE camera's exposure using the standard
        /// VisionPro interface.
        /// </summary>
        /// <param name="AcqFifo"></param>
        /// <param name="Exposure"></param>
        public void ConfigureExposure(ICogAcqFifo acqFifo, double exposure)
        {
            // Get a reference to the ExposureParams interface of the AcqFifo.
            ICogAcqExposure exposureParams = acqFifo.OwnedExposureParams;
            // Always check to see an "Owned" property is supported
            // before using it.
            if (exposureParams != null)  // Check for exposure support.
            {
                exposureParams.Exposure = exposure;  // sets ExposureTimeAbs
                acqFifo.Prepare();  // writes the properties to the camera.
            }
        }

        public void ConfigureBright(ICogAcqFifo acqFifo, double bright)
        {
            // Get a reference to the ExposureParams interface of the AcqFifo.
            ICogAcqBrightness brightParams = acqFifo.OwnedBrightnessParams;
            // Always check to see an "Owned" property is supported
            // before using it.
            if (brightParams != null)  // Check for exposure support.
            {
                brightParams.Brightness = bright;  // sets brightTimeAbs
                acqFifo.Prepare();  // writes the properties to the camera.
            }
        }

        public void ConfigureConstrast(ICogAcqFifo acqFifo, double constrast)
        {
            // Get a reference to the ExposureParams interface of the AcqFifo.
            ICogAcqContrast ConstrastParams = acqFifo.OwnedContrastParams;
            // Always check to see an "Owned" property is supported
            // before using it.
            if (ConstrastParams != null)  // Check for exposure support.
            {
                ConstrastParams.Contrast = constrast;  // sets brightTimeAbs
                acqFifo.Prepare();  // writes the properties to the camera.
            }
        }

        /// <summary>
        /// 通过相机的SN设置取像工具
        /// </summary>
        /// <param name="SN1">相机1 SN</param>
        /// <param name="SN2">相机2 SN</param>
        public void SetAcqFifo(string[] SN, ref bool[] Camare)
        {
            try
            {
                bool[] hasCamera = new bool[AppValue.GetInstance().xiangjishuliang];

                CogFrameGrabbers fgs = new CogFrameGrabbers();

                foreach (ICogFrameGrabber fg in fgs)
                {
                    if (fg.OwnedGigEAccess != null)
                    {
                        if (fg.SerialNumber.Contains(SN[0]))
                        {
                            if (fg.AvailableVideoFormats[0].Contains("Color"))
                            {
                                myFifo[0] = fg.CreateAcqFifo(fg.AvailableVideoFormats[1], CogAcqFifoPixelFormatConstants.Format8Grey, 0, true);
                            }
                            else
                            {
                                myFifo[0] = fg.CreateAcqFifo(fg.AvailableVideoFormats[0], CogAcqFifoPixelFormatConstants.Format8Grey, 0, true);
                            }
                            hasCamera[0] = true;
                        }
                        else if (fg.SerialNumber.Contains(SN[1]))
                        {
                            if (fg.AvailableVideoFormats[0].Contains("Color"))
                            {
                                myFifo[1] = fg.CreateAcqFifo(fg.AvailableVideoFormats[1], CogAcqFifoPixelFormatConstants.Format8Grey, 0, true);
                            }
                            else
                            {
                                myFifo[1] = fg.CreateAcqFifo(fg.AvailableVideoFormats[0], CogAcqFifoPixelFormatConstants.Format8Grey, 0, true);
                            }
                            hasCamera[1] = true;
                        }
                        else if (fg.SerialNumber.Contains(SN[2]))
                        {
                            if (fg.AvailableVideoFormats[0].Contains("Color"))
                            {
                                myFifo[2] = fg.CreateAcqFifo(fg.AvailableVideoFormats[1], CogAcqFifoPixelFormatConstants.Format8Grey, 0, true);
                            }
                            else
                            {
                                myFifo[2] = fg.CreateAcqFifo(fg.AvailableVideoFormats[0], CogAcqFifoPixelFormatConstants.Format8Grey, 0, true);
                            }
                            hasCamera[2] = true;
                        }
                        else if (fg.SerialNumber.Contains(SN[3]))
                        {
                            if (fg.AvailableVideoFormats[0].Contains("Color"))
                            {
                                myFifo[3] = fg.CreateAcqFifo(fg.AvailableVideoFormats[1], CogAcqFifoPixelFormatConstants.Format8Grey, 0, true);
                            }
                            else
                            {
                                myFifo[3] = fg.CreateAcqFifo(fg.AvailableVideoFormats[0], CogAcqFifoPixelFormatConstants.Format8Grey, 0, true);
                            }
                            hasCamera[3] = true;
                        }

                    }
                    else
                    {
                        MessageBox.Show("目前该程序只支持Gige相机的取像,期待后续升级!", "异常信息");
                    }


                }

                for (int i = 0; i < AppValue.GetInstance().xiangjishuliang; i++)
                {
                    Camare[i] = hasCamera[i];

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("发生以下错误信息\n" + ex.Message, "相机连接异常");
            }
        }

        /// <summary>
        /// 采集图像
        /// </summary>
        /// <param name="index">相机序号</param>
        public void GrabImage_1(int index, out CogImage8Grey myImage1)
        {
            myImage1 = null;
            try
            {






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常信息");
            }

        }
        public void CloseCamera()
        {
            CogFrameGrabbers frameGrabbers = new CogFrameGrabbers();
            foreach (ICogFrameGrabber fg in frameGrabbers)
                fg.Disconnect(false);
        }

        /// <summary>
        /// 采集图像
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public void GrabImage(int index, out CogImage8Grey myImage1)
        {
            myImage1 = null;
            try
            {
                if (AppValue.GetInstance().common.myFifo[index] != null)
                {
                    if (AppValue.GetInstance().common.myFifo[index].CameraPort >= 0)
                    {
                        int triggerNumber1;
                        myImage1 = (CogImage8Grey)AppValue.GetInstance().common.myFifo[index].Acquire(out triggerNumber1);
                        triggerNumber1++;
                        if (triggerNumber1 > 1)
                        {
                            GC.Collect();
                            triggerNumber1 = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("相机已丢失！", "取像时...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError(ex.ToString());
            }
        }

        /// <summary>
        /// 打开图像
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public void openimage(out CogImage8Grey myImage1)
        {
            myImage1 = null;
            CogImageFileTool mImageFileTool = new CogImageFileTool();

            OpenFileDialog Dlg = new OpenFileDialog();
            Dlg.Filter = "(*.bmp;)|*.bmp;";//文件格式信息


            Dlg.Multiselect = false;//是否读取多文件

            if (Dlg.ShowDialog() == DialogResult.OK)
            {


                mImageFileTool.Operator.Open(Dlg.FileName, CogImageFileModeConstants.Read);
                mImageFileTool.Run();
                myImage1 = mImageFileTool.OutputImage as CogImage8Grey;


            }

            Dlg.Dispose();
            //        mImageFileTool.Dispose();




        }

        #endregion





        #region 刻印机通讯
        //刻印机
        public bool m_LasearCondition = false;//刻印机连接状态
        public string m_IPAddrLaser;//刻印机IP
        public string m_LaserPort;//刻印机端口号

        public string Group;//刻印图纸
        public object m_LasearLock = new object();//给刻印通讯加锁

        public static bool m_LasearSendComplete = false;//刻印信息发送完成标准
        #endregion

        #region PLC通讯
        //PLC
        public bool m_PLCCondition = false;//PLC连接状态
        public bool m_PLCPrivilege = false;//PLC连接权限

        public string m_IPAddrPLC = "192.168.3.30";
        public int m_LCPort = 3000;



        public int dm1count = 0, dm2count = 0, dm3count = 0, dm4count = 0, dm5count = 0, dm6count = 0, dm7count = 0, dm8count = 0;

        /// <summary>
        /// DMCE_Running  DMCE要料状态
        /// </summary>
   //     public bool[] DMCE_Running = new bool[4];
        //设备编号
        public int EquipmentNume;

        public string Lasermodel = "";//型号
        #endregion

        #region MES通讯
        public string m_MESIP;//MES系统IP地址
        public string m_MESIPortNumber;//MES系统端口号
        public string client;//socket通讯在线地址
        public bool LastCommunication = false;//通讯成功标志
        #endregion

        #region 运动控制
        public int m_IntervalTime = 1000;//报警指示灯间隔时间
        public EStatusMachine MachineStatus;//设备状态存储
        public EStatusMachine m_MachineStatus;//设备异常设备状态储存
        public enum EStatusMachine
        {
            STARTUP,   //待复位
            READY,     //待运行
            RUNNING,  //运行中
            RESETING, //复位中
            ALARMED,  //报警
            PAUSED,   //暂停
            EMERGENCY,  //急停
            NULL,//空
            RESETSUCCESS,//复位成功
            MANUAL//手动
        }

        //延时时间
        public int m_WaitTime = 1000;//进料等待时间
        public int m_CylinderDelayTime = 5000;//气缸延迟时间
        public int m_FeedDelayTime = 5000;//进料延迟时间
        public int m_PlaceDelayTime = 500;//到位延迟时间

        //定时器
        public DateTime m_FlowTime;//上料时间记录
        public DateTime m_WaitingTime;//等料位时间记录
        public DateTime m_LeaserTime;//刻印位时间记录
        public DateTime m_LeaserTimeTwo;//刻印位2时间记录
        public DateTime m_NewTime;//生产时间
        public DateTime m_PipelineTime;//输送线时间记录








        public int m_QueuesNumber = 0;//输送新排队数量
        #endregion

        #region
        public string m_OneProbuctModel;//单独产品型号
        #endregion

        #region 生产记录
        public int m_AblationNumber = 0;//刻印总量

        //产品数量
        public int m_DMCE1Number = 0;
        public int m_DMCE2Number = 0;
        public int m_DMCE3Number = 0;
        public int m_DMCE4Number = 0;
        public int m_DMCE5Number = 0;
        public int m_DMCE6Number = 0;
        public int m_DMCE7Number = 0;
        public int m_DMCE8Number = 0;

        //当班产品数量
        public int m_DMCE1count = 0;
        public int m_DMCE2count = 0;
        public int m_DMCE3count = 0;
        public int m_DMCE4count = 0;
        public int m_DMCE5count = 0;
        public int m_DMCE6count = 0;
        public int m_DMCE7count = 0;
        public int m_DMCE8count = 0;

        //白夜班标志
        public bool m_IsNight = false;
        public string m_ProductionShift;//生产班次

        public string m_CordDate;//二维码信息
        public Dictionary<string, string> Result = new Dictionary<string, string>();

        public int m_LogRetentionTime = 30;//Log文件保留时间
        public int m_ImageRetentionTime = 10;//压缩图片保留时间
        public int m_ImageRetentionNumber = 100;//原始图片保留数量

        public int m_EquipmentNum = 0;
        public int m_CoreNum = 0;
        public int m_Day = 0;
        #endregion
        public string m_User = "操作员";

        /// <summary>
        /// 视觉参数保存
        /// </summary>
        public void baocun()
        {
            ParamPath = AppValue.GetInstance().Data;
            //如果文件夹路径不为空
            if (!ParamPath.Equals(""))
            {


                #region 系统参数
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机1SN码", Convert.ToString(AppValue.GetInstance().common.cameraSN[0]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机2SN码", Convert.ToString(AppValue.GetInstance().common.cameraSN[1]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机3SN码", Convert.ToString(AppValue.GetInstance().common.cameraSN[2]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机4SN码", Convert.ToString(AppValue.GetInstance().common.cameraSN[3]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机5SN码", Convert.ToString(AppValue.GetInstance().common.cameraSN[4]));


                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机1曝光", Convert.ToString(AppValue.GetInstance().common.exposure[0]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机2曝光", Convert.ToString(AppValue.GetInstance().common.exposure[1]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机3曝光", Convert.ToString(AppValue.GetInstance().common.exposure[2]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机4曝光", Convert.ToString(AppValue.GetInstance().common.exposure[3]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机5曝光", Convert.ToString(AppValue.GetInstance().common.exposure[4]));



                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机1VPP", Convert.ToString(AppValue.GetInstance().common.xiangjiVPP[0]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机2VPP", Convert.ToString(AppValue.GetInstance().common.xiangjiVPP[1]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机3VPP", Convert.ToString(AppValue.GetInstance().common.xiangjiVPP[2]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机4VPP", Convert.ToString(AppValue.GetInstance().common.xiangjiVPP[3]));

                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机5VPP", Convert.ToString(AppValue.GetInstance().common.xiangjiVPP[4]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机6VPP", Convert.ToString(AppValue.GetInstance().common.xiangjiVPP[5]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "相机7VPP", Convert.ToString(AppValue.GetInstance().common.xiangjiVPP[6]));

                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "管理员密码", Convert.ToString(AppValue.GetInstance().common.guangliyuan));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "工程师密码", Convert.ToString(AppValue.GetInstance().common.gongcshi));


                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "工站名", Convert.ToString(AppValue.GetInstance().common.gongzhanming));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "在产型号", Convert.ToString(AppValue.GetInstance().common.xianyouchanpin));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "图片保存路径", Convert.ToString(AppValue.GetInstance().common.zaopiancunchulujing));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "图片保存数量", Convert.ToString(AppValue.GetInstance().common.zaopiancunchushuliang));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "系统参数", "图片保存天数", Convert.ToString(AppValue.GetInstance().common.zaopiancunchutianshu));

                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "生产参数", "相机_1总数", Convert.ToString(AppValue.GetInstance().common.xiangji_1zs[0]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "生产参数", "相机_1OK", Convert.ToString(AppValue.GetInstance().common.xiangji_1OK[0]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "生产参数", "相机_1NG", Convert.ToString(AppValue.GetInstance().common.xiangji_1NG[0]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "生产参数", "相机_1良率", Convert.ToString(AppValue.GetInstance().common.xiangji_1LY[0]));

                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "生产参数", "相机_2总数", Convert.ToString(AppValue.GetInstance().common.xiangji_1zs[1]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "生产参数", "相机_2OK", Convert.ToString(AppValue.GetInstance().common.xiangji_1OK[1]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "生产参数", "相机_2NG", Convert.ToString(AppValue.GetInstance().common.xiangji_1NG[1]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "生产参数", "相机_2良率", Convert.ToString(AppValue.GetInstance().common.xiangji_1LY[1]));

                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "生产参数", "相机_3总数", Convert.ToString(AppValue.GetInstance().common.xiangji_1zs[2]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "生产参数", "相机_3OK", Convert.ToString(AppValue.GetInstance().common.xiangji_1OK[2]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "生产参数", "相机_3NG", Convert.ToString(AppValue.GetInstance().common.xiangji_1NG[2]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "生产参数", "相机_3良率", Convert.ToString(AppValue.GetInstance().common.xiangji_1LY[2]));


                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "生产参数", "相机_4总数", Convert.ToString(AppValue.GetInstance().common.xiangji_1zs[3]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "生产参数", "相机_4OK", Convert.ToString(AppValue.GetInstance().common.xiangji_1OK[3]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "生产参数", "相机_4NG", Convert.ToString(AppValue.GetInstance().common.xiangji_1NG[3]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "生产参数", "相机_4良率", Convert.ToString(AppValue.GetInstance().common.xiangji_1LY[3]));


                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "PLC通讯", "PLC_IP", Convert.ToString(AppValue.GetInstance().common.PLC_ip));

                for (int i = 0; i < 7; i++)
                {
                    IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "PLC通讯", "相机触发" + i, Convert.ToString(AppValue.GetInstance().common.plc_读取触发[i]));
                    IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "PLC通讯", "相机结果" + i, Convert.ToString(AppValue.GetInstance().common.plc_写入结果[i]));
                    IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "PLC通讯", "相机X" + i, Convert.ToString(AppValue.GetInstance().common.xiangji_X[i]));
                    IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "PLC通讯", "相机Y" + i, Convert.ToString(AppValue.GetInstance().common.xiangji_Y[i]));
                    IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "PLC通讯", "相机角度" + i, Convert.ToString(AppValue.GetInstance().common.xiangji_角度[i]));
                }

                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "调试参数", "相机4基准X", Convert.ToString(AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[0]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "调试参数", "相机4基准Y", Convert.ToString(AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[1]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "调试参数", "相机4基准角度", Convert.ToString(AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[2]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "调试参数", "相机4补偿X", Convert.ToString(AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[3]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "调试参数", "相机4补偿Y", Convert.ToString(AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[4]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "调试参数", "相机4补偿角度", Convert.ToString(AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[5]));



                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "调试参数", "相机3基准X", Convert.ToString(AppValue.GetInstance().common.gongweiyitiaoshicanshu_3[0]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "调试参数", "相机3基准Y", Convert.ToString(AppValue.GetInstance().common.gongweiyitiaoshicanshu_3[1]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "调试参数", "相机3补偿X", Convert.ToString(AppValue.GetInstance().common.gongweiyitiaoshicanshu_3[2]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "调试参数", "相机3补偿Y", Convert.ToString(AppValue.GetInstance().common.gongweiyitiaoshicanshu_3[3]));


                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "调试参数", "相机1基准角度", Convert.ToString(AppValue.GetInstance().common.gongweiyitiaoshicanshu_1[0]));
                IniAPI.INIWriteValue(ParamPath + "\\Product.ini", "调试参数", "相机1补偿角度", Convert.ToString(AppValue.GetInstance().common.gongweiyitiaoshicanshu_1[1]));


                #endregion






            }

        }


        string[] CTSN;


        /// <summary>
        /// 加载视觉参数
        /// </summary>
        public void LoadParam()
        {

            ParamPath = AppValue.GetInstance().Data;



            if (!this.ParamPath.Equals(""))
            {
                string[] CTSN = new string[AppValue.GetInstance().common.xiangjishuliang];
                string[] CTexposure = new string[AppValue.GetInstance().common.xiangjishuliang];
                string[] CTxiangjiVPP = new string[AppValue.GetInstance().common.xiangjishuliang];

                #region 系统参数
                CTSN[0] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机1SN码", "21484803");
                CTSN[1] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机2SN码", "21484574");
                CTSN[2] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机3SN码", "21484803");
                CTSN[3] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机4SN码", "21484803");
                CTSN[4] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机5SN码", "21484803");


                CTexposure[0] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机1曝光", "1");
                CTexposure[1] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机2曝光", "1");
                CTexposure[2] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机3曝光", "1");
                CTexposure[3] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机4曝光", "1");
                CTexposure[4] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机5曝光", "1");



                CTxiangjiVPP[0] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机1VPP", "21484803");
                CTxiangjiVPP[1] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机2VPP", "21484803");
                CTxiangjiVPP[2] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机3VPP", "21484803");
                CTxiangjiVPP[3] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机4VPP", "21484803");
                CTxiangjiVPP[4] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机5VPP", "21484803");
                CTxiangjiVPP[5] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机6VPP", "21484803");
                CTxiangjiVPP[6] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "相机7VPP", "21484803");



                AppValue.GetInstance().common.guangliyuan = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "管理员密码", "123456");
                AppValue.GetInstance().common.gongcshi = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "工程师密码", "123456");
                AppValue.GetInstance().common.gongzhanming = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "工站名", "限力卷收器_S20");

                AppValue.GetInstance().common.xianyouchanpin = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "在产型号", "EVO710");
                AppValue.GetInstance().common.zaopiancunchulujing = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "图片保存路径", "D://存图");
                AppValue.GetInstance().common.zaopiancunchushuliang = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "图片保存数量", "999999").ToInt();
                AppValue.GetInstance().common.zaopiancunchutianshu = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "系统参数", "图片保存天数", "3").ToInt();


                AppValue.GetInstance().common.xiangji_1zs[0] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "生产参数", "相机_1总数", "0").ToDouble();
                AppValue.GetInstance().common.xiangji_1OK[0] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "生产参数", "相机_1OK", "0").ToDouble();
                AppValue.GetInstance().common.xiangji_1NG[0] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "生产参数", "相机_1NG", "0").ToDouble();
                AppValue.GetInstance().common.xiangji_1LY[0] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "生产参数", "相机_1良率", "0").ToDouble();

                AppValue.GetInstance().common.xiangji_1zs[1] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "生产参数", "相机_2总数", "0").ToDouble();
                AppValue.GetInstance().common.xiangji_1OK[1] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "生产参数", "相机_2OK", "0").ToDouble();
                AppValue.GetInstance().common.xiangji_1NG[1] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "生产参数", "相机_2NG", "0").ToDouble();
                AppValue.GetInstance().common.xiangji_1LY[1] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "生产参数", "相机_2良率", "0").ToDouble();

                AppValue.GetInstance().common.xiangji_1zs[2] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "生产参数", "相机_3总数", "0").ToDouble();
                AppValue.GetInstance().common.xiangji_1OK[2] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "生产参数", "相机_3OK", "0").ToDouble();
                AppValue.GetInstance().common.xiangji_1NG[2] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "生产参数", "相机_3NG", "0").ToDouble();
                AppValue.GetInstance().common.xiangji_1LY[2] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "生产参数", "相机_3良率", "0").ToDouble();

                AppValue.GetInstance().common.xiangji_1zs[3] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "生产参数", "相机_4总数", "0").ToDouble();
                AppValue.GetInstance().common.xiangji_1OK[3] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "生产参数", "相机_4OK", "0").ToDouble();
                AppValue.GetInstance().common.xiangji_1NG[3] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "生产参数", "相机_4NG", "0").ToDouble();
                AppValue.GetInstance().common.xiangji_1LY[3] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "生产参数", "相机_4良率", "0").ToDouble();




                AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[0] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "调试参数", "相机4基准X", "0").ToString();
                AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[1] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "调试参数", "相机4基准Y", "0").ToString();
                AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[2] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "调试参数", "相机4基准角度", "0").ToString();
                AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[3] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "调试参数", "相机4补偿X", "0").ToString();
                AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[4] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "调试参数", "相机4补偿Y", "0").ToString();
                AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[5] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "调试参数", "相机4补偿角度", "0").ToString();



                AppValue.GetInstance().common.gongweiyitiaoshicanshu_3[0] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "调试参数", "相机3基准X", "0").ToString();
                AppValue.GetInstance().common.gongweiyitiaoshicanshu_3[1] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "调试参数", "相机3基准Y", "0").ToString();
                AppValue.GetInstance().common.gongweiyitiaoshicanshu_3[2] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "调试参数", "相机3补偿X", "0").ToString();
                AppValue.GetInstance().common.gongweiyitiaoshicanshu_3[3] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "调试参数", "相机3补偿Y", "0").ToString();

                AppValue.GetInstance().common.gongweiyitiaoshicanshu_1[0] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "调试参数", "相机1基准角度", "0").ToString();
                AppValue.GetInstance().common.gongweiyitiaoshicanshu_1[1] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "调试参数", "相机1补偿角度", "0").ToString();









               

                AppValue.GetInstance().common.PLC_ip = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "PLC通讯", "PLC_IP", "192.168.1.20");


                for (int i = 0; i < 7; i++)
                {
                    AppValue.GetInstance().common.plc_读取触发[i] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "PLC通讯", "相机触发" + i, "0");
                    AppValue.GetInstance().common.plc_写入结果[i] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "PLC通讯", "相机结果" + i, "0");
                    AppValue.GetInstance().common.xiangji_X[i] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "PLC通讯", "相机X" + i, "0");
                    AppValue.GetInstance().common.xiangji_Y[i] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "PLC通讯", "相机Y" + i, "0");
                    AppValue.GetInstance().common.xiangji_角度[i] = IniAPI.INIGetStringValue(this.ParamPath + "\\Product.ini", "PLC通讯", "相机角度" + i, "0");
                }

                for (int i = 0; i < AppValue.GetInstance().common.xiangjishuliang; i++)
                {
                    AppValue.GetInstance().common.cameraSN[i] = Convert.ToString(CTSN[i]);

                    AppValue.GetInstance().common.exposure[i] = Convert.ToDouble(CTexposure[i]);

                    AppValue.GetInstance().common.xiangjiVPP[i] = Convert.ToString(CTxiangjiVPP[i]);
                }




                #endregion
            }
        }



        /// <summary>
        /// 检查文件夹是否存在
        /// </summary>
        /// <param name="path">文件夹路径</param>
        /// <param name="name">文件夹名称</param>
        public void CheckDir(string path, string name)//产品文件是否存在
        {
            if (!System.IO.Directory.Exists(string.Format("{0}//{1}", path, name)))
            {
                System.IO.Directory.CreateDirectory(string.Format("{0}//{1}", path, name));
            }
        }


    }
}
