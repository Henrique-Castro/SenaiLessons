using System;

namespace sistemaNotas {
    class Program {
        static void Main (string[] args) {
            float b1, b2, b3;

            //Nota 1º Bimestre
            receberB1:
            Console.WriteLine ("\nNota do 1º bimestre: ");
            b1 = Convert.ToSingle (Console.ReadLine ());
            if(b1<0 || b1>10){
                Console.WriteLine("\nAs notas podem ser apenas de 0 a 10.");
                goto receberB1;
            }
            //Nota 2º Bimestre
            receberB2:
            Console.WriteLine ("\nNota do 2º bimestre");
            b2 = Convert.ToSingle (Console.ReadLine ());
            if(b2<0 || b2>10){
                Console.WriteLine("\nAs notas podem ser apenas de 0 a 10.");
                goto receberB2;
            }
            //Nota 3º Bimestre
            receberB3:
            Console.WriteLine ("\nNota do 3º bimestre: ");
            b3 = Convert.ToSingle (Console.ReadLine ());
            if(b3<0 || b3>10){
                Console.WriteLine("\nAs notas podem ser apenas de 0 a 10.");
                goto receberB3;
            }
            //Resultado
            float media = (b1 + b2 + b3) / 3;
            if (media < 5) {
                Console.WriteLine ("\nReprovado. \nMédia: " + media);
            } else if (media >= 5 && media < 9) {
                Console.WriteLine ("\nAprovado. \nMédia: " + media);
            } else {
                Console.WriteLine ("\nÉ isso aí, jovem! \nMédia: " + media);
            }
        }
    }
}