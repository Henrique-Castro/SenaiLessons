using System;
using DesafioSala.enums;

namespace DesafioSala.classes {
    public class Aluno {

        public string Nome { get; set; }
        public string Curso { get; set; }
        public int NumeroSala { get; set; }
        static int contador = 0;
        DateTime DataNascimento { get; set; }
        public static Aluno[] ArrayAlunos = new Aluno[1000];
        public Aluno (string nome, string curso, int numeroSala, DateTime dataNascimento) {
            Nome = nome;
            Curso = curso;
            NumeroSala = numeroSala;
            DataNascimento = dataNascimento;
        }
        public static void CadastrarAluno () {
            System.Console.Write ("Nome do aluno: ");
            string nomeAluno = Console.ReadLine ();

            System.Console.Write ("Número da sala: ");
            int numeroSala = int.Parse (Console.ReadLine ());

            System.Console.Write ("Curso: ");
            string curso = Console.ReadLine ();

            System.Console.Write ("Data de nascimento: ");
            DateTime dataNascimento = DateTime.Parse (Console.ReadLine ());

            ArrayAlunos[contador] = new Aluno (nomeAluno, curso, numeroSala, dataNascimento);
            contador++;
            
            Program.MostrarMensagem($"Cadastro de aluno efetuado com sucesso.", TipoMensagemEnum.SUCESSO);
            
        }

        static string VerificarAlunos () {
            foreach (var aluno in ArrayAlunos) {
                if (aluno == null) {
                    return "Não há alunos cadastrados";
                }
                return $"-----------------------------\nAluno: {aluno.Nome}\nNúmero da sala: {aluno.NumeroSala}\nCurso: {aluno.Curso}";
            }
            return "";
        }
    }
}