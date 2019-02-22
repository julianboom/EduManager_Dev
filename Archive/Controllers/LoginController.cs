﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using IBLL;
using Model;
namespace Archive.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        IDeptService deptservice = new DeptService();
        public ActionResult Login()
        {
            return View();
        }
        public JsonResult CheckUserLogin(Users user)
        {
            using (DBEntities db = new DBEntities())
            {

                var users = from p in db.Users
                            where p.UserName == user.UserName && p.Password == user.Password
                            select p;
                if (users.Count() > 0)
                {
                    user = users.FirstOrDefault();

                    UserInfo userInfo = new UserInfo();
                    userInfo.setUser(user.ID);
                    Session["User"] = userInfo.baseInfo;
                    Session["UserName"] = user.UserName;
                    Session["HandleDept"] = user.DeptID;
                    Session["UserID"] = user.ID;
                    Session["RoleID"] = user.RoleID;
                    Session["CurrentUser"] = ((BaseInfo)Session["User"]).user;
                    Session["RealName"] = user.RealName;
                    Session["DeptName"] = deptservice.FindByID((Guid)user.DeptID).DeptName;
                    Session["UnitEditType"] = "Edit";

              
                        return Json(new { result = "success",content=""});
                }
                else
                {
                    return Json(new { result = "error", content = "用户名密码错误，请您检查" });
                }
            }
        }
        public ActionResult LogOut()
        {
            return View("Login");
        }

        public ActionResult TimeOut()
        {
            return View();
        }

    }
}