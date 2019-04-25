using System;
namespace Senaizinho_2_Tarde {
    public class Sala {
        public int NumeroSala { get; private set; }
        public int CapacidadeAtual { get; private set; }
        public int CapacidadeTotal { get; set; }
        public Aluno[] ArrayAlunos { get; }

        public Sala (int numeroSala, int capacidadeTotal) {
            NumeroSala = numeroSala;
            CapacidadeTotal = capacidadeTotal;
            CapacidadeAtual = CapacidadeAtual;
            ArrayAlunos = new Aluno[capacidadeTotal];
        }

        public bool AlocarAluno (Aluno aluno, out string mensagem) {
            if (CapacidadeAtual > 0) {
                CapacidadeAtual--;
                for (int i = 0; i < ArrayAlunos.Length; i++) {
                    if (ArrayAlunos[i] == null) {
                        ArrayAlunos[i] = aluno;

                        mensagem = $"Aluno {aluno.Nome} alocado com sucesso!";
                        return true;
                    }
                }
            }
            mensagem = $"Capacidade da sala {NumeroSala} excedida!";
            return false;
        }

        public bool RemoverAluno (string nomeAluno, out string mensagem) {
            if (this.CapacidadeAtual > 0) {
                for (int i = 0; i < ArrayAlunos.Length; i++) {
                    if (ArrayAlunos[i] != null && nomeAluno.Equals (ArrayAlunos[i])) {
                        ArrayAlunos[i] = null;
                        CapacidadeAtual++;
                        mensagem = $"Aluno {nomeAluno} removido com sucesso!";
                        return true;
                    }
                }
            mensagem = "Não há aluno aqui.";
            return false;
            }
            mensagem = $"{nomeAluno} não foi encontrado";
            return false;
        }

        public string ExibirAlunos () {
            string nomesAlunos = "";
            foreach (var item in ArrayAlunos) {
                if (item != null) {
                    nomesAlunos += item + " ";
                }
            }
            return nomesAlunos;
        }

    }
}