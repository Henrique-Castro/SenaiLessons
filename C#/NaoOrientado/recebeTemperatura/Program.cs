using System;

namespace recebeTemperatura {
    class Program {
        static void Main (string[] args) {
            float[] mesesFloat = new float[14];
            string[] arrayMesesString = {
                "Janeiro",
                "Fevereiro",
                "Março",
                "Abril",
                "Maio",
                "Junho",
                "Julho",
                "Agosto",
                "Setembro",
                "Outubro",
                "Novembro",
                "Dezembro"
            };

            string maiorMes="", menorMes="";
            float maiorTemp = 0, menorTemp = 0;
            System.Console.WriteLine ("Insira a temperatura média de cada mês do ano: ");
            for (int i = 0; i < arrayMesesString.Length; i++)
            {
                System.Console.Write (arrayMesesString[i] + ": ");
                mesesFloat[i] = float.Parse(Console.ReadLine ());
                if (mesesFloat[i] < mesesFloat[i]) {
                    menorMes = arrayMesesString[i];
                    menorTemp = mesesFloat[i];
                }
                if (mesesFloat[i] > maiorTemp) {
                    maiorMes = arrayMesesString[i];
                    maiorTemp = mesesFloat[i];
                }
            }
            System.Console.WriteLine ($"A maior temperatura média do ano foi {maiorTemp}ºC no mês de {maiorMes} e a menor foi {menorTemp}ºC em, {menorMes}.");

        }
    }
}