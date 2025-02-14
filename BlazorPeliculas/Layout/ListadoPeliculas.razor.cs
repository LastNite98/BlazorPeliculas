﻿using Microsoft.AspNetCore.Components;
using BlazorPeliculas.Entidades;

namespace BlazorPeliculas.Layout {
    public partial class ListadoPeliculas {

        [Parameter]
        [EditorRequired]
        public List<Pelicula>? Peliculas { get; set; }
    }
}
