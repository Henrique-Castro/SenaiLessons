using System;

namespace array1 {
    class Program {
        static void Main (string[] args) {
            int pares = 0, impares = 0;
            int[] array = new int[15];
            Random r = new Random ();

            for (int i = 0; i < array.Length; i++) {
                array[i] = r.Next (0, 1000);
                int resultado = 0;
                resultado = array[i] % 2;
                // System.Console.WriteLine(array[i]);
                if (resultado != 0) {
                    impares++;
                } if (resultado == 0) {
                    pares++;
                }
            }
            System.Console.WriteLine ($"Existem {impares} números ímpares e {pares} números pares no array.");
            System.Console.WriteLine ("Quer saber quais são?");
            if (Console.ReadLine ().Equals ("Sim", StringComparison.CurrentCultureIgnoreCase)) {
                for (int x = 0; x < array.Length; x++) {
                    System.Console.WriteLine ("Número {0} -  {1}", x + 1, array[x]);
                }
            }
            Environment.Exit (0);
        }
    }
}