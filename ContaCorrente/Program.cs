using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Rodrigues Bank!");

            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "Cesar";
            conta1.numeroConta = 999;
            conta1.agencia = 132;
            conta1.Depositar(10000);

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Tsuka";
            conta2.numeroConta = 01;
            conta2.agencia = 132;
            conta2.Depositar(5000);



            System.Console.WriteLine($"--------Primeira Conta--------");
            System.Console.WriteLine($"Titular: {conta1.titular}");
            System.Console.WriteLine($"Numero Conta: {conta1.numeroConta}");
            System.Console.WriteLine($"Agência: {conta1.agencia}");
            System.Console.WriteLine($"Saldo: {conta1.ExibirSaldo()}");
            System.Console.WriteLine("--------------------------------");

            System.Console.WriteLine($"--------Segunda Conta--------");
            System.Console.WriteLine($"Titular: {conta2.titular}");
            System.Console.WriteLine($"Numero Conta: {conta2.numeroConta}");
            System.Console.WriteLine($"Agência: {conta2.agencia}");
            System.Console.WriteLine($"Saldo: {conta2.ExibirSaldo()}");
            System.Console.WriteLine("--------------------------------");


            // bool valorRetornado = conta1.Sacar(3500);
            // if (valorRetornado)
            // {
            //     System.Console.WriteLine("Parabéns voce conseguiu!");
            // }else{
            //     System.Console.WriteLine("Você não tem dinheiro na sua conta");
            // }
            // System.Console.WriteLine($"Conta depois do saldo: {conta1.ExibirSaldo()}");

            conta2.Tranferir(100, conta1);
            
            System.Console.WriteLine($"O saldo da conta1 é: {conta1.ExibirSaldo()}");
            System.Console.WriteLine($"O saldo da conta2 é: {conta2.ExibirSaldo()}");

        }
    }
}
