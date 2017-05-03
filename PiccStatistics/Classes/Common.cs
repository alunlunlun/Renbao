using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PiccStatistics.Classes
{
    public static class Common
    {
        public static DataSet GetListByPage(string tableName, string strWhere, int pageSize, int page)
        {
            DataSet ds = new DataSet();
            string strSql = "";
            if (strWhere != "")
            {
                strSql = "select top " + pageSize + " * from " + tableName + " where id >=(select top 1 max(id) from (select top " + (((page - 1) * pageSize) + 1).ToString() + " * from " + tableName + " where " + strWhere + " order by id)) and " + strWhere;
            }
            else
            {
                strSql = "select top " + pageSize + " * from " + tableName + " where id >=(select top 1 max(id) from (select top " + (((page - 1) * pageSize) + 1).ToString() + " * from " + tableName + " order by id)) order by id";

            }
            ds = Maticsoft.DBUtility.DbHelperOleDb.Query(strSql);
            return ds;
        }

        public static int GetRecordCount(string tableName, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM " + tableName);
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperOleDb.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        public static void WriteLog(string sMsg)
        {
            if (sMsg != "")
            {
                Random randObj = new Random(DateTime.Now.Millisecond);
                int file = randObj.Next() + 1;
                string filename = DateTime.Now.ToString("yyyyMMdd") + ".txt";
                try
                {
                    if (Directory.Exists(Application.StartupPath + "\\Logs") == false)//如果不存在就创建file文件夹
                    {
                        Directory.CreateDirectory(Application.StartupPath + "\\Logs");
                    }

                    FileInfo fi = new FileInfo("Logs\\" + filename);
                    if (!fi.Exists)
                    {
                        using (StreamWriter sw = fi.CreateText())
                        {
                            sw.WriteLine(DateTime.Now + "  " + sMsg + "");
                            sw.Close();
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = fi.AppendText())
                        {
                            sw.WriteLine(DateTime.Now + "  " + sMsg + "");
                            sw.Close();
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;

                }
            }
        }
    }
}
