// using System;

// namespace Ex1 {
//     class Program {
//         static void Main (string[] args) {
//             ContaCorrente[] arrayContas = new ContaCorrente[10];
//             int i = 0;
//             string[] menuInicial = {
//                 "1- Entrar na conta",
//                 "2- Criar Conta",
//                 "3- Sair"
//             };
//             string[] menuPrincipal = {
//                 $"----------- M E N U -----------",
//                 $"1- Sacar",
//                 $"2- Depositar",
//                 $"3- Transferir",
//                 $"4- Sair",
//                 "---------------------------------"
//             };
//             double deposito = 0;
//             double saldo = 0;
//             Random r = new Random ();
//             bool hmm = true;
//             while (hmm == true) {
//                 foreach (string linha in menuInicial)
//                 {
//                     System.Console.WriteLine(linha);
//                 }
//                 switch (Console.ReadLine())
//                 {
//                     case "2":
//                     System.Console.Write("Nome: ");
//                     arrayContas[i].setTitular(Console.ReadLine());
//                     System.Console.Write("Senha: ");
//                     arrayContas[i].setSenha(Console.ReadLine());
//                     arrayContas[i].setNumeroConta(i);
//                     System.Console.WriteLine($"Anote aí: sua agência é a número {arrayContas[i].getNumeroConta()}");
//                     continue;
                    


//                     default:break;
//                 }
//                 foreach (string linha in menuPrincipal) {
//                     System.Console.WriteLine (linha);
//                 }

//                 switch (Console.ReadLine ()) {
//                     case "1":
//                         saldo = arrayContas[i].getSaldo ();
//                         System.Console.WriteLine ("Quantia a ser sacada:");
//                         double valorSaque = double.Parse (Console.ReadLine ());
//                         if (arrayContas[i].Sacar (double.Parse (Console.ReadLine ())) == true) {
//                             saldo -= valorSaque;
//                             arrayContas[i].setSaldo (saldo);
//                             System.Console.WriteLine ($"Você sacou {valorSaque} com sucesso.\nSeu saldo agora é de: {conta.getSaldo()}");

//                         };
//                         continue;
//                     case "2":
//                         saldo = arrayContas[i].getSaldo ();
//                         System.Console.WriteLine ("Insira as notas: ");
//                         int valorDeposito = r.Next (2, 2000);
//                         arrayContas[i].Depositar (valorDeposito);
//                         saldo += valorDeposito;
//                         arrayContas[i].setSaldo (saldo);
//                         System.Console.WriteLine ($"Você depositou {valorDeposito} com sucesso.\nSeu saldo agora é de {conta.getSaldo()}");
//                         continue;

//                     case "3":
//                             System.Console.Write("Insira o valor da tranferência: ");
//                             double valorTransferencia = double.Parse(Console.ReadLine());
//                             System.Console.WriteLine("Agencia da conta destino: ");
//                             int numeroAgencia = int.Parse(Console.ReadLine());
//                             arrayContas[i].Transferir(valorTransferencia, arrayContas[i]);
//                             continue;

//                     case "4": break;
//                     default:
//                         break;
//                 }

//             }
//         }
//     }
// }