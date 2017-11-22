using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Helper
{
    public class AppHelper
    {
        #region MD5加密
        //使用MD5加密传入的字符
        public static string EncodeMd5(string str)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "md5");
        }

        #endregion

        #region 保存登录信息
        //保存登录用户的信息
        public static Users LoginedUser
        {
            get
            {
                //如果Session信息不为空
                if (HttpContext.Current.Session["LoginedUser"] != null)
                {
                    //将Session登录信息转换为Users并返回
                    return HttpContext.Current.Session["LoginedUser"] as Users;
                }
                return null;
            }
            set
            {
                //将传入的信息保存到Session中
                HttpContext.Current.Session["LoginedUser"] = value;
            }
        }

        #endregion

        #region 获取主机地址
        //获取主机的地址
        public static string Host
        {
            get
            {
                return HttpContext.Current.Request.Url.AbsoluteUri;
            }
        }

        #endregion

        #region 保存菜单信息
        /// <summary>
        /// 当前登录用户的功能模块（菜单）
        /// 获取menu传递到母版页上展示
        /// </summary>       
        //public static IList<Menu> Privileges
        //{
        //    get
        //    {
        //        //  获取系统中所有的功能模块
        //        IList<Menu> privileges = Container.Instance.Resolve<IMenuService>().GetAll();
        //        //  return privileges;
        //        if (privileges == null)
        //        {
        //            return privileges;
        //        }
        //        IList<Menu> privilegeList = null;//声明一个集合变量
        //        if (LoginedUser != null && LoginedUser.Roles != null)//如果有用户登录并且有对应的角色
        //        {
        //            foreach (Role role in LoginedUser.Roles)//遍历当前用户的角色
        //            {
        //                if (role != null)
        //                {
        //                    foreach (Menu menu in role.Menu)//获取当前用户可以操作的功能
        //                    {
        //                        if (privilegeList == null)
        //                        {
        //                            privilegeList = new List<Menu>();//实例化权限集合
        //                        }
        //                        if (privilegeList.Where(o => o.ID == menu.ID).Count() < 1)//如果当前功能在权限集合中不存在
        //                        {
        //                            privilegeList.Add(menu);//添加到集合中
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        return privilegeList;
        //    }
            #endregion

        }
}