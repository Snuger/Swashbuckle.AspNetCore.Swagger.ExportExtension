using System;
using System.Collections.Generic;
using System.Text;

namespace Swashbuckle.AspNetCore.Swagger.ExportExtension.Models
{
    /// <summary>
    /// RequestModelInfo
    /// </summary>
    public class RequestModelInfo : BaseModelInfo
    {
        /// <summary>
        /// 是否必传
        /// </summary>
        public bool Required { get; set; }
    }
}
