using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    /// <summary>
    /// 公共Service接口端 封装公共的方法 泛型方法
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseService<T> where T : new()
    {
        /// <summary>
        /// 公共创建方法接口
        /// </summary>
        void Create();
        /// <summary>
        /// 公共获取方法接口
        /// </summary>
        void Get();
        /// <summary>
        /// 公共删除方法
        /// </summary>
        void Delete();
    }
}
