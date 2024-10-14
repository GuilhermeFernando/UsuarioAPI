using Microsoft.AspNetCore.Mvc;

namespace UsuarioAPI.Controller;

[ApiController]
[Route("{controller}")]
public class UsuarioController : ControllerBase
{
    [HttpPost]
    public IActionResult Adicionausuario()
    {
        throw new NotImplementedException();
    }
}
