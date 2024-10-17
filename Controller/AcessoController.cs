using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UsuarioAPI.Controller;

[ApiController]
[Route("Controller")]
public class AcessoController : ControllerBase
{
    [HttpGet]
    [Authorize(Policy = "IdadeMinima")]
    public IActionResult Get()
    {
        return Ok("Acesso Permtido!");
    }
}
