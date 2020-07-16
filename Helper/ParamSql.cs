using System.Collections.Generic;

namespace BankDbHelper
{
    /// <summary>
    /// 带参数sql类
    /// 用于多条语句执行带参数时使用
    /// </summary>
    public class ParamSql
    {
        /// <summary>
        /// 执行的sql
        /// </summary>
        public string Sql { get; set; }

        /// <summary>
        /// 参数
        /// </summary>
        public List<SqlHelperParameter> Params { get; set; }

        
        public ParamSql()
        {
            this.Sql = string.Empty;
            this.Params = new List<SqlHelperParameter>();
        }

        public ParamSql(string sql, List<SqlHelperParameter> lst)
        {
            this.Sql = sql;
            this.Params = lst;
        }
    }
}