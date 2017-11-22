using Domain;
using Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 业务逻辑的实现层
/// </summary>
namespace Component
{
    public class BaseComponent<T, M> where T : EntityBase, new() where M : ManagerBase<T>, new()
    {
        /// <summary>
        /// 在此处实例化Manager层的对象  供继承自身和子类使用
        /// </summary>
        protected M manager = (M)typeof(M).GetConstructor(Type.EmptyTypes).Invoke(null);

        public virtual void Create(T entity)
        {
            manager.Create(entity);
        }

        public virtual void Update(T entity)
        {
            manager.Update(entity);
        }
    }
}
