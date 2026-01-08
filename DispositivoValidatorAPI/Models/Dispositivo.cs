namespace DispositivoValidatorAPI.Models
{
    public class Dispositivo
    {
        public int Id { get; set; }
        public string DeviceId { get; set; }
        public bool EsAdmin { get; set; }
        public bool TienePermiso { get; set; }
    }
}
