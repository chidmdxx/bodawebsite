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
                case "mike": persona = _PadrinosData.Mike;
                    break;
                case "adrian":
                case "deito": persona = _PadrinosData.DeIto;
                    break;
                case "moy":
                case "moi": persona = _PadrinosData.Moi;
                    break;
                case "vaj": persona = _PadrinosData.Vaj;
                    break;
                case "franco": persona = _PadrinosData.Franco;
                    break;
                case "ruheri": persona = _PadrinosData.Ruheri;
                    break;
                case "edwin": persona = _PadrinosData.Edwin;
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
                case "anilu": persona = _DamasData.Anilu;
                    break;
                case "annie": persona = _DamasData.Annie;
                    break;
                case "dyanne": persona = _DamasData.Dyanne;
                    break;
                case "gra": persona = _DamasData.Gra;
                    break;
                case "karlita": persona = _DamasData.Karlita;
                    break;
                case "melisa":
                case "mel": persona = _DamasData.Mel;
                    break;
                case "zita": persona = _DamasData.Zita;
                    break;
                default: return new HttpNotFoundResult("Esa dama no existe :p");
            }
            return View(persona);
        }
    }
}