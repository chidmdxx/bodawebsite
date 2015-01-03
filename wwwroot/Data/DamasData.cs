using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wwwroot.Models;

namespace wwwroot.Data
{
    public static class DamasData
    {
        public static PersonaModel Anilu = new PersonaModel
        {
            Nombre = "Anilu",
            Color = ColoresHexData.Rojo,
            ColorPantone = ColoresPantoneData.Rojo
        };

        public static PersonaModel Gra = new PersonaModel
        {
            Nombre = "Gra",
            Color = ColoresHexData.Naranja,
            ColorPantone = ColoresPantoneData.Naranja
        };

        public static PersonaModel Karlita = new PersonaModel
        {
            Nombre = "Karlita",
            Color = ColoresHexData.Amarillo,
            ColorPantone = ColoresPantoneData.Amarillo
        };

        public static PersonaModel Melisa = new PersonaModel
        {
            Nombre = "Melisa",
            Color = ColoresHexData.Verde,
            ColorPantone = ColoresPantoneData.Verde
        };

        public static PersonaModel Dyanne = new PersonaModel
        {
            Nombre = "Dyanne",
            Color = ColoresHexData.AzulClaro,
            ColorPantone = ColoresPantoneData.AzulClaro
        };

        public static PersonaModel Annie = new PersonaModel
        {
            Nombre = "Annie",
            Color = ColoresHexData.AzulFuerte,
            ColorPantone = ColoresPantoneData.AzulFuerte
        };

        public static PersonaModel Zita = new PersonaModel
        {
            Nombre = "Zita",
            Color = ColoresHexData.Morado,
            ColorPantone = ColoresPantoneData.Morado
        };
    }
}