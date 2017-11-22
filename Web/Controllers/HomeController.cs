using Component;
using Domain;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string usersname,string password)
        {
            //实例化UsersComponent供后文使用
            IUsersService users = new UsersComponent();
            Users userslist = users.Login(usersname,password);
            if (userslist!=null)
            {
                return RedirectToAction("Index", "Home");

            }
         
            return View(userslist);

        }
    }
}