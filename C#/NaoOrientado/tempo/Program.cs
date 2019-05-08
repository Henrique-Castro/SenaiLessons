using System;

namespace tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Como está o tempo?\n(Frio/Calor/Chuva)");
            string tempo = Console.ReadLine();
             if(tempo.Equals("Frio")){
                 Console.WriteLine("Vamos à montanha");
             }if(tempo.Equals("Calor")){
                 Console.WriteLine("Vamos à praia");
             }if(tempo.Equals("Chuva")){
                 Console.WriteLine("Vamos para a Steam?\nS/N");
                 string steam = Console.ReadLine();
                 if(steam.Equals("N")){
                     Console.WriteLine("Vamos para o Netflix, então.");
                 }
             }
        }
    }
}
