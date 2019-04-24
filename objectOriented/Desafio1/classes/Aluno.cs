using System;

namespace Desafio1 {
    public class Aluno {
        public string nome, curso;
        public DateTime dataNascimento;
        public int numeroSala;

        //SETTERS
        public void setNome(string nome){
            this.nome = nome;
        }
        public void setCurso(string curso){
            this.curso = curso;
        }
        public void setNumeroSala(int numeroSala){
            this.numeroSala = numeroSala;
        }
        public void setDataNascimento(DateTime dataNascimento){
            this.dataNascimento = dataNascimento;
        }

        //GETTERS
        public string getNome(){
            return nome;
        }
        public string getCurso(){
            return curso;
        }
        public int getNumeroSala(){
            return numeroSala;
        }
        public DateTime getDataNascimento(){
            return dataNascimento;
        }       
    }
}