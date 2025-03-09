using Microsoft.AspNetCore.Mvc;
using TecLog.Controllers.Base;
using TecLog.Models;
using TecLog.Services;

namespace TecLog.Controllers
{
    [ApiController]
    [Route("Usuario")]
    public class UsuarioController : BaseController
    {
        private UsuarioService _UsuarioService;
        public UsuarioController( UsuarioService usuarioService)
        {
            _UsuarioService = usuarioService;
        }

        [HttpPost("Registro")]
        public async Task<IActionResult> RegistraUsuario([FromBody] Usuario userAdd)
        {
            if (userAdd == null) return HandleBadRequest("IU01");

            var result = await _UsuarioService.Criar(userAdd);

            if (!result)
            {
                return HandleServerError("IU02");
            }

            return HandleNoContent();
        }

        [HttpGet("{id}")]
        public async Task<Usuario> BuscaDadosUsuario(int id)
        {
            if (id == 0) HandleBadRequest("BU01");

            var user = await _UsuarioService.BuscaPorId(id);

            if (user == null) HandleNotFound();

            return user;
        }
    }
}
