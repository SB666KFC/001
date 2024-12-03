


using MAGAN_EOLT;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


using QWhale.Editor.TextSource;
using System.Diagnostics;
using System.Reflection;

using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.ToolBlock;
using System.Net.Http;

using System.IO;
using Cognex.VisionPro.ImageFile;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;

using System.Windows;
using Cognex.VisionPro.ToolBlock;
using LaserAblation.ActionBar;

namespace LaserAblation
{
    public delegate void WriteInfoDelegate(int info, String SE);
    public partial class FormMin : UIForm
    {

        public FormMin()
        {
            InitializeComponent();
            x = Width;
            y = Height;
            setTag(this);

        }
        /// <summary>
        /// 每日时间
        /// </summary>
        public string c;
        /// <summary>
        /// OK_NG别类
        /// </summary>
        public string[] Z_re = new string[4];

        public string HUOLV;
        /// <summary>
        /// 不良种类
        /// </summary>
        public string[] Z_se = new string[4];
        private readonly float x; //定义当前窗体的宽度
        private readonly float y; //定义当前窗体的高度
        Int32[] buffer_latch_pos = new Int32[10000];

        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0) setTag(con);
            }
        }

        private void setControls(float newx, float newy, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
                //获取控件的Tag属性值，并分割后存储字符串数组
                if (con.Tag != null)
                {
                    var mytag = con.Tag.ToString().Split(';');
                    //根据窗体缩放的比例确定控件的值
                    con.Width = Convert.ToInt32(Convert.ToSingle(mytag[0]) * newx); //宽度
                    con.Height = Convert.ToInt32(Convert.ToSingle(mytag[1]) * newy); //高度
                    con.Left = Convert.ToInt32(Convert.ToSingle(mytag[2]) * newx); //左边距
                    con.Top = Convert.ToInt32(Convert.ToSingle(mytag[3]) * newy); //顶边距
                    var currentSize = Convert.ToSingle(mytag[4]) * newy; //字体大小                   
                    if (currentSize > 0) con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    con.Focus();
                    if (con.Controls.Count > 0) setControls(newx, newy, con);

                }
        }



        /// <summary>
        /// 重置窗体布局
        /// </summary>
        private void ReWinformLayout()
        {
            var newx = Width / x;
            var newy = Height / y;
            setControls(newx, newy, this);

        }


        Stopwatch stopwatch_1 = new Stopwatch();
        Stopwatch stopwatch_2 = new Stopwatch();
        Stopwatch stopwatch_3 = new Stopwatch();
        Stopwatch stopwatch_4 = new Stopwatch();



        public LogHint logHint = new LogHint();//Log文件类

        /// <summary>
        /// 相机1刷新
        /// </summary>
        public void koingjshuaxin_1(int se)
        {
            AppValue.GetInstance().common.xiangji_1zs[se] = AppValue.GetInstance().common.xiangji_1OK[se] + AppValue.GetInstance().common.xiangji_1NG[se];
            AppValue.GetInstance().common.xiangji_1LY[se] = (AppValue.GetInstance().common.xiangji_1OK[se] / (AppValue.GetInstance().common.xiangji_1OK[se] + AppValue.GetInstance().common.xiangji_1NG[se])) * 100;

            uiLabel_11.Text = "总数：" + AppValue.GetInstance().common.xiangji_1zs[se].ToString("f0");

            uiLabel_12.Text = "OK：" + AppValue.GetInstance().common.xiangji_1OK[se].ToString("f0");

            uiLabel_13.Text = "NG：" + AppValue.GetInstance().common.xiangji_1NG[se].ToString("f0");

            uiLabel_14.Text = "良率：" + AppValue.GetInstance().common.xiangji_1LY[se].ToString("f0") + "%";

            uiLabel_15.Text = AppValue.GetInstance().common.xiangji_jieguo[se].ToString();
            if (AppValue.GetInstance().common.xiangji_jieguo[se] == "OK")
            {
                uiLabel_15.BackColor = Color.Green;
            }
            else
            {
                uiLabel_15.BackColor = Color.Red;
            }


            uiLabel_16.Text = AppValue.GetInstance().common.elapsedTimeMilliseconds[se].ToString("f0") + "ms";



        }
        /// <summary>
        /// 相机2刷新
        /// </summary>
        public void koingjshuaxin_2(int se)
        {
            AppValue.GetInstance().common.xiangji_1zs[se] = AppValue.GetInstance().common.xiangji_1OK[se] + AppValue.GetInstance().common.xiangji_1NG[se];
            AppValue.GetInstance().common.xiangji_1LY[se] = (AppValue.GetInstance().common.xiangji_1OK[se] / (AppValue.GetInstance().common.xiangji_1OK[se] + AppValue.GetInstance().common.xiangji_1NG[se])) * 100;

            uiLabel_21.Text = "总数：" + AppValue.GetInstance().common.xiangji_1zs[se].ToString("f0");

            uiLabel_22.Text = "OK：" + AppValue.GetInstance().common.xiangji_1OK[se].ToString("f0");

            uiLabel_23.Text = "NG：" + AppValue.GetInstance().common.xiangji_1NG[se].ToString("f0");

            uiLabel_24.Text = "良率：" + AppValue.GetInstance().common.xiangji_1LY[se].ToString("f0") + "%";

            uiLabel_25.Text = AppValue.GetInstance().common.xiangji_jieguo[se].ToString();
            if (AppValue.GetInstance().common.xiangji_jieguo[se] == "OK")
            {
                uiLabel_25.BackColor = Color.Green;
            }
            else
            {
                uiLabel_25.BackColor = Color.Red;
            }


            uiLabel_26.Text = AppValue.GetInstance().common.elapsedTimeMilliseconds[se].ToString("f0") + "ms";



        }
        /// <summary>
        /// 相机3刷新
        /// </summary>
        public void koingjshuaxin_3(int se)
        {
            AppValue.GetInstance().common.xiangji_1zs[se] = AppValue.GetInstance().common.xiangji_1OK[se] + AppValue.GetInstance().common.xiangji_1NG[se];
            AppValue.GetInstance().common.xiangji_1LY[se] = (AppValue.GetInstance().common.xiangji_1OK[se] / (AppValue.GetInstance().common.xiangji_1OK[se] + AppValue.GetInstance().common.xiangji_1NG[se])) * 100;

            uiLabel_31.Text = "总数：" + AppValue.GetInstance().common.xiangji_1zs[se].ToString("f0");

            uiLabel_32.Text = "OK：" + AppValue.GetInstance().common.xiangji_1OK[se].ToString("f0");

            uiLabel_33.Text = "NG：" + AppValue.GetInstance().common.xiangji_1NG[se].ToString("f0");

            uiLabel_34.Text = "良率：" + AppValue.GetInstance().common.xiangji_1LY[se].ToString("f0") + "%";

            uiLabel_35.Text = AppValue.GetInstance().common.xiangji_jieguo[se].ToString();
            if (AppValue.GetInstance().common.xiangji_jieguo[se] == "OK")
            {
                uiLabel_35.BackColor = Color.Green;
            }
            else
            {
                uiLabel_35.BackColor = Color.Red;
            }


            uiLabel_36.Text = AppValue.GetInstance().common.elapsedTimeMilliseconds[se].ToString("f0") + "ms";



        }
        /// <summary>
        /// 相机4刷新
        /// </summary>
        public void koingjshuaxin_4(int se)
        {
            AppValue.GetInstance().common.xiangji_1zs[se] = AppValue.GetInstance().common.xiangji_1OK[se] + AppValue.GetInstance().common.xiangji_1NG[se];
            AppValue.GetInstance().common.xiangji_1LY[se] = (AppValue.GetInstance().common.xiangji_1OK[se] / (AppValue.GetInstance().common.xiangji_1OK[se] + AppValue.GetInstance().common.xiangji_1NG[se])) * 100;

            uiLabel_41.Text = "总数：" + AppValue.GetInstance().common.xiangji_1zs[se].ToString("f0");

            uiLabel_42.Text = "OK：" + AppValue.GetInstance().common.xiangji_1OK[se].ToString("f0");

            uiLabel_43.Text = "NG：" + AppValue.GetInstance().common.xiangji_1NG[se].ToString("f0");

            uiLabel_44.Text = "良率：" + AppValue.GetInstance().common.xiangji_1LY[se].ToString("f0") + "%";

            uiLabel_15.Text = AppValue.GetInstance().common.xiangji_jieguo[se].ToString();
            if (AppValue.GetInstance().common.xiangji_jieguo[se] == "OK")
            {
                uiLabel_45.BackColor = Color.Green;
            }
            else
            {
                uiLabel_45.BackColor = Color.Red;
            }


            uiLabel_46.Text = AppValue.GetInstance().common.elapsedTimeMilliseconds[se].ToString("f0") + "ms";



        }
        /// <summary>
        /// 异步调用
        /// </summary>
        /// <param name="se"></param>
        public void CameraState(int se, String SE)
        {
            int a;
            a = se;
            if (a == 1)
            {
                koingjshuaxin_1(0);

            }
            if (a == 2)
            {
                koingjshuaxin_2(1);
            }
            if (a == 3)
            {
                koingjshuaxin_3(2);
            }
            if (a == 4)
            {
                koingjshuaxin_4(3);
            }
            if (a == 5)
            {
                se23(SE);
            }
            if (a == 6)
            {
                uiButton5.Text = "通孔1实时手动触发";
                uiButton5.Enabled = true;
            }
            if (a == 7)
            {

                uiButton7.Text = "通孔2实时手动触发";
                uiButton7.Enabled = true;
            }
            if (a == 8)
            {


            }
        }


        /// <summary>
        /// 日志写入
        /// </summary>
        /// <param name="se"></param>
        public void se23(string se)
        {

            //Flushclient se13 = delegate()
            //  {
            DateTime currentTime = System.DateTime.Now;
            string se1 = currentTime.ToLongTimeString().ToString() + ":" + "    ";
            richTextBox1.Text = se1 + se + "\n" + richTextBox1.Text;

            //  };  
            //AppValue.GetInstance().logs.richTextBox1.Invoke(se13);


        }


        private void FormMin_Load(object sender, EventArgs e)
        {
            tingzhi_1 = 1;

            yingjian();

            this.WindowState = FormWindowState.Maximized;
            this.Text = AppValue.GetInstance().common.gongzhanming;
            tupianbaocunshezhi1();
            jiemianshuaxcin();

            this.Invoke(new WriteInfoDelegate(CameraState), 5, "软件打开完成");
        }









        /// <summary>
        /// 硬件状态
        /// </summary>
        public void yingjian()
        {
            if (AppValue.GetInstance().common.m_Camera[0] == false)
            {
                uiLabel38.BackColor = Color.Red;
                this.Invoke(new WriteInfoDelegate(CameraState), 5, "相机1打开失败");
            }
            else
            {
                uiLabel38.BackColor = Color.LawnGreen;
                this.Invoke(new WriteInfoDelegate(CameraState), 5, "相机1打开完成");
            }
            if (AppValue.GetInstance().common.m_Camera[1] == false)
            {
                uiLabel32.BackColor = Color.Red;
                this.Invoke(new WriteInfoDelegate(CameraState), 5, "相机2打开失败");
            }
            else
            {
                uiLabel32.BackColor = Color.LawnGreen;
                this.Invoke(new WriteInfoDelegate(CameraState), 5, "相机2打开完成");
            }
            if (AppValue.GetInstance().common.m_Camera[2] == false)
            {
                uiLabel39.BackColor = Color.Red;
                this.Invoke(new WriteInfoDelegate(CameraState), 5, "相机3打开失败");
            }
            else
            {
                uiLabel39.BackColor = Color.LawnGreen;
                this.Invoke(new WriteInfoDelegate(CameraState), 5, "相机3打开完成");
            }
            if (AppValue.GetInstance().common.m_Camera[3] == false)
            {
                uiLabel40.BackColor = Color.Red;
                this.Invoke(new WriteInfoDelegate(CameraState), 5, "相机4打开失败");
            }
            else
            {
                uiLabel40.BackColor = Color.LawnGreen;
                this.Invoke(new WriteInfoDelegate(CameraState), 5, "相机4打开完成");
            }

            if (AppValue.GetInstance().common.PLC_状态 == false)
            {
                uiLabel41.BackColor = Color.Red;
                this.Invoke(new WriteInfoDelegate(CameraState), 5, "PLC连接失败");
            }
            else
            {
                uiLabel41.BackColor = Color.LawnGreen;
                this.Invoke(new WriteInfoDelegate(CameraState), 5, "PLC连接成功");
            }



        }


        /// <summary>
        /// 界面刷新
        /// </summary>
        public void jiemianshuaxcin()
        {
            label_DeviceName.Text = AppValue.GetInstance().common.gongzhanming;
            label_Model.Text = AppValue.GetInstance().common.xianyouchanpin;
            uiTextBox87.Text = AppValue.GetInstance().common.zaopiancunchulujing;
            uiTextBox84.Text = AppValue.GetInstance().common.zaopiancunchutianshu.ToString();
            uiTextBox86.Text = AppValue.GetInstance().common.zaopiancunchushuliang.ToString();
            AppValue.GetInstance().common.xianquan = "操作员";
            label_user.Text = AppValue.GetInstance().common.xianquan;
            DisplayControl();
            #region 生产数据

            uiLabel_11.Text = "总数：" + AppValue.GetInstance().common.xiangji_1zs[0].ToString("f0");

            uiLabel_12.Text = "OK：" + AppValue.GetInstance().common.xiangji_1OK[0].ToString("f0");

            uiLabel_13.Text = "NG：" + AppValue.GetInstance().common.xiangji_1NG[0].ToString("f0");

            uiLabel_14.Text = "良率：" + AppValue.GetInstance().common.xiangji_1LY[0].ToString("f0") + "%";


            uiLabel_21.Text = "总数：" + AppValue.GetInstance().common.xiangji_1zs[1].ToString("f0");

            uiLabel_22.Text = "OK：" + AppValue.GetInstance().common.xiangji_1OK[1].ToString("f0");

            uiLabel_23.Text = "NG：" + AppValue.GetInstance().common.xiangji_1NG[1].ToString("f0");

            uiLabel_24.Text = "良率：" + AppValue.GetInstance().common.xiangji_1LY[1].ToString("f0") + "%";


            uiLabel_31.Text = "总数：" + AppValue.GetInstance().common.xiangji_1zs[2].ToString("f0");

            uiLabel_32.Text = "OK：" + AppValue.GetInstance().common.xiangji_1OK[2].ToString("f0");

            uiLabel_33.Text = "NG：" + AppValue.GetInstance().common.xiangji_1NG[2].ToString("f0");

            uiLabel_34.Text = "良率：" + AppValue.GetInstance().common.xiangji_1LY[2].ToString("f0") + "%";


            uiLabel_41.Text = "总数：" + AppValue.GetInstance().common.xiangji_1zs[3].ToString("f0");

            uiLabel_42.Text = "OK：" + AppValue.GetInstance().common.xiangji_1OK[3].ToString("f0");

            uiLabel_43.Text = "NG：" + AppValue.GetInstance().common.xiangji_1NG[3].ToString("f0");

            uiLabel_44.Text = "良率：" + AppValue.GetInstance().common.xiangji_1LY[3].ToString("f0") + "%";

            #endregion


        }

        /// <summary>
        /// 界面保存
        /// </summary>
        public void jiemianbaocun()
        {
            AppValue.GetInstance().common.gongzhanming = label_DeviceName.Text;
            AppValue.GetInstance().common.xianyouchanpin = label_Model.Text;
            AppValue.GetInstance().common.zaopiancunchulujing = uiTextBox87.Text;
            AppValue.GetInstance().common.zaopiancunchutianshu = uiTextBox84.Text.ToInt();
            AppValue.GetInstance().common.zaopiancunchushuliang = uiTextBox86.Text.ToInt();




        }


        #region 窗体显示

        private void 相机采图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplayImage frmdisplay = new FormDisplayImage();
            frmdisplay.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            string path = System.Windows.Forms.Application.StartupPath + "\\Log";
            Process.Start(path);
            //FormViewLog frmviewlog = new FormViewLog();
            //frmviewlog.ShowDialog();
        }

        //IO监控
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                FormIO frmio = new FormIO();
                frmio.ShowDialog();
            }
            else
            {
                UIMessageBox.ShowInfo("IO板卡未连接，请打开软件重新连接IO卡");
            }

        }

        private void 权限登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //IUnityContainer container = UnityIOC.Instance.Container;
            //FormUserLogin user = container.Resolve<FormUserLogin>("Main");
            //user.ShowDialog();
            FormUserLogin frmuser = new FormUserLogin();
            frmuser.ShowDialog();
            DisplayControl();
        }



        #endregion










        /// <summary>
        /// 权限管理
        /// </summary>
        public void DisplayControl()
        {
            label_user.Text = AppValue.GetInstance().common.xianquan;

            this.Invoke(new WriteInfoDelegate(CameraState), 5, AppValue.GetInstance().common.xianquan + "登录成功");
            toolStripButton1.Enabled = false;//IO控制
            toolStripButton_Communicate.Enabled = false;//通讯设置

            toolStripButton5.Enabled = false;//查看日志
            toolStripDropDownButton2.Enabled = false;//图像设置

            if (AppValue.GetInstance().common.xianquan == "操作员")
            {
                toolStripButton5.Enabled = true;//查看日志
            }
            else if (AppValue.GetInstance().common.xianquan == "工程师")
            {
                toolStripDropDownButton2.Enabled = true;//图像设置


                toolStripButton5.Enabled = true;//查看日志
                toolStripDropDownButton2.Enabled = true;//图像设置

            }
            else if (AppValue.GetInstance().common.xianquan == "管理员")
            {

                toolStripButton1.Enabled = true;//IO控制
                toolStripButton_Communicate.Enabled = true;//通讯设置

                toolStripDropDownButton2.Enabled = true;//图像设置

                toolStripButton5.Enabled = true;//查看日志

            }
            label_user.Text = AppValue.GetInstance().common.m_User;
        }













        #region 界面控制
        private void FormMin_FormClosing(object sender, FormClosingEventArgs e)
        {

            AppValue.GetInstance().common.PLC_断开();

            CogFrameGrabbers framegrabbers = new CogFrameGrabbers();
            foreach (ICogFrameGrabber fg in framegrabbers)
                fg.Disconnect(false);
        }


        #endregion



        public void Z_baocuntup(string re, string se, int se1)
        {

            try
            {


                AppValue.GetInstance().common.myImage_baocun[se1] = AppValue.GetInstance().common.myImage[se1];

                Z_re[se1] = re;
                Z_se[se1] = se;

                if (se1 == 0)
                {
                    Thread Z_baocuntup_1 = new Thread(new ThreadStart(Z_baocuntupianxiancheng_1));//创建线程
                    Z_baocuntup_1.IsBackground = true;//设置线程为后台线程
                    Z_baocuntup_1.Start();//启动线程
                }
                if (se1 == 1)
                {
                    Thread Z_baocuntup_2 = new Thread(new ThreadStart(Z_baocuntupianxiancheng_2));//创建线程
                    Z_baocuntup_2.IsBackground = true;//设置线程为后台线程
                    Z_baocuntup_2.Start();//启动线程
                }
                if (se1 == 2)
                {
                    Thread Z_baocuntup_3 = new Thread(new ThreadStart(Z_baocuntupianxiancheng_3));//创建线程
                    Z_baocuntup_3.IsBackground = true;//设置线程为后台线程
                    Z_baocuntup_3.Start();//启动线程
                }
                if (se1 == 3)
                {
                    Thread Z_baocuntup_4 = new Thread(new ThreadStart(Z_baocuntupianxiancheng_4));//创建线程
                    Z_baocuntup_4.IsBackground = true;//设置线程为后台线程
                    Z_baocuntup_4.Start();//启动线程
                }
                if (se1 == 4)
                {
                    Thread Z_baocuntup_5 = new Thread(new ThreadStart(Z_baocuntupianxiancheng_5));//创建线程
                    Z_baocuntup_5.IsBackground = true;//设置线程为后台线程
                    Z_baocuntup_5.Start();//启动线程
                }

                if (se1 == 5)
                {
                    Thread Z_baocuntup_6 = new Thread(new ThreadStart(Z_baocuntupianxiancheng_6));//创建线程
                    Z_baocuntup_6.IsBackground = true;//设置线程为后台线程
                    Z_baocuntup_6.Start();//启动线程
                }
                if (se1 == 6)
                {
                    Thread Z_baocuntup_7 = new Thread(new ThreadStart(Z_baocuntupianxiancheng_7));//创建线程
                    Z_baocuntup_7.IsBackground = true;//设置线程为后台线程
                    Z_baocuntup_7.Start();//启动线程
                }








            }
            catch (Exception)
            {


            }



        }


        public void Z_baocuntupianxiancheng_1()
        {
            String SE11 = "相机1";
            String SE12 = "";
            int a = 0;
            CogImageFile mImageFile = new CogImageFile();
            try
            {
                //获取文件夹子目录数量

                int subDirectoryCount = Directory.GetFiles(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a]).Length;



                if (subDirectoryCount >= AppValue.GetInstance().common.zaopiancunchushuliang)
                {

                    DirectoryInfo directoryInfo = new DirectoryInfo(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a]);
                    FileInfo[] files = directoryInfo.GetFiles().OrderBy(f => f.CreationTime).ToArray();

                    File.Delete(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + files[0].Name);

                    string S = DateTime.Now.ToString("yyyy_MM_dd_HHmm.ss.fff");

                    SE12 = AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + Z_se[a] + S + ".bmp";

                    mImageFile.Open(SE12, CogImageFileModeConstants.Write);
                    mImageFile.Append(AppValue.GetInstance().common.myImage_baocun[a]);
                    mImageFile.Close();
                }
                else
                {
                    string S = DateTime.Now.ToString("yyyy_MM_dd_HHmm.ss.fff");
                    SE12 = AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + Z_se[a] + S + ".bmp";
                    //IniAPI.INIWriteValue(AppValue.GetInstance().SystemINI, "NowProduct", "ParamPathBC", AppValue.GetInstance().ParamPathBC);

                    mImageFile.Open(SE12, CogImageFileModeConstants.Write);
                    mImageFile.Append(AppValue.GetInstance().common.myImage_baocun[a]);
                    mImageFile.Close();
                }
            }
            catch (Exception)
            {


            }

        }

        public void Z_baocuntupianxiancheng_2()
        {
            String SE11 = "相机2";
            String SE12 = "";
            int a = 1;
            CogImageFile mImageFile = new CogImageFile();
            try
            {
                //获取文件夹子目录数量

                int subDirectoryCount = Directory.GetFiles(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a]).Length;



                if (subDirectoryCount >= AppValue.GetInstance().common.zaopiancunchushuliang)
                {

                    DirectoryInfo directoryInfo = new DirectoryInfo(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a]);
                    FileInfo[] files = directoryInfo.GetFiles().OrderBy(f => f.CreationTime).ToArray();

                    File.Delete(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + files[0].Name);

                    string S = DateTime.Now.ToString("yyyy_MM_dd_HHmm.ss.fff");

                    SE12 = AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + Z_se[a] + S + ".bmp";

                    mImageFile.Open(SE12, CogImageFileModeConstants.Write);
                    mImageFile.Append(AppValue.GetInstance().common.myImage_baocun[a]);
                    mImageFile.Close();
                }
                else
                {
                    string S = DateTime.Now.ToString("yyyy_MM_dd_HHmm.ss.fff");
                    SE12 = AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + Z_se[a] + S + ".bmp";
                    //IniAPI.INIWriteValue(AppValue.GetInstance().SystemINI, "NowProduct", "ParamPathBC", AppValue.GetInstance().ParamPathBC);

                    mImageFile.Open(SE12, CogImageFileModeConstants.Write);
                    mImageFile.Append(AppValue.GetInstance().common.myImage_baocun[a]);
                    mImageFile.Close();
                }
            }
            catch (Exception)
            {


            }

        }
        public void Z_baocuntupianxiancheng_3()
        {
            String SE11 = "相机3";
            String SE12 = "";
            int a = 2;
            CogImageFile mImageFile = new CogImageFile();
            try
            {
                //获取文件夹子目录数量

                int subDirectoryCount = Directory.GetFiles(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a]).Length;



                if (subDirectoryCount >= AppValue.GetInstance().common.zaopiancunchushuliang)
                {

                    DirectoryInfo directoryInfo = new DirectoryInfo(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a]);
                    FileInfo[] files = directoryInfo.GetFiles().OrderBy(f => f.CreationTime).ToArray();

                    File.Delete(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + files[0].Name);

                    string S = DateTime.Now.ToString("yyyy_MM_dd_HHmm.ss.fff");

                    SE12 = AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + Z_se[a] + S + ".bmp";

                    mImageFile.Open(SE12, CogImageFileModeConstants.Write);
                    mImageFile.Append(AppValue.GetInstance().common.myImage_baocun[a]);
                    mImageFile.Close();
                }
                else
                {
                    string S = DateTime.Now.ToString("yyyy_MM_dd_HHmm.ss.fff");
                    SE12 = AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + Z_se[a] + S + ".bmp";
                    //IniAPI.INIWriteValue(AppValue.GetInstance().SystemINI, "NowProduct", "ParamPathBC", AppValue.GetInstance().ParamPathBC);

                    mImageFile.Open(SE12, CogImageFileModeConstants.Write);
                    mImageFile.Append(AppValue.GetInstance().common.myImage_baocun[a]);
                    mImageFile.Close();
                }
            }
            catch (Exception)
            {


            }

        }
        public void Z_baocuntupianxiancheng_4()
        {
            String SE11 = "相机4";
            String SE12 = "";
            int a = 3;
            CogImageFile mImageFile = new CogImageFile();
            try
            {
                //获取文件夹子目录数量

                int subDirectoryCount = Directory.GetFiles(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a]).Length;



                if (subDirectoryCount >= AppValue.GetInstance().common.zaopiancunchushuliang)
                {

                    DirectoryInfo directoryInfo = new DirectoryInfo(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a]);
                    FileInfo[] files = directoryInfo.GetFiles().OrderBy(f => f.CreationTime).ToArray();

                    File.Delete(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + files[0].Name);

                    string S = DateTime.Now.ToString("yyyy_MM_dd_HHmm.ss.fff");

                    SE12 = AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + Z_se[a] + S + ".bmp";

                    mImageFile.Open(SE12, CogImageFileModeConstants.Write);
                    mImageFile.Append(AppValue.GetInstance().common.myImage_baocun[a]);
                    mImageFile.Close();
                }
                else
                {
                    string S = DateTime.Now.ToString("yyyy_MM_dd_HHmm.ss.fff");
                    SE12 = AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + Z_se[a] + S + ".bmp";
                    //IniAPI.INIWriteValue(AppValue.GetInstance().SystemINI, "NowProduct", "ParamPathBC", AppValue.GetInstance().ParamPathBC);

                    mImageFile.Open(SE12, CogImageFileModeConstants.Write);
                    mImageFile.Append(AppValue.GetInstance().common.myImage_baocun[a]);
                    mImageFile.Close();
                }
            }
            catch (Exception)
            {


            }

        }

        public void Z_baocuntupianxiancheng_5()
        {
            String SE11 = "相机5";
            String SE12 = "";
            int a = 3;
            CogImageFile mImageFile = new CogImageFile();
            try
            {
                //获取文件夹子目录数量

                int subDirectoryCount = Directory.GetFiles(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a]).Length;



                if (subDirectoryCount >= AppValue.GetInstance().common.zaopiancunchushuliang)
                {

                    DirectoryInfo directoryInfo = new DirectoryInfo(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a]);
                    FileInfo[] files = directoryInfo.GetFiles().OrderBy(f => f.CreationTime).ToArray();

                    File.Delete(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + files[0].Name);

                    string S = DateTime.Now.ToString("yyyy_MM_dd_HHmm.ss.fff");

                    SE12 = AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + Z_se[a] + S + ".bmp";

                    mImageFile.Open(SE12, CogImageFileModeConstants.Write);
                    mImageFile.Append(AppValue.GetInstance().common.myImage_baocun[a]);
                    mImageFile.Close();
                }
                else
                {
                    string S = DateTime.Now.ToString("yyyy_MM_dd_HHmm.ss.fff");
                    SE12 = AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + Z_se[a] + S + ".bmp";
                    //IniAPI.INIWriteValue(AppValue.GetInstance().SystemINI, "NowProduct", "ParamPathBC", AppValue.GetInstance().ParamPathBC);

                    mImageFile.Open(SE12, CogImageFileModeConstants.Write);
                    mImageFile.Append(AppValue.GetInstance().common.myImage_baocun[a]);
                    mImageFile.Close();
                }
            }
            catch (Exception)
            {


            }

        }

        public void Z_baocuntupianxiancheng_6()
        {
            String SE11 = "相机6";
            String SE12 = "";
            int a = 3;
            CogImageFile mImageFile = new CogImageFile();
            try
            {
                //获取文件夹子目录数量

                int subDirectoryCount = Directory.GetFiles(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a]).Length;



                if (subDirectoryCount >= AppValue.GetInstance().common.zaopiancunchushuliang)
                {

                    DirectoryInfo directoryInfo = new DirectoryInfo(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a]);
                    FileInfo[] files = directoryInfo.GetFiles().OrderBy(f => f.CreationTime).ToArray();

                    File.Delete(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + files[0].Name);

                    string S = DateTime.Now.ToString("yyyy_MM_dd_HHmm.ss.fff");

                    SE12 = AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + Z_se[a] + S + ".bmp";

                    mImageFile.Open(SE12, CogImageFileModeConstants.Write);
                    mImageFile.Append(AppValue.GetInstance().common.myImage_baocun[a]);
                    mImageFile.Close();
                }
                else
                {
                    string S = DateTime.Now.ToString("yyyy_MM_dd_HHmm.ss.fff");
                    SE12 = AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + Z_se[a] + S + ".bmp";
                    //IniAPI.INIWriteValue(AppValue.GetInstance().SystemINI, "NowProduct", "ParamPathBC", AppValue.GetInstance().ParamPathBC);

                    mImageFile.Open(SE12, CogImageFileModeConstants.Write);
                    mImageFile.Append(AppValue.GetInstance().common.myImage_baocun[a]);
                    mImageFile.Close();
                }
            }
            catch (Exception)
            {


            }

        }

        public void Z_baocuntupianxiancheng_7()
        {
            String SE11 = "相机7";
            String SE12 = "";
            int a = 3;
            CogImageFile mImageFile = new CogImageFile();
            try
            {
                //获取文件夹子目录数量

                int subDirectoryCount = Directory.GetFiles(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a]).Length;



                if (subDirectoryCount >= AppValue.GetInstance().common.zaopiancunchushuliang)
                {

                    DirectoryInfo directoryInfo = new DirectoryInfo(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a]);
                    FileInfo[] files = directoryInfo.GetFiles().OrderBy(f => f.CreationTime).ToArray();

                    File.Delete(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + files[0].Name);

                    string S = DateTime.Now.ToString("yyyy_MM_dd_HHmm.ss.fff");

                    SE12 = AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + Z_se[a] + S + ".bmp";

                    mImageFile.Open(SE12, CogImageFileModeConstants.Write);
                    mImageFile.Append(AppValue.GetInstance().common.myImage_baocun[a]);
                    mImageFile.Close();
                }
                else
                {
                    string S = DateTime.Now.ToString("yyyy_MM_dd_HHmm.ss.fff");
                    SE12 = AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + SE11 + "//" + Z_re[a] + "//" + Z_se[a] + S + ".bmp";
                    //IniAPI.INIWriteValue(AppValue.GetInstance().SystemINI, "NowProduct", "ParamPathBC", AppValue.GetInstance().ParamPathBC);

                    mImageFile.Open(SE12, CogImageFileModeConstants.Write);
                    mImageFile.Append(AppValue.GetInstance().common.myImage_baocun[a]);
                    mImageFile.Close();
                }
            }
            catch (Exception)
            {


            }

        }

        /// <summary>
        /// 通孔1复检
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Invoke(new WriteInfoDelegate(CameraState), 5, "通孔1复检触发");
            int se = 0;
            //VPP序号
            int se1 = 1;
            stopwatch_1.Reset();
            stopwatch_1.Start();



            try
            {
                if (AppValue.GetInstance().common.myFifo[se] != null)
                {
                    AppValue.GetInstance().common.GrabImage(se, out AppValue.GetInstance().common.myImage[se1]);


                }
                else
                {
                    this.ShowWarningDialog(uiButton1.Text + "未连接");

                }
                //TB.Inputs["Image1"].Value = MyCommon.myImage1;
                AppValue.GetInstance().common.modelTB[se1].Inputs["OutputImage"].Value = AppValue.GetInstance().common.myImage[se1];

                AppValue.GetInstance().common.modelTB[se1].Run();

                AppValue.GetInstance().common.LB_1X[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["X1"].Value.ToString());
                AppValue.GetInstance().common.LB_1Y[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["Y1"].Value.ToString());
                AppValue.GetInstance().common.LB_1A[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["A1"].Value.ToString());
                AppValue.GetInstance().common.LB_jieguo[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["jieguo"].Value.ToString());

                if (AppValue.GetInstance().common.LB_jieguo[se1] != -999999)
                {

                    cogRecordDisplay5.Record = AppValue.GetInstance().common.modelTB[se1].CreateLastRunRecord().SubRecords[1];
                    cogRecordDisplay5.Fit(true);
                    if (AppValue.GetInstance().common.LB_jieguo[se1] == 1)
                    {
                        AppValue.GetInstance().common.xiangji_1OK[se]++;
                        AppValue.GetInstance().common.xiangji_jieguo[se] = "OK";
                        Z_baocuntup("OK", "OK", se1);
                    }
                    else
                    {
                        AppValue.GetInstance().common.xiangji_1NG[se]++;
                        AppValue.GetInstance().common.xiangji_jieguo[se] = "NG";
                        Z_baocuntup("NG", "NG", se1);
                    }

                }
                else
                {
                    cogRecordDisplay5.Record = AppValue.GetInstance().common.modelTB[se1].CreateLastRunRecord().SubRecords[0];
                    cogRecordDisplay5.Fit(true);
                    AppValue.GetInstance().common.xiangji_1NG[se]++;
                    AppValue.GetInstance().common.xiangji_jieguo[se] = "NG";
                    Z_baocuntup("NG", "NG", se1);
                }

                stopwatch_1.Stop();
                AppValue.GetInstance().common.elapsedTimeMilliseconds[se] = stopwatch_1.ElapsedMilliseconds;

                this.Invoke(new WriteInfoDelegate(CameraState), 1, "");
                string se11 = "通孔1复检处理结果:" + AppValue.GetInstance().common.LB_jieguo[se1] + "," + "X:" + AppValue.GetInstance().common.LB_1X[se1] + "," + "Y:" + AppValue.GetInstance().common.LB_1Y[se1] + "," + "角度:" + AppValue.GetInstance().common.LB_1A[se1];
                this.Invoke(new WriteInfoDelegate(CameraState), 5, se11);

            }
            catch (Exception)
            {


            }

        }








        /// <summary>
        /// 通孔2复检
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton4_Click(object sender, EventArgs e)
        {
            this.Invoke(new WriteInfoDelegate(CameraState), 5, "通孔2复检触发");
            int se = 1;
            //VPP序号
            int se1 = 3;
            stopwatch_2.Reset();
            stopwatch_2.Start();



            try
            {
                if (AppValue.GetInstance().common.myFifo[se] != null)
                {
                    AppValue.GetInstance().common.GrabImage(se, out AppValue.GetInstance().common.myImage[se1]);


                }
                else
                {
                    this.ShowWarningDialog(uiButton4.Text + "未连接");

                }
                //TB.Inputs["Image1"].Value = MyCommon.myImage1;
                AppValue.GetInstance().common.modelTB[se1].Inputs["OutputImage"].Value = AppValue.GetInstance().common.myImage[se1];

                AppValue.GetInstance().common.modelTB[se1].Run();

                AppValue.GetInstance().common.LB_1X[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["X1"].Value.ToString());
                AppValue.GetInstance().common.LB_1Y[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["Y1"].Value.ToString());
                AppValue.GetInstance().common.LB_1A[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["A1"].Value.ToString());
                AppValue.GetInstance().common.LB_jieguo[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["jieguo"].Value.ToString());

                if (AppValue.GetInstance().common.LB_jieguo[se1] != -999999)
                {

                    cogRecordDisplay4.Record = AppValue.GetInstance().common.modelTB[se1].CreateLastRunRecord().SubRecords[1];
                    cogRecordDisplay4.Fit(true);
                    if (AppValue.GetInstance().common.LB_jieguo[se1] == 1)
                    {
                        AppValue.GetInstance().common.xiangji_1OK[se]++;
                        AppValue.GetInstance().common.xiangji_jieguo[se] = "OK";
                        Z_baocuntup("OK", "OK", se1);
                    }
                    else
                    {
                        AppValue.GetInstance().common.xiangji_1NG[se]++;
                        AppValue.GetInstance().common.xiangji_jieguo[se] = "NG";
                        Z_baocuntup("NG", "NG", se1);
                    }

                }
                else
                {
                    cogRecordDisplay4.Record = AppValue.GetInstance().common.modelTB[se1].CreateLastRunRecord().SubRecords[0];
                    cogRecordDisplay4.Fit(true);
                    AppValue.GetInstance().common.xiangji_1NG[se]++;
                    AppValue.GetInstance().common.xiangji_jieguo[se] = "NG";
                    Z_baocuntup("NG", "NG", se1);
                }

                stopwatch_2.Stop();
                AppValue.GetInstance().common.elapsedTimeMilliseconds[se] = stopwatch_2.ElapsedMilliseconds;

                this.Invoke(new WriteInfoDelegate(CameraState), 2, "");
                string se11 = "通孔2复检处理结果:" + AppValue.GetInstance().common.LB_jieguo[se1] + "," + "X:" + AppValue.GetInstance().common.LB_1X[se1] + "," + "Y:" + AppValue.GetInstance().common.LB_1Y[se1] + "," + "角度:" + AppValue.GetInstance().common.LB_1A[se1];
                this.Invoke(new WriteInfoDelegate(CameraState), 5, se11);

            }
            catch (Exception)
            {


            }
        }
        /// <summary>
        /// 咬齿1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton3_Click(object sender, EventArgs e)
        {
            this.Invoke(new WriteInfoDelegate(CameraState), 5, "咬齿1触发");
            int se = 2;
            //VPP序号
            int se1 = 4;
            stopwatch_3.Reset();
            stopwatch_3.Start();



            try
            {
                if (AppValue.GetInstance().common.myFifo[se] != null)
                {
                    AppValue.GetInstance().common.GrabImage(se, out AppValue.GetInstance().common.myImage[se1]);


                }
                else
                {
                    this.ShowWarningDialog(uiButton3.Text + "未连接");

                }
                //TB.Inputs["Image1"].Value = MyCommon.myImage1;
                AppValue.GetInstance().common.modelTB[se1].Inputs["OutputImage"].Value = AppValue.GetInstance().common.myImage[se1];

                AppValue.GetInstance().common.modelTB[se1].Run();

                AppValue.GetInstance().common.LB_1X[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["X1"].Value.ToString());
                AppValue.GetInstance().common.LB_1Y[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["Y1"].Value.ToString());
                AppValue.GetInstance().common.LB_1A[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["A1"].Value.ToString());
                AppValue.GetInstance().common.LB_jieguo[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["jieguo"].Value.ToString());

                if (AppValue.GetInstance().common.LB_jieguo[se1] != -999999)
                {

                    cogRecordDisplay3.Record = AppValue.GetInstance().common.modelTB[se1].CreateLastRunRecord().SubRecords[1];
                    cogRecordDisplay3.Fit(true);
                    if (AppValue.GetInstance().common.LB_jieguo[se1] == 1)
                    {
                        AppValue.GetInstance().common.xiangji_1OK[se]++;
                        AppValue.GetInstance().common.xiangji_jieguo[se] = "OK";
                        Z_baocuntup("OK", "OK", se1);
                    }
                    else
                    {
                        AppValue.GetInstance().common.xiangji_1NG[se]++;
                        AppValue.GetInstance().common.xiangji_jieguo[se] = "NG";
                        Z_baocuntup("NG", "NG", se1);
                    }

                }
                else
                {
                    cogRecordDisplay3.Record = AppValue.GetInstance().common.modelTB[se1].CreateLastRunRecord().SubRecords[0];
                    cogRecordDisplay3.Fit(true);
                    AppValue.GetInstance().common.xiangji_1NG[se]++;
                    AppValue.GetInstance().common.xiangji_jieguo[se] = "NG";
                    Z_baocuntup("NG", "NG", se1);
                }

                stopwatch_3.Stop();
                AppValue.GetInstance().common.elapsedTimeMilliseconds[se] = stopwatch_3.ElapsedMilliseconds;

                this.Invoke(new WriteInfoDelegate(CameraState), 2, "");
                string se11 = "咬齿1处理结果:" + AppValue.GetInstance().common.LB_jieguo[se1] + "," + "X:" + AppValue.GetInstance().common.LB_1X[se1] + "," + "Y:" + AppValue.GetInstance().common.LB_1Y[se1] + "," + "角度:" + AppValue.GetInstance().common.LB_1A[se1];
                this.Invoke(new WriteInfoDelegate(CameraState), 5, se11);

            }
            catch (Exception)
            {


            }
        }
        /// <summary>
        /// 相机4触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Invoke(new WriteInfoDelegate(CameraState), 5, "卡扣状态触发");
            int se = 4;
            //VPP序号
            int se1 = 6;
            stopwatch_4.Reset();
            stopwatch_4.Start();



            try
            {
                if (AppValue.GetInstance().common.myFifo[se] != null)
                {
                    AppValue.GetInstance().common.GrabImage(se, out AppValue.GetInstance().common.myImage[se1]);


                }
                else
                {
                    this.ShowWarningDialog(uiButton2.Text + "未连接");

                }
                //TB.Inputs["Image1"].Value = MyCommon.myImage1;
                AppValue.GetInstance().common.modelTB[se1].Inputs["OutputImage"].Value = AppValue.GetInstance().common.myImage[se1];

                AppValue.GetInstance().common.modelTB[se1].Run();

                AppValue.GetInstance().common.LB_1X[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["X1"].Value.ToString());
                AppValue.GetInstance().common.LB_1Y[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["Y1"].Value.ToString());
                AppValue.GetInstance().common.LB_1A[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["A1"].Value.ToString());
                AppValue.GetInstance().common.LB_jieguo[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["jieguo"].Value.ToString());

                if (AppValue.GetInstance().common.LB_jieguo[se1] != -999999)
                {

                    cogRecordDisplay6.Record = AppValue.GetInstance().common.modelTB[se1].CreateLastRunRecord().SubRecords[1];
                    cogRecordDisplay6.Fit(true);
                    if (AppValue.GetInstance().common.LB_jieguo[se1] == 1)
                    {
                        AppValue.GetInstance().common.xiangji_1OK[3]++;
                        AppValue.GetInstance().common.xiangji_jieguo[3] = "OK";
                        Z_baocuntup("OK", "OK", se1);
                    }
                    else
                    {
                        AppValue.GetInstance().common.xiangji_1NG[3]++;
                        AppValue.GetInstance().common.xiangji_jieguo[3] = "NG";
                        Z_baocuntup("NG", "NG", se1);
                    }

                }
                else
                {
                    cogRecordDisplay6.Record = AppValue.GetInstance().common.modelTB[se1].CreateLastRunRecord().SubRecords[0];
                    cogRecordDisplay6.Fit(true);
                    AppValue.GetInstance().common.xiangji_1NG[3]++;
                    AppValue.GetInstance().common.xiangji_jieguo[3] = "NG";
                    Z_baocuntup("NG", "NG", se1);
                }

                stopwatch_4.Stop();
                AppValue.GetInstance().common.elapsedTimeMilliseconds[se] = stopwatch_4.ElapsedMilliseconds;

                this.Invoke(new WriteInfoDelegate(CameraState), 4, "");
                string se11 = "卡扣状态处理结果:" + AppValue.GetInstance().common.LB_jieguo[se1] + "," + "X:" + AppValue.GetInstance().common.LB_1X[se1] + "," + "Y:" + AppValue.GetInstance().common.LB_1Y[se1] + "," + "角度:" + AppValue.GetInstance().common.LB_1A[se1];
                this.Invoke(new WriteInfoDelegate(CameraState), 5, se11);

            }
            catch (Exception)
            {


            }
        }




        ///// <summary>
        ///// 相机1参数调试
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void uiButton5_Click(object sender, EventArgs e)
        //{
        //    AppValue.GetInstance().common.canshumingc = uiButton5.Text;
        //    AppValue.GetInstance().common.gongweihao = 1;
        //    canshu frmuser = new canshu();
        //    frmuser.ShowDialog();

        //}
        ///// <summary>
        ///// 相机2参数调试
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void uiButton8_Click(object sender, EventArgs e)
        //{
        //    AppValue.GetInstance().common.canshumingc = uiButton8.Text;
        //    AppValue.GetInstance().common.gongweihao = 2;
        //    canshu frmuser = new canshu();
        //    frmuser.ShowDialog();
        //}
        ///// <summary>
        ///// 相机3参数调试
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void uiButton7_Click(object sender, EventArgs e)
        //{
        //    AppValue.GetInstance().common.canshumingc = uiButton7.Text;
        //    AppValue.GetInstance().common.gongweihao = 3;
        //    canshu frmuser = new canshu();
        //    frmuser.ShowDialog();
        //}
        ///// <summary>
        ///// 相机4参数调试
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void uiButton6_Click(object sender, EventArgs e)
        //{
        //    AppValue.GetInstance().common.canshumingc = uiButton6.Text;
        //    AppValue.GetInstance().common.gongweihao = 4;
        //    canshu frmuser = new canshu();
        //    frmuser.ShowDialog();
        //}





        /// <summary>
        /// 窗体布局
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMin_Resize(object sender, EventArgs e)
        {
            ReWinformLayout();

        }
        /// <summary>
        /// 主线程控制状态
        /// </summary>
        public int tingzhi_1;
        /// <summary>
        /// 启动按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton9_Click(object sender, EventArgs e)
        {
            if (AppValue.GetInstance().common.PLC_状态 == true)
            {
                try
                {
                    if (uiButton9.Text == "运行")
                    {

                        this.Invoke(new WriteInfoDelegate(CameraState), 5, "程序运行");
                        tingzhi_1 = 0;
                        uiButton9.Text = "停止";
                        uiButton9.FillColor = Color.Red;



                        Thread _GrabThread = new Thread(new ThreadStart(runImageGrab));//启用新线程调用runImageGrab方法连续采集图片
                        _GrabThread.IsBackground = true;//设置线程为后台线程
                        _GrabThread.Name = "主流程";//给线程命名
                        _GrabThread.Start();//启动线程

                        if (AppValue.GetInstance().common.PLC_状态 == true)
                        {
                            Thread _GrabThread_1SE = new Thread(new ThreadStart(xintiao1));//启用新线程调用runImageGrab方法连续采集图片
                            _GrabThread_1SE.IsBackground = true;//设置线程为后台线程
                            _GrabThread_1SE.Name = "心跳";//给线程命名
                            _GrabThread_1SE.Start();//启动线程
                        }
                    }
                    else
                    {
                        this.Invoke(new WriteInfoDelegate(CameraState), 5, "程序停止");
                        uiButton9.Text = "运行";
                        tingzhi_1 = 1;
                        uiButton9.FillColor = Color.Green;
                    }


                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                this.ShowWarningDialog("PLC未连接" + "请检查连接硬件");
            }



        }
        /// <summary>
        /// 通讯心跳
        /// </summary>
        public void xintiao1()
        {
            while (true)
            {
                // UInt16 active_level = 0;
                UInt16 bitno = 0;
                int sleep_body = 500;
                
                AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.plc_写入结果[0], 1);
                Thread.Sleep(sleep_body); //睡眠xxx毫秒，元件持续时间
                AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.xiangji_角度[0],0);
                Thread.Sleep(sleep_body); //睡眠xxx毫秒，元件持续时间
                if (tingzhi_1 == 1)
                {
                    break;
                }
            }
        }








        /// <summary>
        /// 拍照处理图像线程
        /// </summary>
        public void runImageGrab()
        {
            do
            {
                try
                {
                    if (AppValue.GetInstance().common.PLC_状态 == true)
                    {

                        for (int i = 0; i < 7; i++)
                        {
                            AppValue.GetInstance().common.plc_读取数值[i] = ((uint)AppValue.GetInstance().common.siemens.Read(AppValue.GetInstance().common.plc_读取触发[i])).ToString();
                        }
                    }
                }
                catch (Exception)
                {

                    //  MessageBox.Show("PLC已断开");
                }

                if (AppValue.GetInstance().common.plc_读取数值[0] == "1")
                {
                    AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.plc_写入结果[0], "0");
                    uiButton5_Click(null, null);
                }
                if (AppValue.GetInstance().common.plc_读取数值[1] == "1")
                {
                    AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.plc_写入结果[1], "0");
                    uiButton1_Click(null, null);
                }
                if (AppValue.GetInstance().common.plc_读取数值[2] == "1")
                {
                    AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.plc_写入结果[2], "0");
                    uiButton7_Click(null, null);
                }
                if (AppValue.GetInstance().common.plc_读取数值[3] == "1")
                {
                    AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.plc_写入结果[3], "0");
                    uiButton4_Click(null, null);
                }
                if (AppValue.GetInstance().common.plc_读取数值[4] == "1")
                {
                    AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.plc_写入结果[4], "0");
                    uiButton3_Click(null, null);
                }
                if (AppValue.GetInstance().common.plc_读取数值[5] == "1")
                {
                    AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.plc_写入结果[5], "0");
                    uiButton6_Click(null, null);
                }
                if (AppValue.GetInstance().common.plc_读取数值[6] == "1")
                {
                    AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.plc_写入结果[6], "0");
                    uiButton2_Click(null, null);
                }





                Thread.Sleep(100);
                if (tingzhi_1 == 1)
                {
                    break;
                }
            } while (true);//如果HCamera.Busy为true状态，则一直循环，否则，退出循环
        }


        /// <summary>
        /// 图片保存设置
        /// </summary>
        public void tupianbaocunshezhi1()
        {
            c = DateTime.Now.ToString("yyyy_MM_dd");
            try
            {
                int mProductsPath = System.IO.Directory.GetDirectories(AppValue.GetInstance().common.zaopiancunchulujing).Length;

                if (mProductsPath > AppValue.GetInstance().common.zaopiancunchutianshu)
                {
                    int sber = mProductsPath - AppValue.GetInstance().common.zaopiancunchutianshu;
                    DirectoryInfo directoryInfo = new DirectoryInfo(AppValue.GetInstance().common.zaopiancunchulujing);
                    DirectoryInfo[] files = directoryInfo.GetDirectories().OrderBy(f => f.CreationTime).ToArray();

                    for (int i = 0; i < sber; i++)
                    {
                        DirectoryInfo di = new DirectoryInfo(AppValue.GetInstance().common.zaopiancunchulujing + "//" + files[i].Name);
                        di.Delete(true);
                    }

                }
            }
            catch (Exception)
            {


            }


            //检查文件是否存在
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing, HUOLV);
            //产品名序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin, HUOLV);
            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机1", HUOLV);
            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机2", HUOLV);
            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机3", HUOLV);
            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机4", HUOLV);


            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机5", HUOLV);
            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机6", HUOLV);
            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机7", HUOLV);


            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机1" + "//" + "OK", HUOLV);
            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机1" + "//" + "NG", HUOLV);
            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机2" + "//" + "OK", HUOLV);
            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机2" + "//" + "NG", HUOLV);
            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机3" + "//" + "OK", HUOLV);
            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机3" + "//" + "NG", HUOLV);
            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机4" + "//" + "OK", HUOLV);
            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机4" + "//" + "NG", HUOLV);

            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机5" + "//" + "OK", HUOLV);
            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机5" + "//" + "NG", HUOLV);

            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机6" + "//" + "OK", HUOLV);
            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机6" + "//" + "NG", HUOLV);

            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机7" + "//" + "OK", HUOLV);
            //检查产品面序列
            AppValue.GetInstance().common.CheckDir(AppValue.GetInstance().common.zaopiancunchulujing + "//" + c + "//" + AppValue.GetInstance().common.xianyouchanpin + "//" + "相机7" + "//" + "NG", HUOLV);

        }




        private void uiLabel89_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            try
            {
                jiemianbaocun();
                AppValue.GetInstance().common.baocun();
                this.Invoke(new WriteInfoDelegate(CameraState), 5, "参数保存成功");
            }
            catch (Exception)
            {
                this.Invoke(new WriteInfoDelegate(CameraState), 5, "参数保存失败");

            }

        }

        private void uiButton10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                AppValue.GetInstance().common.xiangji_1zs[i] = 0;
                AppValue.GetInstance().common.xiangji_1OK[i] = 0;
                AppValue.GetInstance().common.xiangji_1LY[i] = 0;
                AppValue.GetInstance().common.xiangji_1SJ[i] = 0;
                AppValue.GetInstance().common.xiangji_1NG[i] = 0;
                AppValue.GetInstance().common.xiangji_jieguo[i] = "NULL";


            }

            this.Invoke(new WriteInfoDelegate(CameraState), 1, "");
            this.Invoke(new WriteInfoDelegate(CameraState), 2, "");
            this.Invoke(new WriteInfoDelegate(CameraState), 3, "");
            this.Invoke(new WriteInfoDelegate(CameraState), 4, "");


            uiLabel_15.BackColor = Color.Silver;
            uiLabel_25.BackColor = Color.Silver;
            uiLabel_35.BackColor = Color.Silver;
            uiLabel_45.BackColor = Color.Silver;

            uiLabel_14.Text = "良率：" + 0 + "%";
            uiLabel_24.Text = "良率：" + 0 + "%";
            uiLabel_34.Text = "良率：" + 0 + "%";
            uiLabel_44.Text = "良率：" + 0 + "%";


            uiLabel_16.Text = 0 + "ms";
            uiLabel_26.Text = 0 + "ms";
            uiLabel_36.Text = 0 + "ms";
            uiLabel_46.Text = 0 + "ms";


        }
        /// <summary>
        /// 通孔2实时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton7_Click(object sender, EventArgs e)
        {
            uiButton7.Text = "实时测试中...";
            uiButton7.Enabled = false;
            Thread tongkong2 = new Thread(new ThreadStart(tongkong1shishi_2));//启用新线程调用runImageGrab方法连续采集图片
            tongkong2.IsBackground = true;//设置线程为后台线程
            tongkong2.Name = "通孔2";//给线程命名
            tongkong2.Start();//启动线程

        }
        /// <summary>
        /// 通孔1实时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton5_Click(object sender, EventArgs e)
        {
            uiButton5.Text = "实时测试中...";
            uiButton5.Enabled = false;
            Thread tongkong1 = new Thread(new ThreadStart(tongkong1shishi_1));//启用新线程调用runImageGrab方法连续采集图片
            tongkong1.IsBackground = true;//设置线程为后台线程
            tongkong1.Name = "通孔1";//给线程命名
            tongkong1.Start();//启动线程




        }


        public void tongkong1shishi_1()
        {
            this.Invoke(new WriteInfoDelegate(CameraState), 5, "通孔1实时触发");
            int se = 0;
            //VPP序号
            int se1 = 0;
            stopwatch_1.Reset();
            stopwatch_1.Start();
            do
            {


                try
                {
                    if (AppValue.GetInstance().common.myFifo[se] != null)
                    {
                        AppValue.GetInstance().common.GrabImage(se, out AppValue.GetInstance().common.myImage[se1]);


                    }
                    else
                    {
                        this.ShowWarningDialog(uiLabel37.Text + "未连接");
                        break;
                    }
                    //TB.Inputs["Image1"].Value = MyCommon.myImage1;
                    AppValue.GetInstance().common.modelTB[se1].Inputs["OutputImage"].Value = AppValue.GetInstance().common.myImage[se1];

                    AppValue.GetInstance().common.modelTB[se1].Run();

                    AppValue.GetInstance().common.LB_1X[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["X1"].Value.ToString());
                    AppValue.GetInstance().common.LB_1Y[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["Y1"].Value.ToString());
                    AppValue.GetInstance().common.LB_1A[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["A1"].Value.ToString());
                    AppValue.GetInstance().common.LB_jieguo[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["jieguo"].Value.ToString());

                    if (AppValue.GetInstance().common.LB_jieguo[se1] != -999999)
                    {

                        cogRecordDisplay7.Record = AppValue.GetInstance().common.modelTB[se1].CreateLastRunRecord().SubRecords[0];
                        cogRecordDisplay7.Fit(true);
                        if (AppValue.GetInstance().common.LB_jieguo[se1] == 1)
                        {
                            stopwatch_1.Stop();
                            AppValue.GetInstance().common.elapsedTimeMilliseconds[se1] = stopwatch_1.ElapsedMilliseconds;
                        //    AppValue.GetInstance().common.xiangji_jieguo[se1] = "OK";
                            Z_baocuntup("OK", "OK", se1);
                            string se11 = "通孔1实时处理结果:" + AppValue.GetInstance().common.LB_jieguo[se] + "," + "X:" + AppValue.GetInstance().common.LB_1X[se] + "," + "Y:" + AppValue.GetInstance().common.LB_1Y[se] + "," + "角度:" + AppValue.GetInstance().common.LB_1A[se] + "消耗时间：" + AppValue.GetInstance().common.elapsedTimeMilliseconds[se1];
                            this.Invoke(new WriteInfoDelegate(CameraState), 5, se11);
                            break;
                        }
                        else
                        {

                            //  AppValue.GetInstance().common.xiangji_jieguo[se1] = "NG";

                        }

                    }
                    else
                    {
                        cogRecordDisplay7.Record = AppValue.GetInstance().common.modelTB[se1].CreateLastRunRecord().SubRecords[0];
                        cogRecordDisplay7.Fit(true);
                        // AppValue.GetInstance().common.xiangji_1NG[se]++;
                        //    AppValue.GetInstance().common.xiangji_jieguo[se1] = "NG";
                        //   Z_baocuntup("NG", "NG", se);
                    }
                    //  stopwatch_1.Stop();
                    AppValue.GetInstance().common.elapsedTimeMilliseconds[se1] = stopwatch_1.ElapsedMilliseconds;

                    //  this.Invoke(new WriteInfoDelegate(CameraState), 1, "");
                    if (AppValue.GetInstance().common.elapsedTimeMilliseconds[se1] > 3000)
                    {
                        string se11 = "通孔1实时处理超时——" + "消耗时间：" + AppValue.GetInstance().common.elapsedTimeMilliseconds[se1];
                        this.Invoke(new WriteInfoDelegate(CameraState), 5, se11);
                        stopwatch_1.Stop();
                        break; ;
                    }
                }
                catch (Exception)
                {


                }
            } while (true);
            this.Invoke(new WriteInfoDelegate(CameraState), 6, "");
        }



        public void tongkong1shishi_2()
        {
            this.Invoke(new WriteInfoDelegate(CameraState), 5, "通孔2实时触发");
            int se = 1;
            //VPP序号
            int se1 = 2;
            stopwatch_1.Reset();
            stopwatch_1.Start();
            do
            {


                try
                {
                    if (AppValue.GetInstance().common.myFifo[se] != null)
                    {
                        AppValue.GetInstance().common.GrabImage(se, out AppValue.GetInstance().common.myImage[se1]);


                    }
                    else
                    {
                        this.ShowWarningDialog(uiLabel37.Text + "未连接");
                        break;
                    }
                    //TB.Inputs["Image1"].Value = MyCommon.myImage1;
                    AppValue.GetInstance().common.modelTB[se1].Inputs["OutputImage"].Value = AppValue.GetInstance().common.myImage[se1];

                    AppValue.GetInstance().common.modelTB[se1].Run();

                    AppValue.GetInstance().common.LB_1X[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["X1"].Value.ToString());
                    AppValue.GetInstance().common.LB_1Y[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["Y1"].Value.ToString());
                    AppValue.GetInstance().common.LB_1A[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["A1"].Value.ToString());
                    AppValue.GetInstance().common.LB_jieguo[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["jieguo"].Value.ToString());

                    if (AppValue.GetInstance().common.LB_jieguo[se1] != -999999)
                    {

                        cogRecordDisplay8.Record = AppValue.GetInstance().common.modelTB[se1].CreateLastRunRecord().SubRecords[0];
                        cogRecordDisplay8.Fit(true);
                        if (AppValue.GetInstance().common.LB_jieguo[se1] == 1)
                        {
                            stopwatch_1.Stop();
                            AppValue.GetInstance().common.elapsedTimeMilliseconds[se1] = stopwatch_1.ElapsedMilliseconds;
                         //   AppValue.GetInstance().common.xiangji_jieguo[se] = "OK";
                            Z_baocuntup("OK", "OK", se1);
                            string se11 = "通孔2实时处理结果:" + AppValue.GetInstance().common.LB_jieguo[se1] + "," + "X:" + AppValue.GetInstance().common.LB_1X[se1] + "," + "Y:" + AppValue.GetInstance().common.LB_1Y[se1] + "," + "角度:" + AppValue.GetInstance().common.LB_1A[se1] + "消耗时间：" + AppValue.GetInstance().common.elapsedTimeMilliseconds[se1];
                            this.Invoke(new WriteInfoDelegate(CameraState), 5, se11);
                            break;
                        }
                        else
                        {

                            //  AppValue.GetInstance().common.xiangji_jieguo[se1] = "NG";

                        }

                    }
                    else
                    {
                        cogRecordDisplay8.Record = AppValue.GetInstance().common.modelTB[se1].CreateLastRunRecord().SubRecords[0];
                        cogRecordDisplay8.Fit(true);
                        // AppValue.GetInstance().common.xiangji_1NG[se]++;
                        //    AppValue.GetInstance().common.xiangji_jieguo[se1] = "NG";
                        //   Z_baocuntup("NG", "NG", se);
                    }
                    //  stopwatch_1.Stop();
                    AppValue.GetInstance().common.elapsedTimeMilliseconds[se1] = stopwatch_1.ElapsedMilliseconds;

                    //  this.Invoke(new WriteInfoDelegate(CameraState), 1, "");
                    if (AppValue.GetInstance().common.elapsedTimeMilliseconds[se1] > 3000)
                    {
                        string se11 = "通孔1实时处理超时——" + "消耗时间：" + AppValue.GetInstance().common.elapsedTimeMilliseconds[se1];
                        this.Invoke(new WriteInfoDelegate(CameraState), 5, se11);
                        stopwatch_1.Stop();
                        break; ;
                    }
                }
                catch (Exception)
                {


                }
            } while (true);
            this.Invoke(new WriteInfoDelegate(CameraState),7, "");
        }


        /// <summary>
        /// 咬齿2触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton6_Click(object sender, EventArgs e)
        {
            this.Invoke(new WriteInfoDelegate(CameraState), 5, "咬齿2触发");
            int se = 3;
            //VPP序号
            int se1 = 5;
            stopwatch_3.Reset();
            stopwatch_3.Start();



            try
            {
                if (AppValue.GetInstance().common.myFifo[se] != null)
                {
                    AppValue.GetInstance().common.GrabImage(se, out AppValue.GetInstance().common.myImage[se1]);


                }
                else
                {
                    this.ShowWarningDialog(uiButton6.Text + "未连接");

                }
                //TB.Inputs["Image1"].Value = MyCommon.myImage1;
                AppValue.GetInstance().common.modelTB[se1].Inputs["OutputImage"].Value = AppValue.GetInstance().common.myImage[se1];

                AppValue.GetInstance().common.modelTB[se1].Run();

                AppValue.GetInstance().common.LB_1X[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["X1"].Value.ToString());
                AppValue.GetInstance().common.LB_1Y[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["Y1"].Value.ToString());
                AppValue.GetInstance().common.LB_1A[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["A1"].Value.ToString());
                AppValue.GetInstance().common.LB_jieguo[se1] = Convert.ToDouble(AppValue.GetInstance().common.modelTB[se1].Outputs["jieguo"].Value.ToString());

                if (AppValue.GetInstance().common.LB_jieguo[se1] != -999999)
                {

                    cogRecordDisplay9.Record = AppValue.GetInstance().common.modelTB[se1].CreateLastRunRecord().SubRecords[1];
                    cogRecordDisplay9.Fit(true);
                    if (AppValue.GetInstance().common.LB_jieguo[se1] == 1)
                    {
                        AppValue.GetInstance().common.xiangji_1OK[2]++;
                        AppValue.GetInstance().common.xiangji_jieguo[2] = "OK";
                        Z_baocuntup("OK", "OK", se1);
                    }
                    else
                    {
                        AppValue.GetInstance().common.xiangji_1NG[2]++;
                        AppValue.GetInstance().common.xiangji_jieguo[2] = "NG";
                        Z_baocuntup("NG", "NG", se1);
                    }

                }
                else
                {
                    cogRecordDisplay9.Record = AppValue.GetInstance().common.modelTB[se1].CreateLastRunRecord().SubRecords[0];
                    cogRecordDisplay9.Fit(true);
                    AppValue.GetInstance().common.xiangji_1NG[2]++;
                    AppValue.GetInstance().common.xiangji_jieguo[2] = "NG";
                    Z_baocuntup("NG", "NG", se1);
                }

                stopwatch_3.Stop();
                AppValue.GetInstance().common.elapsedTimeMilliseconds[se] = stopwatch_3.ElapsedMilliseconds;

                this.Invoke(new WriteInfoDelegate(CameraState), 3, "");
                string se11 = "咬齿2处理结果:" + AppValue.GetInstance().common.LB_jieguo[se1] + "," + "X:" + AppValue.GetInstance().common.LB_1X[se1] + "," + "Y:" + AppValue.GetInstance().common.LB_1Y[se1] + "," + "角度:" + AppValue.GetInstance().common.LB_1A[se1];
                this.Invoke(new WriteInfoDelegate(CameraState), 5, se11);

            }
            catch (Exception)
            {


            }
        }
    }
}
