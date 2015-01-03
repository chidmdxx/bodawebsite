using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wwwroot.Models
{
    public class PersonaModel
    {
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string PathAFotos
        {
            get
            {
                return string.Format("~/Content/Boda/PadrinosMadrinas/{0}/", this.Nombre);
            }
        }
        public string MensajePersonal { get; set; }
    }
}