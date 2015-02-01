using wwwroot.Models;

namespace wwwroot.Data
{
    public static class _PadrinosData
    {
        public static PersonaModel Mike = new PersonaModel
        {
            Nombre = "Mike",
            Color = _ColoresHexData.Verde,
            ColorPantone = _ColoresPantoneData.Verde,
            MensajePersonal = @"Para mi siempre has sido como un hermano y me gustaria que 
                                fueras parte de la boda como mi best man. Se que ya te lo había pedido y que soy terrible
                                en escribir estas cosas, y realmente significa mucho que estes haciendo esto."
        };

        public static PersonaModel DeIto = new PersonaModel
        {
            Nombre = "De Ito",
            Color = _ColoresHexData.AzulFuerte,
            ColorPantone = _ColoresPantoneData.AzulFuerte,
            MensajePersonal = @"De Ito, gracias por todo el apoyo incondicional, a través de todos los años de conocernos,
                                por eso es que me gustaría que estuvieras entre los padrinos de en la boda, espero poder contar
                                contigo siempre y sabes que para cualquier cosa me tienes a mi, te quiero un buen"
        };

        public static PersonaModel Moi = new PersonaModel
        {
            Nombre = "Moi",
            Color = _ColoresHexData.AzulClaro,
            ColorPantone = _ColoresPantoneData.AzulClaro,
            MensajePersonal = @"No llevamos tanto tiempo de conocernos, pero eso no importa, eres de las personas
                                que mas quiero y para mi sería un placer que fueras uno de mis padrinos en la boda :D
                                (además de que la foto jugando Magic se ve super cool)"
        };

        public static PersonaModel Vaj = new PersonaModel
        {
            Nombre = "Vaj",
            Color = _ColoresHexData.Naranja,
            ColorPantone = _ColoresPantoneData.Naranja,
            MensajePersonal = @"Hermano, eres de los primeros en saber que esto pasaría, y de los primeros en saber que nos
                                casariamos, y me gustaría que fueras uno de mis padrinos, gracias por siempre haber estado a mi lado
                                y por todo el apoyo que me has dado :D"
        };

        public static PersonaModel Franco = new PersonaModel
        {
            Nombre = "Franco",
            Color = _ColoresHexData.Amarillo,
            ColorPantone = _ColoresPantoneData.Amarillo,
            MensajePersonal = @"Franco, eres super chido, te quiero y eres un hermano para mi, sería un placer que fueras
                                uno de los padrinos en nuestra boda. (no te dije mientras andabas aca por faltaba el Lego) 
                                y si esto esta en Azure y github, porfa no trates de romper la página o de burlarte de lo malo que soy en UX"
        };

        public static PersonaModel Ruheri = new PersonaModel
        {
            Nombre = "Ruheri",
            Color = _ColoresHexData.Rojo,
            ColorPantone = _ColoresPantoneData.Rojo,
            MensajePersonal = @"Eres literalmente mi hermano y aunque tengamos nuestras diferencias, te quiero y estimo
                                mucho, por eso quiero que estes entre los padrinos de la boda. Gracias por toda experiencia
                                y por todo momento juntos, sabes que siempre me tendrás para apoyarte."
        };

        public static PersonaModel Edwin = new PersonaModel
        {
            Nombre = "Edwin",
            Color = _ColoresHexData.Morado,
            ColorPantone = _ColoresPantoneData.Morado,
            MensajePersonal = @"Si hay alguien en quien puedo contar eres tú, te quiero mucho y sería un honor que
                                fueras un padrino en la boda. Gracias por todo momento que hemos pasado y que se que pasaremos :)"
        };
    }
}