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

        public ActionResult Damo(string id)
        {
            PersonaModel persona;
            id = id ?? string.Empty;
            switch (id.ToLowerInvariant().Trim())
            {
                case "tyto": persona = persona = new PersonaModel
                    {
                        Nombre = "Tyto",
                        Color = "#5b5d62",
                        ColorPantone = "Pantone Uncoated 433 U",
                        MensajePersonal = "¡Hola Tyto! siempre hemos podido confiar en ti y eres un gran amigo de ambos, y desde que empezamos a salir habíamos bromeado con tener que pelear por el lado de quien estarías durante la boda así que llegamos a este punto intermedio que esperemos te agrade :D Yep, eres el unico damo de toda la boda! Pero, que significa eso te preguntarás? No, no tienes que ir de vestido ni nada, significa que vas a tener un trabajo muy especial durante nuestra boda :). Ese trabajo especial es que acompañes y ayudes a José Angel, el hermano de majo a caminar hacia el altar. Como eres tan cercano a ambos decidimos darte esta tarea que significaría mucho para Majo, puess el unico de nuestras familias que no tiene quien lo acompañe debido a que todos los demás ya habrían caminado antes, pero confiamos en que tu lo hagas :) El hermano de Majo y tu irian vestidos iguales, pero diferente a los padrinos. Ustedes irian de traje gris (para combinar con el vestido de las damas que es gris), camisa blanca, y moño, pañuelo y fajilla grises (ve eso con Majo) Pero en fin, no podríamos darle este trabajo tan importante a nadie más que a ti, que aunque tal vez no sea fácil (el hermano de Majo no se ha sentido bien ultimamente, pero esperamos que mejore para la boda) sabemos que podemos contar contigo para realizarlo. Te queremos mucho Tyto, esperamos que aceptes ayudarnos en este día tan especial :)"
                    };
                    break;
                default: return new HttpNotFoundResult();
            }
            return View(persona);
        }
    }
}