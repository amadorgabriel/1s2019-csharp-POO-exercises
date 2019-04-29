using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            System.Console.Write("Digite sua senha: ");
            usuario.setSenha(Console.ReadLine()); //gravou a senha no Usuario
            string senha = usuario.getSenha();//
            System.Console.WriteLine($"Sua senha é {senha}");
        }
    }
}
