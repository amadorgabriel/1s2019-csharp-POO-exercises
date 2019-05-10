using System.Threading;
namespace FinancaDeMesa.Util {
    public class ValidacoesUtil {
        public static bool ValidarEmail (string email) {
            if (email.Contains ("@") && email.Contains (".")) {
                return true;
            }
            return false;
        }

        public static bool ValidarSenha (string senha, string confirmacaoSenha) {
            if (senha.Length >= 6 && senha.Equals (confirmacaoSenha)) {
                return true;
            }
            return false;
                //CARA SENHA MUITO PEQUENA;

        }
    }
}