using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wwwroot.Models;

namespace wwwroot.Data
{
    public static class MadrinasData
    {
        public static PersonaModel Anilu = new PersonaModel
        {
            Nombre = "Anilu",
            Color = ColoresData.Rojo
        };

        public static PersonaModel Gra = new PersonaModel
        {
            Nombre = "Gra",
            Color = ColoresData.Naranja
        };

        public static PersonaModel Karlita = new PersonaModel
        {
            Nombre = "Karlita",
            Color = ColoresData.Amarillo
        };

        public static PersonaModel Melisa = new PersonaModel
        {
            Nombre = "Melisa",
            Color = ColoresData.Verde
        };

        public static PersonaModel Dyanne = new PersonaModel
        {
            Nombre = "Dyanne",
            Color = ColoresData.AzulClaro
        };

        public static PersonaModel Annie = new PersonaModel
        {
            Nombre = "Annie",
            Color = ColoresData.AzulFuerte
        };

        public static PersonaModel Zita = new PersonaModel
        {
            Nombre = "Zita",
            Color = ColoresData.Morado
        };
    }
}