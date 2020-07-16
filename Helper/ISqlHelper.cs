using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BankDbHelper
{
    public interface ISqlHelper: IDisposable
    {
#if NS21
        /// <summary>
        /// 异步方法
        /// 测试数据库链接
        /// </summary>
        /// <returns></returns>
        Task<bool> TestConnectionAsync();

        /// <summary>
        ///  异步方法
        /// 获取dataset
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        Task<DataSet> GetDataSetAsync(string sql);

        /// <summary>
        ///  异步方法
        /// 获取datatable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        Task<DataTable> GetDataTableAsync(string sql);

        /// <summary>
        ///  异步方法
        /// 获取datatable通过参数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="lstPara"></param>
        /// <returns></returns>
        Task<DataTable> GetDataTableAsync(string sql, List<SqlHelperParameter> lstPara);

        /// <summary>
        ///  异步方法
        /// 获取值
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        Task<object> GetValueAsync(string sql);

        /// <summary>
        ///  异步方法
        /// 获取值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="lstPara"></param>
        /// <returns></returns>
        Task<object> GetValueAsync(string sql, List<SqlHelperParameter> lstPara);

        /// <summary>
        ///  异步方法
        /// 执行存储过程，除sqlite
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="lstPara"></param>
        /// <returns></returns>
        Task<Hashtable> ExecProcAsync(string procName, List<SqlHelperParameter> lstPara);

        /// <summary>
        ///  异步方法
        /// 执行sql by Arraylist
        /// </summary>
        /// <param name="sqlList">new 之后add</param>
        /// <returns>执行成功为空,有错误会返回错误信息</returns>
        Task<string> ExecSqlAsync(ArrayList sqlList);

        /// <summary>
        ///  异步方法
        /// 执行单个sql
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>执行成功为空,有错误会返回错误信息</returns>
        Task<string> ExecSqlAsync(string sql);

        /// <summary>
        ///  异步方法
        /// 执行sql by params
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="lstPara"></param>
        /// <returns>执行成功为空,有错误会返回错误信息</returns>
        Task<string> ExecSqlAsync(string sql, List<SqlHelperParameter> lstPara);

        /// <summary>
        ///  异步方法
        /// 执行带参数的语句list
        /// </summary>
        /// <param name="lst"></param>
        /// <returns>执行成功为空,有错误会返回错误信息</returns>
        Task<string> ExecSqlAsync(List<ParamSql> lst);

        /// <summary>
        ///  异步方法
        /// 释放链接
        /// </summary>
        /// <returns></returns>
        Task DisposeAsync();

#else
#endif
        /// <summary>
        /// 同步方法
        /// 测试数据库链接
        /// </summary>
        /// <returns></returns>
        bool TestConnection();

        /// <summary>
        /// 同步方法
        /// 获取dataset
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        DataSet GetDataSet(string sql);

        /// <summary>
        /// 同步方法
        /// 获取datatable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        DataTable GetDataTable(string sql);

        /// <summary>
        /// 同步方法
        /// 获取datatable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        DataTable GetDataTable(string sql, List<SqlHelperParameter> lstPara);

        /// <summary>
        /// 同步方法
        /// 获取objectvalue
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        object GetValue(string sql);

        /// <summary>
        /// 同步方法
        /// 获取objectvalue
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        object GetValue(string sql, List<SqlHelperParameter> lstPara);

        /// <summary>
        /// 同步方法
        /// 执行存储过程
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        Hashtable ExecProc(string procName, List<SqlHelperParameter> lstPara);

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sqlList"></param>
        /// <returns>执行成功为空,有错误会返回错误信息</returns>
        string ExecSql(ArrayList sqlList);

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>执行成功为空,有错误会返回错误信息</returns>
        string ExecSql(string sql);

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>执行成功为空,有错误会返回错误信息</returns>
        string ExecSql(string sql, List<SqlHelperParameter> lstPara);

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>执行成功为空,有错误会返回错误信息</returns>
        string ExecSql(List<ParamSql> lst);

    }
}