using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BankDbHelper
{
    /// <summary>
    /// helper类入口
    /// </summary>
    public class BankSqlHelper
    {
        public bool IsDebug;
        private ISqlHelper helper;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="dbInfo"></param>
        public BankSqlHelper(DbInfo dbInfo)
        {

            string connString = string.Empty;
            string port = string.Empty;
            switch (dbInfo.DbType)
            {
                case DBTypeEnum.Oracle:
                    port = dbInfo.Port;
                    if (string.IsNullOrEmpty(port))
                    {
                        port = "1521";
                    }
                    connString = $"user id={dbInfo.UserName};password={dbInfo.Password}; data source=//{dbInfo.ServerName}:{port}/{dbInfo.DataBaseName};Pooling=true;Min Pool Size=1";
                    helper = new OracleSqlHelper(connString);
                    break;

                case DBTypeEnum.SqlServer:
                    port = dbInfo.Port;
                    if (string.IsNullOrEmpty(port))
                    {
                        port = "1433";
                    }

                    connString = $"Data Source={dbInfo.ServerName},{port};Initial Catalog={dbInfo.DataBaseName}; uid ={dbInfo.UserName}; pwd ={dbInfo.Password};Pooling=true;Min Pool Size=1";

                    this.helper = new SqlServerSqlHelper(connString);
                    break;

                case DBTypeEnum.Sqlite:
                    this.helper = new SqliteHelper(dbInfo.ConnString);
                    break;

                case DBTypeEnum.MySql:
                    port = dbInfo.Port;    
                    if (string.IsNullOrEmpty(port))
                    {
                        port = "3306";
                    }
                    connString = $"server={dbInfo.ServerName};port={port};database={dbInfo.DataBaseName};uid={dbInfo.UserName};pwd={dbInfo.Password};CharSet=utf8";

                    this.helper = new MySqlHelper(connString);
                    break;

                default:
                    break;
            }
        }

#if NS21
        /// <summary>
        /// 测试数据库链接
        /// </summary>
        /// <returns></returns>
        public async Task<bool> TestConnectionAsync()
        {
            return await this.helper.TestConnectionAsync();
        }

        /// <summary>
        /// 获取dataset
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public async Task<DataSet> GetDataSetAsync(string sql)
        {
            return await this.helper.GetDataSetAsync(sql);
        }

        /// <summary>
        /// 获取datatable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public async Task<DataTable> GetDataTableAsync(string sql)
        {
            return await this.helper.GetDataTableAsync(sql);
        }
        /// <summary>
        /// 获取datatable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public async Task<DataTable> GetDataTableAsync(string sql, List<SqlHelperParameter> lstPara)
        {
            return await this.helper.GetDataTableAsync(sql, lstPara);
        }

        /// <summary>
        /// 获取值
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public async Task<object> GetValueAsync(string sql)
        {
            return await this.helper.GetValueAsync(sql);
        }

        /// <summary>
        /// 获取值
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public async Task<object> GetValueAsync(string sql, List<SqlHelperParameter> lstPara)
        {
            return await this.helper.GetValueAsync(sql, lstPara);
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="lstPara"></param>
        /// <returns></returns>
        public async Task<Hashtable> ExecProcAsync(string procName, List<SqlHelperParameter> lstPara)
        {
            return await this.helper.ExecProcAsync(procName, lstPara);
        }

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="lst"></param>
        /// <returns>执行成功为空,有错误会返回错误信息</returns>
        public async Task<string> ExecSqlAsync(List<ParamSql> lst)
        {
            return await this.helper.ExecSqlAsync(lst);
        }

        /// <summary>
        /// 执行sq语句
        /// </summary>
        /// <param name="sqlList"></param>
        /// <returns>执行成功为空,有错误会返回错误信息</returns>
        public async Task<string> ExecSqlAsync(ArrayList sqlList)
        {
            return await this.helper.ExecSqlAsync(sqlList);
        }

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="lstPara"></param>
        /// <returns>执行成功为空,有错误会返回错误信息</returns>
        public async Task<string> ExecSqlAsync(string sql, List<SqlHelperParameter> lstPara)
        {
            return await this.helper.ExecSqlAsync(sql, lstPara);
        }

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>执行成功为空,有错误会返回错误信息</returns>
        public async Task<string> ExecSqlAsync(string sql)
        {
            return await this.helper.ExecSqlAsync(sql);
        }

        /// <summary>
        /// 释放数据库链接
        /// </summary>
        /// <returns></returns>
        public async Task DisposeAsync()
        {
            await this.helper.DisposeAsync();
        }

#else
#endif

        public bool TestConnection()
        {
            return this.helper.TestConnection();
        }

        public DataSet GetDataSet(string sql)
        {
            return this.helper.GetDataSet(sql);
        }

        public DataTable GetDataTable(string sql)
        {
            return this.helper.GetDataTable(sql);
        }

        public DataTable GetDataTable(string sql, List<SqlHelperParameter> lstPara)
        {
            return this.helper.GetDataTable(sql, lstPara);
        }

        public object GetValue(string sql)
        {
            return this.helper.GetValue(sql);
        }

        public object GetValue(string sql, List<SqlHelperParameter> lstPara)
        {
            return this.helper.GetValue(sql, lstPara);
        }

        public Hashtable ExecProc(string procName, List<SqlHelperParameter> lstPara)
        {
            return this.helper.ExecProc(procName, lstPara);
        }

        public string ExecSql(List<ParamSql> lst)
        {
            return this.helper.ExecSql(lst);
        }

        public string ExecSql(ArrayList sqlList)
        {
            return this.helper.ExecSql(sqlList);
        }

        public string ExecSql(string sql, List<SqlHelperParameter> lstPara)
        {
            return this.helper.ExecSql(sql, lstPara);
        }

        public string ExecSql(string sql)
        {
            return this.helper.ExecSql(sql);
        }

        public void Dispose()
        {
            this.helper.Dispose();
        }
    }
}