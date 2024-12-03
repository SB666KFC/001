using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaserAblation
{
     class AppValue
    {
        public string guanbi = "false";//关闭程序

        public string ParamPath = "D://" + "Config";//参数保存路径

        public string Data = "D://" + "Config";// 程序Config文件夹所在路径

        public string Delete = "D://" + "Config";//删除文件夹

        public bool gigeState;//网口是否打开

        public string SystemINI = "D://" + "Config\\System.ini";// 系统配置文件

        public string SystemINIjiaodu = "D://" + "Config\\Systemjiaodu.ini";// 系统配置文件


        public string ParamPathBC;//保存路径

        public int aa;//委托变量

        public int bb = 0;//OK数量

        public int cc = 0;//NG数量





        private static AppValue _AppValue = null;//定义一个静态字段，数据类型为AppValue（本类）。

        private static object _Lock = new object();//定义一个object类型的静态字段


        /// <summary>
        /// 相机数量
        /// </summary>
       public int xiangjishuliang = 7;


        public Comon common = new Comon();//公共方法
       

        public delegate void TitleChangedEventHandler(int se);

        public TitleChangedEventHandler TitleChanged;
      

        /// <summary>
        /// 更改当前文件夹路径
        /// </summary>
        /// <param name="path"></param>
        public void CreateProduct(string path)
        {
            Data = ParamPath + "\\" + path;
        }

        /// <summary>
        /// 删除文件夹路径
        /// </summary>
        /// <param name="path"></param>
        public void Delect(string path)
        {
            Delete = ParamPath + "\\" + path;
        }


        public static AppValue GetInstance()//通过这个方法，获取_instance的状态，返回值为AppValue类型
        {
            if (_AppValue == null)
            {
                lock (_Lock)//加锁
                {
                    if (_AppValue == null)
                    {
                        _AppValue = new AppValue();
                    }
                }
            }
            return _AppValue;
        }
        /// <summary>
        /// 委托事件
        /// </summary>
        /// <param name="a"></param>
        public void weituo(int a)
        {
            int se23;
            se23 = a;
            if (TitleChanged != null)
                TitleChanged(se23); //委托调用
        }

    }
}
