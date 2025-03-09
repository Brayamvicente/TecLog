using Microsoft.AspNetCore.Mvc;
using TecLog.Models;
using TecLog.Services;
using TecLog.Controllers.Base;

namespace TecLog.Controllers
{
    [ApiController]
    [Route("Auth")]
    public class AuthController : BaseController
    {

        private UsuarioService _UsuarioService;

        public AuthController(UsuarioService usuarioService)
        {
            _UsuarioService = usuarioService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Logar([FromQuery] string usuario, [FromQuery] string senha)
        {
            if (usuario == string.Empty || senha == string.Empty) return HandleBadRequest("LU01");

            var Usuario = await _UsuarioService.BuscaPorUserName(usuario);

            if (Usuario.Senha == senha)
            {
                return HandleOk();
            }
            else
                return Unauthorized();
        }
    }
}


