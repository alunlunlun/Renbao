namespace PiccStatistics
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.btnDayReport = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnDetial = new DevComponents.DotNetBar.ButtonItem();
            this.btnShop = new DevComponents.DotNetBar.ButtonItem();
            this.btnDayRatio = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.btnUserManager = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbUserid = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMain = new DevComponents.DotNetBar.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.Class = "";
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("微软雅黑", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.Size = new System.Drawing.Size(818, 86);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 1;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar3);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Controls.Add(this.ribbonBar2);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 28);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(818, 56);
            // 
            // 
            // 
            this.ribbonPanel1.Style.Class = "";
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.Class = "";
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.Class = "";
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDayReport});
            this.ribbonBar3.Location = new System.Drawing.Point(286, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(81, 53);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 4;
            this.ribbonBar3.Text = "ribbonBar3";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.Class = "";
            this.ribbonBar3.TitleVisible = false;
            // 
            // btnDayReport
            // 
            this.btnDayReport.Image = ((System.Drawing.Image)(resources.GetObject("btnDayReport.Image")));
            this.btnDayReport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDayReport.Name = "btnDayReport";
            this.btnDayReport.SubItemsExpandWidth = 14;
            this.btnDayReport.Text = "日报表统计";
            this.btnDayReport.Click += new System.EventHandler(this.btnDayReport_Click);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.Class = "";
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDetial,
            this.btnShop,
            this.btnDayRatio});
            this.ribbonBar1.Location = new System.Drawing.Point(73, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(213, 53);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 3;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.Class = "";
            this.ribbonBar1.TitleVisible = false;
            // 
            // btnDetial
            // 
            this.btnDetial.Image = ((System.Drawing.Image)(resources.GetObject("btnDetial.Image")));
            this.btnDetial.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDetial.Name = "btnDetial";
            this.btnDetial.SubItemsExpandWidth = 14;
            this.btnDetial.Text = "明细维护";
            this.btnDetial.Click += new System.EventHandler(this.btnDetial_Click);
            // 
            // btnShop
            // 
            this.btnShop.Image = ((System.Drawing.Image)(resources.GetObject("btnShop.Image")));
            this.btnShop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnShop.Name = "btnShop";
            this.btnShop.SubItemsExpandWidth = 14;
            this.btnShop.Text = "店家维护";
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnDayRatio
            // 
            this.btnDayRatio.Image = ((System.Drawing.Image)(resources.GetObject("btnDayRatio.Image")));
            this.btnDayRatio.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDayRatio.Name = "btnDayRatio";
            this.btnDayRatio.SubItemsExpandWidth = 14;
            this.btnDayRatio.Text = "日比例设定";
            this.btnDayRatio.Click += new System.EventHandler(this.btnDayRatio_Click);
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.Class = "";
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnUserManager});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(70, 53);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 2;
            this.ribbonBar2.Text = "ribbonBar2";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.Class = "";
            this.ribbonBar2.TitleVisible = false;
            // 
            // btnUserManager
            // 
            this.btnUserManager.Image = global::PiccStatistics.Properties.Resources.user_online_24px_1174119_easyicon_net;
            this.btnUserManager.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnUserManager.Name = "btnUserManager";
            this.btnUserManager.SubItemsExpandWidth = 14;
            this.btnUserManager.Text = "用户管理";
            this.btnUserManager.Click += new System.EventHandler(this.btnUserManager_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "功能菜单";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.tslbUserid});
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(818, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(210, 17);
            this.toolStripStatusLabel1.Text = "技术支持：dongqiliang@gmail.com";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(481, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "    ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel3.Text = "当前用户：";
            // 
            // tslbUserid
            // 
            this.tslbUserid.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tslbUserid.Name = "tslbUserid";
            this.tslbUserid.Size = new System.Drawing.Size(44, 17);
            this.tslbUserid.Text = "董启亮";
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabMain.CanReorderTabs = true;
            this.tabMain.CloseButtonOnTabsVisible = true;
            this.tabMain.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabMain.Controls.Add(this.pictureBox1);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 86);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabMain.SelectedTabIndex = -1;
            this.tabMain.Size = new System.Drawing.Size(818, 345);
            this.tabMain.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock;
            this.tabMain.TabIndex = 4;
            this.tabMain.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabMain.Text = "tabControl1";
            this.tabMain.TabItemClose += new DevComponents.DotNetBar.TabStrip.UserActionEventHandler(this.tabMain_TabItemClose);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(818, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 453);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "人保保单统计 v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevComponents.DotNetBar.TabControl tabMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tslbUserid;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem btnUserManager;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btnDetial;
        private DevComponents.DotNetBar.ButtonItem btnShop;
        private DevComponents.DotNetBar.ButtonItem btnDayRatio;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem btnDayReport;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}