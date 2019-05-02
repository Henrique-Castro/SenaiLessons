using System.Collections.Generic;
using ToDoList.ModelView;

namespace ToDoList.Repository
{
    public class UsuarioRepository
    {
        private static List<UsuarioModelView> listaDeUsuarios = new List<UsuarioModelView>();

        ///<summary>Insere o usuário cadastrado na plataforma de armazenamento escolhida e também define seu ID com base na quantidade de usuários já existentes.</summary>
        ///<param name="usuarioModelView">Objeto usuário</param>
        ///<returns>Retorna um objeto do tipo UsuarioModelView.</returns>
        public UsuarioModelView InserirUsuario(UsuarioModelView usuarioModelView){
            usuarioModelView.Id = listaDeUsuarios.Count + 1;

            listaDeUsuarios.Add(usuarioModelView);

            return usuarioModelView;
        }

        public static UsuarioModelView BuscarUsuarioPorNome(string nome){
            
            foreach (UsuarioModelView usuario in listaDeUsuarios)
            {
                if(usuario.Nome.Equals(nome)){
                    return usuario;
                }
            }
            return null;
        }
        public static UsuarioModelView BuscarUsuarioPorEmail(string email){
            
            foreach (UsuarioModelView usuario in listaDeUsuarios)
            {
                if(usuario.Email.Equals(email)){
                    return usuario;
                }
            }
            return null;
        }
        public static UsuarioModelView BuscarUsuarioPorId(int id){
            
            foreach (UsuarioModelView usuario in listaDeUsuarios)
            {
                if(usuario.Id == id){
                    return usuario;
                }
            }
            return null;
        }
    }
}