using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    /// <summary>
    /// Manager层才是真正操作数据库的层次  要独立出来
    /// </summary>
    public class ManagerBase<T> where T : new()
    {
        /// <summary>
        /// 创建操作
        /// </summary>
        /// <param name="t"></param>
        public  void Create(T t)
        {
           //数据操作
        }


        /// <summary>
        /// 更新操作
        /// </summary>
        /// <param name="t"></param>
        public  void Update(T t)
        {
           //数据操作
        }
    }
}
