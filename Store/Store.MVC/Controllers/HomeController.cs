using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.MVC.Controllers
{
    public class HomeController : Controller
    {
        Store.DAL.EfContext.StoreContext db = new DAL.EfContext.StoreContext();
        public ActionResult Index()
        {          
            return View(db.Products);
        }
    }
}