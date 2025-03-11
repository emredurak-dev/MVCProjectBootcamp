using MVCProjectBootcamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjectBootcamp.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }

        public List<CategoryClass> BlogList()
        {
            List<CategoryClass> ct = new List<CategoryClass>();
            ct.Add(new CategoryClass()
            {
                CategoryName="Software",
                CategoryCount=8
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Trip",
                CategoryCount = 4
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Technology",
                CategoryCount = 6
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Sports",
                CategoryCount = 18
            });
            return ct;
        }
    }
}