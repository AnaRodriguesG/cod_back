using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROJETO_LOGIN.Context;
using PROJETO_LOGIN.Entities;
using System.Threading.Tasks;

namespace PROJETO_LOGIN.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResultadoController : ControllerBase
    {
        private readonly QuizContext _context;

        public ResultadoController(QuizContext context)
        {
            _context = context;
        }

       [HttpPost("salvar")]
public async Task<IActionResult> SalvarResultado([FromBody] Resultado resultado)
{
    try
    {
        // Execute um comando SQL bruto para inserir o resultado no banco de dados
        await _context.Database.ExecuteSqlInterpolatedAsync($@"
            INSERT INTO SiteQuizz.Resultado 
            (Relatorio_Perfil, Resultado_Teste) 
            VALUES 
            ({resultado.Relatorio_Perfil}, {resultado.Resultado_Teste})");

        return Ok(new { message = "Resultado salvo com sucesso!" });
    }
    catch (Exception ex)
    {
        return StatusCode(500, new { message = $"Erro ao salvar resultado: {ex.Message}" });
    }
}

    }
}
