namespace LaserAblation
{
    partial class FormDisplayImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisplayImage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiDoubleUpDown_Exposure = new Sunny.UI.UIDoubleUpDown();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiTrackBar1 = new Sunny.UI.UITrackBar();
            this.uiLabel134 = new Sunny.UI.UILabel();
            this.uiSymbolButton9 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton5 = new Sunny.UI.UISymbolButton();
            this.uiButton16 = new Sunny.UI.UIButton();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLine13 = new Sunny.UI.UILine();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiComboBox_SelectCam = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiButton_Live = new Sunny.UI.UIButton();
            this.uiButton_Once = new Sunny.UI.UIButton();
            this.uiComboBox_VppModel = new Sunny.UI.UIComboBox();
            this.uiButton_vpp = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cogRecordDisplay1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 640);
            this.panel2.TabIndex = 15;
            // 
            // cogRecordDisplay1
            // 
            this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay1.Dock = System.Windows.Forms.DockStyle.Left;
            this.cogRecordDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay1.Location = new System.Drawing.Point(0, 0);
            this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
            this.cogRecordDisplay1.Size = new System.Drawing.Size(697, 640);
            this.cogRecordDisplay1.TabIndex = 16;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(697, 35);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 640);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiButton3);
            this.panel1.Controls.Add(this.uiDoubleUpDown_Exposure);
            this.panel1.Controls.Add(this.uiLine2);
            this.panel1.Controls.Add(this.uiButton2);
            this.panel1.Controls.Add(this.uiTrackBar1);
            this.panel1.Controls.Add(this.uiLabel134);
            this.panel1.Controls.Add(this.uiSymbolButton9);
            this.panel1.Controls.Add(this.uiSymbolButton5);
            this.panel1.Controls.Add(this.uiButton16);
            this.panel1.Controls.Add(this.uiLine1);
            this.panel1.Controls.Add(this.uiLine13);
            this.panel1.Controls.Add(this.uiButton1);
            this.panel1.Controls.Add(this.uiComboBox_SelectCam);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Controls.Add(this.uiButton_Live);
            this.panel1.Controls.Add(this.uiButton_Once);
            this.panel1.Controls.Add(this.uiComboBox_VppModel);
            this.panel1.Controls.Add(this.uiButton_vpp);
            this.panel1.Controls.Add(this.uiLabel3);
            this.panel1.Controls.Add(this.uiLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(700, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 640);
            this.panel1.TabIndex = 17;
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Location = new System.Drawing.Point(21, 480);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(262, 59);
            this.uiButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton3.TabIndex = 305;
            this.uiButton3.Text = "保存视觉配置";
            this.uiButton3.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiDoubleUpDown_Exposure
            // 
            this.uiDoubleUpDown_Exposure.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDoubleUpDown_Exposure.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDoubleUpDown_Exposure.Location = new System.Drawing.Point(86, 71);
            this.uiDoubleUpDown_Exposure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDoubleUpDown_Exposure.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiDoubleUpDown_Exposure.Name = "uiDoubleUpDown_Exposure";
            this.uiDoubleUpDown_Exposure.ShowText = false;
            this.uiDoubleUpDown_Exposure.Size = new System.Drawing.Size(116, 29);
            this.uiDoubleUpDown_Exposure.Style = Sunny.UI.UIStyle.Custom;
            this.uiDoubleUpDown_Exposure.TabIndex = 304;
            this.uiDoubleUpDown_Exposure.Text = "uiDoubleUpDown1";
            this.uiDoubleUpDown_Exposure.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiDoubleUpDown_Exposure.ValueChanged += new Sunny.UI.UIDoubleUpDown.OnValueChanged(this.uiDoubleUpDown_Exposure_ValueChanged);
            // 
            // uiLine2
            // 
            this.uiLine2.BackColor = System.Drawing.Color.Transparent;
            this.uiLine2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine2.LineDashStyle = Sunny.UI.UILineDashStyle.Solid;
            this.uiLine2.Location = new System.Drawing.Point(3, 328);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(297, 20);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 303;
            this.uiLine2.Text = "工位程序切换";
            this.uiLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(31, 284);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(241, 38);
            this.uiButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton2.TabIndex = 302;
            this.uiButton2.Text = "手动检测";
            this.uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiTrackBar1
            // 
            this.uiTrackBar1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTrackBar1.Location = new System.Drawing.Point(57, 245);
            this.uiTrackBar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTrackBar1.Name = "uiTrackBar1";
            this.uiTrackBar1.Size = new System.Drawing.Size(183, 22);
            this.uiTrackBar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTrackBar1.TabIndex = 301;
            this.uiTrackBar1.Text = "uiTrackBar1";
            this.uiTrackBar1.ValueChanged += new System.EventHandler(this.uiTrackBar1_ValueChanged);
            // 
            // uiLabel134
            // 
            this.uiLabel134.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel134.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel134.Location = new System.Drawing.Point(112, 231);
            this.uiLabel134.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.uiLabel134.Name = "uiLabel134";
            this.uiLabel134.Size = new System.Drawing.Size(90, 19);
            this.uiLabel134.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel134.TabIndex = 300;
            this.uiLabel134.Text = "0/0";
            this.uiLabel134.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolButton9
            // 
            this.uiSymbolButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton9.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton9.Location = new System.Drawing.Point(18, 231);
            this.uiSymbolButton9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton9.Name = "uiSymbolButton9";
            this.uiSymbolButton9.Size = new System.Drawing.Size(37, 36);
            this.uiSymbolButton9.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton9.Symbol = 61514;
            this.uiSymbolButton9.SymbolSize = 5;
            this.uiSymbolButton9.TabIndex = 299;
            this.uiSymbolButton9.TipsFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton9.Click += new System.EventHandler(this.uiSymbolButton9_Click);
            // 
            // uiSymbolButton5
            // 
            this.uiSymbolButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton5.Location = new System.Drawing.Point(246, 231);
            this.uiSymbolButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton5.Name = "uiSymbolButton5";
            this.uiSymbolButton5.Size = new System.Drawing.Size(37, 36);
            this.uiSymbolButton5.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton5.Symbol = 61518;
            this.uiSymbolButton5.SymbolSize = 5;
            this.uiSymbolButton5.TabIndex = 298;
            this.uiSymbolButton5.TipsFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton5.Click += new System.EventHandler(this.uiSymbolButton5_Click);
            // 
            // uiButton16
            // 
            this.uiButton16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton16.Location = new System.Drawing.Point(164, 178);
            this.uiButton16.Margin = new System.Windows.Forms.Padding(0);
            this.uiButton16.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton16.Name = "uiButton16";
            this.uiButton16.Radius = 8;
            this.uiButton16.RectSize = 2;
            this.uiButton16.Size = new System.Drawing.Size(119, 38);
            this.uiButton16.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton16.TabIndex = 297;
            this.uiButton16.Text = "寻访追溯图片";
            this.uiButton16.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton16.Click += new System.EventHandler(this.uiButton16_Click);
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine1.LineDashStyle = Sunny.UI.UILineDashStyle.Solid;
            this.uiLine1.Location = new System.Drawing.Point(3, 152);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(297, 20);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 27;
            this.uiLine1.Text = "图像追溯";
            this.uiLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine13
            // 
            this.uiLine13.BackColor = System.Drawing.Color.Transparent;
            this.uiLine13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine13.LineDashStyle = Sunny.UI.UILineDashStyle.Solid;
            this.uiLine13.Location = new System.Drawing.Point(3, 7);
            this.uiLine13.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine13.Name = "uiLine13";
            this.uiLine13.Size = new System.Drawing.Size(297, 16);
            this.uiLine13.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine13.TabIndex = 26;
            this.uiLine13.Text = "相机调试";
            this.uiLine13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(31, 178);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(108, 38);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 23;
            this.uiButton1.Text = "打开图片";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiComboBox_SelectCam
            // 
            this.uiComboBox_SelectCam.DataSource = null;
            this.uiComboBox_SelectCam.FillColor = System.Drawing.Color.White;
            this.uiComboBox_SelectCam.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox_SelectCam.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboBox_SelectCam.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboBox_SelectCam.Items.AddRange(new object[] {
            "实时通孔检测1",
            "夹角复检1",
            "实时通孔检测2",
            "夹角复检2",
            "咬齿1",
            "咬齿2",
            "卡扣扣接状态"});
            this.uiComboBox_SelectCam.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox_SelectCam.Location = new System.Drawing.Point(101, 31);
            this.uiComboBox_SelectCam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox_SelectCam.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox_SelectCam.Name = "uiComboBox_SelectCam";
            this.uiComboBox_SelectCam.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox_SelectCam.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox_SelectCam.Style = Sunny.UI.UIStyle.Custom;
            this.uiComboBox_SelectCam.SymbolSize = 24;
            this.uiComboBox_SelectCam.TabIndex = 14;
            this.uiComboBox_SelectCam.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox_SelectCam.Watermark = "";
            this.uiComboBox_SelectCam.SelectedIndexChanged += new System.EventHandler(this.uiComboBox_SelectCam_SelectedIndexChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(17, 31);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 29);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 12;
            this.uiLabel1.Text = "相机选择：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton_Live
            // 
            this.uiButton_Live.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Live.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Live.Location = new System.Drawing.Point(178, 108);
            this.uiButton_Live.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Live.Name = "uiButton_Live";
            this.uiButton_Live.Size = new System.Drawing.Size(95, 38);
            this.uiButton_Live.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton_Live.TabIndex = 18;
            this.uiButton_Live.Text = "实时采集";
            this.uiButton_Live.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Live.Click += new System.EventHandler(this.uiButton_Live_Click);
            // 
            // uiButton_Once
            // 
            this.uiButton_Once.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Once.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Once.Location = new System.Drawing.Point(32, 108);
            this.uiButton_Once.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Once.Name = "uiButton_Once";
            this.uiButton_Once.Size = new System.Drawing.Size(107, 38);
            this.uiButton_Once.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton_Once.TabIndex = 17;
            this.uiButton_Once.Text = "单次采图";
            this.uiButton_Once.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Once.Click += new System.EventHandler(this.uiButton_Once_Click);
            // 
            // uiComboBox_VppModel
            // 
            this.uiComboBox_VppModel.DataSource = null;
            this.uiComboBox_VppModel.FillColor = System.Drawing.Color.White;
            this.uiComboBox_VppModel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox_VppModel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboBox_VppModel.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboBox_VppModel.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox_VppModel.Location = new System.Drawing.Point(115, 356);
            this.uiComboBox_VppModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox_VppModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox_VppModel.Name = "uiComboBox_VppModel";
            this.uiComboBox_VppModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox_VppModel.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox_VppModel.Style = Sunny.UI.UIStyle.Custom;
            this.uiComboBox_VppModel.SymbolSize = 24;
            this.uiComboBox_VppModel.TabIndex = 20;
            this.uiComboBox_VppModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox_VppModel.Watermark = "";
            // 
            // uiButton_vpp
            // 
            this.uiButton_vpp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_vpp.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_vpp.Location = new System.Drawing.Point(21, 404);
            this.uiButton_vpp.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_vpp.Name = "uiButton_vpp";
            this.uiButton_vpp.Size = new System.Drawing.Size(262, 38);
            this.uiButton_vpp.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton_vpp.TabIndex = 21;
            this.uiButton_vpp.Text = "vpp工具";
            this.uiButton_vpp.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_vpp.Click += new System.EventHandler(this.uiButton_vpp_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(14, 356);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 29);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 19;
            this.uiLabel3.Text = "VPP切换：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(31, 71);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(48, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 13;
            this.uiLabel2.Text = "曝光:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormDisplayImage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1003, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Name = "FormDisplayImage";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "图像管理";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 1003, 675);
            this.Load += new System.EventHandler(this.FormDisplayImage_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIComboBox uiComboBox_SelectCam;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton_Live;
        private Sunny.UI.UIComboBox uiComboBox_VppModel;
        private Sunny.UI.UIButton uiButton_vpp;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UITrackBar uiTrackBar1;
        private Sunny.UI.UILabel uiLabel134;
        public Sunny.UI.UISymbolButton uiSymbolButton9;
        public Sunny.UI.UISymbolButton uiSymbolButton5;
        private Sunny.UI.UIButton uiButton16;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine13;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UIButton uiButton_Once;
        private Sunny.UI.UIDoubleUpDown uiDoubleUpDown_Exposure;
        private Sunny.UI.UIButton uiButton3;
    }
}