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
using System.Timers;
using System.Windows.Forms;
using S7.Net;

namespace LaserAblation
{
    public partial class FormIO : UIForm
    {
        public FormIO()
        {
            InitializeComponent();
        }


        private void FormIO_Load(object sender, EventArgs e)
        {
            uiDataGridView1.DataSource = NonBind1();
            uiDataGridView2.DataSource = NonBind2();
            this.uiDataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.uiDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiDataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.uiDataGridView1.AutoResizeColumn(1, DataGridViewAutoSizeColumnMode.DisplayedCells);
            this.uiDataGridView1.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCells);


            this.uiDataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.uiDataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiDataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.uiDataGridView2.AutoResizeColumn(1, DataGridViewAutoSizeColumnMode.DisplayedCells);
            this.uiDataGridView2.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCells);

            txtIP.Text = AppValue.GetInstance().common.PLC_ip;


            if (AppValue.GetInstance().common.PLC_状态 == true)
            {
                textBox1.Text = "PLC连接成功";
                uiButton1.Enabled = false;
                timer1.Enabled = true;
            }
            else
            {
                textBox1.Text = "PLC连接成功";
                uiButton2.Enabled = false;
            }
        }


        /// <summary>
        /// 页面刷新
        /// </summary>
        /// <returns></returns>
        public DataTable NonBind1()
        {

            DataTable mydt = new DataTable();
            mydt.Columns.Add("输入/输出", Type.GetType("System.String"));
            mydt.Columns.Add("功能名称", Type.GetType("System.String"));
            mydt.Columns.Add("地址", Type.GetType("System.String"));
            mydt.Columns.Add("读取/写入", Type.GetType("System.String"));
            mydt.Rows.Add(new object[] { "→", "工位1触发", AppValue.GetInstance().common.plc_读取触发[0], AppValue.GetInstance().common.plc_读取数值[0] });
            mydt.Rows.Add(new object[] { "→", "工位2触发", AppValue.GetInstance().common.plc_读取触发[1], AppValue.GetInstance().common.plc_读取数值[1] });
            mydt.Rows.Add(new object[] { "→", "工位3触发", AppValue.GetInstance().common.plc_读取触发[2], AppValue.GetInstance().common.plc_读取数值[2] });
            mydt.Rows.Add(new object[] { "→", "工位4触发", AppValue.GetInstance().common.plc_读取触发[3], AppValue.GetInstance().common.plc_读取数值[3] });

            mydt.Rows.Add(new object[] { "→", "工位5触发", AppValue.GetInstance().common.plc_读取触发[4], AppValue.GetInstance().common.plc_读取数值[4] });
            mydt.Rows.Add(new object[] { "→", "工位6触发", AppValue.GetInstance().common.plc_读取触发[5], AppValue.GetInstance().common.plc_读取数值[5] });
            mydt.Rows.Add(new object[] { "→", "工位7触发", AppValue.GetInstance().common.plc_读取触发[6], AppValue.GetInstance().common.plc_读取数值[6] });



            return mydt;
        }



        /// <summary>
        /// 页面刷新
        /// </summary>
        /// <returns></returns>
        public DataTable NonBind2()
        {

            DataTable mydt = new DataTable();
            mydt.Columns.Add("输入/输出", Type.GetType("System.String"));
            mydt.Columns.Add("功能名称", Type.GetType("System.String"));
            mydt.Columns.Add("地址", Type.GetType("System.String"));
            mydt.Columns.Add("读取/写入", Type.GetType("System.String"));
            mydt.Rows.Add(new object[] { "←", "工位1结果", AppValue.GetInstance().common.plc_写入结果[0], "" });

            mydt.Rows.Add(new object[] { "←", "工位2结果", AppValue.GetInstance().common.plc_写入结果[1], "" });
            mydt.Rows.Add(new object[] { "←", "工位2数据", AppValue.GetInstance().common.xiangji_X[1], "" });


            mydt.Rows.Add(new object[] { "←", "工位3结果", AppValue.GetInstance().common.plc_写入结果[2], "" });

            mydt.Rows.Add(new object[] { "←", "工位4结果", AppValue.GetInstance().common.plc_写入结果[3], "" });
            mydt.Rows.Add(new object[] { "←", "工位4数据", AppValue.GetInstance().common.xiangji_X[3], "" });


            mydt.Rows.Add(new object[] { "←", "工位5结果", AppValue.GetInstance().common.plc_写入结果[4], "" });
            mydt.Rows.Add(new object[] { "←", "工位6结果", AppValue.GetInstance().common.plc_写入结果[5], "" });
            mydt.Rows.Add(new object[] { "←", "工位7结果", AppValue.GetInstance().common.plc_写入结果[6], "" });


            return mydt;
        }

        private void FormIO_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (AppValue.GetInstance().common.PLC_状态 == false)
            {
                AppValue.GetInstance().common.PLC_ip = txtIP.Text;
                AppValue.GetInstance().common.PLC_L连接(AppValue.GetInstance().common.PLC_ip);
                if (AppValue.GetInstance().common.PLC_状态 == true)
                {
                    textBox1.Text = "PLC连接成功";
                    textBox1.BackColor = Color.Green;
                    timer1.Enabled = true;
                    uiButton2.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("PLC已连接，请勿重复打开");
            }


        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (AppValue.GetInstance().common.PLC_状态 == true)
            {
                timer1.Enabled = false;
                AppValue.GetInstance().common.PLC_断开();
                if (AppValue.GetInstance().common.PLC_状态 == false)
                {
                    textBox1.Text = "PLC未连接";
                    uiButton1.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("PLC已断开,请勿重复断开");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (AppValue.GetInstance().common.PLC_状态 == true)
                {


                    for (int i = 0; i < 4; i++)
                    {
                        AppValue.GetInstance().common.plc_读取数值[i] = ((uint)AppValue.GetInstance().common.siemens.Read(AppValue.GetInstance().common.plc_读取触发[i])).ToString();
                    }
                    NonBind1();

                }
            }
            catch (Exception)
            {

                //  MessageBox.Show("PLC已断开");
            }


        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            setsave();
            AppValue.GetInstance().common.baocun();
        }



        /// <summary>
        /// 保存参数
        /// </summary>
        public void setsave()
        {
            try
            {
     








                AppValue.GetInstance().common.plc_读取触发[0] = uiDataGridView1.Rows[0].Cells[2].Value.ToString();

                AppValue.GetInstance().common.plc_读取触发[1] = uiDataGridView1.Rows[1].Cells[2].Value.ToString();

                AppValue.GetInstance().common.plc_读取触发[2] = uiDataGridView1.Rows[2].Cells[2].Value.ToString();

                AppValue.GetInstance().common.plc_读取触发[3] = uiDataGridView1.Rows[3].Cells[2].Value.ToString();

                AppValue.GetInstance().common.plc_读取触发[4] = uiDataGridView1.Rows[4].Cells[2].Value.ToString();

                AppValue.GetInstance().common.plc_读取触发[5] = uiDataGridView1.Rows[5].Cells[2].Value.ToString();

                AppValue.GetInstance().common.plc_读取触发[6] = uiDataGridView1.Rows[6].Cells[2].Value.ToString();





                AppValue.GetInstance().common.plc_写入结果[0] = uiDataGridView2.Rows[0].Cells[2].Value.ToString();
                AppValue.GetInstance().common.plc_写入结果[1] = uiDataGridView2.Rows[1].Cells[2].Value.ToString();
                AppValue.GetInstance().common.xiangji_X[1] = uiDataGridView2.Rows[2].Cells[2].Value.ToString();
                AppValue.GetInstance().common.plc_写入结果[2] = uiDataGridView2.Rows[3].Cells[2].Value.ToString();

                AppValue.GetInstance().common.plc_写入结果[3] = uiDataGridView2.Rows[4].Cells[2].Value.ToString();
                AppValue.GetInstance().common.xiangji_X[3] = uiDataGridView2.Rows[5].Cells[2].Value.ToString();

                AppValue.GetInstance().common.plc_写入结果[4] = uiDataGridView2.Rows[6].Cells[2].Value.ToString();
                AppValue.GetInstance().common.plc_写入结果[5] = uiDataGridView2.Rows[7].Cells[2].Value.ToString();
                AppValue.GetInstance().common.plc_写入结果[6] = uiDataGridView2.Rows[8].Cells[2].Value.ToString();




                AppValue.GetInstance().common.plc_写入数值[0] = Convert.ToInt32( uiDataGridView2.Rows[0].Cells[3].Value.ToString());
                AppValue.GetInstance().common.plc_写入数值[1] = Convert.ToInt32(uiDataGridView2.Rows[1].Cells[3].Value.ToString());
                AppValue.GetInstance().common.xiangji_X数值[1] = Convert.ToDouble(uiDataGridView2.Rows[2].Cells[3].Value.ToString());

                AppValue.GetInstance().common.plc_写入数值[2] = Convert.ToInt32(uiDataGridView2.Rows[3].Cells[3].Value.ToString());
                AppValue.GetInstance().common.plc_写入数值[3] = Convert.ToInt32(uiDataGridView2.Rows[4].Cells[3].Value.ToString());
                AppValue.GetInstance().common.xiangji_X数值[3] = Convert.ToDouble(uiDataGridView2.Rows[5].Cells[3].Value.ToString());

                AppValue.GetInstance().common.plc_写入数值[4] = Convert.ToInt32(uiDataGridView2.Rows[6].Cells[3].Value.ToString());
                AppValue.GetInstance().common.plc_写入数值[5] = Convert.ToInt32(uiDataGridView2.Rows[7].Cells[3].Value.ToString());
                AppValue.GetInstance().common.plc_写入数值[6] = Convert.ToInt32(uiDataGridView2.Rows[8].Cells[3].Value.ToString());
             
                


            }
            catch (Exception)
            {


            }

        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            if (AppValue.GetInstance().common.PLC_状态 == true)
            {
                setsave();
                try
                {
                    AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.plc_写入结果[1], AppValue.GetInstance().common.plc_写入数值[1]);
                    AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.xiangji_角度[0], AppValue.GetInstance().common.xiangji_角度数值[0]);
                    AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.plc_写入结果[1], AppValue.GetInstance().common.plc_写入数值[1]);
                    AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.plc_写入结果[2], AppValue.GetInstance().common.plc_写入数值[2]);
                    AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.xiangji_X[2], AppValue.GetInstance().common.xiangji_X数值[2]);
                    AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.xiangji_Y[2], AppValue.GetInstance().common.xiangji_Y数值[2]);
                    AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.plc_写入结果[3], AppValue.GetInstance().common.plc_写入数值[3]);
                    AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.xiangji_X[3], AppValue.GetInstance().common.xiangji_X数值[3]);
                    AppValue.GetInstance().common.siemens.Write(AppValue.GetInstance().common.xiangji_Y[3], AppValue.GetInstance().common.xiangji_Y数值[3]);
                   
                }
                catch (Exception)
                {


                }
            }

        }
    }
}
