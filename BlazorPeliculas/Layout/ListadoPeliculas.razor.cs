﻿using Microsoft.AspNetCore.Components;
using BlazorPeliculas.Entidades;

namespace BlazorPeliculas.Layout {
    public partial class ListadoPeliculas {

        [Parameter]
        [EditorRequired]
        public List<Pelicula>? Peliculas { get; set; }
        public bool MostrarBotones { get; set; }

        private void EliminarPelicula() {
            Console.WriteLine("Eliminando una pelicula");
        }
    }
}
