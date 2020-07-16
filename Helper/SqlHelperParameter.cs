using System.Data;

namespace BankDbHelper
{
    /// <summary>
    /// sql参数类
    /// </summary>
    public class SqlHelperParameter
    {
        /// <summary>
        /// 参数名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 参数类型
        /// </summary>
        public ParamsType DataType { get; set; }

        /// <summary>
        /// 输入还是输出
        /// </summary>
        public ParameterDirection Direction { get; set; }

        /// <summary>
        /// 参数值
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// 参数大小
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dataType"></param>
        /// <param name="direction"></param>
        /// <param name="value"></param>
        /// <param name="size">默认500，根据自己需求来改变
        public SqlHelperParameter(string name, ParamsType dataType, ParameterDirection direction, object value, int size=500)
        {
            this.Name = name;
            this.DataType = dataType;
            this.Direction = direction;
            this.Value = value;
            this.Size = size;
        }
    }
}