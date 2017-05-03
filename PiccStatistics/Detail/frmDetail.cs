using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PiccStatistics.Detail
{
    public partial class frmDetail : Office2007Form
    {
        private BackgroundWorker bkWorker = new BackgroundWorker();
        private Common.frmProcessProgress notifyForm;
        private int PBcount = 0;
        string MySql = "";
        string filePath = "";
        bool flag = false;

        #region ------初始变量------
        private string strSql = "";
        private int intPage = 1;
        private int intPageSize = 20;
        private int pageCounts = 0;
        private string tName = "Detail";
        #endregion

        public frmDetail()
        {
            this.EnableGlass = false;
            InitializeComponent();

            bkWorker.WorkerReportsProgress = true;
            bkWorker.WorkerSupportsCancellation = true;
            bkWorker.DoWork += new DoWorkEventHandler(DoWork);
            bkWorker.ProgressChanged += new ProgressChangedEventHandler(ProgessChanged);
            bkWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CompleteWork);
            
        }

        public void CancelWork()
        {
            bkWorker.CancelAsync();
        }

        public void DoWork(object sender, DoWorkEventArgs e)
        {
            
            // 事件处理，指定处理函数  
            e.Result = ProcessProgress(bkWorker, e);
        }
        public void CompleteWork(object sender, RunWorkerCompletedEventArgs e)
        {
            notifyForm.Close();
            fillGVList(tName, "", intPageSize, intPage);
            intPage = 1;

        }
        public void ProgessChanged(object sender, ProgressChangedEventArgs e)
        {
            notifyForm.SetNotifyInfo(e.ProgressPercentage, "导入进度:" + Convert.ToString(e.ProgressPercentage) + "%");
        }
        private int ProcessProgress(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(filePath);
            try
            {
                Maticsoft.DBUtility.DbHelperOleDb.ExecuteSql("delete * from Detail");

                OleDbConnectionStringBuilder connectStringBuilder = new OleDbConnectionStringBuilder();
                connectStringBuilder.DataSource = filePath.Trim();
                connectStringBuilder.Provider = "Microsoft.Jet.OLEDB.4.0";
                connectStringBuilder.Add("Extended Properties", "Excel 8.0");
                using (OleDbConnection cn = new OleDbConnection(connectStringBuilder.ConnectionString))
                {
                    DataSet ds = new DataSet();
                    string sql = "Select * from [明细$]";
                    OleDbCommand cmdLiming = new OleDbCommand(sql, cn);
                    cn.Open();
                    using (OleDbDataReader drLiming = cmdLiming.ExecuteReader())
                    {
                        ds.Load(drLiming, LoadOption.OverwriteChanges, new string[] { "Sheet1" });
                        DataTable dt = ds.Tables["Sheet1"];
                        if (dt.Rows.Count > 0)
                        {
                            PBcount = dt.Rows.Count;
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                
                                string bxdqr = "1900-1-1";
                                if (dt.Rows[i]["保险到期日"].ToString().Length > 18)
                                {
                                    bxdqr = dt.Rows[i]["保险到期日"].ToString();
                                }

                                string code = "3700000000000";
                                if (dt.Rows[i]["推荐送修码"].ToString().Length > 6)
                                {
                                    code = dt.Rows[i]["推荐送修码"].ToString();
                                }
                                //写入数据库数据
                                MySql = "insert into Detail(baodanhao,beibaoxianren,chepaihao,chejiahao,qiandanriqi,qibaoriqi,baoxiandaoqiri,chudengriqi,pingpaixinghao,xinchegouzhijia,xinxuchuan,chuxianceshu,tuijiansongxiuma,tuijiansongxiumingcheng,baofei,gendanbili,gengdanshouxufei) values('"
                                   + dt.Rows[i]["保单号"].ToString() + "','"
                                   + dt.Rows[i]["被保险人"].ToString() + "','"
                                   + dt.Rows[i]["车牌号"].ToString() + "','"
                                   + dt.Rows[i]["车架号"].ToString() + "','"
                                   + dt.Rows[i]["签单日期"].ToString() + "','"
                                   + dt.Rows[i]["起保日期"].ToString() + "','"
                                   + bxdqr + "','"
                                   + dt.Rows[i]["初登日期"].ToString() + "','"
                                   + dt.Rows[i]["品牌型号"].ToString() + "','"
                                   + dt.Rows[i]["新车购置价"].ToString() + "','"
                                   + dt.Rows[i]["新续转"].ToString() + "','"
                                   + dt.Rows[i]["出险次数"].ToString() + "','"
                                   + code + "','"
                                   + dt.Rows[i]["推荐送修名称"].ToString() + "','"
                                   + dt.Rows[i]["保费"].ToString() + "','"
                                   + dt.Rows[i]["跟单比例"].ToString() + "','"
                                   + dt.Rows[i]["跟单手续费"].ToString() + "')";
                                Maticsoft.DBUtility.DbHelperOleDb.ExecuteSql(MySql);
                                if (bkWorker.CancellationPending)
                                {
                                    e.Cancel = true;
                                    return -1;
                                }
                                else
                                {


                                    // 状态报告  
                                    bkWorker.ReportProgress(i*100 / PBcount);

                                    // 等待，用于UI刷新界面，很重要  
                                    System.Threading.Thread.Sleep(1);
                                }

                            }

                        }
                        else
                        {

                            MsgBox.Show("请检查你的Excel中是否存在数据", "提示");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MsgBox.Show(ex.ToString(), "提示");
               
            }



           

            return -1;
        }
        private void btnInput_Click(object sender, EventArgs e)
        {
            openfd.Filter = "Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                filePath = openfd.FileName;

            }
            else
            {
                filePath = "";
            }
            if (filePath != "")
            {
                bkWorker.RunWorkerAsync();

                notifyForm = new Common.frmProcessProgress();
                notifyForm.Owner = this;
                notifyForm.ShowDialog();
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


            ds.Tables[0].Columns["baodanhao"].ColumnName = "保单号";
            ds.Tables[0].Columns["beibaoxianren"].ColumnName = "被保险人";
            ds.Tables[0].Columns["chepaihao"].ColumnName = "车牌号";
            ds.Tables[0].Columns["chejiahao"].ColumnName = "车架号";
            ds.Tables[0].Columns["qiandanriqi"].ColumnName = "签单日期";
            ds.Tables[0].Columns["qibaoriqi"].ColumnName = "起保日期";
            ds.Tables[0].Columns["baoxiandaoqiri"].ColumnName = "保险到期日";
            ds.Tables[0].Columns["chudengriqi"].ColumnName = "初登日期";
            ds.Tables[0].Columns["pingpaixinghao"].ColumnName = "品牌型号";
            ds.Tables[0].Columns["xinchegouzhijia"].ColumnName = "新车购置价";
            ds.Tables[0].Columns["xinxuchuan"].ColumnName = "新续转";
            ds.Tables[0].Columns["chuxianceshu"].ColumnName = "出险次数";
            ds.Tables[0].Columns["tuijiansongxiuma"].ColumnName = "推荐送修码";
            ds.Tables[0].Columns["tuijiansongxiumingcheng"].ColumnName = "推荐送修名称";
            ds.Tables[0].Columns["baofei"].ColumnName = "保费";
            ds.Tables[0].Columns["gendanbili"].ColumnName = "跟单比例";
            ds.Tables[0].Columns["gengdanshouxufei"].ColumnName = "跟单手续费";



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

        private void frmDetail_Load(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbKey.Text != "")
            {
                fillGVList(tName, "baodanhao='" + tbKey.Text + "'", intPageSize, 1);
            }
            else
            {
                fillGVList(tName, "", intPageSize, 1);         //填充数据
            }
        }
    }
}
