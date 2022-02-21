using System;
using System.Collections.Generic;
using System.Text;

namespace Swashbuckle.AspNetCore.Swagger.ExportExtension.Models
{
    /// <summary>
    /// 枚举信息
    /// </summary>
    public class EnumInfo
    {
        /// <summary>
        /// 枚举类型
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 枚举值类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 枚举值
        /// </summary>
        public int[] Range { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
    }
}
