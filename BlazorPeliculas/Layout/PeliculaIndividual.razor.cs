using Microsoft.AspNetCore.Components;
using BlazorPeliculas.Entidades;

namespace BlazorPeliculas.Layout {
    public partial class PeliculaIndividual {

        [Parameter]
        [EditorRequired]
        public Pelicula? Pelicula { get; set; }
        [Parameter]
        public bool MostrarBotones { get; set; }
        [Parameter]
        public EventCallback EliminarPelicula { get; set; }

    }
}
