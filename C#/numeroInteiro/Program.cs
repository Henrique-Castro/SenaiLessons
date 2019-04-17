using System;

namespace numeroInteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if(n2 == 0){
                Console.WriteLine("O divisor não pode ser igual a zero");
            };
            int result = n1 / n2;
            Console.WriteLine("Resultado: " + result);
        }
    }
}
