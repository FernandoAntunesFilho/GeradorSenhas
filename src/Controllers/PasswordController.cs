using Microsoft.AspNetCore.Mvc;

namespace GeradorSenhas.src.Controllers
{
    [ApiController]
    public class PasswordController : ControllerBase
    {
        [HttpGet("password")]
        public IActionResult CreatePassword([FromQuery] bool letrasMinusculas = false,
            bool letrasMaiusculas = false,
            bool numeros = false,
            bool caracteresEspeciais = false)
        {
            var retorno = $"Letras Minusculas: {letrasMinusculas}, Letras Maiusculas: {letrasMaiusculas}, Numeros: {numeros}, Caracteres Especiais: {caracteresEspeciais}";
            return Ok(retorno);
        }
    }
}