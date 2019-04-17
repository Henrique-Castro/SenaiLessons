using System;

namespace vrumAirLinesOO {
    public class Passageiro {

        string nome, numero;
        DateTime data;
        
        public void setNome(string nome){
            this.nome = nome;
        }
        public string getNome(){
            return this.nome;
        }
        public void setNumero(string numero){
            this.numero = numero;
        }
        public string getNumero(){
            return this.numero;
        }
        public void setData(DateTime data){
            this.data = data;
        }
        public DateTime getData(){
            return this.data;
        }


    }
}