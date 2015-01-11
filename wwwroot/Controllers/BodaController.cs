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
            id = id ?? string.Empty;
            switch (id.ToLowerInvariant())
            {
                case "mike": persona = PadrinosData.Mike;
                    break;
                case "tyto": persona = PadrinosData.Tyto;
                    break;
                case "moy":
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
                default: return new HttpNotFoundResult("Hey no eres padrino, o no escribiste bien tu nombre");
            }
            return View(persona);
        }

        public ActionResult Damas(string id)
        {
            PersonaModel persona = new PersonaModel();
            id = id ?? string.Empty;
            switch (id.ToLowerInvariant().Trim())
            {
                case "anilu": persona = DamasData.Anilu;
                    break;
                case "annie": persona = DamasData.Annie;
                    break;
                case "dyanne": persona = DamasData.Dyanne;
                    break;
                case "gra": persona = DamasData.Gra;
                    break;
                case "karlita": persona = DamasData.Karlita;
                    break;
                case "melisa":
                case "mel": persona = DamasData.Mel;
                    break;
                case "zita": persona = DamasData.Zita;
                    break;
                default: return new HttpNotFoundResult("Esa dama no existe :p");
            }
            return View(persona);
        }
    }
}