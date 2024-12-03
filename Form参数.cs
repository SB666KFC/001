using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace LaserAblation
{
    public partial class canshu : UIForm
    {
        public canshu()
        {
            InitializeComponent();
        }

        private void Form参数_Load(object sender, EventArgs e)
        {
            uiLine13.Text = AppValue.GetInstance().common.canshumingc;
            if (AppValue.GetInstance().common.gongweihao == 1)
            {
                uiDataGridView1.DataSource = NonBind1();
            }
            if (AppValue.GetInstance().common.gongweihao == 2)
            {
                uiDataGridView1.DataSource = NonBind2();
            }
            if (AppValue.GetInstance().common.gongweihao == 3)
            {
                uiDataGridView1.DataSource = NonBind3();
            }
            if (AppValue.GetInstance().common.gongweihao == 4)
            {
                uiDataGridView1.DataSource = NonBind4();
            }
         
        }

        /// <summary>
        /// 页面刷新
        /// </summary>
        /// <returns></returns>
        public DataTable NonBind4()
        {
            DataTable mydt = new DataTable();
            mydt.Columns.Add("参数说明", Type.GetType("System.String"));
            mydt.Columns.Add("参数", Type.GetType("System.String"));
            mydt.Rows.Add(new object[] { "基准X", AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[0] });
            mydt.Rows.Add(new object[] { "基准Y", AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[1] });
            mydt.Rows.Add(new object[] { "基准角度", AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[2] });
            mydt.Rows.Add(new object[] { "补偿X", AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[3] });
            mydt.Rows.Add(new object[] { "补偿Y", AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[4] });
            mydt.Rows.Add(new object[] { "补偿角度", AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[5] });
            return mydt;
        }

        /// <summary>
        /// 页面刷新
        /// </summary>
        /// <returns></returns>
        public DataTable NonBind3()
        {
            DataTable mydt = new DataTable();
            mydt.Columns.Add("参数说明", Type.GetType("System.String"));
            mydt.Columns.Add("参数", Type.GetType("System.String"));
            mydt.Rows.Add(new object[] { "基准X", AppValue.GetInstance().common.gongweiyitiaoshicanshu_3[0] });
            mydt.Rows.Add(new object[] { "基准Y", AppValue.GetInstance().common.gongweiyitiaoshicanshu_3[1] });

            mydt.Rows.Add(new object[] { "补偿X", AppValue.GetInstance().common.gongweiyitiaoshicanshu_3[2] });
            mydt.Rows.Add(new object[] { "补偿Y", AppValue.GetInstance().common.gongweiyitiaoshicanshu_3[3] });

            return mydt;
        }

        /// <summary>
        /// 页面刷新
        /// </summary>
        /// <returns></returns>
        public DataTable NonBind2()
        {
            DataTable mydt = new DataTable();
            mydt.Columns.Add("参数说明", Type.GetType("System.String"));
            mydt.Columns.Add("参数", Type.GetType("System.String"));

            return mydt;
        }

        /// <summary>
        /// 页面刷新
        /// </summary>
        /// <returns></returns>
        public DataTable NonBind1()
        {
            DataTable mydt = new DataTable();
            mydt.Columns.Add("参数说明", Type.GetType("System.String"));
            mydt.Columns.Add("参数", Type.GetType("System.String"));
            mydt.Rows.Add(new object[] { "基准角度", AppValue.GetInstance().common.gongweiyitiaoshicanshu_1[0] });

            mydt.Rows.Add(new object[] { "补偿角度", AppValue.GetInstance().common.gongweiyitiaoshicanshu_1[1] });

            return mydt;
        }

        private void 参数设定_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            if (AppValue.GetInstance().common.gongweihao == 1)
            {
                setsave1();
            }
            if (AppValue.GetInstance().common.gongweihao == 3)
            {
                setsave3();
            }
            if (AppValue.GetInstance().common.gongweihao == 4)
            {
                setsave4();
            }
        }


        /// <summary>
        /// 保存参数
        /// </summary>
        public void setsave4()
        {
            try
            {
                AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[0] = uiDataGridView1.Rows[0].Cells[1].Value.ToString();

                AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[1] = uiDataGridView1.Rows[1].Cells[1].Value.ToString();

                AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[2] = uiDataGridView1.Rows[2].Cells[1].Value.ToString();

                AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[3] = uiDataGridView1.Rows[3].Cells[1].Value.ToString();

                AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[4] = uiDataGridView1.Rows[4].Cells[1].Value.ToString();

                AppValue.GetInstance().common.gongweiyitiaoshicanshu_4[5] = uiDataGridView1.Rows[5].Cells[1].Value.ToString();

            }
            catch (Exception)
            {


            }

        }


        /// <summary>
        /// 保存参数
        /// </summary>
        public void setsave3()
        {
            try
            {
                AppValue.GetInstance().common.gongweiyitiaoshicanshu_3[0] = uiDataGridView1.Rows[0].Cells[1].Value.ToString();

                AppValue.GetInstance().common.gongweiyitiaoshicanshu_3[1] = uiDataGridView1.Rows[1].Cells[1].Value.ToString();

                AppValue.GetInstance().common.gongweiyitiaoshicanshu_3[2] = uiDataGridView1.Rows[2].Cells[1].Value.ToString();

                AppValue.GetInstance().common.gongweiyitiaoshicanshu_3[3] = uiDataGridView1.Rows[3].Cells[1].Value.ToString();



            }
            catch (Exception)
            {


            }

        }

        /// <summary>
        /// 保存参数
        /// </summary>
        public void setsave1()
        {
            try
            {
                AppValue.GetInstance().common.gongweiyitiaoshicanshu_1[0] = uiDataGridView1.Rows[0].Cells[1].Value.ToString();
                AppValue.GetInstance().common.gongweiyitiaoshicanshu_1[1] = uiDataGridView1.Rows[1].Cells[1].Value.ToString();
            }
            catch (Exception)
            {


            }

        }


    }
}
