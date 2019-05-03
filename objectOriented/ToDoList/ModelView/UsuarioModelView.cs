using System;
namespace ToDoList.ModelView
{
    public class UsuarioModelView : BaseModelView
    {
        public string Email;
        public string Senha, Tipo;

        public UsuarioModelView(){

        }
        public UsuarioModelView(string nome, string email, string senha, string tipo){
            Nome = nome;
            Email = email;
            Senha = senha;
            Tipo = tipo;
            DataCriacao = DateTime.Now;
            Id = Id++;
        }
        
    }
}