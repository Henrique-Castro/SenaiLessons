using System;
namespace classes {
    public class Usuario {
        string nome, senha, cpf, email;

        public void setNome(string nome){
            this.nome = nome;
        }
        public string getNome(string nome){
            return this.nome;
        }

        public void setCpf(string cpf) {
            this.cpf = cpf;
        }
        public string getCpf() {
            return this.cpf;
        }

        public void setSenha (string senha) {
            this.senha = senha;
        }
        public string getSenha () {
            return this.senha;
        }

    }
}