using System.ComponentModel.DataAnnotations;

namespace WebApp.Controllers.Models
{
    public class Inventario
    {
        [Key]
        public int ProductoId { get; set; }

        public string? ProductoNombre { get; set; }

        public int StockDisponible { get; set; }

        public int ReponerStock { get; set; }
    }
}
