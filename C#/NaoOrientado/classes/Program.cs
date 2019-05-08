using System;
namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();

            System.Console.WriteLine("Qual o seu nome?");
            usuario.setNome(Console.ReadLine());

            System.Console.WriteLine("Digite sua senha");
            usuario.setSenha(Console.ReadLine());

            string senha = usuario.getSenha();
            System.Console.WriteLine($"Sua senha é {senha}");
        }
    }
}
