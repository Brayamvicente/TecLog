using Microsoft.AspNetCore.Mvc;

namespace TecLog.Controllers.Base;

public class BaseController : ControllerBase
{
    protected IActionResult HandleResponse(string mensagem)
    {
        return Ok(new { Message = mensagem });
    }
   
    protected IActionResult HandleBadRequest(string mensagem)
    {
        return BadRequest(new { Message = mensagem }); 
    }

    
    protected IActionResult HandleServerError(string mensagem)
    {
        return StatusCode(500, new { Message = mensagem }); 
    }
    
    protected IActionResult HandleUnauthorized(string mensagem)
    {
        return Unauthorized(new { Message = mensagem });
    }
    
    protected IActionResult HandleNoContent()
    {
        return NoContent(); 
    }
}