using System.Collections.Generic;
using System.IO;
using McBonalds.Models;

namespace McBonalds.Repositories
{
    public class ShakeRepository
    {
        private const string PATH = "Database/Shakes.csv";

        private static List<Shake> ListaDeShakes = new List<Shake> ();

        public static List<Shake> Listar(){
            ListaDeShakes.Clear();
            var listaNaoTratada = File.ReadAllLines(PATH);
            foreach (var linha in listaNaoTratada)
            {
                if(linha != null){
                var dados = linha.Split(";");
                var shake = new Shake(
                    id:ulong.Parse(dados[0]),
                    nome:dados[1],
                    preco:float.Parse(dados[2])
                );
                ListaDeShakes.Add(shake);
                }
            }
            return ListaDeShakes;
        }
        public static double ObterPrecoDe(string nomeShake){
            ListaDeShakes = Listar();
            double preco = 0;
            foreach (var item in ListaDeShakes)
            {
                if(item.Nome.Equals(nomeShake)){
                    preco = item.Preco;
                }
            }
            return preco;
        }
        public static ulong ObterIdDe(string nomeShake){
            ListaDeShakes = Listar();
            ulong id = 0;
            foreach (var item in ListaDeShakes)
            {
                if(item.Nome.Equals(nomeShake)){
                    id = item.Id;
                }
            }
            return id;
        }
    }
}