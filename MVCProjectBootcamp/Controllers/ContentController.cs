using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjectBootcamp.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ContentManager cm = new ContentManager(new EfContentDal());

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAllContent()
        {
            Context c = new Context();
            var values = c.Contents.ToList();
            return View(values);
        }


        [HttpPost]
        public ActionResult GetAllContent(string p)
        {
            var values = cm.GetContent(p);

            //var values = c.Contents.ToList();
            return View(values);
        }
        public ActionResult ContentByHeading(int id)
        {
            var contentValues = cm.GetContentById(id);
            return View(contentValues);
        }
    }
}