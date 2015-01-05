using wwwroot.Models;

namespace wwwroot.Data
{
    public static class DamasData
    {
        public static PersonaModel Anilu = new PersonaModel
        {
            Nombre = "Anilu",
            Color = ColoresHexData.Rojo,
            ColorPantone = ColoresPantoneData.Rojo,
            NumeroDeFotos = 2,
            MensajePersonal = @"Anilu. Siempre contamos la historia de cuando mamá me dijo que estaba embarazada de ti y yo me puse a llorar. La historia es verdad, pero lloraba porque después de años y años de pedir una hermana y sin que mi sueño se hiciera realidad pensé que mamá y papá me estaban jugando una broma, no creí posible que fuera cierto y pensé que jugaban con mis sentimientos. En cuanto vi la pancita de mamá comenzar a crecer y me di cuenta de que era verdad me di cuenta de que mi sueño se había echo realidad. Y aquí estamos, 15 años después. Sé que a veces peleamos, pero todas las hermanas hacen eso, también nos reímos, bromeamos, nos prestamos la ropa, jugamos videojuegos, vemos películas, nos aconsejamos, nos quejamos de mamá y papá, nos apoyamos y nos divertimos. Tú has sido, no solo para mí sino para toda la familia, esa chispa que nos hacía falta. Gracias por todo nena, y no olvides que aunque este lejos, siempre voy a estar cerca de ti (además de que me puedes visitar cuando quieras, ahí tienes tu casa en Seattle). Mientras tanto, cuida a mamá, a papá y al bey, ahí te los encargo ;). Tu hermana, Mary."
        };

        public static PersonaModel Gra = new PersonaModel
        {
            Nombre = "Gra",
            Color = ColoresHexData.Naranja,
            ColorPantone = ColoresPantoneData.Naranja,
            NumeroDeFotos = 1,
            MensajePersonal = @"Gra, de todas las damas que voy a tener a mi lado el día de mi boda, tu eres la que conozco de más reciente, sin embargo desde el tiempo que te conozco has sido una gran amiga. Gracias por abrirme las puertas de tu casa, acompañarme, escucharme, enseñarme a cocinar jaja y sobre todo siempre estar al pendiente y haber retomado la amistad aunque estuviéramos lejos un tiempo. Eres una persona súper inteligente y con muchas metas y yo sé que lo lograras todo, porque cuentas con esa determinación y ese amor por aprender. Gracias de nuevo por estar a mi lado en este día, y espero que siempre sepas que cuentas conmigo para todo."
        };

        public static PersonaModel Karlita = new PersonaModel
        {
            Nombre = "Karlita",
            Color = ColoresHexData.Amarillo,
            NumeroDeFotos = 2,
            ColorPantone = ColoresPantoneData.Amarillo
        };

        public static PersonaModel Melisa = new PersonaModel
        {
            Nombre = "Melisa",
            Color = ColoresHexData.Verde,
            NumeroDeFotos = 2,
            ColorPantone = ColoresPantoneData.Verde
        };

        public static PersonaModel Dyanne = new PersonaModel
        {
            Nombre = "Dyanne",
            Color = ColoresHexData.AzulClaro,
            NumeroDeFotos = 2,
            ColorPantone = ColoresPantoneData.AzulClaro
        };

        public static PersonaModel Annie = new PersonaModel
        {
            Nombre = "Annie",
            Color = ColoresHexData.AzulFuerte,
            NumeroDeFotos = 2,
            ColorPantone = ColoresPantoneData.AzulFuerte
        };

        public static PersonaModel Zita = new PersonaModel
        {
            Nombre = "Zita",
            Color = ColoresHexData.Morado,
            NumeroDeFotos = 2,
            ColorPantone = ColoresPantoneData.Morado
        };
    }
}