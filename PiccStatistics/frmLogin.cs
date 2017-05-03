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
    public partial class frmLogin : DevComponents.DotNetBar.Office2007Form
    {
        public frmLogin()
        {
            this.EnableGlass = false;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            if (tbPwd.Text == "" || cbUserid.Text == "")
            {
                MsgBox.Show("请输入登录口令", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                return;
            }
            if (Classes.OperInfo.CheckUser(cbUserid.Text, tbPwd.Text))
            {
                frmMain frm = new frmMain();
                frm.Tag = cbUserid.Text;
                frm.Show();
                this.Visible = false;
                Classes.Common.WriteLog("用户:"+cbUserid.Text+",登录成功!");
            }
            else
            {
                Classes.Common.WriteLog("登录失败！口令错误!");
                MsgBox.Show("您输入的口令不正确", "错误", MsgBox.MyButtons.OK, MsgBox.MyIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Application.Exit();
                    return true;
                case Keys.Enter:
                    btnLogin_Click(null, null);
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Classes.OperInfo.GetList("");
            cbUserid.ValueMember = "userid";
            cbUserid.DisplayMember = "userid";
            cbUserid.DataSource = ds.Tables[0];
        }
    }
}
