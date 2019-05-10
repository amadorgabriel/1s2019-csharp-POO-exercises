using System;
using System.Threading;
using FinancaDeMesa.Repositorio;
using FinancaDeMesa.Util;
using FinancaDeMesa.ViewController;
using FinancaDeMesa.ViewModel;

namespace FinancaDeMesa.ViewController {
    public class UsuarioViewController {
        public static void CadastrarUsuario () {

            string nome, email, senha, confirmacaoSenha;
            bool repetir = false;

            System.Console.Write ("Digite seu nome completo: ");
            nome = Console.ReadLine ();

            do {
                System.Console.Write ("Digite seu email: ");
                email = Console.ReadLine ();

                if (!ValidacoesUtil.ValidarEmail (email)) {
                    System.Console.WriteLine ("Email Inválido, digite novamente..");
                    Thread.Sleep (2000);
                    repetir = false;
                } else {
                    repetir = true;
                }
            } while (!repetir);

            do {

                System.Console.Write ("Digite sua senha: ");
                senha = Console.ReadLine ();

                System.Console.Write ("Digite sua senha novamente: ");
                confirmacaoSenha = Console.ReadLine ();

                if (!ValidacoesUtil.ValidarSenha (senha, confirmacaoSenha)) {
                    System.Console.WriteLine ("Senhas muito curtas ou não compatíveis..");
                    Thread.Sleep (2000);
                    repetir = false;
                } else {
                    repetir = true;
                }

            } while (!repetir);

            UsuarioViewModel usuario = new UsuarioViewModel();

            usuario.Email = email;
            usuario.Senha = senha;
            usuario.DataCriacao = DateTime.Now;

            //INSERIR USUÁRIO A LISTA
            UsuarioRepositorio.InserirUsuario(usuario);
            //INSERIR USUARIO

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine ($"Cadastro do usuario {} realizado com sucesso!");
            Console.ResetColor ();
            Thread.Sleep (2000);
        }

        public static void LogarUsuario () {

        }

    }
}