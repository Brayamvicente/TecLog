using Microsoft.AspNetCore.Mvc;
using TecLog.Models;
using TecLog.Services;
using TecLog.Controllers.Base;
using TecLog.Dto;

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
        public async Task<IActionResult> Logar([FromBody] Login login)
        {
            if (login.Usuario == string.Empty || login.Senha == string.Empty) return HandleBadRequest("LU01");

            var Usuario = await _UsuarioService.BuscaPorUserName(login.Usuario);

            if (Usuario.Senha == login.Senha)
            {
                return HandleOk();
            }
            else
                return Unauthorized();
        }
    }
}


