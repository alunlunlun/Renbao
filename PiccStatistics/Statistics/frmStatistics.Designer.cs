namespace PiccStatistics.Statistics
{
    partial class frmStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistics));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnMX = new DevComponents.DotNetBar.ButtonX();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnExportDay = new DevComponents.DotNetBar.ButtonX();
            this.btnReportView = new DevComponents.DotNetBar.ButtonX();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.pb = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.btnInput = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.savefd = new System.Windows.Forms.SaveFileDialog();
            this.openfd = new System.Windows.Forms.OpenFileDialog();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnFirst = new DevComponents.DotNetBar.ButtonItem();
            this.btnPre = new DevComponents.DotNetBar.ButtonItem();
            this.btnNext = new DevComponents.DotNetBar.ButtonItem();
            this.btnLast = new DevComponents.DotNetBar.ButtonItem();
            this.cbPage = new DevComponents.DotNetBar.ComboBoxItem();
            this.btnGoto = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.lblCounts = new DevComponents.DotNetBar.LabelItem();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.lbl = new DevComponents.DotNetBar.LabelItem();
            this.cbPageSize = new DevComponents.DotNetBar.ComboBoxItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.gvList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnMX);
            this.panelEx1.Controls.Add(this.dtpEnd);
            this.panelEx1.Controls.Add(this.btnExportDay);
            this.panelEx1.Controls.Add(this.btnReportView);
            this.panelEx1.Controls.Add(this.dtp);
            this.panelEx1.Controls.Add(this.lblCount);
            this.panelEx1.Controls.Add(this.pb);
            this.panelEx1.Controls.Add(this.btnInput);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(996, 46);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            // 
            // btnMX
            // 
            this.btnMX.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMX.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMX.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMX.Image = ((System.Drawing.Image)(resources.GetObject("btnMX.Image")));
            this.btnMX.Location = new System.Drawing.Point(476, 13);
            this.btnMX.Name = "btnMX";
            this.btnMX.Size = new System.Drawing.Size(94, 23);
            this.btnMX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMX.TabIndex = 21;
            this.btnMX.Text = "显示明细";
            this.btnMX.Click += new System.EventHandler(this.btnMX_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(147, 13);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(129, 21);
            this.dtpEnd.TabIndex = 20;
            // 
            // btnExportDay
            // 
            this.btnExportDay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportDay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExportDay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExportDay.Image = ((System.Drawing.Image)(resources.GetObject("btnExportDay.Image")));
            this.btnExportDay.Location = new System.Drawing.Point(378, 13);
            this.btnExportDay.Name = "btnExportDay";
            this.btnExportDay.Size = new System.Drawing.Size(92, 23);
            this.btnExportDay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExportDay.TabIndex = 19;
            this.btnExportDay.Text = "导出报表";
            this.btnExportDay.Click += new System.EventHandler(this.btnExportDay_Click);
            // 
            // btnReportView
            // 
            this.btnReportView.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReportView.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReportView.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReportView.Image = ((System.Drawing.Image)(resources.GetObject("btnReportView.Image")));
            this.btnReportView.Location = new System.Drawing.Point(287, 12);
            this.btnReportView.Name = "btnReportView";
            this.btnReportView.Size = new System.Drawing.Size(85, 23);
            this.btnReportView.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReportView.TabIndex = 17;
            this.btnReportView.Text = "开始统计";
            this.btnReportView.Click += new System.EventHandler(this.btnReportView_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(12, 13);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(129, 21);
            this.dtp.TabIndex = 16;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(808, 13);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(50, 23);
            this.lblCount.TabIndex = 15;
            this.lblCount.Text = "0";
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.pb.BackgroundStyle.Class = "";
            this.pb.Location = new System.Drawing.Point(595, 13);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(207, 23);
            this.pb.TabIndex = 14;
            this.pb.Text = "progressBarX1";
            // 
            // btnInput
            // 
            this.btnInput.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInput.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInput.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInput.Image = ((System.Drawing.Image)(resources.GetObject("btnInput.Image")));
            this.btnInput.Location = new System.Drawing.Point(864, 13);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(116, 23);
            this.btnInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInput.TabIndex = 10;
            this.btnInput.Text = "生成统计数据";
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(-71, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(63, 21);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "员工名称:";
            // 
            // openfd
            // 
            this.openfd.FileName = "openFileDialog1";
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnFirst,
            this.btnPre,
            this.btnNext,
            this.btnLast,
            this.cbPage,
            this.btnGoto,
            this.labelItem1,
            this.lblCounts,
            this.labelItem3,
            this.lbl,
            this.cbPageSize,
            this.labelItem2});
            this.bar1.Location = new System.Drawing.Point(0, 451);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(996, 28);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.bar1.TabIndex = 12;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnFirst
            // 
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Text = "首  页";
            // 
            // btnPre
            // 
            this.btnPre.Name = "btnPre";
            this.btnPre.Text = "上一页";
            // 
            // btnNext
            // 
            this.btnNext.Name = "btnNext";
            this.btnNext.Text = "下一页";
            // 
            // btnLast
            // 
            this.btnLast.Name = "btnLast";
            this.btnLast.Text = "尾  页";
            // 
            // cbPage
            // 
            this.cbPage.DropDownHeight = 106;
            this.cbPage.ItemHeight = 17;
            this.cbPage.Name = "cbPage";
            // 
            // btnGoto
            // 
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Text = "Go";
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "共有记录";
            // 
            // lblCounts
            // 
            this.lblCounts.Name = "lblCounts";
            // 
            // labelItem3
            // 
            this.labelItem3.Name = "labelItem3";
            this.labelItem3.Text = "条";
            // 
            // lbl
            // 
            this.lbl.Name = "lbl";
            this.lbl.Text = "每页显示";
            // 
            // cbPageSize
            // 
            this.cbPageSize.DropDownHeight = 106;
            this.cbPageSize.ItemHeight = 17;
            this.cbPageSize.Name = "cbPageSize";
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "条";
            // 
            // gvList
            // 
            this.gvList.AllowUserToAddRows = false;
            this.gvList.AllowUserToDeleteRows = false;
            this.gvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvList.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvList.Location = new System.Drawing.Point(0, 46);
            this.gvList.MultiSelect = false;
            this.gvList.Name = "gvList";
            this.gvList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvList.RowTemplate.Height = 30;
            this.gvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvList.Size = new System.Drawing.Size(996, 405);
            this.gvList.TabIndex = 13;
            this.gvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvList_CellContentClick);
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 479);
            this.Controls.Add(this.gvList);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Name = "frmStatistics";
            this.Text = "日报表统计";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnMX;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private DevComponents.DotNetBar.ButtonX btnExportDay;
        private DevComponents.DotNetBar.ButtonX btnReportView;
        private System.Windows.Forms.DateTimePicker dtp;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.Controls.ProgressBarX pb;
        private DevComponents.DotNetBar.ButtonX btnInput;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.SaveFileDialog savefd;
        private System.Windows.Forms.OpenFileDialog openfd;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnFirst;
        private DevComponents.DotNetBar.ButtonItem btnPre;
        private DevComponents.DotNetBar.ButtonItem btnNext;
        private DevComponents.DotNetBar.ButtonItem btnLast;
        private DevComponents.DotNetBar.ComboBoxItem cbPage;
        private DevComponents.DotNetBar.ButtonItem btnGoto;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem lblCounts;
        private DevComponents.DotNetBar.LabelItem labelItem3;
        private DevComponents.DotNetBar.LabelItem lbl;
        private DevComponents.DotNetBar.ComboBoxItem cbPageSize;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.Controls.DataGridViewX gvList;
    }
}