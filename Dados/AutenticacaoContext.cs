using autenticacaoEfCookie.Models;
using Microsoft.EntityFrameworkCore;

namespace autenticacaoEfCookie.Dados
{
    public class AutenticacaoContext:DbContext
    {
        public AutenticacaoContext(DbContextOptions<AutenticacaoContext> options):base(options){}

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Permissao> Permissoes { get; set; }
        public DbSet<UsuarioPermissao> UsuarioPermissoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Permissao>().ToTable("Permissoes");
            modelBuilder.Entity<UsuarioPermissao>().ToTable("UsuarioPermissoes");

            base.OnModelCreating(modelBuilder);
        }
    }
}