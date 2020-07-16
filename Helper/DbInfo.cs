using System;
using System.Collections.Generic;
using System.Text;

namespace BankDbHelper
{
    /// <summary>
    /// 数据库信息通用类
    /// </summary>
    public class DbInfo
    {
        /// <summary>
        /// 数据库类型
        /// </summary>
        public DBTypeEnum DbType { get; set; }

        /// <summary>
        /// 数据库地址
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// 端口
        /// 默认端口可不填
        /// 比如mysql 3306,SQL server 1433,oracle 1521
        /// </summary>
        public string Port { get; set; }

        /// <summary>
        /// 登录名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        public string DataBaseName { get; set; }

        /// <summary>
        /// 数据库链接字符串，sqllite专用
        /// </summary>
        public string ConnString { get; set; }
    }
}
