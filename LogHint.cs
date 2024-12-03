using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAGAN_EOLT
{
    public class LogHint
    {
        DataInteraction DataInteraction = new DataInteraction();
        
        public Queue<string> LogLis = new Queue<string>();
        //public Queue<string> LogListInfo = new Queue<string>();
        //public Queue<string> LogList3 = new Queue<string>();





      
        public void DisplayFontColour(ListBox listBoxName, DrawItemEventArgs e)
        {
            if (listBoxName.Items.Count > 0 && listBoxName.Items.Count > e.Index)
            {
                if (e.Index < 0)
                { return; }
                string str = listBoxName.Items[e.Index].ToString();

                Color foreColor = Color.Black;
                //重点，根据item的具体内容决定颜色
                if (str.Contains("Info")) { foreColor = Color.Black; }
                if (str.Contains("Error")) { foreColor = Color.Red; }
                if (str.Contains("Hint")) { foreColor = Color.Blue; }
                //重点，画上颜色
                e.Graphics.DrawString(str, e.Font, new SolidBrush(foreColor), e.Bounds);
            }

        }


    }
}
