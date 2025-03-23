using GeradorSenhas.src.Services;
using Microsoft.AspNetCore.Mvc;

namespace GeradorSenhas.src.Controllers
{
    [ApiController]
    public class PasswordController : ControllerBase
    {
        private readonly PasswordService _service;
        public PasswordController(PasswordService service)
        {
            _service = service;
        }

        [HttpGet("password")]
        public IActionResult CreatePassword([FromQuery] bool letrasMinusculas = false,
            bool letrasMaiusculas = false,
            bool numeros = false,
            bool caracteresEspeciais = false)
        {
            try
            {
                var retorno = _service.NewPassword(letrasMaiusculas, letrasMinusculas, numeros, caracteresEspeciais);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}