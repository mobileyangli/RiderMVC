using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using RiderMVC.DAL;
using RiderMVC.Model;

namespace RiderMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var studentDao = new StudentDao();
            var stud = new Student() {Name = "link"};
            studentDao.AddStudent(stud);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}