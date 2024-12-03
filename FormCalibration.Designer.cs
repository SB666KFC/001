namespace LaserAblation
{
    partial class FormCalibration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalibration));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiButton_SaverBack = new Sunny.UI.UIButton();
            this.uiButton_SaverFront = new Sunny.UI.UIButton();
            this.uiButton_LoadImage = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtRMS = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtAspect = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtScal = new System.Windows.Forms.TextBox();
            this.txtRotation = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtSkew = new System.Windows.Forms.TextBox();
            this.lvCalib = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiButton_FrontAmend = new Sunny.UI.UIButton();
            this.uiButton_BackAmend = new Sunny.UI.UIButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.uiButton_BackLaser = new Sunny.UI.UIButton();
            this.uiButton_Clear2 = new Sunny.UI.UIButton();
            this.uiButton_Amend2 = new Sunny.UI.UIButton();
            this.uiButton_Saver2 = new Sunny.UI.UIButton();
            this.uiTextBox_Y2 = new Sunny.UI.UITextBox();
            this.uiTextBox_X2 = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiButton_Add2 = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiTextBox_Back = new Sunny.UI.UITextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiButton_FrontLaser = new Sunny.UI.UIButton();
            this.uiButton_Clear1 = new Sunny.UI.UIButton();
            this.uiButton_Amend1 = new Sunny.UI.UIButton();
            this.uiButton_Add1 = new Sunny.UI.UIButton();
            this.uiButton_Saver1 = new Sunny.UI.UIButton();
            this.uiTextBox_Y1 = new Sunny.UI.UITextBox();
            this.uiTextBox_X1 = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTextBox_Front = new Sunny.UI.UITextBox();
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.uiTabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cogRecordDisplay1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1058, 572);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(532, 3);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(523, 566);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabIndex = 8;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uiButton_SaverBack);
            this.tabPage1.Controls.Add(this.uiButton_SaverFront);
            this.tabPage1.Controls.Add(this.uiButton_LoadImage);
            this.tabPage1.Controls.Add(this.uiButton2);
            this.tabPage1.Controls.Add(this.uiButton1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.lvCalib);
            this.tabPage1.Controls.Add(this.uiButton_FrontAmend);
            this.tabPage1.Controls.Add(this.uiButton_BackAmend);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(523, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "九点标定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // uiButton_SaverBack
            // 
            this.uiButton_SaverBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_SaverBack.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_SaverBack.Location = new System.Drawing.Point(258, 435);
            this.uiButton_SaverBack.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_SaverBack.Name = "uiButton_SaverBack";
            this.uiButton_SaverBack.Size = new System.Drawing.Size(257, 77);
            this.uiButton_SaverBack.TabIndex = 1264;
            this.uiButton_SaverBack.Text = "保存定位相机标定";
            this.uiButton_SaverBack.TipsFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_SaverBack.Click += new System.EventHandler(this.uiButton_SaverBack_Click);
            // 
            // uiButton_SaverFront
            // 
            this.uiButton_SaverFront.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_SaverFront.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_SaverFront.Location = new System.Drawing.Point(241, 435);
            this.uiButton_SaverFront.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_SaverFront.Name = "uiButton_SaverFront";
            this.uiButton_SaverFront.Size = new System.Drawing.Size(11, 77);
            this.uiButton_SaverFront.TabIndex = 1263;
            this.uiButton_SaverFront.Text = "保存前相机标定";
            this.uiButton_SaverFront.TipsFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_SaverFront.Visible = false;
            this.uiButton_SaverFront.Click += new System.EventHandler(this.uiButton_SaverFront_Click);
            // 
            // uiButton_LoadImage
            // 
            this.uiButton_LoadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_LoadImage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_LoadImage.Location = new System.Drawing.Point(258, 296);
            this.uiButton_LoadImage.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_LoadImage.Name = "uiButton_LoadImage";
            this.uiButton_LoadImage.Size = new System.Drawing.Size(257, 35);
            this.uiButton_LoadImage.TabIndex = 1262;
            this.uiButton_LoadImage.Text = "加载本地图像";
            this.uiButton_LoadImage.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_LoadImage.Click += new System.EventHandler(this.uiButton_LoadImage_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(258, 249);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(257, 35);
            this.uiButton2.TabIndex = 1261;
            this.uiButton2.Text = "定位相机采集图像";
            this.uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
           // this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(241, 249);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(11, 35);
            this.uiButton1.TabIndex = 1260;
            this.uiButton1.Text = "前相机采集图像";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Visible = false;
           // this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtRMS);
            this.groupBox4.Controls.Add(this.txtX);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.txtAspect);
            this.groupBox4.Controls.Add(this.txtY);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.txtScal);
            this.groupBox4.Controls.Add(this.txtRotation);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.txtSkew);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(3, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 275);
            this.groupBox4.TabIndex = 1259;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "标定结果";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(17, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 15);
            this.label21.TabIndex = 36;
            this.label21.Text = "平移 X";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRMS
            // 
            this.txtRMS.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRMS.Location = new System.Drawing.Point(87, 239);
            this.txtRMS.Name = "txtRMS";
            this.txtRMS.Size = new System.Drawing.Size(129, 24);
            this.txtRMS.TabIndex = 49;
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtX.Location = new System.Drawing.Point(87, 29);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(129, 24);
            this.txtX.TabIndex = 37;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(17, 242);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 15);
            this.label22.TabIndex = 48;
            this.label22.Text = "RMS 误差";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(17, 67);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 15);
            this.label23.TabIndex = 38;
            this.label23.Text = "平移 Y";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAspect
            // 
            this.txtAspect.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAspect.Location = new System.Drawing.Point(87, 134);
            this.txtAspect.Name = "txtAspect";
            this.txtAspect.Size = new System.Drawing.Size(129, 24);
            this.txtAspect.TabIndex = 47;
            // 
            // txtY
            // 
            this.txtY.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtY.Location = new System.Drawing.Point(87, 64);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(129, 24);
            this.txtY.TabIndex = 39;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(17, 137);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 15);
            this.label24.TabIndex = 46;
            this.label24.Text = "纵横比";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(17, 172);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 15);
            this.label25.TabIndex = 40;
            this.label25.Text = "旋转";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScal
            // 
            this.txtScal.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtScal.Location = new System.Drawing.Point(87, 99);
            this.txtScal.Name = "txtScal";
            this.txtScal.Size = new System.Drawing.Size(129, 24);
            this.txtScal.TabIndex = 45;
            // 
            // txtRotation
            // 
            this.txtRotation.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRotation.Location = new System.Drawing.Point(87, 169);
            this.txtRotation.Name = "txtRotation";
            this.txtRotation.Size = new System.Drawing.Size(129, 24);
            this.txtRotation.TabIndex = 41;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(17, 102);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 15);
            this.label26.TabIndex = 44;
            this.label26.Text = "缩放";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(17, 207);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(37, 15);
            this.label27.TabIndex = 42;
            this.label27.Text = "倾斜";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSkew
            // 
            this.txtSkew.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSkew.Location = new System.Drawing.Point(87, 204);
            this.txtSkew.Name = "txtSkew";
            this.txtSkew.Size = new System.Drawing.Size(129, 24);
            this.txtSkew.TabIndex = 43;
            // 
            // lvCalib
            // 
            this.lvCalib.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvCalib.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvCalib.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvCalib.HideSelection = false;
            this.lvCalib.Location = new System.Drawing.Point(0, 0);
            this.lvCalib.Name = "lvCalib";
            this.lvCalib.Size = new System.Drawing.Size(523, 238);
            this.lvCalib.TabIndex = 1258;
            this.lvCalib.UseCompatibleStateImageBehavior = false;
            this.lvCalib.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "像素坐标X";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "像素坐标Y";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "机械坐标X (mm)";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "机械坐标Y (mm)";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 120;
            // 
            // uiButton_FrontAmend
            // 
            this.uiButton_FrontAmend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_FrontAmend.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_FrontAmend.Location = new System.Drawing.Point(241, 343);
            this.uiButton_FrontAmend.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_FrontAmend.Name = "uiButton_FrontAmend";
            this.uiButton_FrontAmend.Size = new System.Drawing.Size(11, 77);
            this.uiButton_FrontAmend.TabIndex = 5;
            this.uiButton_FrontAmend.Text = "前相机标定";
            this.uiButton_FrontAmend.TipsFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_FrontAmend.Visible = false;
            this.uiButton_FrontAmend.Click += new System.EventHandler(this.uiButton_FrontAmend_Click);
            // 
            // uiButton_BackAmend
            // 
            this.uiButton_BackAmend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_BackAmend.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_BackAmend.Location = new System.Drawing.Point(258, 343);
            this.uiButton_BackAmend.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_BackAmend.Name = "uiButton_BackAmend";
            this.uiButton_BackAmend.Size = new System.Drawing.Size(257, 77);
            this.uiButton_BackAmend.TabIndex = 6;
            this.uiButton_BackAmend.Text = "定位相机标定";
            this.uiButton_BackAmend.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_BackAmend.Click += new System.EventHandler(this.uiButton_BackAmend_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.uiButton_BackLaser);
            this.tabPage3.Controls.Add(this.uiButton_Clear2);
            this.tabPage3.Controls.Add(this.uiButton_Amend2);
            this.tabPage3.Controls.Add(this.uiButton_Saver2);
            this.tabPage3.Controls.Add(this.uiTextBox_Y2);
            this.tabPage3.Controls.Add(this.uiTextBox_X2);
            this.tabPage3.Controls.Add(this.uiLabel5);
            this.tabPage3.Controls.Add(this.uiLabel6);
            this.tabPage3.Controls.Add(this.listView2);
            this.tabPage3.Controls.Add(this.uiButton_Add2);
            this.tabPage3.Controls.Add(this.uiLabel2);
            this.tabPage3.Controls.Add(this.uiTextBox_Back);
            this.tabPage3.Location = new System.Drawing.Point(0, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(523, 526);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "定位相机机械坐标";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // uiButton_BackLaser
            // 
            this.uiButton_BackLaser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_BackLaser.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_BackLaser.Location = new System.Drawing.Point(24, 422);
            this.uiButton_BackLaser.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_BackLaser.Name = "uiButton_BackLaser";
            this.uiButton_BackLaser.Size = new System.Drawing.Size(326, 64);
            this.uiButton_BackLaser.TabIndex = 23;
            this.uiButton_BackLaser.Text = "刻印标定点";
            this.uiButton_BackLaser.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
         //   this.uiButton_BackLaser.Click += new System.EventHandler(this.uiButton_BackLaser_Click);
            // 
            // uiButton_Clear2
            // 
            this.uiButton_Clear2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Clear2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Clear2.Location = new System.Drawing.Point(399, 254);
            this.uiButton_Clear2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Clear2.Name = "uiButton_Clear2";
            this.uiButton_Clear2.Size = new System.Drawing.Size(93, 35);
            this.uiButton_Clear2.TabIndex = 18;
            this.uiButton_Clear2.Text = "清除";
            this.uiButton_Clear2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Clear2.Click += new System.EventHandler(this.uiButton_Clear2_Click);
            // 
            // uiButton_Amend2
            // 
            this.uiButton_Amend2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Amend2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Amend2.Location = new System.Drawing.Point(399, 200);
            this.uiButton_Amend2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Amend2.Name = "uiButton_Amend2";
            this.uiButton_Amend2.Size = new System.Drawing.Size(93, 35);
            this.uiButton_Amend2.TabIndex = 17;
            this.uiButton_Amend2.Text = "修改";
            this.uiButton_Amend2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Amend2.Click += new System.EventHandler(this.uiButton_Amend2_Click);
            // 
            // uiButton_Saver2
            // 
            this.uiButton_Saver2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Saver2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Saver2.Location = new System.Drawing.Point(373, 327);
            this.uiButton_Saver2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Saver2.Name = "uiButton_Saver2";
            this.uiButton_Saver2.Size = new System.Drawing.Size(139, 64);
            this.uiButton_Saver2.TabIndex = 16;
            this.uiButton_Saver2.Text = "保存";
            this.uiButton_Saver2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Saver2.Click += new System.EventHandler(this.uiButton_Saver2_Click);
            // 
            // uiTextBox_Y2
            // 
            this.uiTextBox_Y2.ButtonSymbol = 61761;
            this.uiTextBox_Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_Y2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiTextBox_Y2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_Y2.Location = new System.Drawing.Point(399, 102);
            this.uiTextBox_Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_Y2.Maximum = 2147483647D;
            this.uiTextBox_Y2.Minimum = -2147483648D;
            this.uiTextBox_Y2.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_Y2.Name = "uiTextBox_Y2";
            this.uiTextBox_Y2.Size = new System.Drawing.Size(93, 26);
            this.uiTextBox_Y2.TabIndex = 15;
            this.uiTextBox_Y2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_X2
            // 
            this.uiTextBox_X2.ButtonSymbol = 61761;
            this.uiTextBox_X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_X2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiTextBox_X2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_X2.Location = new System.Drawing.Point(399, 52);
            this.uiTextBox_X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_X2.Maximum = 2147483647D;
            this.uiTextBox_X2.Minimum = -2147483648D;
            this.uiTextBox_X2.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_X2.Name = "uiTextBox_X2";
            this.uiTextBox_X2.Size = new System.Drawing.Size(93, 26);
            this.uiTextBox_X2.TabIndex = 14;
            this.uiTextBox_X2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(369, 105);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(36, 21);
            this.uiLabel5.TabIndex = 13;
            this.uiLabel5.Text = "Y：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.Location = new System.Drawing.Point(369, 55);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(36, 21);
            this.uiLabel6.TabIndex = 12;
            this.uiLabel6.Text = "X：";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.HoverSelection = true;
            this.listView2.Location = new System.Drawing.Point(3, 3);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(347, 310);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "No";
            this.columnHeader9.Width = 40;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "机械坐标X(mm)";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "机械坐标Y(mm)";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 150;
            // 
            // uiButton_Add2
            // 
            this.uiButton_Add2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Add2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Add2.Location = new System.Drawing.Point(399, 149);
            this.uiButton_Add2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Add2.Name = "uiButton_Add2";
            this.uiButton_Add2.Size = new System.Drawing.Size(93, 35);
            this.uiButton_Add2.TabIndex = 10;
            this.uiButton_Add2.Text = "添加";
            this.uiButton_Add2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Add2.Click += new System.EventHandler(this.uiButton_Add2_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(20, 349);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(138, 21);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "后相机标定配方：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_Back
            // 
            this.uiTextBox_Back.ButtonSymbol = 61761;
            this.uiTextBox_Back.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_Back.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiTextBox_Back.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_Back.Location = new System.Drawing.Point(165, 346);
            this.uiTextBox_Back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_Back.Maximum = 2147483647D;
            this.uiTextBox_Back.Minimum = -2147483648D;
            this.uiTextBox_Back.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_Back.Name = "uiTextBox_Back";
            this.uiTextBox_Back.Size = new System.Drawing.Size(117, 25);
            this.uiTextBox_Back.TabIndex = 3;
            this.uiTextBox_Back.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uiButton_FrontLaser);
            this.tabPage2.Controls.Add(this.uiButton_Clear1);
            this.tabPage2.Controls.Add(this.uiButton_Amend1);
            this.tabPage2.Controls.Add(this.uiButton_Add1);
            this.tabPage2.Controls.Add(this.uiButton_Saver1);
            this.tabPage2.Controls.Add(this.uiTextBox_Y1);
            this.tabPage2.Controls.Add(this.uiTextBox_X1);
            this.tabPage2.Controls.Add(this.uiLabel4);
            this.tabPage2.Controls.Add(this.uiLabel3);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.uiLabel1);
            this.tabPage2.Controls.Add(this.uiTextBox_Front);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(523, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "前相机机械坐标";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uiButton_FrontLaser
            // 
            this.uiButton_FrontLaser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_FrontLaser.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_FrontLaser.Location = new System.Drawing.Point(24, 422);
            this.uiButton_FrontLaser.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_FrontLaser.Name = "uiButton_FrontLaser";
            this.uiButton_FrontLaser.Size = new System.Drawing.Size(326, 64);
            this.uiButton_FrontLaser.TabIndex = 22;
            this.uiButton_FrontLaser.Text = "刻印标定点";
            this.uiButton_FrontLaser.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
       //     this.uiButton_FrontLaser.Click += new System.EventHandler(this.uiButton_FrontLaser_Click);
            // 
            // uiButton_Clear1
            // 
            this.uiButton_Clear1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Clear1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Clear1.Location = new System.Drawing.Point(399, 254);
            this.uiButton_Clear1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Clear1.Name = "uiButton_Clear1";
            this.uiButton_Clear1.Size = new System.Drawing.Size(93, 35);
            this.uiButton_Clear1.TabIndex = 21;
            this.uiButton_Clear1.Text = "清除";
            this.uiButton_Clear1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Clear1.Click += new System.EventHandler(this.uiButton_Clear1_Click);
            // 
            // uiButton_Amend1
            // 
            this.uiButton_Amend1.BackColor = System.Drawing.Color.Transparent;
            this.uiButton_Amend1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Amend1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Amend1.Location = new System.Drawing.Point(399, 200);
            this.uiButton_Amend1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Amend1.Name = "uiButton_Amend1";
            this.uiButton_Amend1.Size = new System.Drawing.Size(93, 35);
            this.uiButton_Amend1.TabIndex = 20;
            this.uiButton_Amend1.Text = "修改";
            this.uiButton_Amend1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Amend1.Click += new System.EventHandler(this.uiButton_Amend1_Click);
            // 
            // uiButton_Add1
            // 
            this.uiButton_Add1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Add1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Add1.Location = new System.Drawing.Point(399, 149);
            this.uiButton_Add1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Add1.Name = "uiButton_Add1";
            this.uiButton_Add1.Size = new System.Drawing.Size(93, 35);
            this.uiButton_Add1.TabIndex = 19;
            this.uiButton_Add1.Text = "添加";
            this.uiButton_Add1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Add1.Click += new System.EventHandler(this.uiButton_Add1_Click);
            // 
            // uiButton_Saver1
            // 
            this.uiButton_Saver1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_Saver1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Saver1.Location = new System.Drawing.Point(373, 327);
            this.uiButton_Saver1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Saver1.Name = "uiButton_Saver1";
            this.uiButton_Saver1.Size = new System.Drawing.Size(139, 64);
            this.uiButton_Saver1.TabIndex = 10;
            this.uiButton_Saver1.Text = "保存";
            this.uiButton_Saver1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_Saver1.Click += new System.EventHandler(this.uiButton_Saver1_Click);
            // 
            // uiTextBox_Y1
            // 
            this.uiTextBox_Y1.ButtonSymbol = 61761;
            this.uiTextBox_Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_Y1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiTextBox_Y1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_Y1.Location = new System.Drawing.Point(399, 102);
            this.uiTextBox_Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_Y1.Maximum = 2147483647D;
            this.uiTextBox_Y1.Minimum = -2147483648D;
            this.uiTextBox_Y1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_Y1.Name = "uiTextBox_Y1";
            this.uiTextBox_Y1.Size = new System.Drawing.Size(93, 26);
            this.uiTextBox_Y1.TabIndex = 9;
            this.uiTextBox_Y1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_X1
            // 
            this.uiTextBox_X1.ButtonSymbol = 61761;
            this.uiTextBox_X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_X1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiTextBox_X1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_X1.Location = new System.Drawing.Point(399, 52);
            this.uiTextBox_X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_X1.Maximum = 2147483647D;
            this.uiTextBox_X1.Minimum = -2147483648D;
            this.uiTextBox_X1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_X1.Name = "uiTextBox_X1";
            this.uiTextBox_X1.Size = new System.Drawing.Size(93, 26);
            this.uiTextBox_X1.TabIndex = 8;
            this.uiTextBox_X1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(369, 105);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(36, 21);
            this.uiLabel4.TabIndex = 7;
            this.uiLabel4.Text = "Y：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(369, 55);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(36, 21);
            this.uiLabel3.TabIndex = 6;
            this.uiLabel3.Text = "X：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(347, 310);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "No";
            this.columnHeader6.Width = 40;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "机械坐标X(mm)";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "机械坐标Y(mm)";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 150;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(20, 349);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(138, 21);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "前相机标定配方：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox_Front
            // 
            this.uiTextBox_Front.ButtonSymbol = 61761;
            this.uiTextBox_Front.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_Front.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiTextBox_Front.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox_Front.Location = new System.Drawing.Point(165, 346);
            this.uiTextBox_Front.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox_Front.Maximum = 2147483647D;
            this.uiTextBox_Front.Minimum = -2147483648D;
            this.uiTextBox_Front.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox_Front.Name = "uiTextBox_Front";
            this.uiTextBox_Front.Size = new System.Drawing.Size(117, 26);
            this.uiTextBox_Front.TabIndex = 2;
            this.uiTextBox_Front.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cogRecordDisplay1
            // 
            this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay1.Location = new System.Drawing.Point(3, 3);
            this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
            this.cogRecordDisplay1.Size = new System.Drawing.Size(523, 566);
            this.cogRecordDisplay1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormCalibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 607);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormCalibration";
            this.Text = "九点标定";
            this.Load += new System.EventHandler(this.FormCalibration_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtRMS;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtAspect;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtScal;
        private System.Windows.Forms.TextBox txtRotation;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtSkew;
        private System.Windows.Forms.ListView lvCalib;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private Sunny.UI.UIButton uiButton_FrontAmend;
        private Sunny.UI.UIButton uiButton_BackAmend;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UITextBox uiTextBox_Y1;
        private Sunny.UI.UITextBox uiTextBox_X1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox_Front;
        private System.Windows.Forms.TabPage tabPage3;
        private Sunny.UI.UITextBox uiTextBox_Y2;
        private Sunny.UI.UITextBox uiTextBox_X2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private Sunny.UI.UIButton uiButton_Add2;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox uiTextBox_Back;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
        private Sunny.UI.UIButton uiButton_Saver1;
        private Sunny.UI.UIButton uiButton_Saver2;
        private Sunny.UI.UIButton uiButton_Clear1;
        private Sunny.UI.UIButton uiButton_Amend1;
        private Sunny.UI.UIButton uiButton_Add1;
        private Sunny.UI.UIButton uiButton_Clear2;
        private Sunny.UI.UIButton uiButton_Amend2;
        private Sunny.UI.UIButton uiButton_LoadImage;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Sunny.UI.UIButton uiButton_SaverBack;
        private Sunny.UI.UIButton uiButton_SaverFront;
        private Sunny.UI.UIButton uiButton_FrontLaser;
        private Sunny.UI.UIButton uiButton_BackLaser;
    }
}