using Aspose.Cells;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PiccStatistics.Statistics
{
    public partial class frmStatistics : Office2007Form
    {
        private BackgroundWorker bkWorker = new BackgroundWorker();
        private Common.frmProcessProgress notifyForm;
        private int PBcount = 0;

        #region ------初始变量------
        private string strSql = "";
        private int intPage = 1;
        private int intPageSize = 20;
        private int pageCounts = 0;
        private string tName = "detail";
        #endregion

        DataSet ds_report = new DataSet();
        public frmStatistics()
        {
            InitializeComponent();
            bkWorker.WorkerReportsProgress = true;
            bkWorker.WorkerSupportsCancellation = true;
            bkWorker.DoWork += new DoWorkEventHandler(DoWork);
            bkWorker.ProgressChanged += new ProgressChangedEventHandler(ProgessChanged);
            bkWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CompleteWork);

        }


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

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            fillGVList(tName, strSql, intPageSize, pageCounts);
        }

        private void btnGoto_Click(object sender, EventArgs e)
        {

        }

        private void cbPageSize_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        public void CancelWork()
        {
            bkWorker.CancelAsync();
        }
        public void DoWork(object sender, DoWorkEventArgs e)
        {
            // 事件处理，指定处理函数  
            //e.Result = ProcessProgress(bkWorker, e);
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


       

        private void btnReportView_Click(object sender, EventArgs e)
        {
            ds_report = Maticsoft.DBUtility.DbHelperOleDb.Query("SELECT '" + dtp.Value.ToShortDateString() + "~" + dtpEnd.Value.ToShortDateString() + "' as riqi,team,shopname,tuijiansongxiuma,(jiaoqiang0+xinshangye0+xubaoshangye0+zhuanbaoshangye0) as baofei0,(jiaoqiang+xinshangye+xubaoshangye+zhuanbaoshangye) as baofei,(jiaoqiangbili*jiaoqiang) as jiaoqiang0,(xubaobili*xinshangye) as xinshangye0,(zhuanbaobili*xubaoshangye) as xubaoshangye0,(jiaoqiangbili*zhuanbaoshangye) as zhuanbaoshangye0,sum(jiaoqiang1) as jiaoqiang,sum(xincheshangye1) as xinshangye,sum(xubaoshangye1) as xubaoshangye,sum(zhuanbaoshangye1) as zhuanbaoshangye FROM v_dantongji where riqi >=#" + dtp.Value.ToShortDateString() + "# and riqi <=#" + dtpEnd.Value.ToShortDateString() + "# group by team,shopname,xinshangbili,xubaobili,zhuanbaobili,jiaoqiangbili,tuijiansongxiuma");
            if (ds_report.Tables[0].Rows.Count > 0)
            {

                ds_report.Tables[0].Columns["riqi"].ColumnName = "日期";
                ds_report.Tables[0].Columns["team"].ColumnName = "团队";
                ds_report.Tables[0].Columns["shopname"].ColumnName = "店名";
                ds_report.Tables[0].Columns["tuijiansongxiuma"].ColumnName = "推荐送修码";
                ds_report.Tables[0].Columns["baofei0"].ColumnName = "手续费";
                ds_report.Tables[0].Columns["baofei"].ColumnName = "总保费";
                ds_report.Tables[0].Columns["jiaoqiang0"].ColumnName = "交强险签单保费提成";
                ds_report.Tables[0].Columns["xinshangye0"].ColumnName = "新车商业险签单保费提成";
                ds_report.Tables[0].Columns["xubaoshangye0"].ColumnName = "续保商业险签单保费提成";
                ds_report.Tables[0].Columns["zhuanbaoshangye0"].ColumnName = "转保商业险签单保费提成";
                ds_report.Tables[0].Columns["jiaoqiang"].ColumnName = "交强险签单保费总额";
                ds_report.Tables[0].Columns["xinshangye"].ColumnName = "新车商业险签单保费总额";
                ds_report.Tables[0].Columns["xubaoshangye"].ColumnName = "续保商业险签单保费总额";
                ds_report.Tables[0].Columns["zhuanbaoshangye"].ColumnName = "转保商业险签单保费总额";
            }
            gvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gvList.DataSource = ds_report.Tables[0];
        }

        private void btnExportDay_Click(object sender, EventArgs e)
        {
            if (ds_report.Tables.Count < 1)
            {
                MsgBox.Show("请先开始统计!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                return;
            }
            if (ds_report == null)
            {
                MsgBox.Show("请先开始统计!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                return;
            }

            if (ds_report.Tables[0].Rows.Count > 0)
            {
                string filePath = "";
                savefd.Filter = "Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx";
                if (savefd.ShowDialog() == DialogResult.OK)
                {
                    filePath = savefd.FileName;

                }
                if (filePath != "")
                {
                    OutFileToDisk(ds_report.Tables[0], "日报表统计", @filePath);
                    MsgBox.Show("生成成功!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                }
                
            }

        }

        /// <summary>
        /// 导出数据到本地
        /// </summary>
        /// <param name="dt">要导出的数据</param>
        /// <param name="tableName">表格标题</param>
        /// <param name="path">保存路径</param>
        public static void OutFileToDisk(DataTable dt, string tableName, string path)
        {


            Workbook workbook = new Workbook(); //工作簿
            Worksheet sheet = workbook.Worksheets[0]; //工作表
            Cells cells = sheet.Cells;//单元格

            //为标题设置样式    
            Style styleTitle = workbook.Styles[workbook.Styles.Add()];//新增样式
            styleTitle.HorizontalAlignment = TextAlignmentType.Center;//文字居中
            styleTitle.Font.Name = "宋体";//文字字体
            styleTitle.Font.Size = 12;//文字大小
            styleTitle.Font.IsBold = true;//粗体

            //样式2
            Style style2 = workbook.Styles[workbook.Styles.Add()];//新增样式
            style2.HorizontalAlignment = TextAlignmentType.Left;//文字居中
            style2.Font.Name = "宋体";//文字字体
            style2.Font.Size = 12;//文字大小
            style2.Font.IsBold = true;//粗体
            style2.IsTextWrapped = true;//单元格内容自动换行

            style2.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

            //样式3
            Style style3 = workbook.Styles[workbook.Styles.Add()];//新增样式
            style3.HorizontalAlignment = TextAlignmentType.Center;//文字居中
            style3.Font.Name = "宋体";//文字字体
            style3.Font.Size = 12;//文字大小
            style3.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

            int Colnum = dt.Columns.Count;//表格列数
            int Rownum = dt.Rows.Count;//表格行数

            //生成行1 标题行   
            cells.Merge(0, 0, 1, Colnum);//合并单元格
            cells[0, 0].PutValue(tableName);//填写内容
            cells[0, 0].SetStyle(styleTitle);
            cells.SetRowHeight(0, 38);

            //生成行2 列名行
            for (int i = 0; i < Colnum; i++)
            {
                cells[1, i].PutValue(dt.Columns[i].ColumnName);
                cells[1, i].SetStyle(style2);
                cells.SetRowHeight(1, 25);
                cells.SetColumnWidth(Colnum, 25);
            }

            //生成数据行
            for (int i = 0; i < Rownum; i++)
            {
                for (int k = 0; k < Colnum; k++)
                {
                    cells[2 + i, k].PutValue(dt.Rows[i][k].ToString());
                    cells[2 + i, k].SetStyle(style3);
                }
                cells.SetRowHeight(2 + i, 24);
            }

            workbook.Save(path);
        }

        private void btnMX_Click(object sender, EventArgs e)
        {
            frmStatistics_Load(null, null);
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {
            DataSet ds_report = new DataSet();
            ds_report = Maticsoft.DBUtility.DbHelperOleDb.Query("select * from v_dantongji");
            ds_report.Tables[0].Columns["riqi"].ColumnName = "日期";
            ds_report.Tables[0].Columns["chejiahao"].ColumnName = "车架号";
            ds_report.Tables[0].Columns["jiaoqiang1"].ColumnName = "交强险签单保费";
            ds_report.Tables[0].Columns["xincheshangye1"].ColumnName = "新车商业险签单保费";
            ds_report.Tables[0].Columns["xubaoshangye1"].ColumnName = "续保商业险签单保费";
            ds_report.Tables[0].Columns["zhuanbaoshangye1"].ColumnName = "转保商业险签单保费";
            ds_report.Tables[0].Columns["team"].ColumnName = "团队";
            ds_report.Tables[0].Columns["shopname"].ColumnName = "店名";
            ds_report.Tables[0].Columns["tuijiansongxiuma"].ColumnName = "推荐送修码";
            ds_report.Tables[0].Columns["xinshangbili"].ColumnName = "新商比例";
            ds_report.Tables[0].Columns["xubaobili"].ColumnName = "续保比例";
            ds_report.Tables[0].Columns["zhuanbaobili"].ColumnName = "转保比例";
            ds_report.Tables[0].Columns["jiaoqiangbili"].ColumnName = "交强比例";
            gvList.DataSource = ds_report.Tables[0];

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            //生成报表测试

            //读取当日比例
            Maticsoft.DBUtility.DbHelperOleDb.ExecuteSql("delete * from dan_tongji");
            DataSet ds = new DataSet();


            ds = Maticsoft.DBUtility.DbHelperOleDb.Query("select * from v_detail");
            pb.Maximum = ds.Tables[0].Rows.Count;
            pb.Minimum = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //string riqi = ds.Tables[0].Rows[i]["qiandanriqi"].ToString().Substring(0, 10);
                string riqi = Convert.ToDateTime(ds.Tables[0].Rows[i]["qiandanriqi"]).ToString("yyyy-MM-dd");
                //MessageBox.Show(riqi);
                string chejiahao = ds.Tables[0].Rows[i][0].ToString();
                string tuijiansongxiuma = ds.Tables[0].Rows[i]["tuijiansongxiuma"].ToString();
                string shopname = ds.Tables[0].Rows[i]["shopname"].ToString();
                string jiaoqiang = "0";

                DataSet dsBili = new DataSet();
                dsBili = Maticsoft.DBUtility.DbHelperOleDb.Query("select top 1 * from bili where riqi=#" + riqi + "# and shopcode='" + tuijiansongxiuma + "'");
                // MessageBox.Show("select top 1 * from bili where riqi=#" + riqi + "# and shopcode='" + tuijiansongxiuma + "'");
                if (dsBili.Tables[0].Rows.Count > 0)
                {
                    // MessageBox.Show("ok"+"select top 1 * from bili where riqi=#" + riqi + "# and shopcode='" + tuijiansongxiuma + "'");
                    object k = Maticsoft.DBUtility.DbHelperOleDb.GetSingle("select baofei from detail where chejiahao='" + chejiahao + "' and baodanhao like 'PDZA%'");
                    if (k != null)
                    {
                        jiaoqiang = k.ToString();
                    }
                    string xinshangye = "0";
                    object o = Maticsoft.DBUtility.DbHelperOleDb.GetSingle("select baofei from detail where chejiahao='" + chejiahao + "' and xinxuchuan=6 and baodanhao like 'PDAA%'");
                    if (o != null)
                    {
                        //MessageBox.Show(o.ToString());
                        xinshangye = o.ToString();
                    }
                    string xubaoshangye = "0";
                    object b = Maticsoft.DBUtility.DbHelperOleDb.GetSingle("select baofei from detail where chejiahao='" + chejiahao + "' and (xinxuchuan<>1 and xinxuchuan<>6)  and baodanhao like 'PDAA%'");
                    if (b != null)
                    {
                        //MessageBox.Show(o.ToString());
                        xubaoshangye = b.ToString();
                    }
                    string zhuanbaoshangye = "0";
                    object j = Maticsoft.DBUtility.DbHelperOleDb.GetSingle("select baofei from detail where chejiahao='" + chejiahao + "' and xinxuchuan=1  and baodanhao like 'PDAA%'");
                    if (j != null)
                    {
                        //MessageBox.Show(o.ToString());
                        zhuanbaoshangye = j.ToString();
                    }



                    double jiaoqiang_bili = double.Parse(dsBili.Tables[0].Rows[0][2].ToString());
                    double xinshang_bili = double.Parse(dsBili.Tables[0].Rows[0][3].ToString());
                    double xubao_bili = double.Parse(dsBili.Tables[0].Rows[0][4].ToString());
                    double zhuanbao_bili = double.Parse(dsBili.Tables[0].Rows[0][5].ToString());
                    string MySql = "insert into dan_tongji(riqi,chejiahao,tuijiansongxiuma,jiaoqiang,xincheshangye,xubaoshangye,zhuangbaoshangye,jiaoqiangbili,xinshangbili,xubaobili,zhuanbaobili) values('"
                                            + riqi + "','"
                                            + chejiahao + "','"
                                            + tuijiansongxiuma + "','"
                                            + jiaoqiang + "','"
                                            + xinshangye + "','"
                                            + xubaoshangye + "','"
                                            + zhuanbaoshangye + "','"
                                            + jiaoqiang_bili + "','"
                                            + xinshang_bili + "','"
                                            + xubao_bili + "','"
                                            + zhuanbao_bili + "')";
                    //MessageBox.Show(MySql);
                    Maticsoft.DBUtility.DbHelperOleDb.ExecuteSql(MySql);



                }

                Application.DoEvents();
                lblCount.Text = i.ToString();
                pb.Value = i;
            }

            MessageBoxEx.EnableGlass = false;

            DataSet ds_report = new DataSet();
            ds_report = Maticsoft.DBUtility.DbHelperOleDb.Query("select * from v_dantongji");
            ds_report.Tables[0].Columns["riqi"].ColumnName = "日期";
            ds_report.Tables[0].Columns["chejiahao"].ColumnName = "车架号";
            ds_report.Tables[0].Columns["jiaoqiang1"].ColumnName = "交强险签单保费";
            ds_report.Tables[0].Columns["xincheshangye1"].ColumnName = "新车商业险签单保费";
            ds_report.Tables[0].Columns["xubaoshangye1"].ColumnName = "续保商业险签单保费";
            ds_report.Tables[0].Columns["zhuanbaoshangye1"].ColumnName = "转保商业险签单保费";
            ds_report.Tables[0].Columns["team"].ColumnName = "团队";
            ds_report.Tables[0].Columns["shopname"].ColumnName = "店名";
            ds_report.Tables[0].Columns["tuijiansongxiuma"].ColumnName = "推荐送修码";
            ds_report.Tables[0].Columns["xinshangbili"].ColumnName = "新商比例";
            ds_report.Tables[0].Columns["xubaobili"].ColumnName = "续保比例";
            ds_report.Tables[0].Columns["zhuanbaobili"].ColumnName = "转保比例";
            ds_report.Tables[0].Columns["jiaoqiangbili"].ColumnName = "交强比例";
            gvList.DataSource = ds_report.Tables[0];
            MsgBox.Show("生成成功!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);

        }

        private void gvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
