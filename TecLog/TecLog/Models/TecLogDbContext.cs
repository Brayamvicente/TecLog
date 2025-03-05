using Microsoft.EntityFrameworkCore;

namespace TecLog.Models
{
    public class TecLogDbContext : DbContext
    {
        public TecLogDbContext(DbContextOptions<TecLogDbContext> options) : base(options) { }

        DbSet<Usuario> Usuarios { get; set; }
    }
}
