using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AJCSPORT.Models;

namespace AJCSPORT.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            //if (Session["admin"] == null)
            //    Session["admin"] = u;
            return View((User)Session["admin"]);
        }
        //page Articles
        [HttpGet]
        public ActionResult Articles()
        {
            List<Article> liste = new List<Article>();
            liste = new DaoArticle().SelectAll();
            return View(liste);
        }
        [HttpPost]
        public ActionResult Articles(int id)
        {
            List<Article> liste = new List<Article>();
            liste = new DaoArticle().SelectAll();
            ViewBag.article = id;
            return View(liste);
        }
        public ActionResult ArticlesAdd(Article a)
        {
            new DaoArticle().Insert(a);
            return RedirectToAction("Articles");
        }
        public ActionResult ArticlesUpdate(Article a)
        {
            new DaoArticle().Update(a);
            return RedirectToAction("Articles");
        }
        public ActionResult ArticlesDelete(int id)
        {
            new DaoArticle().Delete(id);
            return RedirectToAction("Articles");
        }
        //page Clients
        [HttpGet]
        public ActionResult Clients()
        {
            List<User> liste = new List<User>();
            liste = new DaoUser().SelectAll();
            return View(liste);
        }
        [HttpPost]
        public ActionResult Clients(string id)
        {
            List<User> liste = new List<User>();
            liste = new DaoUser().SelectAll();
            ViewBag.user = id;
            return View(liste);
        }
        public ActionResult ClientsAdd(User u)
        {
            new DaoUser().Insert(u);
            return RedirectToAction("Clients");
        }
        public ActionResult ClientsUpdate(User u)
        {
            new DaoUser().Update(u);
            return RedirectToAction("Clients");
        }
        public ActionResult ClientsDelete(string id)
        {
            new DaoUser().Delete(id);
            return RedirectToAction("Clients");
        }
    }
}