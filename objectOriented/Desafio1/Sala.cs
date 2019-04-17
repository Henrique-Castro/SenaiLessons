namespace Desafio1 {
    public class Sala {
        public int numeroSala, capacidadeAtual = 5, capacidadeTotal = 5;
        public string[] alunos;

        //SETTERS
        public void setNumeroSala(int numeroSala){
            this.numeroSala = numeroSala;
        }
        public void setCapacidadeAtual(int capacidadeAtual){
            this.capacidadeAtual = capacidadeAtual;
        }
        public void setCapacidadeTotal(int capacidadeTotal){
            this.capacidadeTotal = capacidadeTotal;
        }
        public void setAlunos(string[] alunos){
            this.alunos = alunos;
        }

        //GETTERS
        public int getNumeroSala(){
            return numeroSala;
        }
        public int getCapacidadeAtual(){
            return capacidadeAtual;
        }
        public int getCapacidadeTotal(){
            return capacidadeTotal;
        }
        public string[] getAlunos(){
            return alunos;
        }

        //AÇÕES
        public bool Alocar(string nomeAluno, string[] dadosAluno, Sala numeroSala){
            if(capacidadeAtual == 0){
                return false;
            }else{
                capacidadeAtual = capacidadeAtual - 1;
                this.alunos = dadosAluno;
                return true;
            }
        }
    }
}