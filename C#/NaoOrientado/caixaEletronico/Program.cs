using System;
using System.Collections.Generic;

namespace caixaEletronico {
    class Program {
        static void Main (string[] args) {
            int[] notasDisponiveis = { 100, 50, 20, 10, 5, 2, 1 };
            Console.Write ("Digite o valor você quer sacar: ");
            int saque = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Você receberá: ");
            for (int i = 0; i < notasDisponiveis.Length; i++) {
                int qtnNotas = saque / notasDisponiveis[i];
                saque = saque % notasDisponiveis[i];
                if (saque != 0) {
                    System.Console.WriteLine ($"{qtnNotas} nota(s) de {notasDisponiveis[i]}, ");
                }
            }
        }
    }
}