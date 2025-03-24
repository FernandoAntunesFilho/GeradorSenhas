using System.ComponentModel.DataAnnotations;
using System.Text;
using GeradorSenhas.src.Core;

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

            string stringBase = MountStringBase(maiusculas, minusculas, numeros, especiais);

            string senha = GeneratePassword(stringBase);

            return senha;
        }

        private string GeneratePassword(string stringBase)
        {
            if (string.IsNullOrEmpty(stringBase) || stringBase.Length == 0)
                return string.Empty;

            Random random = new Random();
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < 12; i++)
            {
                char caractereAleatorio = stringBase[random.Next(stringBase.Length)];
                resultado.Append(caractereAleatorio);
            }

            return resultado.ToString();
        }

        private static string MountStringBase(bool maiusculas, bool minusculas, bool numeros, bool especiais)
        {
            var stringBase = string.Empty;

            stringBase = maiusculas ? stringBase += PasswordConstants.Maiusculas : stringBase;
            stringBase = minusculas ? stringBase += PasswordConstants.Minusculas : stringBase;
            stringBase = numeros ? stringBase += PasswordConstants.Numeros : stringBase;
            stringBase = especiais ? stringBase += PasswordConstants.Especiais : stringBase;
            return stringBase;
        }
    }
}