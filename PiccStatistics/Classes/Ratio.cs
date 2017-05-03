using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace PiccStatistics.Classes
{
    class Ratio
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static bool Add(string riqi, double jiaoqiangbili, double xincheshangyebili, double xubaoshangyebili, double xubaoshangyebili1, double xubaoshangyebili2, double xubaoshangyebili3, double xubaoshangyebili4, double xubaoshangyebili5, double zhuanbaoshangyebili, double zhuanbaoshangyebili1, double zhuanbaoshangyebili2, double zhuanbaoshangyebili3, double zhuanbaoshangyebili4, string shopcode, string shopname)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [Bili] (");
            strSql.Append("riqi,jiaoqiangbili,xincheshangyebili,xubaoshangyebili,xubaoshangyebili1,xubaoshangyebili2,xubaoshangyebili3,xubaoshangyebili4,xubaoshangyebili5,zhuanbaoshangyebili,zhuanbaoshangyebili1,zhuanbaoshangyebili2,zhuanbaoshangyebili3,zhuanbaoshangyebili4,shopcode,shopname)");
            strSql.Append(" values (");
            strSql.Append("@riqi,@jiaoqiangbili,@xincheshangyebili,@xubaoshangyebili,@xubaoshangyebili1,@xubaoshangyebili2,@xubaoshangyebili3,@xubaoshangyebili4,@xubaoshangyebili5,@zhuanbaoshangyebili,@zhuanbaoshangyebili1,@zhuanbaoshangyebili2,@zhuanbaoshangyebili3,@zhuanbaoshangyebili4,@shopcode,@shopname)");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@riqi", OleDbType.Date),
                    new OleDbParameter("@jiaoqiangbili", OleDbType.Double),
                    new OleDbParameter("@xincheshangyebili", OleDbType.Double),
                    new OleDbParameter("@xubaoshangyebili", OleDbType.Double),
                    new OleDbParameter("@xubaoshangyebili1", OleDbType.Double),
                    new OleDbParameter("@xubaoshangyebili2", OleDbType.Double),
                    new OleDbParameter("@xubaoshangyebili3", OleDbType.Double),
                    new OleDbParameter("@xubaoshangyebili4", OleDbType.Double),
                    new OleDbParameter("@xubaoshangyebili5", OleDbType.Double),
                    new OleDbParameter("@zhuanbaoshangyebili", OleDbType.Double),
                    new OleDbParameter("@zhuanbaoshangyebili1", OleDbType.Double),
                    new OleDbParameter("@zhuanbaoshangyebili2", OleDbType.Double),
                    new OleDbParameter("@zhuanbaoshangyebili3", OleDbType.Double),
                    new OleDbParameter("@zhuanbaoshangyebili4", OleDbType.Double),
                    new OleDbParameter("@shopcode", OleDbType.VarChar,50),
                    new OleDbParameter("@shopname", OleDbType.VarChar,50)};
            parameters[0].Value = riqi;
            parameters[1].Value = jiaoqiangbili;
            parameters[2].Value = xincheshangyebili;
            parameters[3].Value = xubaoshangyebili;
            parameters[4].Value = xubaoshangyebili1;
            parameters[5].Value = xubaoshangyebili2;
            parameters[6].Value = xubaoshangyebili3;
            parameters[7].Value = xubaoshangyebili4;
            parameters[8].Value = xubaoshangyebili5;
            parameters[9].Value = zhuanbaoshangyebili;
            parameters[10].Value = zhuanbaoshangyebili1;
            parameters[11].Value = zhuanbaoshangyebili2;
            parameters[12].Value = zhuanbaoshangyebili3;
            parameters[13].Value = zhuanbaoshangyebili4;
            parameters[14].Value = shopcode;
            parameters[15].Value = shopname;

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
    }
    
}
