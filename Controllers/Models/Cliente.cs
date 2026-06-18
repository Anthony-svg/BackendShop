using System.ComponentModel.DataAnnotations;

namespace WebApp.Controllers.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        public string? NombreCliente { get; set; }

        public string? TelefonoCliente { get; set; }

    }
}
