using System.Threading;
using FinancaDeMesa.ViewModel;

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

        public static bool ValidarValorTransacao(double valor, double confirmacaoValor){
            if (valor.Equals(confirmacaoValor))
            {
                return true;
            }
            return false;
        }
    }
}