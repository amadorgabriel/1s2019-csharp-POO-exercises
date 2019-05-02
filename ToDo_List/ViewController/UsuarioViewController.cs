using System;
using System.Threading;
using ToDo_List.Utils;

namespace ToDo_List.ViewController
{
    public class UsuarioViewController
    {
        public static void CadastrarUsuario()
        { // CADASTRAR USUARIO

            string nome;
            string email;
            string senha;

            bool repetir = false;
            do
            {
                Console.Clear();

                System.Console.Write("Digite seu nome completo: ");
                nome = Console.ReadLine();

                if (!ValidadoresUtil.ValNomeCompleto(nome))
                {
                    System.Console.WriteLine("O formato de nome está incoreto");
                    Thread.Sleep(2000);
                }
            } while (!ValidadoresUtil.ValNomeCompleto(nome));

            Thread.Sleep(2000);

            do
            {
                System.Console.Write("Digite seu Email: ");
                email = Console.ReadLine();
                ValidadoresUtil.ValEmail(email);
                if (!ValidadoresUtil.ValEmail(email))
                {
                    System.Console.WriteLine("O formato de Email está incorreto");
                    Thread.Sleep(2000);
                }
            } while (!ValidadoresUtil.ValEmail(email));

            Thread.Sleep(2000);

            do
            {
                System.Console.Write("Digite sua senha: ");
                senha = Console.ReadLine();
                if (!ValidadoresUtil.ValSenha(senha))
                {
                    System.Console.WriteLine("A senha possui menos de cinco caracteres, digite novamente");
                    Thread.Sleep(2000);
                }
            } while (!ValidadoresUtil.ValSenha(senha));

            //------------------------------------------------------------------------------------

            UsuarioViewController Usuario = new UsuarioViewController();
            

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"Usuario Cadasrado com sucesso!");
            Console.ResetColor(); 
        

        

        }
        // LOGA USUARIO
    }
}