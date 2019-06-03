using System;
using Microsoft.Extensions.Primitives;

namespace McBonalds.Models {
    public class Cliente {
        public ulong Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }

        public Cliente () {

        }
        public Cliente (ulong id, string nome, string endereco, string telefone, string email) {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
        }
        public Cliente (string nome, string endereco, string telefone, string email) {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
        }
    }
}