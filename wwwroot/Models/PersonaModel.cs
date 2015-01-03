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
        public string ColorPantone { get; set; }
        public string PathAFotos
        {
            get
            {
                return string.Format("~/Content/PadrinosDamas/{0}/", this.Nombre);
            }
        }
        public int NumeroDeFotos { get; set; }
        public string MensajePersonal { get; set; }
    }
}