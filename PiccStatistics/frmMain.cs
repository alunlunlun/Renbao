using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PiccStatistics
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007Form
    {
        public frmMain()
        {
            this.EnableGlass = false;
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tslbUserid.Text = this.Tag.ToString();
        }

        private void btnUserManager_Click(object sender, EventArgs e)
        {
            Users.frmUsers frm = new Users.frmUsers();
            openWindow(frm);
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MsgBox.Show("确认退出", "提示", MsgBox.MyButtons.YesNo, MsgBox.MyIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
            
        }
#region ------ 窗体操作 ------
        private bool IsOpenTab(string tabName)
        {
            bool isOpened = false;

            foreach (TabItem tab in tabMain.Tabs)
            {
                if (tab.Name == tabName.Trim())
                {
                    isOpened = true;
                    tabMain.SelectedTab = tab;
                    break;
                }
            }
            return isOpened;
        }
        public void openWindow(Form frm)
        {
            DevComponents.DotNetBar.TabItem tp = new DevComponents.DotNetBar.TabItem();
            DevComponents.DotNetBar.TabControlPanel tcp = new DevComponents.DotNetBar.TabControlPanel();
            tp.MouseDown += new MouseEventHandler(tp_MouseDown);
            tcp.Dock = System.Windows.Forms.DockStyle.Fill;
            tcp.Location = new System.Drawing.Point(0, 0);

            frm.TopLevel = false;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tcp.Controls.Add(frm);
            tp.Text = frm.Text;
            tp.Name = frm.Name;

            if (!IsOpenTab(frm.Name))
            {
                tcp.TabItem = tp;
                tp.AttachedControl = tcp;
                tabMain.Controls.Add(tcp);
                tabMain.Tabs.Add(tp);
                tabMain.SelectedTab = tp;
            }
            tabMain.Refresh();
        }
        private void tp_MouseDown(object sender, MouseEventArgs e)
        {
            tabMain.SelectedTab = (TabItem)sender;
            if (e.Button == MouseButtons.Right && tabMain.SelectedTab != null)
            {
                this.tabMain.Select();
                //cms.Show(this.tabMain, e.X, e.Y);
            }
        }

        private void tabMain_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            TabItem tb = tabMain.SelectedTab;
            tabMain.Tabs.Remove(tb);
        }

        #endregion

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 明细按钮
  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetial_Click(object sender, EventArgs e)
        {
            Detail.frmDetail frm = new Detail.frmDetail();
            openWindow(frm);
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            Shop.frmShop frm = new Shop.frmShop();
            openWindow(frm);
        }

        private void btnDayRatio_Click(object sender, EventArgs e)
        {
            Ratio.frmRatio frm = new Ratio.frmRatio();
            openWindow(frm);
        }

        private void btnDayReport_Click(object sender, EventArgs e)
        {
            Statistics.frmStatistics frm = new Statistics.frmStatistics();
            openWindow(frm);
        }
    }
}
