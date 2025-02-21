using Microsoft.AspNetCore.Components;

namespace BlazorPeliculas.Layout {
    public partial class ListadoGenerico<Titem> {
        [Parameter]
        public RenderFragment Cargando { get; set; } = null!;

        [Parameter]
        public RenderFragment NoHayRegistros { get; set; } = null!;

        [Parameter]
        public RenderFragment<Titem> HayRegistros { get; set; } = null!;

        [Parameter]
        [EditorRequired]
        public List<Titem> Listado { get; set; } = null!;
    }
}