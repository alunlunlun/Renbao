namespace PiccStatistics.Ratio
{
    partial class frmRatio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRatio));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnAll = new DevComponents.DotNetBar.ButtonX();
            this.dpt = new System.Windows.Forms.DateTimePicker();
            this.btnInput = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.gvList = new DevComponents.DotNetBar.Controls.DataGridViewX();
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
            this.btnDellAll = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnDellAll);
            this.panelEx1.Controls.Add(this.btnAll);
            this.panelEx1.Controls.Add(this.dpt);
            this.panelEx1.Controls.Add(this.btnInput);
            this.panelEx1.Controls.Add(this.btnSearch);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(931, 46);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            // 
            // btnAll
            // 
            this.btnAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAll.Image")));
            this.btnAll.Location = new System.Drawing.Point(215, 12);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(91, 23);
            this.btnAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btnAll.TabIndex = 15;
            this.btnAll.Text = "显示全部";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // dpt
            // 
            this.dpt.Location = new System.Drawing.Point(13, 12);
            this.dpt.Name = "dpt";
            this.dpt.Size = new System.Drawing.Size(116, 21);
            this.dpt.TabIndex = 14;
            // 
            // btnInput
            // 
            this.btnInput.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInput.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInput.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInput.Image = ((System.Drawing.Image)(resources.GetObject("btnInput.Image")));
            this.btnInput.Location = new System.Drawing.Point(844, 12);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInput.TabIndex = 13;
            this.btnInput.Text = "添加";
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(135, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gvList
            // 
            this.gvList.AllowUserToAddRows = false;
            this.gvList.AllowUserToDeleteRows = false;
            this.gvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gvList.RowTemplate.Height = 30;
            this.gvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvList.Size = new System.Drawing.Size(931, 390);
            this.gvList.TabIndex = 11;
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
            this.bar1.Location = new System.Drawing.Point(0, 436);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(931, 28);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.bar1.TabIndex = 10;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnFirst
            // 
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Text = "首  页";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPre
            // 
            this.btnPre.Name = "btnPre";
            this.btnPre.Text = "上一页";
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Name = "btnNext";
            this.btnNext.Text = "下一页";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Name = "btnLast";
            this.btnLast.Text = "尾  页";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
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
            this.btnGoto.Click += new System.EventHandler(this.btnGoto_Click);
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
            this.cbPageSize.TextChanged += new System.EventHandler(this.cbPageSize_TextChanged);
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "条";
            // 
            // btnDellAll
            // 
            this.btnDellAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDellAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDellAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDellAll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDellAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDellAll.Image")));
            this.btnDellAll.Location = new System.Drawing.Point(764, 12);
            this.btnDellAll.Name = "btnDellAll";
            this.btnDellAll.Size = new System.Drawing.Size(74, 23);
            this.btnDellAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btnDellAll.TabIndex = 16;
            this.btnDellAll.Text = "清空";
            this.btnDellAll.Click += new System.EventHandler(this.btnDellAll_Click);
            // 
            // frmRatio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 464);
            this.Controls.Add(this.gvList);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Name = "frmRatio";
            this.Text = "日比例设定";
            this.Load += new System.EventHandler(this.frmRatio_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnInput;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.DataGridViewX gvList;
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
        private System.Windows.Forms.DateTimePicker dpt;
        private DevComponents.DotNetBar.ButtonX btnAll;
        private DevComponents.DotNetBar.ButtonX btnDellAll;
    }
}