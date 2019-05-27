using System;
using System.Collections.Generic;
using System.IO;
using McBonalds.Models;

namespace McBonalds.Repositories {
    public class HamburguerRepository {
        private const string PATH = "Database/Hamburgueres.csv";

        private static List<Hamburguer> ListaDeHamburgueres = new List<Hamburguer> ();

        public static List<Hamburguer> Listar(){
            ListaDeHamburgueres.Clear();
            var listaNaoTratada = File.ReadAllLines(PATH);
            foreach (var linha in listaNaoTratada)
            {
                if(linha != null){
                var dados = linha.Split(";");
                var hamburguer = new Hamburguer(
                    id:ulong.Parse(dados[0]),
                    nome:dados[1],
                    preco:float.Parse(dados[2])
                );
                ListaDeHamburgueres.Add(hamburguer);
                }
            }
            return ListaDeHamburgueres;
        }
        public static float ObterPrecoDe(string nomeHamburguer){
            ListaDeHamburgueres = Listar();
            float preco = 0;
            foreach (var item in ListaDeHamburgueres)
            {
                if(item.Nome.Equals(nomeHamburguer)){
                    preco = item.Preco;
                }
            }
            return preco;
        }
        public static ulong ObterIdDe(string nomeHamburguer){
            ListaDeHamburgueres = Listar();
            ulong id = 0;
            foreach (var item in ListaDeHamburgueres)
            {
                if(item.Nome.Equals(nomeHamburguer)){
                    id = item.Id;
                }
            }
            return id;
        }
    }
}