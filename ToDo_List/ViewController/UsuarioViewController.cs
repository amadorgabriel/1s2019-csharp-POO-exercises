using System;
using System.Threading;
using ToDo_List.Repositorio;
using ToDo_List.Utils;
using ToDo_List.ViewModel;

namespace ToDo_List.ViewController
{
    public class UsuarioViewController
    {
        public static int Contador = 0;
        public static UsuarioViewModel UserSelecionado = new UsuarioViewModel();
        public static void CadastrarUsuario()
        { // CADASTRAR USUARIO

            string nome;
            string email;
            string senha;
            string tipoUsuario;

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
                System.Console.WriteLine("Escolha seu tipo de conta: (admin/usuário) ");
                System.Console.WriteLine(" 1 - ADMINISTRADOR ");
                System.Console.WriteLine(" 2 - USUÁRIO");
                System.Console.Write("Código: ");
                int codigo = int.Parse(Console.ReadLine());
                if (1.Equals(codigo))
                {
                    tipoUsuario = "ADMINISTRADOR";
                    break;
                }
                else if (2.Equals(codigo))
                {
                    tipoUsuario = "USUÁRIO";
                    break;
                }
                else
                {
                    System.Console.WriteLine("Código invalido, por favor selecione entre 1 e 2");
                    Thread.Sleep(1000);
                    repetir = false;
                }
            } while (!false);

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

            UsuarioViewModel Usuario = new UsuarioViewModel();
            Usuario.Nome = nome;
            Usuario.Email = email;
            Usuario.Datacriacao = DateTime.Now;
            Usuario.Senha = senha;
            Usuario.Id = Contador;
            Usuario.TipoUsuario = tipoUsuario;

            Contador++;

            UsuarioRepositorio.Inserir(Usuario);

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"Usuario Cadasrado com sucesso!");
            Console.ResetColor();

        }// LOGA USUARIO

        public static void ListarUser()
        {
            foreach (var item in UsuarioRepositorio.Listar())
            {
                System.Console.WriteLine($"ID: {item.Id} - Tipo de Acesso: {item.TipoUsuario} - Nome Usuário: {item.Nome} - Email: {item.Email} - Data de Criação: {item.Datacriacao}");
            }
        }//LISTA USUARIO

        public static bool EfetuarLogin()
        {
            string email;
            string senha;

            System.Console.Write("Digite seu Email: ");
            email = Console.ReadLine();

            System.Console.Write("Digite sua Senha: ");
            senha = Console.ReadLine();

            foreach (var item in UsuarioRepositorio.Listar())
            {
                if (email.Equals(item.Email) && senha.Equals(item.Senha))
                {
                    System.Console.WriteLine("lOGANDO...");
                    Thread.Sleep(2000);
                    UserSelecionado = item;
                    return true;
                }
            }
            System.Console.WriteLine("Email ou senha incorreto(s), PRESS ENTER para voltar ao menu");
            Console.ReadLine();
            return false;
        }



    }
}