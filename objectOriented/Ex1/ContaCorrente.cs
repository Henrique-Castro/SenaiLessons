namespace Ex1 //Namespace diz em qual projeto está inserida/relacionada
{
    public class ContaCorrente {
        public string titular, senha;
        public int numeroConta, numeroAgencia;
        private double saldo { get; set; }

        public void setNumeroConta(int numeroConta){
            this.numeroConta = numeroConta;
        }
        public void setTitular(string titular){
            this.titular = titular;
        }
        public int getNumeroConta(){
            return numeroConta;
        }
        public void setSenha(string senha){
            this.senha = senha;
        }
        public bool Sacar (double valor) {
            if (valor > saldo) {
                return false;
            } else {
                saldo -= valor;
                return true;
            }
        }
        public void Depositar (double valor) {
            saldo += valor;
        }

        public double getSaldo () {

            return saldo;
        }
        public void setSaldo (double valor) {
            this.saldo = saldo;
        }
        public bool Transferir (double valor, ContaCorrente contaDestino) {
            if(valor > saldo){
                return false;
            }else{
                saldo -= valor;
                contaDestino.saldo += valor;
                return true;
            }
        }
    }
}