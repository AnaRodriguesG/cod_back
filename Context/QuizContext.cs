using PROJETO_LOGIN.Entities;
using Microsoft.EntityFrameworkCore;

namespace PROJETO_LOGIN.Context
{
    public class QuizContext : DbContext
    {
        internal object resultado;

        public QuizContext(DbContextOptions<QuizContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
namespace PROJETO_LOGIN.Entities
{
    public class Resultado
    {
        public int Id_Resultado { get; set; }
        public string Relatorio_Perfil { get; set; }
        public string Resultado_Teste { get; set; }
        public int Tabela_Tipo_Pergunta { get; set; }
        public int Tabela_Resposta_Teste { get; set; }

        // Relacionamentos (se existirem)
        // public Tipo_Pergunta Tipo_Pergunta { get; set; }
        // public Resposta Resposta_Teste { get; set; }
    }
}
