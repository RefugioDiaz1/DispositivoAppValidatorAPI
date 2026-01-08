using DispositivoValidatorAPI.Data;
using DispositivoValidatorAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DispositivoValidatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DispositivosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DispositivosController(AppDbContext context)
        {
            _context = context;
        }

        public class DeviceRequest
        {
            public string DeviceId { get; set; }
        }

        [HttpPost("validar")]
        public IActionResult Validar([FromBody] DeviceRequest request)
        {
            var dispositivo = _context.DispositivosRegistrados
                .FirstOrDefault(d => d.DeviceId == request.DeviceId);

            if (dispositivo == null)
            {
                return Ok(new
                {
                    Existe = false,
                    EsAdmin = false,
                    TienePermiso = false
                });
            }

            return Ok(new
            {
                Existe = true,
                dispositivo.EsAdmin,
                dispositivo.TienePermiso
            });
        }


        [HttpPost("registrar")]
        public IActionResult Registrar([FromBody] FirebaseRegistro data)
        {
            if (string.IsNullOrWhiteSpace(data.DeviceId))
                return BadRequest("DeviceId requerido");

            try
            {
                var existe = _context.FirebaseRegistro.Any(x => x.DeviceId == data.DeviceId);
                if (existe)
                    return Ok(new { mensaje = "Ya registrado" });

                // Asegúrate que FechaRegistro se establezca aquí para evitar problemas
                data.FechaRegistro = DateTime.Now;

                _context.FirebaseRegistro.Add(data);
                _context.SaveChanges();

                return Ok(new { mensaje = "Registrado correctamente" });
            }
            catch (Exception ex)
            {
                // Loguea el error aquí si tienes logger, por ejemplo:
                // _logger.LogError(ex, "Error al registrar dispositivo");

                return StatusCode(500, new { mensaje = "Error al registrar dispositivo", detalle = ex.Message });
            }
        }

        [HttpPost("enviar")]
        public IActionResult Enviar([FromBody] ContactRequest contacto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(contacto.Nombre) || string.IsNullOrWhiteSpace(contacto.Correo))
                    return BadRequest("Nombre y correo son obligatorios.");

                _context.Contactos.Add(contacto);
                _context.SaveChanges();

                return Ok(new { mensaje = "Mensaje enviado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error interno: " + ex.Message });
            }
        }

    }
}
