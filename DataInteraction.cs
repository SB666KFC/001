using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGAN_EOLT
{
    public class DataInteraction
    {
        //文件保存位置
        public string FilePath_Log = Application.StartupPath + "\\Log";
        public string FilePath_Alert = Application.StartupPath + "\\Alert";

        //写入TXT文件
        public void TxtWrite(string str, string Filename, bool type)
        {
            try
            {
                string path;
                if (type)
                {
                    path = FilePath_Log;
                }
                else
                {
                    path = FilePath_Alert;
                }
                if (Directory.Exists(path) == false)//如果不存在就创建file文件夹
                {
                    Directory.CreateDirectory(path);
                }
                System.IO.StreamWriter t = new System.IO.StreamWriter(path + "\\" + Filename, true, System.Text.Encoding.UTF8);
                t.WriteLine(str);
                t.Close();
            }
            catch (Exception)
            {
            }
            
        }
    }
}
