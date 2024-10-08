using Microsoft.AspNetCore.Mvc;
using PROJETO_LOGIN.Context;
using PROJETO_LOGIN.Entities;
using Microsoft.EntityFrameworkCore;

namespace PROJETO_LOGIN.Controllers
{
    [Route("api/Usuarios/[controller]")]
    [ApiController]

    public class CadastroController : ControllerBase
    {
        private readonly QuizContext _context;

        public CadastroController(QuizContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuario()
        {
            return await _context.Usuarios.ToListAsync();
        }

        [HttpGet ("{id}")]
         
         public async Task<ActionResult<Usuario>> GetUsuario(int id)
         {
            var usuario = await _context.Usuarios.FindAsync(id);

            if(usuario == null)
            {
                return NotFound();
            }

            return usuario;
         }

        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUsuario), new { id = usuario.Id }, usuario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return BadRequest("O Id fornecido não pertence ao Id do cliente.");
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return Ok("Cliente atualizado com sucesso!");
            }
            catch (DbUpdateConcurrencyException)
            {
                if(!UsuarioExists(id))
                {
                    return NotFound("Cliente não encontrado.");
                }
                else
                {
                    throw;
                }
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();

            }

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }
    }
}