using System;

namespace idadeFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int menores = 0, maiores = 0;
            System.Console.WriteLine("Insira a idade de 10 pessoas em ordem: ");
            for(int i = 1; i <= 10; i++){
                    System.Console.WriteLine("Idade da pessoa {0} :", i);
                    int idade = int.Parse(Console.ReadLine());
                    if(idade > 0 && idade <18){
                        menores++;
                    }else if(idade >=18){
                        maiores++;
                    }
            }
            System.Console.WriteLine("Das pessoas registradas, {0} são menores e {1} são maiores de idade", menores, maiores);
        }
    }
}
