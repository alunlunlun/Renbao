using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PiccStatistics.Users
{
    public partial class frmUsers : DevComponents.DotNetBar.Office2007Form
    {

        #region ------初始变量------
        private string strSql = "";
        private int intPage = 1;
        private int intPageSize = 20;
        private int pageCounts = 0;
        private string tName = "OperInfo";
        private bool flag = false;
        #endregion
        public frmUsers()
        {
            this.EnableGlass = false;
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            gvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //gvList.Rows[0].Height = 30;
            fillGVList(tName, "", intPageSize, 1);         //填充数据

            //分页
            //初始页面显示条数选择框
            for (int i = 1; i < 6; i++)
            {
                int j = i * 10;
                cbPageSize.Items.Add(j.ToString());
            }
            cbPageSize.Text = "20";
            flag = true;
        }


        #region ------共用刷新方法------
        public void refreshData()
        {
            fillGVList(tName, strSql, intPageSize, intPage);
        }
        #endregion

        #region ------填出datagridview------
        private void fillGVList(string tableName, string key, int pageSize, int page)
        {
            strSql = key;
            intPage = page;

            DataSet ds = new DataSet();
            ds = Classes.Common.GetListByPage(tableName, key, pageSize, page);

           
            ds.Tables[0].Columns["userid"].ColumnName = "用户名";
            ds.Tables[0].Columns["pwd"].ColumnName = "密码";
            ds.Tables[0].Columns["name"].ColumnName = "姓名";



            gvList.DataSource = ds.Tables[0];
            gvList.Columns[0].Visible = false;
            if (ds.Tables[0].Rows.Count > 0)
            {
                intPages();
            }
            else
            {
                MsgBox.Show("对不起，没有您搜索的记录!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);

            }

        }
        #endregion

        #region ------分页代码------
        private void intPages()
        {

            int counts = Classes.Common.GetRecordCount(tName, strSql);
            lblCounts.Text = counts.ToString();
            if (counts % intPageSize == 0)
            {
                pageCounts = counts / intPageSize;

            }
            else
            {
                pageCounts = (counts / intPageSize) + 1;

            }

            cbPage.Items.Clear();
            for (int i = 1; i <= pageCounts; i++)
            {
                cbPage.Items.Add(i.ToString());
            }
            cbPage.SelectedIndex = intPage - 1;
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            //转移到第一页
            fillGVList(tName, strSql, intPageSize, 1);

        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            intPage--;
            if (intPage >= 1)
            {
                fillGVList(tName, strSql, intPageSize, intPage);
            }
            else
            {
                intPage++;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            intPage++;
            if (intPage <= pageCounts)
            {
                fillGVList(tName, strSql, intPageSize, intPage);
            }
            else
            {
                intPage--;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            fillGVList(tName, strSql, intPageSize, pageCounts);
        }

        private void btnGoto_Click(object sender, EventArgs e)
        {
            int cPage = int.Parse(cbPage.Text);
            fillGVList(tName, strSql, intPageSize, cPage);
        }

        private void cbPageSize_TextChanged(object sender, EventArgs e)
        {
            if (cbPageSize.Text != "" && flag==true)
            {
                int cPageSize = int.Parse(cbPageSize.Text);
                intPageSize = cPageSize;
                fillGVList(tName, strSql, cPageSize, 1);
            }
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUsers frm = new frmAddUsers();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (gvList.Rows.Count < 1)
            {
                MsgBox.Show("对不起，没有数据!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                return;
            }
            string id = gvList.SelectedRows[0].Cells[1].Value.ToString();
            if (id != "")
            {
                MessageBoxEx.EnableGlass = false;
                if (MsgBox.Show("确定删除该用户？", "提示", MsgBox.MyButtons.YesNo, MsgBox.MyIcon.Question) == DialogResult.Yes)
                {
                    Classes.OperInfo.Delete(id);
                    this.gvList.Rows[0].Selected = true;
                    fillGVList(tName, strSql, intPageSize, intPage);
                }
            }
            else
            {
                MsgBox.Show("请选择要删除的用户!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbKey.Text.Trim() != "")
            {
                strSql = "name like '%" + tbKey.Text.Trim() + "%'";
                intPage = 1;
                fillGVList(tName, strSql, intPageSize, 1);
            }
            else
            {
                frmUsers_Load(null, null);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvList.Rows.Count < 1)
            {
                MsgBox.Show("对不起，没有数据!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                return;
            }
            string userid = gvList.SelectedRows[0].Cells[0].Value.ToString();
            if (userid != "")
            {
                frmEditUsers frmEdit = new frmEditUsers();
                frmEdit.Owner = this;
                frmEdit.Tag = userid.ToString();
                frmEdit.ShowDialog();

            }
            else
            {
                MsgBox.Show("请选择要修改的行!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
            }
        }

        private void gvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(null, null);
        }
    }
}
