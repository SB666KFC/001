using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.ToolBlock;

using System.Windows.Forms;

namespace LaserAblation
{
    class Vision
    {
        /// <summary>
        /// 定义图像变量
        /// </summary>
        public CogImage8Grey m_image;
        /// <summary>
        /// 实例化本地图像获取变量图像
        /// </summary>
        public CogImageFileTool m_imagefiletool = new CogImageFileTool();
        /// <summary>
        /// 实例化相机变量
        /// </summary>
        public CogAcqFifoTool m_acqtool = new CogAcqFifoTool();
        /// <summary>
        /// 实例化ToolBlock变量
        /// </summary>
        public CogToolBlock m_ToolBlock = new CogToolBlock();
        //定义路径接收变量
        public string path;
        /// <summary>
        /// 产品名
        /// </summary>
        public string type;
        /// <summary>
        /// 相机标志位
        /// </summary>
        public bool iscam_OK;

        public string productpath;

        public string strpronames;


        public void Loadproduct()
        {
           

            try
            {
                if (type != "")
                {
                    //判断本地图像是否文件存在
                    if (File.Exists(productpath + "//" + type + "_imagefiletool.app"))
                    {
                        m_imagefiletool = CogSerializer.LoadObjectFromFile(productpath + "//" + type + "_imagefiletool.app") as CogImageFileTool;
                    }
                    //判断相机是否文件存在
                    if (File.Exists(productpath + "//" + type + "AcqFifoTool.app"))
                    {
                        m_acqtool = CogSerializer.LoadObjectFromFile(productpath + "//" + type + "AcqFifoTool.app") as CogAcqFifoTool;
                    }
                    //判断工具是否文件存在
                    if (File.Exists(productpath + "//" + type + "Toolblock1.app"))
                    {
                        m_ToolBlock = CogSerializer.LoadObjectFromFile(productpath + "//" + type + "Toolblock1.app") as CogToolBlock;
                    }
                }
    
            }
            catch (Exception ex)
            {
              
            }
        }


        /// <summary>
        /// 保存产品
        /// </summary>
        /// <returns></returns>
        public void Saveproduct()
        {
          

            //首先判断构造函数内赋值是否为空
            if (type == "")
            {
                MessageBox.Show("产品类型为空，请输入产品类型!");//判断是否为空 
            }
            productpath = path + "//" + "Data//" + type;
            if (!(Directory.Exists(path + "//" + "Data//" + type)))
            {
                Directory.CreateDirectory(path + "//" + "Data//" + type);
            }

            try
            {
                //判断是否获取到本地图像
                if (m_imagefiletool != null)
                {
                    //保存CogImageFileTool，以app打尾
                    CogSerializer.SaveObjectToFile(m_imagefiletool, productpath + "//" + type + "_imagefiletool.app");
                }
                //判断相机是否获取设置
                if (m_acqtool.Operator != null)
                {
                    //保存CogAcqFifoTool，以app打尾
                    CogSerializer.SaveObjectToFile(m_acqtool, productpath + "//" + type + "AcqFifoTool.app");
                }
                //判断工具是否为空
                if (m_ToolBlock != null)
                {
                    //保存工具变量 CogToolBlock
                    CogSerializer.SaveObjectToFile(m_ToolBlock, productpath + "//" + type + "Toolblock1.app");
                }
               
            }

            catch (Exception ex)
            {
                //反则失败
                
            }
        }

    }

}
