using System;

namespace sistemaDeNotasArray {
    class Program {
        static void Main (string[] args) {
            // 2) Faça um programa que receba o nome, sobrenome, data de nascimento e 2 notas de 10 alunos e armazene essas

            // informações em vetores distintos. Calcule e imprima:

            // a. O nome completo, idade, média do aluno e se ele foi Aprovador ou reprovado.Para ser aprovado o aluno deve ter média maior ou igual a 50.Efetuar todas a validações possíveis.
            string[] arrayPrimeirosNomes = new string[5],
                arraySobrenomes = new string[5];

            int[] arrayIdades = new int[5];
            float[] arrayNotas1 = new float[5],
                arrayNotas2 = new float[5],
                arrayMedias = new float[5];

            DateTime[] arrayDatasDeNascimento = new DateTime[5];

            for (int i = 0; i < arrayNotas1.Length; i++) {

                System.Console.Write ("Primeiro nome do aluno: ");
                arrayPrimeirosNomes[i] = Console.ReadLine ();

                System.Console.Write ("Sobrenome do aluno: ");
                arraySobrenomes[i] = Console.ReadLine ();

                System.Console.Write ("Data de nascimento (dd/mm/aaaa) : ");
                arrayDatasDeNascimento[i] = DateTime.Parse (Console.ReadLine ());

                System.Console.Write ("Nota 1: ");
                arrayNotas1[i] = float.Parse (Console.ReadLine ());

                System.Console.Write ("Nota 2: ");
                arrayNotas2[i] = float.Parse (Console.ReadLine ());

                arrayMedias[i] = (arrayNotas1[i] + arrayNotas2[i])/2;
                arrayIdades[i] = Convert.ToInt32((DateTime.Today - arrayDatasDeNascimento[i]).TotalDays / 365.242199);
                System.Console.WriteLine($"Aluno {i+1}/10 cadastrado com sucesso, próximo: ");
            }
            
            for (int x = 0; x < arrayNotas1.Length; x++)
            {
                string situacao;
                if(arrayMedias[x] >= 50){
                    situacao = "Aprovado";
                }else{
                    situacao = "Reprovado";
                }
                System.Console.WriteLine($"\nAluno {arrayPrimeirosNomes[x]} {arraySobrenomes[x]}: \n{arrayIdades[x]} anos\n{arrayMedias[x]}\n{situacao}\n------------------------------");
            }
        }
    }
}