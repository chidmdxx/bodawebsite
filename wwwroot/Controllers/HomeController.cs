using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace wwwroot.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Fotos()
        {
            return View();
        }

        public ActionResult Informacion()
        {
            ViewBag.Message = "Aqui aparecerá la información sobre el lugar de la boda.";

            return View();
        }
    }
}