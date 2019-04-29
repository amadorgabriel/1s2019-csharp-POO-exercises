using System;

namespace TsukaAirLines
{
    class Program
    {
        static void Main(string[] args)
        {

            bool sair = false;
            Passageiro[] passageiros = new Passageiro[2];
            int numPassageiros = 0;
            Console.WriteLine("----------Bem Vindo a TsukaAirLines!-----------");

            do
            {
                System.Console.WriteLine("Escolha uma opção: ");
                System.Console.WriteLine("1 - Registrar passageiro ");
                System.Console.WriteLine("2 - Exibir passageiros ");
                System.Console.WriteLine("0 - Sair ");
                System.Console.WriteLine("-------------------------------------------");
                int codigo = int.Parse(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        Passageiro p = new Passageiro();
                        System.Console.Write("Digite seu nome: ");
                        p.setNome(Console.ReadLine());
                        passageiros[numPassageiros] = p;
                        numPassageiros++;
                        System.Console.WriteLine("Cadastro Concluído!");
                        break;

                    case 2: ///
                        System.Console.WriteLine("Todos passageiros cadastrados são: ");
                        foreach (var passageiro in passageiros)
                        {
                            if (passageiro != null)
                            {
                                
                            System.Console.WriteLine(passageiro.getNome());
                            }

                        }

                        break;

                    case 0:

                        break;

                    default:

                        break;


                }

            } while (!sair);


        }
    }
}
