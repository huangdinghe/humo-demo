using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// 公共实体
    /// </summary>
    public class EntityBase
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 是否展示 用于实现逻辑删除操作
        /// </summary>
        public bool IsShow { get; set; }
    }
}
