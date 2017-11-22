using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IUsersService : IBaseService<Users>
    {
        /// <summary>
        /// 登录 返回Users对象
        /// </summary>
        /// <param name="usersname"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Users Login(string usersname, string password);
    }
}
