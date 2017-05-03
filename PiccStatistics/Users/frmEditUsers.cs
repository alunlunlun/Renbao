using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PiccStatistics.Users
{
    public partial class frmEditUsers : DevComponents.DotNetBar.Office2007Form
    {
        string tName = "OperInfo";
        public frmEditUsers()
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



            Classes.OperInfo.Update(tbCode.Text, tbPwd.Text, tbName.Text);
            MsgBox.Show("修改成功", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
            frmUsers fUser = (frmUsers)this.Owner;
            fUser.refreshData();
            this.Close();
        }

        private void frmEditUsers_Load(object sender, EventArgs e)
        {
            DataSet ds = Maticsoft.DBUtility.DbHelperOleDb.Query("select * from " + tName + " where id=" + this.Tag);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                tbCode.Text = dt.Rows[0]["userid"].ToString();
                tbName.Text = dt.Rows[0]["name"].ToString();
                tbPwd.Text = dt.Rows[0]["pwd"].ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
