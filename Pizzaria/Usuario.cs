using System;
// using System.DateTime;

namespace Pizzaria
{
    public class Usuario
    {
        //ADICIONAR CONTADOR
        public static int quantUsuarios = 0;

        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public DateTime dataCriacao { get; set; }

        public static void Inserir()
        {
            string nome;
            string email;
            string senha;
            DateTime dataCriacao = DateTime.Now; 


            System.Console.Write("Digite seu nome completo: ");
            nome = Console.ReadLine();

            do
            {
                System.Console.Write("Digite sua Email: ");
                email = Console.ReadLine();
                if (!email.Contains("@") || !email.Contains("."))
                {
                    System.Console.WriteLine("Email não encontrado!");
                }

            } while (!email.Contains("@") || !email.Contains("."));

            do
            {
                System.Console.Write("Digite sua Senha: ");
                senha = Console.ReadLine();

                if (senha.Length < 6)
                {
                    System.Console.WriteLine("Senha muito curta!");
                }
            } while (senha.Length < 6);

            System.Console.WriteLine($"Usuário cadastrado com Sucesso na data{dataCriacao}");

            quantUsuarios ++;

            
            

        }

    }
}