using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro.Exceptions;

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

using Cognex.VisionPro.CalibFix;
using System.Windows.Shapes;
using System.Xml.Linq;



namespace LaserAblation
{
    public partial class FormCalibration : UIForm
    {
        private CogImage8Grey myImage;
        private CogToolBlock AmendTB1, AmendTB2;//区分型号vpp

        List<(double, double)> listCoord = new List<(double, double)>();
        public FormCalibration()
        {
            InitializeComponent();
        }


        private void FormCalibration_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\proc\\Amend1.vpp";
            AmendTB1 = CogSerializer.LoadObjectFromFile(path) as CogToolBlock;

            path = Application.StartupPath + "\\proc\\Amend2.vpp";
            AmendTB2 = CogSerializer.LoadObjectFromFile(path) as CogToolBlock;

          //  INIUtils.Path = Application.StartupPath + @"\Settings\CalibrationParam.ini";
          //  Dictionary<string, string> frontCamera = INIUtils.GetAllKeyValues("FrontCamera");
          //  for (int i = 0; i < frontCamera.Count; i++)
          //  {
          //      string str = (i + 1).ToString();
          //      ListViewItem item = new ListViewItem(str);
          //      item.SubItems.Add(frontCamera[str].Split(',')[0]);
          //      item.SubItems.Add(frontCamera[str].Split(',')[1]);
          //      listView1.Items.Add(item);
          //  }
          ////  Dictionary<string, string> backCamera = INIUtils.GetAllKeyValues("BackCamera");
          //  for (int i = 0; i < frontCamera.Count; i++)
          //  {
          //      string str = (i + 1).ToString();
          //      ListViewItem item = new ListViewItem(str);
          //     // item.SubItems.Add(backCamera[str].Split(',')[0]);
          //    //  item.SubItems.Add(backCamera[str].Split(',')[1]);
          //      listView2.Items.Add(item);
          //  }
        //    Dictionary<string, string> formula = INIUtils.GetAllKeyValues("Formula");
           // uiTextBox_Back.Text = formula["Back"];
            //uiTextBox_Front.Text = formula["Front"];


        }

        private void uiButton_Add2_Click(object sender, EventArgs e)
        {
            //判断listview控件内是否有九点
            if (listView2.Items.Count >= 9)
            {
                UIMessageBox.ShowInfo("表格内信息数量不能大于9个");
            }
            else
            {
                ListViewItem item = new ListViewItem((listView2.Items.Count + 1).ToString());
                item.SubItems.Add(uiTextBox_X2.Text.ToString());
                item.SubItems.Add(uiTextBox_Y2.Text.ToString());
                listView2.Items.Add(item);
                uiTextBox_X2.Text = "";
                uiTextBox_Y2.Text = "";
            }
        }

        private void uiButton_Add1_Click(object sender, EventArgs e)
        {
            //判断listview控件内是否有九点
            if (listView1.Items.Count >= 9)
            {
                UIMessageBox.ShowInfo("表格内信息数量不能大于9个");
            }
            else
            {
                ListViewItem item = new ListViewItem((listView1.Items.Count + 1).ToString());
                item.SubItems.Add(uiTextBox_X1.Text.ToString());
                item.SubItems.Add(uiTextBox_Y1.Text.ToString());
                listView1.Items.Add(item);
                uiTextBox_X1.Text = "";
                uiTextBox_Y1.Text = "";
            }
        }

