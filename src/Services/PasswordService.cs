using System.ComponentModel.DataAnnotations;

namespace GeradorSenhas.src.Services
{
    public class PasswordService
    {
        public string NewPassword(bool maiusculas, bool minusculas, bool numeros, bool especiais)
        {
            if (maiusculas == false &&
                minusculas == false &&
                numeros == false &&
                especiais == false) throw new ValidationException("Pelo menos uma opção deve ser selecionada");
            
            return string.Empty;
        }
    }
}