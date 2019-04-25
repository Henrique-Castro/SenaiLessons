using System;
using System.Globalization;
using DesafioSala.classes;
using DesafioSala.enums;

namespace DesafioSala {
    class Program {
    static void Main (string[] args) {
    do {
    MostrarMenu ();

    switch (int.Parse (Console.ReadLine ())) {
    case 1:
    Aluno.CadastrarAluno ();
    continue;
    case 2:
    Sala.CadastrarSala ();
    continue;
    case 3:
    Sala.AlocarAluno ();
    continue;
    case 0:
    break;
    default:
    break;
                }
            } while (true);
        }

        public static void MostrarMensagem (string mensagem, TipoMensagemEnum tipoMensagem) {
            switch (tipoMensagem) {
                case TipoMensagemEnum.SUCESSO:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case TipoMensagemEnum.ERRO:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case TipoMensagemEnum.ALERTA:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case TipoMensagemEnum.DESTAQUE:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
            }
            System.Console.WriteLine (mensagem);
            Console.ResetColor ();

            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
            Console.ReadLine ();

        }
        public static Aluno BuscarAlunoPorNome (string nomeAluno, Aluno[] arrayAlunos) {
            foreach (Aluno aluno in arrayAlunos) {
                if (aluno == null) {
                    MostrarMensagem ("Não há alunos cadastrados.", TipoMensagemEnum.ERRO);
                    return null;
                }
                if (aluno.Nome.Equals (nomeAluno)) {
                    return aluno;
                }
            }
            return null;
        }
        public static Sala BuscarSalaPorNumero (int numeroSala, Sala[] arraySalas) {
            foreach (Sala sala in arraySalas) {
                if (sala == null) {
                    MostrarMensagem ("Não há salas cadastradas.", TipoMensagemEnum.ERRO);
                    return null;
                }
                if (sala.NumeroSala == numeroSala) {
                    return sala;
                }
            }
            return null;
        }
        public static bool ValidarAlocarOuRemover () {
            
            return true;
        }
        public static void MostrarMenu () {
            string[] menu = {
                "=======================================",
                "||             M E N U               ||",
                "||       1- Cadastrar aluno          ||",
                "||       2- Cadastrar sala           ||",
                "||       3- Alocar aluno             ||",
                "||       4- Remover aluno            ||",
                "||       5- Verificar salas          ||",
                "||       6- Verificar alunos         ||",
                "||       0- Sair                     ||",
                "======================================="
            };
            Console.Clear ();
            foreach (string linha in menu) {
                System.Console.WriteLine (linha);
            }
        }
    }
}