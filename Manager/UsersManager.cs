using Core;
using Domain;
using Manager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
   public class UsersManager : ManagerBase<Users>
    {
        //连接字符串  都需要 放在外面
        string con = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ToString();

        /// <summary>
        /// 用户登录 对数据库的操作
        /// </summary>
        /// <param name="usersname"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Users Login(string usersname,string password)
        {

            #region 未封SqlDbHelper装操作
            //SqlConnection conn = new SqlConnection(con);
            //conn.Open();
            //string sql = string.Format("select * from Users where UsersName='{0}' and Password='{1}' ", usersname, password);
            //SqlCommand comm = new SqlCommand(sql, conn);
            //SqlDataAdapter adp = new SqlDataAdapter(comm);
            //DataTable dt = new DataTable();
            //adp.Fill(dt);
            //conn.Close();

            //Users users = new Users();
            //if (dt.Rows.Count > 0)
            //{
            //    users.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            //    users.UsersName = dt.Rows[0]["UsersName"].ToString();
            //    users.Email = dt.Rows[0]["Email"].ToString();
            //    users.TelePhone = dt.Rows[0]["TelePhone"].ToString();
            //    users.ClassesId = int.Parse(dt.Rows[0]["Id"].ToString());
            //    users.RolesId = int.Parse(dt.Rows[0]["RolesId"].ToString());
            //    users.IsShow = true;
            //    users.Gender = dt.Rows[0]["Gender"].ToString();

            //}
            //return users;

            #endregion

            #region 调用DbHelper操作
      
            DataTable dt = SqlDBHelper.ExecuteDataTable
                (
                "select * from Users where UsersName=@usersname and Password=@password ", 
                new SqlParameter("usersname",usersname),
                new SqlParameter("password", password)
                );

            IList<Users> sys = ModelConvertHelper<Users>.ConvertToModel(dt);

            Users users = new Users();
            if (dt.Rows.Count > 0)
            {
                users.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                users.UsersName = dt.Rows[0]["UsersName"].ToString();
                users.Email = dt.Rows[0]["Email"].ToString();
                users.TelePhone = dt.Rows[0]["TelePhone"].ToString();
                users.ClassesId = int.Parse(dt.Rows[0]["Id"].ToString());
                users.RolesId = int.Parse(dt.Rows[0]["RolesId"].ToString());
                users.IsShow = true;
                users.Gender = dt.Rows[0]["Gender"].ToString();

            }
            //Users users = sys;
            return users;


            #endregion


        }
    }
}
