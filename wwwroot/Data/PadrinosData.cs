using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wwwroot.Models;

namespace wwwroot.Data
{
    public static class PadrinosData
    {
        public static PersonaModel Mike = new PersonaModel
        {
            Nombre = "Mike",
            Color = ColoresData.Rojo
        };

        public static PersonaModel Tyto = new PersonaModel
        {
            Nombre = "Tyto",
            Color = ColoresData.Naranja
        };

        public static PersonaModel Moi = new PersonaModel
        {
            Nombre = "Moi",
            Color = ColoresData.Amarillo
        };

        public static PersonaModel Vaj = new PersonaModel
        {
            Nombre = "Vaj",
            Color = ColoresData.Verde
        };

        public static PersonaModel Franco = new PersonaModel
        {
            Nombre = "Franco",
            Color = ColoresData.AzulClaro
        };

        public static PersonaModel Ruheri = new PersonaModel
        {
            Nombre = "Ruheri",
            Color = ColoresData.AzulFuerte
        };

        public static PersonaModel Edwin = new PersonaModel
        {
            Nombre = "Edwin",
            Color = ColoresData.Morado
        };
    }
}