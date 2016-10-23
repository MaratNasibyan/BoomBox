using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.DAL.Repositories;

namespace Store.MVC.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork db = new UnitOfWork();
        public ActionResult Index()
        {          
            return View(db.Products.GetAll());
        }
    }
}