        private void uiButton_Clear2_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
        }

        private void uiButton_Clear1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void uiButton_Amend1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectItem1 = listView1.SelectedItems[0];

           
            
            
            }


        }

        private void uiButton_Amend2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem selectItem1 = listView2.SelectedItems[0];

            
             
            }
        }

        private void uiButton_Saver1_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 9)
            {
              //  INIUtils.Path = Application.StartupPath + @"\Settings\CalibrationParam.ini";
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                 //   INIUtils.Write("FrontCamera", (i + 1).ToString(), listView1.Items[i].SubItems[1].Text + "," + listView1.Items[i].SubItems[2].Text);
                }
             //  INIUtils.Write("Formula", "Front", uiTextBox_Front.Text);
                UIMessageBox.ShowSuccess("前相机机械坐标信息保存本地成功！");
            }
            else
            {
                UIMessageBox.ShowInfo("添加坐标数量少于9点，请检查点位信息");
            }

        }

        private void uiButton_Saver2_Click(object sender, EventArgs e)
        {
            if (listView2.Items.Count == 9)
            {
              
            }
            else
            {
                UIMessageBox.ShowInfo("添加坐标数量少于9点，请检查点位信息");
            }
        }

        private void uiButton_LoadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.bmp;*.png;*.jpg;*.jpeg;*.tif)|*.bmp;*.png;*.jpg;*.jpeg;*.tif";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                //string fullpath = openFileDialog1.FileName;//文件路径
                //FileStream fs = new FileStream(fullpath, FileMode.Open);
                CogImageFileTool cogImageFileTool = new CogImageFileTool();
                cogImageFileTool.Operator.Open(openFileDialog1.FileName, CogImageFileModeConstants.Read);
                cogImageFileTool.Run();

                myImage = (CogImage8Grey)cogImageFileTool.OutputImage;
                cogRecordDisplay1.Image = myImage;
                cogRecordDisplay1.Fit(true);

            }
        }

        //前相机标定
        CogCalibNPointToNPointTool calibTool = null;
        private void uiButton_FrontAmend_Click(object sender, EventArgs e)
        {
            if (myImage != null)
            {
                List<(double, double)> rowMajorCoordinates = new List<(double, double)>();
                listCoord.Clear();
                lvCalib.Items.Clear();
                string[] outputname = new string[] { "Output", "Output1", "Output2", "Output3", "Output4", "Output5", "Output6", "Output7", "Output8" };
                AmendTB1.Inputs["Input"].Value = myImage;
                AmendTB1.Run();
                cogRecordDisplay1.Record = AmendTB1.CreateLastRunRecord().SubRecords[0];//显示运行记录
                for (int i = 0; i < 9; i++)
                {
                    string[] result = AmendTB1.Outputs[outputname[i]].Value.ToString().Split(',');

                    listCoord.Add((Convert.ToDouble(result[0]), Convert.ToDouble(result[1])));
                }
                //坐标排序
                CoordinateOrdering(listCoord, ref rowMajorCoordinates, false);

                //实例化一个标定工具
                calibTool = new CogCalibNPointToNPointTool();


                //参数显示到listview控件内
               // INIUtils.Path = Application.StartupPath + @"\Settings\CalibrationParam.ini";
             //   Dictionary<string, string> frontCamera = INIUtils.GetAllKeyValues("FrontCamera");
                //for (int i = 0; i < frontCamera.Count; i++)
                //{
                //    string str = (i + 1).ToString();
                //    ListViewItem item = new ListViewItem(str);
                //    item.SubItems.Add(rowMajorCoordinates[i].Item1.ToString("0.00"));
                //    item.SubItems.Add(rowMajorCoordinates[i].Item2.ToString("0.00"));
                //    item.SubItems.Add(frontCamera[str].Split(',')[0]);
                //    item.SubItems.Add(frontCamera[str].Split(',')[1]);
                //    lvCalib.Items.Add(item);
                //    //发送信息
                //    calibTool.Calibration.AddPointPair(rowMajorCoordinates[i].Item1, rowMajorCoordinates[i].Item2, Convert.ToDouble(frontCamera[str].Split(',')[0]), Convert.ToDouble(frontCamera[str].Split(',')[1]));
                //}

                calibTool.InputImage = myImage;
                calibTool.CalibrationImage = calibTool.InputImage;
                try
                {
                    calibTool.Calibration.Calibrate();

                    calibTool.CurrentRecordEnable = CogCalibNPointToNPointCurrentRecordConstants.UncalibratedAxes |
                                                    CogCalibNPointToNPointCurrentRecordConstants.CalibratedAxes |
                                                    CogCalibNPointToNPointCurrentRecordConstants.CalUncalibratedPoints |
                                                    CogCalibNPointToNPointCurrentRecordConstants.CalRawCalibratedPoints;
                    if (calibTool.Calibration.Calibrated)
                    {
                        txtX.Text = (calibTool.Calibration.GetComputedUncalibratedFromCalibratedTransform() as CogTransform2DLinear).TranslationX.ToString("0.0000");
                        txtY.Text = (calibTool.Calibration.GetComputedUncalibratedFromCalibratedTransform() as CogTransform2DLinear).TranslationY.ToString("0.0000");
                        txtScal.Text = (calibTool.Calibration.GetComputedUncalibratedFromCalibratedTransform() as CogTransform2DLinear).Scaling.ToString("0.000000");
                        txtAspect.Text = (calibTool.Calibration.GetComputedUncalibratedFromCalibratedTransform() as CogTransform2DLinear).Aspect.ToString("0.000000");
                        txtRotation.Text = CogMisc.RadToDeg((calibTool.Calibration.GetComputedUncalibratedFromCalibratedTransform() as CogTransform2DLinear).Rotation).ToString("0.000000");
                        txtSkew.Text = CogMisc.RadToDeg((calibTool.Calibration.GetComputedUncalibratedFromCalibratedTransform() as CogTransform2DLinear).Skew).ToString("0.000000");
                        txtRMS.Text = calibTool.Calibration.ComputedRMSError.ToString("0.0000000");
                        //cogRecordDisplay1.Record = calibTool.CreateLastRunRecord().SubRecords[0];
                        //cogRecordDisplay1.Fit(true);
                    }
                }
                catch (CogException ce)
                {
                    UIMessageBox.ShowError("Encountered exception: " + ce.Message);
                }

            }

        }

        //保存前标定信息相机
        private void uiButton_SaverFront_Click(object sender, EventArgs e)
        {
            //bool isSaveAll = false;
            //string path = "";
            //CogCalibNPointToNPointTool calibTooltemp = null;
            //CogToolBlock TB = null;
            //if (MessageBox.Show("是否更新到全部型号", "确认窗口", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    isSaveAll = true;

            //}

            //if (isSaveAll)
            //{
            //    for (int i = 0; i < AppValue.GetInstance().common.m_Product.Count(); i++)
            //    {
            //        path = Application.StartupPath + "\\proc\\" + AppValue.GetInstance().common.m_Product[i] + ".vpp";
            //        TB = AppValue.GetInstance().common.TBList[AppValue.GetInstance().common.m_Product[i]];//对应的vpp
            //        foreach (ICogTool tool in TB.Tools)
            //        {
            //            if (tool.Name == "CogCalibNPointToNPointTool1")
            //            {
            //                calibTooltemp = (CogCalibNPointToNPointTool)tool;
            //                break;
            //            }

            //        }
            //        calibTooltemp.Calibration = calibTool.Calibration;
            //        calibTooltemp.InputImage = calibTool.InputImage;
            //        calibTooltemp.CalibrationImage = calibTool.CalibrationImage;
            //        AutoCalibration(calibTooltemp, calibTool.CalibrationImage as CogImage8Grey);
            //        CogSerializer.SaveObjectToFile(TB, path);
            //    }
            //    readVpp();
            //    UIMessageBox.ShowSuccess("保存标定文件成功");
            //}
            //else
            //{
              

            //}
        }

        #region 后相机标定

        private void uiButton_BackAmend_Click(object sender, EventArgs e)
        {
            if (myImage != null)
            {
                List<(double, double)> rowMajorCoordinates = new List<(double, double)>();
                listCoord.Clear();
                lvCalib.Items.Clear();
                string[] outputname = new string[] { "Output", "Output1", "Output2", "Output3", "Output4", "Output5", "Output6", "Output7", "Output8" };
                AmendTB2.Inputs["Input"].Value = myImage;
                AmendTB2.Run();
                cogRecordDisplay1.Record = AmendTB2.CreateLastRunRecord().SubRecords[0];//显示运行记录
                for (int i = 0; i < 9; i++)
                {
                    string[] result = AmendTB2.Outputs[outputname[i]].Value.ToString().Split(',');

                    listCoord.Add((Convert.ToDouble(result[0]), Convert.ToDouble(result[1])));
                }
                //坐标排序
               //CoordinateOrdering(listCoord, ref rowMajorCoordinates, true);

                //实例化一个标定工具
                calibTool = new CogCalibNPointToNPointTool();


                //参数显示到listview控件内
               // INIUtils.Path = Application.StartupPath + @"\Settings\CalibrationParam.ini";
          //  Dictionary<string, string> frontCamera = INIUtils.GetAllKeyValues("BackCamera");
             ////   for (int i = 0; i < frontCamera.Count; i++)
             //   {
             //       string str = (i + 1).ToString();
             //       ListViewItem item = new ListViewItem(str);
             //       item.SubItems.Add(listCoord[i].Item1.ToString("0.00"));
             //       item.SubItems.Add(listCoord[i].Item2.ToString("0.00"));
             //      // item.SubItems.Add(frontCamera[str].Split(',')[0]);
             //     //  item.SubItems.Add(frontCamera[str].Split(',')[1]);
             //       lvCalib.Items.Add(item);
             //       //发送信息
             //       calibTool.Calibration.AddPointPair(listCoord[i].Item1, listCoord[i].Item2, Convert.ToDouble(frontCamera[str].Split(',')[0]), Convert.ToDouble(frontCamera[str].Split(',')[1]));
             //   }

                calibTool.InputImage = myImage;
                calibTool.CalibrationImage = calibTool.InputImage;
                try
                {
                    calibTool.Calibration.Calibrate();

                    calibTool.CurrentRecordEnable = CogCalibNPointToNPointCurrentRecordConstants.UncalibratedAxes |
                                                    CogCalibNPointToNPointCurrentRecordConstants.CalibratedAxes |
                                                    CogCalibNPointToNPointCurrentRecordConstants.CalUncalibratedPoints |
                                                    CogCalibNPointToNPointCurrentRecordConstants.CalRawCalibratedPoints;
                    if (calibTool.Calibration.Calibrated)
                    {
                        txtX.Text = (calibTool.Calibration.GetComputedUncalibratedFromCalibratedTransform() as CogTransform2DLinear).TranslationX.ToString("0.0000");
                        txtY.Text = (calibTool.Calibration.GetComputedUncalibratedFromCalibratedTransform() as CogTransform2DLinear).TranslationY.ToString("0.0000");
                        txtScal.Text = (calibTool.Calibration.GetComputedUncalibratedFromCalibratedTransform() as CogTransform2DLinear).Scaling.ToString("0.000000");
                        txtAspect.Text = (calibTool.Calibration.GetComputedUncalibratedFromCalibratedTransform() as CogTransform2DLinear).Aspect.ToString("0.000000");
                        txtRotation.Text = CogMisc.RadToDeg((calibTool.Calibration.GetComputedUncalibratedFromCalibratedTransform() as CogTransform2DLinear).Rotation).ToString("0.000000");
                        txtSkew.Text = CogMisc.RadToDeg((calibTool.Calibration.GetComputedUncalibratedFromCalibratedTransform() as CogTransform2DLinear).Skew).ToString("0.000000");
                        txtRMS.Text = calibTool.Calibration.ComputedRMSError.ToString("0.0000000");
                        //cogRecordDisplay1.Record = calibTool.CreateLastRunRecord().SubRecords[0];
                        //cogRecordDisplay1.Fit(true);
                    }
                }
                catch (CogException ce)
                {
                    UIMessageBox.ShowError("Encountered exception: " + ce.Message);
                }
            }
        }

        private void uiButton_SaverBack_Click(object sender, EventArgs e)
        {
            //bool isSaveAll = false;
            //string path = "";
            //CogCalibNPointToNPointTool calibTooltemp = null;
            //CogToolBlock TB = null;
            //if (MessageBox.Show("是否更新到全部型号", "确认窗口", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    isSaveAll = true;

            //}

            //if (isSaveAll)
            //{
            //    for (int i = 0; i < AppValue.GetInstance().common.m_Product.Count(); i++)
            //    {
            //        path = Application.StartupPath + "\\proc\\" + AppValue.GetInstance().common.m_Product[i] + ".vpp";
            //        TB = AppValue.GetInstance().common.TBList[AppValue.GetInstance().common.m_Product[i]];//对应的vpp
            //        foreach (ICogTool tool in TB.Tools)
            //        {
            //            if (tool.Name == "CogCalibNPointToNPointTool1")
            //            {
            //                calibTooltemp = (CogCalibNPointToNPointTool)tool;
            //                break;
            //            }

            //        }
            //        calibTooltemp.Calibration = calibTool.Calibration;
            //        calibTooltemp.InputImage = calibTool.InputImage;
            //        calibTooltemp.CalibrationImage = calibTool.CalibrationImage;
            //        AutoCalibration(calibTooltemp, calibTool.CalibrationImage as CogImage8Grey);
            //        CogSerializer.SaveObjectToFile(TB, path);
            //    }
            //    readVpp();
            //    UIMessageBox.ShowSuccess("保存标定文件成功");
            //}
            //else
            //{
            

            
            //}
        }
        #endregion

        public void AutoCalibration(CogCalibNPointToNPointTool calibTool, CogImage8Grey myImage)
        {
            calibTool.InputImage = myImage;
            calibTool.CalibrationImage = calibTool.InputImage;
            try
            {
                calibTool.Calibration.Calibrate();
            }
            catch (CogException ce)
            {
                UIMessageBox.ShowError("Encountered exception: " + ce.Message);
            }
        }
        //坐标排序
        private void CoordinateOrdering(List<(double, double)> coordinates, ref List<(double, double)> rowmajorCoordinates, bool condition)
        {

            // 按行排列的重新排列结果
            List<(double, double)> rowMajorCoordinates = GenerateCoordinates(coordinates, condition);

            rowmajorCoordinates = rowMajorCoordinates;
        }




        // 生成重新排列的坐标
        public static List<(double, double)> GenerateCoordinates(List<(double, double)> coordinates, bool rowMajor)
        {
            if (rowMajor)
            {
                // 按行排列
                coordinates.Sort((a, b) =>
                {
                    if (a.Item1 != b.Item1)
                        return a.Item1.CompareTo(b.Item1);
                    else
                        return a.Item2.CompareTo(b.Item2);
                });


            }
            else
            {
                // 按列排列
                coordinates.Sort((a, b) =>
                {
                    if (a.Item2 != b.Item2)
                        return a.Item2.CompareTo(b.Item2);
                    else
                        return a.Item1.CompareTo(b.Item1);
                });
            }

            return coordinates;
        }



       
        }



    
    }




