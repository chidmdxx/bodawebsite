using wwwroot.Models;

namespace wwwroot.Data
{
    public static class PadrinosData
    {
        public static PersonaModel Mike = new PersonaModel
        {
            Nombre = "Mike",
            Color = ColoresHexData.AzulFuerte,
            ColorPantone = ColoresPantoneData.AzulFuerte,
            NumeroDeFotos = 2,
            MensajePersonal = @"Para mi siempre has sido como un hermano y me gustaria que 
                                fueras parte de la boda como mi best man. Se que ya te lo había pedido
                                pero así puedes ver el Lego que armamos para esto"
        };

        public static PersonaModel Tyto = new PersonaModel
        {
            Nombre = "Tyto",
            Color = ColoresHexData.Naranja,
            ColorPantone = ColoresPantoneData.Naranja,
            NumeroDeFotos = 2,
            MensajePersonal = @"Tyto eres de las persona más raras e interesantes que conosco, además de un gran amigo
                                y alguien en quien siempre puedo contar, por eso quiero pedirte que estes entre
                                los padrinos para la boda."
        };

        public static PersonaModel Moi = new PersonaModel
        {
            Nombre = "Moi",
            Color = ColoresHexData.Amarillo,
            ColorPantone = ColoresPantoneData.Amarillo,
            NumeroDeFotos = 2,
            MensajePersonal = @"No llevamos tanto tiempo de conocernos, pero eso no importa, eres de las personas
                                que mas quiero y para mi sería un placer que fueras uno de mis padrinos en la boda :D"
        };

        public static PersonaModel Vaj = new PersonaModel
        {
            Nombre = "Vaj",
            Color = ColoresHexData.Verde,
            ColorPantone = ColoresPantoneData.Verde,
            NumeroDeFotos = 1,
            MensajePersonal = @"Hermano, eres de los primeros en saber que esto pasaría, y de los primeros en saber que nos
                                casariamos, y me gustaría que fueras uno de mis padrinos"
        };

        public static PersonaModel Franco = new PersonaModel
        {
            Nombre = "Franco",
            Color = ColoresHexData.AzulClaro,
            ColorPantone = ColoresPantoneData.AzulClaro,
            NumeroDeFotos = 1,
            MensajePersonal = @"Franco, eres super chido, te quiero y eres un hermano para mi, sería un placer que fueras
                                uno de los padrinos en nuestra boda. (no te dije mientras andabas aca por falta del Lego) 
                                y si esto esta en Azure y github, porfa no trates de romper la página"
        };

        public static PersonaModel Ruheri = new PersonaModel
        {
            Nombre = "Ruheri",
            Color = ColoresHexData.Rojo,
            ColorPantone = ColoresPantoneData.Rojo,
            NumeroDeFotos = 1,
            MensajePersonal = @"Eres literalmente mi hermano y aunque tengamos nuestras diferencias, te quiero y estimo
                                mucho, por eso quiero que estes entre los padrinos de la boda."
        };

        public static PersonaModel Edwin = new PersonaModel
        {
            Nombre = "Edwin",
            Color = ColoresHexData.Morado,
            ColorPantone = ColoresPantoneData.Morado,
            NumeroDeFotos = 1,
            MensajePersonal = @"Si hay alguien en quien puedo contar en contigo Ed, te quiero mucho y sería un honor que
                                fueras un padrino en la boda. (ya se que tienes el Lego pero pues ya tenía lo foto
                                y quería hacer la foto)"
        };
    }
}