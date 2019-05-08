using System;

namespace PadariaMVC.ViewModel {
    public class UsuarioViewModel : BaseViewModel {
        public string Senha { get; set; }
        public string Email { get; set; }
        
        public UsuarioViewModel (string nome, string email, string senha) {
            Nome = nome;
            Email = email;
            Senha = senha;
            Id = Id++;
        }
        public UsuarioViewModel(){
            
        }
    }
}