using Microsoft.EntityFrameworkCore;

namespace TecLog.Models
{
    public class TecLogDbContext : DbContext
    {
        public TecLogDbContext(DbContextOptions<TecLogDbContext> options) : base(options) { }

        DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario {
                    Id = 1,
                    UserName = "brayam.vicente",
                    Nome = "Brayam", 
                    Cpf = 93260334068, 
                    Senha = "123456" ,
                    Endereco = "jaime silveira",
                    Telefone = 51992859570}
            );
        }
    }
}
