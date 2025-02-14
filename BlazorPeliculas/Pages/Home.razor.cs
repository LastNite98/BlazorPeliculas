using BlazorPeliculas.Entidades;

namespace BlazorPeliculas.Pages {
    public partial class Home {

        List<Pelicula> ObtenerPeliculas() {
            return new List<Pelicula>()
                {
            new Pelicula{ Titulo = "Attack On Titan",  FechaLanzamiento = new DateTime(2023, 11, 11)},
            new Pelicula{ Titulo = "Digimon",  FechaLanzamiento = new DateTime(2025, 06, 20)},
            new Pelicula{ Titulo = "La historia de la Decima",  FechaLanzamiento = new DateTime(2027, 09, 01)},
            new Pelicula{ Titulo = "La champions de las remontadas",  FechaLanzamiento = new DateTime(2024, 01, 31)},
            };
        }

    }
}
