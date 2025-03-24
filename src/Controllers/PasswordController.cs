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
        public IActionResult CreatePassword(
            [FromQuery] int tamanho = 12,
            [FromQuery] bool letrasMinusculas = false,
            [FromQuery] bool letrasMaiusculas = false,
            [FromQuery] bool numeros = false,
            [FromQuery] bool caracteresEspeciais = false)
        {
            try
            {
                var retorno = _service.NewPassword(tamanho, letrasMaiusculas, letrasMinusculas, numeros, caracteresEspeciais);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}