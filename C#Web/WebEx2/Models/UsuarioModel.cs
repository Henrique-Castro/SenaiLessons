using System;
namespace WebEx2.Models
{
    public class UsuarioModel
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public string Email{get;set;}
        public string Password{get;set;}
        public DateTime BirthDate{get;set;}

        public UsuarioModel(){

        }
        public UsuarioModel(string name, string email, string password, DateTime birthDate){
            Name = name;
            Email = email;
            Password = password;
            BirthDate = birthDate;
        }
        public UsuarioModel(int id, string name, string email, string password, DateTime birthDate){
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            BirthDate = birthDate;
        }
    }
}