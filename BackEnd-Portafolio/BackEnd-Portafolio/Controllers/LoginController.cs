using BackEnd_Portafolio.Domain.IServices;
using BackEnd_Portafolio.Domain.Models;
using BackEnd_Portafolio.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_Portafolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]

        public async Task<IActionResult> Post([FromBody] Usuario usuario)
        {
            try
            {

                usuario.Password = Encriptar.EncriptarPassword(usuario.Password);
                var user = await _loginService.ValidateUser(usuario);
                if (user == null)
                {

                    return BadRequest(new { message=" Usuarioa o contrasena invalidos" });
                }

                return Ok(new { usuario = user.NombreUsuario});
            }
            catch (Exception ex)
            {

               return BadRequest(ex.Message);
            }
        }

    }
}
