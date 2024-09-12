using PROJETO_LOGIN.Entities;
using Microsoft.EntityFrameworkCore;

namespace PROJETO_LOGIN.Context
{
    public class QuizContext : DbContext
    {

        public QuizContext(DbContextOptions<QuizContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}