using BankDbHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SqlServer
            {
                //BankSqlHelper bankSqlHelper = new BankSqlHelper(new DbInfo
                //{
                //    ServerName = "localhost",
                //    DataBaseName = "test",
                //    DbType = DBTypeEnum.SqlServer,
                //    Password = "123456",
                //    UserName = "sa",
                //    Port = "1433"
                //});
                //if (bankSqlHelper.TestConnection())
                //{
                //    var result = bankSqlHelper.GetValue("select 1");
                //    Console.WriteLine(result);
                //}
            }
            #endregion

            #region Oracle
            BankSqlHelper bankSqlHelper = new BankSqlHelper(new DbInfo
            {
                ServerName = "192.168.106.71",
                DataBaseName = "fjzy",
                DbType = DBTypeEnum.Oracle,
                Password = "romens",
                UserName = "fjxyhdbo",
                Port = "1521"
            });
            //Console.WriteLine("??");
            string ysj = "adhkjafhajhfa";
            if (bankSqlHelper.TestConnection())
            {
                var result = bankSqlHelper.GetValue("select 5 from dual");
                //Console.WriteLine(result);
            }
            #endregion

            #region Mysql

                //BankSqlHelper bankSqlHelper = new BankSqlHelper(new DbInfo
                //{
                //    ServerName = "test",
                //    DbType = DBTypeEnum.MySql,
                //    Password = "123456",
                //    Port = "3306",
                //    UserName = "root"
                //});
                //if ( bankSqlHelper.TestConnection())
                //{
                //    var result =  bankSqlHelper.GetValue("select 1");
                //    Console.WriteLine(result);
                //}

            #endregion

            #region Sqlite
            
                //BankSqlHelper bankSqlHelper = new BankSqlHelper(new DbInfo
                //{
                //    ConnString = "Db/LogData.sqlite",
                //    DbType = DBTypeEnum.Sqlite
                //});
                //if ( bankSqlHelper.TestConnection())
                //{
                //    var result =  bankSqlHelper.GetValue("select 1");
                //    Console.WriteLine(result);
                //}
            
            #endregion
        }
    }
}
