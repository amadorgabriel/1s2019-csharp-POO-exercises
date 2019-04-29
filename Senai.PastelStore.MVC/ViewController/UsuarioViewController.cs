using System;
using Senai.PastelStore.MVC.Utils;
using Senai.PastelStore.MVC.ViewModel;

namespace Senai.PastelStore.MVC.ViewController {
    public class UsuarioViewController {
        public static void CadastrarUsuario () {
            string nome, email, senha, confirmaSenha;

            do { //DIGITAR NOME
                System.Console.Write ("Digite seu nome: ");
                nome = Console.ReadLine ();

                if (string.IsNullOrEmpty (nome)) // MÉTODO PRÓPRIO PARA ANALIDAR STRINGS
                {
                    System.Console.WriteLine ("Nome Inválido!");
                }
            } while (string.IsNullOrEmpty (nome));

            do { //DIGITAR EMAIL
                System.Console.Write ("Digite seu email: ");
                email = Console.ReadLine ();
                if (ValidacoesUtil.ValidadorDeEmail (email)) {
                    System.Console.WriteLine ("Email inválido");
                }
            } while (ValidacoesUtil.ValidadorDeEmail (email));

            do { //DIGITAR SENHA 2 VEZES
                System.Console.Write ("Digite sua senha: ");
                senha = Console.ReadLine ();

                System.Console.Write ("Confirme a senha: ");
                confirmaSenha = Console.ReadLine ();

                if (!ValidacoesUtil.ValidadorDeSenha(senha, confirmaSenha))
                {
                    System.Console.WriteLine("Senha Inválida");
                }

            } while (!ValidacoesUtil.ValidadorDeSenha(senha, confirmaSenha));

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            



        }
    }
}