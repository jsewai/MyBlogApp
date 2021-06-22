using MyBlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogApp.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        readonly private CustomMembershipProvider customMembershipProvider = new CustomMembershipProvider();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
    }
}