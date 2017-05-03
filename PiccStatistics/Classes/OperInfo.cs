using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;

namespace PiccStatistics.Classes
{
    public static class OperInfo
    {
        public static bool Exists(string userid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from OperInfo");
            strSql.Append(" where userid=@userid ");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@userid", OleDbType.VarChar,50)         };
            parameters[0].Value = userid;
            DataSet ds = new DataSet();
            ds = DbHelperOleDb.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows[0][0].ToString() == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        /// <summary>
		/// 增加一条数据
		/// </summary>
		public static void Add(string userid,string pwd,string name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [OperInfo] (");
            strSql.Append("userid,pwd,name)");
            strSql.Append(" values (");
            strSql.Append("@userid,@pwd,@name)");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@userid", OleDbType.VarChar,50),
                    new OleDbParameter("@pwd", OleDbType.VarChar,50),
                    new OleDbParameter("@name", OleDbType.VarChar,50)};
            parameters[0].Value = userid;
            parameters[1].Value = pwd;
            parameters[2].Value = name;

            DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool Update(string userid, string pwd, string name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [OperInfo] set ");
            strSql.Append("userid=@userid,");
            strSql.Append("pwd=@pwd,");
            strSql.Append("name=@name");
            strSql.Append(" where userid=@userid ");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@userid", OleDbType.VarChar,50),
                    new OleDbParameter("@pwd", OleDbType.VarChar,50),
                    new OleDbParameter("@name", OleDbType.VarChar,50)};
            parameters[0].Value = userid;
            parameters[1].Value = pwd;
            parameters[2].Value = name;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
		/// 删除一条数据
		/// </summary>
		public static bool Delete(string userid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [OperInfo] ");
            strSql.Append(" where userid=@userid ");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@userid", OleDbType.VarChar,50)};
            parameters[0].Value = userid;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckUser(string Userid, string Pwd)
        {
            DataSet ds = new DataSet();
            ds = DbHelperOleDb.Query("select * from OperInfo where userid='" + Userid + "'");
            if (ds == null)
            {
                return false;
            }
            if (ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            if (ds.Tables[0].Rows[0]["Pwd"].ToString() != Pwd)
            {
                return false;
            }
            return true;
        }

        /// <summary>
		/// 获得数据列表
		/// </summary>
		public static DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [OperInfo] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOleDb.Query(strSql.ToString());
        }

    }

    

}
