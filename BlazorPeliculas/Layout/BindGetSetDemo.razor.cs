namespace BlazorPeliculas.Layout {
    public partial class BindGetSetDemo {
        private string? texto = string.Empty;
        private Task SetAsync(string valor) {
            texto = valor.ToUpper();
            return Task.CompletedTask;
        }

    }
}