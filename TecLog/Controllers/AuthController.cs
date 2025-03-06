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
            var result = await _usuarioService.Criar(userAdd);
            if (result)
            {
                
            }
        }
    }
}


