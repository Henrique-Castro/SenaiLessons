using System;

namespace recebeFor {
    class Program {
        static void Main (string[] args) {
            string sexo, idade, peso;
            int homens = 0, mulheres = 0, idadeHomens = 0, idadeMulheres = 0;
            float pesoHomens = 0, pesoMulheres = 0;
            System.Console.WriteLine ("Insira os seguintes dados sobre 10 pessoas:");
            for (int i = 1; i <= 10; i++) {

                System.Console.WriteLine ("Sexo (M/F) da pessoa {0} :", i);
                sexo = Console.ReadLine ();

                // (sexo[i].Equals("M",StringComparison.CurrentCultureIgnoreCase)) ? homens++ : 
                // (sexo[i].Equals("F",StringComparison.CurrentCultureIgnoreCase)) ? mulheres++ : 
                // System.Console.WriteLine("Use apenas uma das siglas (M ou F)");

                if (sexo.Equals ("M", StringComparison.CurrentCultureIgnoreCase)) {

                    homens++;
                    System.Console.WriteLine ("Idade da pessoa {0} :", i);
                    idadeHomens = idadeHomens + int.Parse (Console.ReadLine ());
                    System.Console.WriteLine ("Peso da pessoa {0} :", i);
                    pesoHomens = pesoHomens + float.Parse (Console.ReadLine ());

                } else if (sexo.Equals ("F", StringComparison.CurrentCultureIgnoreCase)) {

                    mulheres++;
                    System.Console.WriteLine ("Idade da pessoa {0} :", i);
                    idadeMulheres = idadeMulheres + int.Parse (Console.ReadLine ());
                    System.Console.WriteLine ("Peso da pessoa {0} :", i);
                    pesoMulheres = pesoMulheres + float.Parse (Console.ReadLine ());

                } else {
                    System.Console.WriteLine ("Use apenas uma das siglas (M ou F)");
                    Environment.Exit (0);

                }
                // (sexo[i].Equals("M",StringComparison.CurrentCultureIgnoreCase)) ? idadeHomens = idadeHomens + int.Parse(Console.ReadLine()) :
                // (sexo[i].Equals("F",StringComparison.CurrentCultureIgnoreCase)) ? idadeMulheres = idadeMulheres + int.Parse(Console.ReadLine()) :
                // System.Console.WriteLine("Digite uma idade e sexo válidos");break;

            }
            System.Console.WriteLine ("Total de homens: {0}\nTotal de mulheres: {1}\nMédia de idade dos homens: {2} anos\nMédida de idade das mulheres: {3} anos\nMédia de peso dos homens: {4}kg\nMédia de peso das mulheres: {5}kg",
                homens, mulheres, (idadeHomens / homens), (idadeMulheres / mulheres), (pesoHomens / homens), (pesoMulheres / mulheres));

        }
    }
}