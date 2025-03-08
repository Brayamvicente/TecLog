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

        private UsuarioService _usuarioService;

        public AuthController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("Registro")]
        public async Task<IActionResult> RegistraUsuario([FromBody] Usuario userAdd)
        {
            if (userAdd == null) return HandleBadRequest("IU01");

            var result = await _usuarioService.Criar(userAdd);

            if (!result)
            {
                return HandleServerError("IU02");
            }

            return HandleNoContent();
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromQuery] string usuario, [FromQuery] string senha)
        {
            if (usuario == string.Empty || senha == string.Empty) return HandleBadRequest("LU01");

            var Usuario = await _usuarioService.BuscaPorUserName(usuario);

            if (Usuario.Senha == senha)
            {
                return HandleOk();
            }
            else
                return Unauthorized();
        }


        [HttpGet("{id}")]
        public async Task<Usuario> BuscaDadosUsuario(int id)
        {
            if (id == 0) HandleBadRequest("BU01");

            var user = await _usuarioService.BuscaPorId(id);

            if (user == null) HandleNotFound();

            return user;
        }
    }
}


