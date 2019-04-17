using System;
namespace Desafio1 {
    class Program {
        static void Main (string[] args) {
            // Aluno[] dadosAlunos = new Aluno[5]; ????????????
            Sala[] alunosSala = new Sala[5];
            Aluno aluno = new Aluno ();
            Sala sala = new Sala ();
            string[] arrayAlunos = new string[5];
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

            int i = 0;

            while (true) {

                string nomeAluno, curso;
                DateTime dataNascimento;
                int numeroSala;
                //Exibir menu:
                foreach (string linha in menu) {
                    System.Console.WriteLine (linha);
                }

                switch (Console.ReadLine ()) {
                    case "1":
                        System.Console.Write ("Nome do aluno: ");
                        nomeAluno = Console.ReadLine ();
                        System.Console.Write ("Curso: ");
                        curso = Console.ReadLine ();
                        System.Console.Write ("Data de nascimento (dd/mm/aaaa): ");
                        dataNascimento = DateTime.Parse (Console.ReadLine ());

                        aluno.setNome (nomeAluno);
                        aluno.setCurso (curso);
                        aluno.setDataNascimento (dataNascimento);
                        // arrayAlunos[i] = dadosAlunos ??????????????
                        i++;
                        continue;

                    case "2":
                        System.Console.Write ("Número da sala: ");
                        numeroSala = int.Parse (Console.ReadLine ());
                        sala.setNumeroSala (numeroSala);
                        continue;

                    case "3":
                        System.Console.Write ("Nome do aluno: ");
                        string nome = Console.ReadLine ();
                        System.Console.WriteLine ("Número da sala destino: ");
                        int numero = int.Parse (Console.ReadLine ());

                        // sala.Alocar (nome, ) ???????????????
                        continue;
                    default:
                        break;
                }
            }
        }
    }
}