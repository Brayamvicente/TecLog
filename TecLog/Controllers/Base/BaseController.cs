using Microsoft.AspNetCore.Mvc;

namespace TecLog.Controllers.Base;

public class BaseController : ControllerBase
{


    protected IActionResult HandleOk()
    {
        return Ok();
    }
    protected IActionResult HandleBadRequest(string mensagem)
    {
        return BadRequest(new { Message = mensagem }); 
    }
    
    protected IActionResult HandleServerError(string mensagem)
    {
        return StatusCode(500, new { Message = mensagem }); 
    }

    protected IActionResult HandleNotFound()
    {
        return NotFound();
    }

    protected IActionResult HandleNoContent()
    {
        return NoContent(); 
    }

    protected IActionResult HandleUnauthorized()
    {
        return Unauthorized();
    }
}