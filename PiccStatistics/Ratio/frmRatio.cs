using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PiccStatistics.Ratio
{
    public partial class frmRatio : Office2007Form
    {
        #region ------初始变量------
        private Common.frmProcessProgress notifyForm;
        private string strSql = "";
        private int intPage = 1;
        private int intPageSize = 20;
        private int pageCounts = 0;
        private string tName = "bili";
        private bool flag = false;
        #endregion

        public frmRatio()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dpt.Value.ToShortDateString().Trim() != "")
            {
                strSql = " riqi=#" + dpt.Value.ToShortDateString().Trim() + "#";
                intPage = 1;
                fillGVList(tName, strSql, intPageSize, 1);
            }
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

            ds.Tables[0].Columns["id"].ColumnName = "编号";
            ds.Tables[0].Columns["riqi"].ColumnName = "日期";
            ds.Tables[0].Columns["jiaoqiangbili"].ColumnName = "交强比例";
            ds.Tables[0].Columns["xincheshangyebili"].ColumnName = "新车商业比例";
            ds.Tables[0].Columns["xubaoshangyebili"].ColumnName = "续保商业比例";
            ds.Tables[0].Columns["zhanbaoshangyebili"].ColumnName = "转保商业比例";
            ds.Tables[0].Columns["shopcode"].ColumnName = "推荐送修码";
            ds.Tables[0].Columns["shopname"].ColumnName = "店名";

            gvList.DataSource = ds.Tables[0];

  
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

        #region ------显示所有数据------
        private void btnAll_Click(object sender, EventArgs e)
        {

            fillGVList(tName, "", intPageSize, intPage);
            intPage = 1;


        }
        #endregion

        private void frmRatio_Load(object sender, EventArgs e)
        {
            fillGVList(tName, "", intPageSize, 1);         //填充数据

            //分页
            //初始页面显示条数选择框
            for (int i = 1; i < 6; i++)
            {
                int j = i * 10;
                cbPageSize.Items.Add(j.ToString());
            }
            cbPageSize.Text = "50";
            flag = true;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            Ratio.frrmAddRatio frm = new frrmAddRatio();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnDellAll_Click(object sender, EventArgs e)
        {
            Maticsoft.DBUtility.DbHelperOleDb.ExecuteSql("delete * from bili");
            fillGVList(tName, "", intPageSize, 1);         //填充数据
        }
    }
}
