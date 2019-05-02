namespace ToDo_List.Utils
{
    public class ValidadoresUtil
    {
        //VALIDADOR NOME COMPLETO

        public static bool ValNomeCompleto(string nome)
        {
            if (nome.Contains(" "))
            {
                return true;
            }
            return false;
        }

        public static bool ValEmail(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }
            return false;
        }

        public static bool ValSenha(string senha)
        {
            if (senha.Length < 5)
            {
                return false;
            }
            return true;
        }
    }
}