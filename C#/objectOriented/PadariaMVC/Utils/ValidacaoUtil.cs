using System.Reflection.Metadata;
using PadariaMVC.Utils.Enums;
using PadariaMVC.ViewController;

namespace PadariaMVC.Utils {
    public class ValidacaoUtil {
        ///<summary>Valida o nome do Usuário, verifica se o mesmo está vazio ou é nulo.</summary>
        ///<param name="nome">Email do usuário</param>
        ///<returns>Retorna true caso o nome seja válido, caso contrário retorna false</returns>
        public static bool ValidarNome (string nome) {
            if (string.IsNullOrEmpty (nome)) {
                return false;
            }
            return true;
        }
        ///<summary>Valida o email do Usuário, verifica se o mesmo possui "@" e ".", verifica se o tamanho do email é maior que 5.</summary>
        ///<param name="email">Email do usuário</param>
        ///<returns>Retorna true caso o email seja válido, caso contrário retorna false</returns>
        public static bool ValidarEmail (string email) {
            if (!email.Contains ("@") && !email.Contains (".") && email.Length <= 5) {
                return false;
            }
            return true;
        }
        ///<summary>Valida a senha do Usuário, verifica se a mesma é igual à sua confirmação, varifica se o tamanho da senha é maior que 5.</summary>
        ///<param name="senha">Senha do usuário</param>
        ///<returns>Retorna true caso a senha seja válida, caso contrário retorna false</returns>
        public static bool ValidarSenha (string senha, string confirmacaoSenha) {
            if (senha.Equals (confirmacaoSenha) && senha.Length <= 5) {
                System.Console.WriteLine ("A senha e a confirmação devem serem iguais e ter 6 ou mais caracteres.");
                return false;
            }
            else if (senha.Equals (confirmacaoSenha) && senha.Length > 5) {
                return true;
            }
            Mensagem.MostrarMensagem("Houve um erro, por favor, tente novamente.", TipoMensagemEnum.ERRO);
            return false;
        }
        public static bool ValidarPreco(string precoString, float preco){
            if(float.TryParse(precoString, out preco)){
                return true;
            }return false;
        }
       //Override
        public static bool ValidarPreco(float preco){
            if(preco > 0){
                return true;
            }return false;
        }
        
    }
}