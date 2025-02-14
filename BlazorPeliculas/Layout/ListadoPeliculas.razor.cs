using BlazorPeliculas.Entidades;
using Microsoft.AspNetCore.Components;

namespace BlazorPeliculas.Layout {
    public partial class ListadoPeliculas {

        [Parameter]
        public List<Pelicula>? Peliculas { get; set; }

        protected override async Task OnInitializedAsync() {
            await Task.Delay(3000);
            Peliculas = ObtenerPeliculas();
        }

        List<Pelicula> ObtenerPeliculas() {
            return new List<Pelicula>()
                {
            new Pelicula{ Titulo = "Konosuba",  FechaLanzamiento = new DateTime(2023, 11, 11)},
            new Pelicula{ Titulo = "Pokemon",  FechaLanzamiento = new DateTime(2025, 06, 20)},
            new Pelicula{ Titulo = "Minecraft",  FechaLanzamiento = new DateTime(2027, 09, 01)},
            new Pelicula{ Titulo = "Two Girls One Cup",  FechaLanzamiento = new DateTime(2024, 01, 31)},
            };
        }

    }
}
