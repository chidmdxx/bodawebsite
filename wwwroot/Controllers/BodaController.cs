using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wwwroot.Models;
using wwwroot.Data;

namespace wwwroot.Controllers
{
    public class BodaController : Controller
    {
        public ActionResult Padrinos(string id)
        {
            PersonaModel persona = new PersonaModel();
            switch (id.ToLowerInvariant())
            {
                case "mike": persona = PadrinosData.Mike;
                    break;
                case "tyto": persona = PadrinosData.Tyto;
                    break;
                case "moi": persona = PadrinosData.Moi;
                    break;
                case "vaj": persona = PadrinosData.Vaj;
                    break;
                case "franco": persona = PadrinosData.Franco;
                    break;
                case "ruheri": persona = PadrinosData.Ruheri;
                    break;
                case "edwin": persona = PadrinosData.Edwin;
                    break;
            }
            return View(persona);
        }
    }
}