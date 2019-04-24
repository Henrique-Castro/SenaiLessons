using System;
using Desafio1.enums;

namespace Desafio1 {
    class Program {
        static void Main (string[] args) {
            Aluno[] aluno = new Aluno[5];
            Sala[] sala = new Sala[5];
            Sala s = new Sala ();
            Aluno a = new Aluno ();
            Aluno alunoRecuperado = new Aluno ();
            Sala salaRecuperada = new Sala ();
            int contadorSala = 0, contadorAluno = 0;
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
                        if (contadorAluno > 5) {
                            System.Console.WriteLine ("O limite máximo de alunos foi atingido. Aperto ENTER para voltar ao menu.");

                        }

                        System.Console.Write ("Nome do aluno: ");
                        nomeAluno = Console.ReadLine ();
                        System.Console.Write ("Curso: ");
                        curso = Console.ReadLine ();
                        System.Console.Write ("Data de nascimento (dd/mm/aaaa): ");
                        dataNascimento = DateTime.Parse (Console.ReadLine ());

                        a.setNome (nomeAluno);
                        a.setCurso (curso);
                        a.setDataNascimento (dataNascimento);

                        aluno[contadorAluno] = a;

                        contadorAluno++;
                        continue;

                    case "2":

                        System.Console.Write ("Número da sala: ");
                        numeroSala = int.Parse (Console.ReadLine ());
                        System.Console.Write ("Capacidade Total:");
                        s.capacidadeTotal = int.Parse (Console.ReadLine ());
                        s.capacidadeAtual = s.capacidadeTotal;
                        s.setNumeroSala (numeroSala);

                        sala[contadorSala] = s;
                        contadorSala++;

                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine ("Cadastro efetuado com sucesso.");
                        Console.ResetColor ();

                        System.Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                        Console.ReadLine ();
                        continue;

                    case "3":
                        if (contadorAluno == 0 || contadorSala == 0) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ($"Não há aluno ou sala cadastrado(a)");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }
                        System.Console.Write ("Nome do aluno: ");
                        nomeAluno = Console.ReadLine ();

                        foreach (var item in aluno) {
                            if (item != null && item.Equals (item.nome)) {
                                alunoRecuperado = item;
                                break;
                            }
                            System.Console.WriteLine ("Não eixstem alunos cadastrados");
                        }
                        if (alunoRecuperado == null) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ($"Não há aluno cadastrado com o nome {alunoRecuperado}");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        System.Console.WriteLine ("Número da sala destino: ");
                        numeroSala = int.Parse (Console.ReadLine ());
                        foreach (var item in sala) {
                            if (item != null && item.Equals (item.numeroSala)) {
                                salaRecuperada = item;
                                break;
                            }
                            System.Console.WriteLine ("Não eixstem salas cadastradas com esse número");
                        }
                        if (salaRecuperada == null) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ($"Não há sala cadastrada com o número {salaRecuperada}");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine (salaRecuperada.Alocar (alunoRecuperado.nome));
                        Console.ResetColor ();

                        System.Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                        Console.ReadLine ();
                        continue;
                    case "4":
                            if (contadorAluno == 0 || contadorSala == 0) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ($"Não há aluno ou sala cadastrado(a)");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }
                        System.Console.Write ("Número da sala: ");
                        numeroSala = int.Parse(Console.ReadLine ());

                        foreach (var item in sala) {
                            if (item != null && item.Equals (item.numeroSala)) {
                                salaRecuperada = item;
                                break;
                            }
                            System.Console.WriteLine ("Não eixstem salas cadastradas com esse número");
                        }

                        continue;
                    case "5":
                        if (contadorAluno == 0) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ($"Não há sala cadastrada");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }
                        foreach (var item in sala) {
                            if (item != null) {
                                string[] listarSala = {
                                "----------------------------",
                                $"Número da sala{item.numeroSala}",
                                $"Vagas Disponíveis{item.capacidadeAtual}",
                                "----------------------------"
                                };
                                foreach (string linha in listarSala) {
                                    System.Console.WriteLine (linha);
                                }
                            }
                        }
                        continue;
                    case "6":
                        if (contadorAluno != 0) {
                            System.Console.WriteLine ("Os alunos cadastrados são:");
                            foreach (var item in aluno) {
                                System.Console.WriteLine ($"{item.nome} sala{item.numeroSala}");
                            }
                        }
                        continue;
                    default:
                        break;
                }
            }
        }
    
    
    
    
    static void MostrarMensagem(string mensagem, TipoMensagemEnum tipoMensagem){
        switch(tipoMensagem){

        }
        
    }
    }

}