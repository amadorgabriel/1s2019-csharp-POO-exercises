namespace Senai.Revisao.MVC.Util
{
    public class ValidadorUtil
    {
        public static bool ValidarEmail(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarSenha(string senha, string confirmacao)
        {
            if (senha.Equals(confirmacao))
            {
                return true;
            }
            return false;
        }
    }
}