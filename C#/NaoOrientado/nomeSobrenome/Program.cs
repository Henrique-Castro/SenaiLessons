using System;

namespace nomeSobrenome {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Digite o seu primeiro nome:");
            string nome = Console.ReadLine ();
            Console.WriteLine ("Digite o seu sobrenome:");
            string sobrenome = Console.ReadLine ();
            string nomeCompleto = nome + " " + sobrenome;
            Console.WriteLine ("Bem vindo, " + nomeCompleto);
        }
    }
}