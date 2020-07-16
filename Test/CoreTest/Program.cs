using BankDbHelper;
using System;
using System.Threading.Tasks;

namespace CoreTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            #region SqlServer
            {
                BankSqlHelper bankSqlHelper = new BankSqlHelper(new DbInfo
                {
                    ServerName = "localhost",
                    DataBaseName = "test",
                    DbType = DBTypeEnum.SqlServer,
                    Password = "123456",
                    UserName ="sa",
                    Port = "1433"
                 });
                if (await bankSqlHelper.TestConnectionAsync())
                {
                    var result =  await bankSqlHelper.GetValueAsync("select 1");
                    Console.WriteLine(result);
                }
            }
            #endregion

            #region Oracle
            {
                BankSqlHelper bankSqlHelper = new BankSqlHelper(new DbInfo
                {
                    ServerName = "localhost",
                    DataBaseName = "fjzy",
                    DbType = DBTypeEnum.Oracle,
                    Password = "0000",
                    UserName = "sysdba",
                    Port = "1521"
                });

                if (await bankSqlHelper.TestConnectionAsync())
                {
                    var result = await bankSqlHelper.GetValueAsync("select 1 from dual");
                    Console.WriteLine(result);
                }
            }
            #endregion

            #region Mysql
            {
                BankSqlHelper bankSqlHelper = new BankSqlHelper(new DbInfo
                {
                    ServerName ="test",
                    DbType = DBTypeEnum.MySql,
                    Password ="123456",
                    Port ="3306" ,
                    UserName ="root"
                });
                if (await bankSqlHelper.TestConnectionAsync())
                {
                    var result = await bankSqlHelper.GetValueAsync("select 1");
                    Console.WriteLine(result);
                }
            }
            #endregion

            #region Sqlite
            {
                BankSqlHelper bankSqlHelper = new BankSqlHelper(new DbInfo
                {
                    ConnString = "Db/LogData.sqlite",
                    DbType = DBTypeEnum.Sqlite
                 });
                if (await bankSqlHelper.TestConnectionAsync())
                {
                    var result = await bankSqlHelper.GetValueAsync("select 1");
                    Console.WriteLine(result);
                }
            }
            #endregion

            Console.WriteLine("Hello World!");
        }
    }
}
