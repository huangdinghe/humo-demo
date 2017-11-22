using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 用户实体
/// </summary>
namespace Domain
{
    public class Users : EntityBase
    {
        /// <summary>
        /// 班级Id
        /// </summary>
        public int ClassesId { get; set; }

        /// <summary>
        /// 角色Id
        /// </summary>
        public int RolesId { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UsersName { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string TelePhone { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
    }
}
