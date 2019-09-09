using Senai.OpFlix.WebApi.Domains;
using Senai.OpFlix.WebApi.Interfaces;
using Senai.OpFlix.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.OpFlix.WebApi.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
    {
        public Usuarios BuscarPorEmailSenha(LoginViewModel dadosLogin)
        {
            using(OpflixContext ctx = new OpflixContext())
            {
                return ctx.Usuarios.FirstOrDefault(x => x.Email.Equals(dadosLogin.Email) && x.Senha == dadosLogin.Senha);               
            }
        }

        public void Cadastrar(Usuarios novoUsuario)
        {
            using(OpflixContext ctx = new OpflixContext())
            {
                ctx.Usuarios.Add(novoUsuario);
                ctx.SaveChanges();
            }
        }
    }
}
