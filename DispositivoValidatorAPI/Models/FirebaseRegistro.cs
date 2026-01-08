using System.ComponentModel.DataAnnotations;

namespace DispositivoValidatorAPI.Models
{
    public class FirebaseRegistro
    {
        [Key]
        public int Id { get; set; } // PK, auto-incremental

        [Required]
        [MaxLength(100)]
        public string DeviceId { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Modelo { get; set; }

        [MaxLength(100)]
        public string? Telefono { get; set; }

        [MaxLength(100)]
        public string? SistemaOperativo { get; set; }

        [MaxLength(50)]
        public string? VersionSO { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }

}
