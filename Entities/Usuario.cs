namespace PROJETO_LOGIN.Entities
{
    public class Usuario {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
    }
}
namespace PROJETO_LOGIN.Entities
{
    public class Resultado
{
  
    // Outras propriedades
    public string Relatorio_Perfil { get; set; }
    public string Resultado_Teste { get; set; }
    public int Tabela_Tipo_Pergunta { get; set; }
    public int Tabela_Resposta_Teste { get; set; }
}

}