using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Menu:EntityBase
    {
        /// <summary>
        /// 菜单名
        /// </summary>
        public int MenuName { get; set; }

       /// <summary>
       /// 所在类
       /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// 控制器名
        /// </summary>
        public string ControllerName { get; set; }

        /// <summary>
        /// Action名
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// 父级菜单Id
        /// </summary>
        public int ParentId { get; set; }

    }
}
