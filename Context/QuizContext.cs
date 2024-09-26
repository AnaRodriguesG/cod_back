using PROJETO_LOGIN.Entities;
using Microsoft.EntityFrameworkCore;

namespace PROJETO_LOGIN.Context
{
   public class QuizContext : DbContext
{
    public QuizContext(DbContextOptions<QuizContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Resultado> Resultado { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configurar a entidade Resultado como uma entidade sem chave
        modelBuilder.Entity<Resultado>().HasNoKey();
    }
}

    
}

