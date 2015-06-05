using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project.Models;
using PagedList;

namespace project.Controllers
{
    public class HomeController : Controller
    {

        private BlogDBContext db = new BlogDBContext();
        
        public ActionResult Index(int page=1)
        {
            int length = db.Blogs.Count();
            List<Blog> article_list = db.Blogs.OrderByDescending(i => i.ReleaseDate).Take(length).ToList();
            return View(article_list.OrderByDescending(x=>x.ReleaseDate).ToPagedList(page,10));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Details(int id = 0)
        {
            Blog article = db.Blogs.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}