using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string passeio = "Montanha";

            switch(passeio) {
                case "deserto": Console.WriteLine("Leva uma água!");break;

                case "Praia": Console.WriteLine("Não se esqueça do protetor solar!");break;

                case "Floresta": Console.WriteLine("Use repelente!");break;

                case "Montanha": Console.WriteLine("Bora escalar!");break;

                default: Console.WriteLine("Bora assistir Netflix, então.");break;
            }
            Console.WriteLine("A aplicação vai acabar agora.");
        }
    }
}
