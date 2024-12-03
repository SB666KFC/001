namespace LaserAblation
{
    partial class FormVpp
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel_Location = new Sunny.UI.UILabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cogToolBlockEditV21 = new Cognex.VisionPro.ToolBlock.CogToolBlockEditV2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uiLabel_jieguo = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel_A1 = new Sunny.UI.UILabel();
            this.uiLabel_Y1 = new Sunny.UI.UILabel();
            this.uiLabel_X1 = new Sunny.UI.UILabel();
            this.uiLabel_Ang = new Sunny.UI.UILabel();
            this.uiLabel_Y = new Sunny.UI.UILabel();
            this.uiLabel_X = new Sunny.UI.UILabel();
            this.uiButton_WriteVpp = new Sunny.UI.UIButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV21)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(0, 0);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(98, 29);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "程序路径：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel_Location
            // 
            this.uiLabel_Location.AutoSize = true;
            this.uiLabel_Location.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel_Location.Location = new System.Drawing.Point(102, 4);
            this.uiLabel_Location.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel_Location.Name = "uiLabel_Location";
            this.uiLabel_Location.Size = new System.Drawing.Size(29, 21);
            this.uiLabel_Location.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_Location.TabIndex = 1;
            this.uiLabel_Location.Text = "D/";
            this.uiLabel_Location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Controls.Add(this.uiLabel_Location);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 29);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cogToolBlockEditV21);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1183, 730);
            this.panel2.TabIndex = 3;
            // 
            // cogToolBlockEditV21
            // 
            this.cogToolBlockEditV21.AllowDrop = true;
            this.cogToolBlockEditV21.ContextMenuCustomizer = null;
            this.cogToolBlockEditV21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogToolBlockEditV21.Location = new System.Drawing.Point(0, 0);
            this.cogToolBlockEditV21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cogToolBlockEditV21.MinimumSize = new System.Drawing.Size(652, 0);
            this.cogToolBlockEditV21.Name = "cogToolBlockEditV21";
            this.cogToolBlockEditV21.ShowNodeToolTips = true;
            this.cogToolBlockEditV21.Size = new System.Drawing.Size(1183, 730);
            this.cogToolBlockEditV21.SuspendElectricRuns = false;
            this.cogToolBlockEditV21.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.uiLabel_jieguo);
            this.panel3.Controls.Add(this.uiLabel7);
            this.panel3.Controls.Add(this.uiLabel_A1);
            this.panel3.Controls.Add(this.uiLabel_Y1);
            this.panel3.Controls.Add(this.uiLabel_X1);
            this.panel3.Controls.Add(this.uiLabel_Ang);
            this.panel3.Controls.Add(this.uiLabel_Y);
            this.panel3.Controls.Add(this.uiLabel_X);
            this.panel3.Controls.Add(this.uiButton_WriteVpp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 792);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1183, 63);
            this.panel3.TabIndex = 4;
            // 
            // uiLabel_jieguo
            // 
            this.uiLabel_jieguo.AutoSize = true;
            this.uiLabel_jieguo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel_jieguo.Location = new System.Drawing.Point(642, 19);
            this.uiLabel_jieguo.Name = "uiLabel_jieguo";
            this.uiLabel_jieguo.Size = new System.Drawing.Size(19, 21);
            this.uiLabel_jieguo.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_jieguo.TabIndex = 11;
            this.uiLabel_jieguo.Text = "0";
            this.uiLabel_jieguo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.Location = new System.Drawing.Point(558, 20);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(78, 21);
            this.uiLabel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel7.TabIndex = 8;
            this.uiLabel7.Text = "检查结果:";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_A1
            // 
            this.uiLabel_A1.AutoSize = true;
            this.uiLabel_A1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel_A1.Location = new System.Drawing.Point(422, 20);
            this.uiLabel_A1.Name = "uiLabel_A1";
            this.uiLabel_A1.Size = new System.Drawing.Size(19, 21);
            this.uiLabel_A1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_A1.TabIndex = 7;
            this.uiLabel_A1.Text = "0";
            this.uiLabel_A1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_Y1
            // 
            this.uiLabel_Y1.AutoSize = true;
            this.uiLabel_Y1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel_Y1.Location = new System.Drawing.Point(217, 20);
            this.uiLabel_Y1.Name = "uiLabel_Y1";
            this.uiLabel_Y1.Size = new System.Drawing.Size(19, 21);
            this.uiLabel_Y1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_Y1.TabIndex = 6;
            this.uiLabel_Y1.Text = "0";
            this.uiLabel_Y1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_X1
            // 
            this.uiLabel_X1.AutoSize = true;
            this.uiLabel_X1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel_X1.Location = new System.Drawing.Point(67, 19);
            this.uiLabel_X1.Name = "uiLabel_X1";
            this.uiLabel_X1.Size = new System.Drawing.Size(19, 21);
            this.uiLabel_X1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_X1.TabIndex = 5;
            this.uiLabel_X1.Text = "0";
            this.uiLabel_X1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_Ang
            // 
            this.uiLabel_Ang.AutoSize = true;
            this.uiLabel_Ang.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel_Ang.Location = new System.Drawing.Point(361, 19);
            this.uiLabel_Ang.Name = "uiLabel_Ang";
            this.uiLabel_Ang.Size = new System.Drawing.Size(55, 21);
            this.uiLabel_Ang.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_Ang.TabIndex = 4;
            this.uiLabel_Ang.Text = "角度1:";
            this.uiLabel_Ang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_Y
            // 
            this.uiLabel_Y.AutoSize = true;
            this.uiLabel_Y.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel_Y.Location = new System.Drawing.Point(181, 19);
            this.uiLabel_Y.Name = "uiLabel_Y";
            this.uiLabel_Y.Size = new System.Drawing.Size(33, 21);
            this.uiLabel_Y.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_Y.TabIndex = 3;
            this.uiLabel_Y.Text = "Y1:";
            this.uiLabel_Y.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_X
            // 
            this.uiLabel_X.AutoSize = true;
            this.uiLabel_X.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel_X.Location = new System.Drawing.Point(33, 19);
            this.uiLabel_X.Name = "uiLabel_X";
            this.uiLabel_X.Size = new System.Drawing.Size(33, 21);
            this.uiLabel_X.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_X.TabIndex = 2;
            this.uiLabel_X.Text = "X1:";
            this.uiLabel_X.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton_WriteVpp
            // 
            this.uiButton_WriteVpp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_WriteVpp.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_WriteVpp.Location = new System.Drawing.Point(922, 8);
            this.uiButton_WriteVpp.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_WriteVpp.Name = "uiButton_WriteVpp";
            this.uiButton_WriteVpp.Size = new System.Drawing.Size(258, 46);
            this.uiButton_WriteVpp.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton_WriteVpp.TabIndex = 1;
            this.uiButton_WriteVpp.Text = "保存更新后程序";
            this.uiButton_WriteVpp.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton_WriteVpp.Click += new System.EventHandler(this.uiButton_WriteVpp_Click);
            // 
            // FormVpp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 855);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(1487, 1029);
            this.Name = "FormVpp";
            this.Padding = new System.Windows.Forms.Padding(0, 33, 0, 0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "程序编辑";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.FormVpp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV21)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel_Location;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Cognex.VisionPro.ToolBlock.CogToolBlockEditV2 cogToolBlockEditV21;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UIButton uiButton_WriteVpp;
        private Sunny.UI.UILabel uiLabel_A1;
        private Sunny.UI.UILabel uiLabel_Y1;
        private Sunny.UI.UILabel uiLabel_X1;
        private Sunny.UI.UILabel uiLabel_Ang;
        private Sunny.UI.UILabel uiLabel_Y;
        private Sunny.UI.UILabel uiLabel_X;
        private Sunny.UI.UILabel uiLabel_jieguo;
        private Sunny.UI.UILabel uiLabel7;
    }
}