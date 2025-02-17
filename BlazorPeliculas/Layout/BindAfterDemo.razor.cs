﻿namespace BlazorPeliculas.Layout {
    public partial class BindAfterDemo {
        private string busqueda = string.Empty;
        private List<string> personasEncontradas = new List<string>();

        private async Task Buscar() {
            var personas = new List<string> {
                "Felipe Gavilán",
                "Felipe Díaz",
                "Claudia Rodriguez",
                "Claudia Celeste"
            };
            await Task.Delay(1000);

            personasEncontradas = personas.Where(p => p.Contains(busqueda)).ToList();

        }
    }
}
