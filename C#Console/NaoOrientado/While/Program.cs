using System;

namespace While {
    class Program {
        static void Main (string[] args) {
            // System.Console.WriteLine ("Qual número da táboada do {0} você quer?", taboada);
            // int numero = int.Parse (Console.ReadLine ());
            inicio:

                System.Console.WriteLine ("Qual taboada você quer saber? ");
            int taboada = int.Parse (Console.ReadLine ());
            int contador = 0;
            while (contador >= 0 && contador < 11) {
                int resultado = contador * taboada;
                System.Console.WriteLine ("{0} x {1} = {2}", contador, taboada, resultado);
                contador++;
            }
            System.Console.WriteLine("Quer ver alguma outra taboada? ");
            string dnv = Console.ReadLine();
            
            switch(dnv){
                case "sim": goto inicio;

                case "não": break;

                default: System.Console.WriteLine("Não faço ideia do que você escreveu, colabora aí.");break;
            }
        }
    }
}