using System.ComponentModel.DataAnnotations;

namespace DispositivoValidatorAPI.Models
{
    public class ContactRequest
    {
        [Key]
        public int Id { get; set; } // PK, auto-incremental
        public string Nombre { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Area { get; set; } = string.Empty;
        public string Comentario { get; set; } = string.Empty;
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
