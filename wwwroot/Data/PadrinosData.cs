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
            Color = ColoresHexData.Rojo,
            ColorPantone = ColoresPantoneData.Rojo
        };

        public static PersonaModel Tyto = new PersonaModel
        {
            Nombre = "Tyto",
            Color = ColoresHexData.Naranja,
            ColorPantone = ColoresPantoneData.Naranja
        };

        public static PersonaModel Moi = new PersonaModel
        {
            Nombre = "Moi",
            Color = ColoresHexData.Amarillo,
            ColorPantone = ColoresPantoneData.Amarillo
        };

        public static PersonaModel Vaj = new PersonaModel
        {
            Nombre = "Vaj",
            Color = ColoresHexData.Verde,
            ColorPantone = ColoresPantoneData.Verde
        };

        public static PersonaModel Franco = new PersonaModel
        {
            Nombre = "Franco",
            Color = ColoresHexData.AzulClaro,
            ColorPantone = ColoresPantoneData.AzulClaro
        };

        public static PersonaModel Ruheri = new PersonaModel
        {
            Nombre = "Ruheri",
            Color = ColoresHexData.AzulFuerte,
            ColorPantone = ColoresPantoneData.AzulFuerte
        };

        public static PersonaModel Edwin = new PersonaModel
        {
            Nombre = "Edwin",
            Color = ColoresHexData.Morado,
            ColorPantone = ColoresPantoneData.Morado
        };
    }
}