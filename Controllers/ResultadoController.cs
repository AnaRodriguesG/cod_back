using Microsoft.AspNetCore.Mvc;
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
            if (resultado == null)
            {
                return BadRequest("Dados inválidos.");
            }

            try
            {
                _context.resultado.Add(resultado);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Resultado salvo com sucesso!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao salvar resultado: {ex.Message}");
            }
        }
    }
}
