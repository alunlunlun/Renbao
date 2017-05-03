using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace PiccStatistics.Users
{
    public partial class frmAddUsers : DevComponents.DotNetBar.Office2007Form
    {
        public frmAddUsers()
        {
            this.EnableGlass = false;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbCode.Text.Trim() == "")
            {
                MsgBox.Show("请输入员工工号", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                tbCode.Focus();
                return;
            }

            if (tbName.Text.Trim() == "")
            {
                MsgBox.Show("请输入员工姓名", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                tbName.Focus();
                return;
            }

            if (tbPwd.Text.Trim() == "")
            {
                MsgBox.Show("请输入登录密码", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                tbPwd.Focus();
                return;
            }

            if (Classes.OperInfo.Exists(tbCode.Text))
            {
                MsgBox.Show("人员工号已存在!请修改用户帐号!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                tbCode.Focus();
                return;
            }

            Classes.OperInfo.Add(tbCode.Text, tbName.Text, tbPwd.Text);
            MessageBoxEx.EnableGlass = false;
            MsgBox.Show("添加成功", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
            frmUsers fUser = (frmUsers)this.Owner;
            fUser.refreshData();
            this.Close();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
