using System;
using DesafioSala.enums;

namespace DesafioSala.classes {
    public class Sala {
    static int ContadorSala = 0;
        public int NumeroSala { get; set; }
        public int CapacidadeAtual { get; set; }
        public int CapacidadeTotal { get; set; }
        public static string[] Alunos { get; set; }

        public static Sala[] ArraySalas = new Sala[10];
        public Sala (int numeroSala, int capacidadeAtual, int capacidadeTotal) {
            NumeroSala = numeroSala;
            CapacidadeAtual = capacidadeAtual;
            CapacidadeTotal = capacidadeTotal;
        }
        public static void CadastrarSala () {
            System.Console.Write ("Digite o número da sala: ");
            int numeroSala = int.Parse (Console.ReadLine ());

            System.Console.Write ("Capacidade total da sala (Máx. 5): ");
            int capacidadeTotal = int.Parse (Console.ReadLine ());

            ArraySalas[ContadorSala] = new Sala (numeroSala, capacidadeTotal, capacidadeTotal);
            ContadorSala++;
            Program.MostrarMensagem ("Sala cadastrada com sucesso.", TipoMensagemEnum.SUCESSO);
        }
        public static void AlocarAluno () {
            System.Console.Write ("Nome do aluno: ");
            string nomeAluno = Console.ReadLine ();

            System.Console.Write ("Número da sala destino: ");
            int numeroDestino = int.Parse (Console.ReadLine ());

            Program.BuscarAlunoPorNome(nomeAluno,Aluno.ArrayAlunos).NumeroSala = numeroDestino;
            
            Program.BuscarSalaPorNumero(numeroDestino, Sala.ArraySalas).Alunos = nomeAluno;
        }

    }
}