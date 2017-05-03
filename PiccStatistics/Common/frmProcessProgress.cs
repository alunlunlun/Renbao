using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PiccStatistics.Common
{
    public partial class frmProcessProgress : Office2007Form
    {
        public frmProcessProgress()
        {
            this.EnableGlass = false;
            InitializeComponent();
        }

        public void SetNotifyInfo(int percent, string message)
        {
            this.lblInfo.Text = message;
            this.PB.Value = percent;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Detail.frmDetail frm = (Detail.frmDetail)this.Owner;
            frm.CancelWork();
            this.Close();
        }
    }
}
