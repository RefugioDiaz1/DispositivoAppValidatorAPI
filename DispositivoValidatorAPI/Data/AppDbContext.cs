using DispositivoValidatorAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DispositivoValidatorAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Dispositivo> DispositivosRegistrados { get; set; }
        public DbSet<FirebaseRegistro> FirebaseRegistro { get; set; }
        public DbSet<ContactRequest> Contactos { get; set; }
    }
}