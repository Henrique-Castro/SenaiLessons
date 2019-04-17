// using System;

// namespace _123123 {
//     class Program {
//         static void Main (string[] args) {
//             Dictionary<int, Lists<string>> words = new Dictionary<int, Lists<string>> ();

//             for (int len = 3; len < 11; len++) {
//                 words[len] = new List<string> ();
//             }
//             foreach (string word in dict) {
//                 int n = word.Length;
//                 if (n < 11 && n > 2) {
//                     List<string> l = words[n];
//                     l.Add (word);
//                 }
//             }
//                 string s = words[5][3];


//             // int maxPalavrasUsuario = 5;
//             // int maxPalavrasFrase = 5;
//             // Random r = new Random();
//             // string[] palavrasUsuario = new string[5];

//             // for (int i = 0; maxPalavrasUsuario > 0; i++) {
//             //     palavrasUsuario[i] = Console.ReadLine ();
//             //     if (--maxPalavrasUsuario != 0) {
//             //         System.Console.WriteLine ("Faltam " + --maxPalavrasFrase + ". Digite mais uma!");
//             //     } else {
//             //         System.Console.WriteLine ("Pronto!");
//             //     }

//             // }

//             // string[, ] matrizPalavras = { 
//             //     { "Nós", "Temer", "Naruto", "Bowie", "" },
//             //     { "jamais", "ás vezes", "pode", "sempre", "" },
//             //     { "saberemos", "toca", "ser", "será", "" },
//             //     { "sobre", "gaita", "duro", "bom", "" },
//             //     { "buraco negro", "na prisão", "hoje", "músico", "" },
//             // };

//             // for (int i = 0; i < matrizPalavras.GetLength (0); i++) {
//             //     for (int j = 0; j < matrizPalavras.GetLength (0); j++) {
//             //         if ("".Equals (matrizPalavras[i, j])) {
//             //             matrizPalavras[i,j] = palavrasUsuario[j];
//             //         }
//             //     }
//             // }

//             // string frase = "";
//             // for (int i = 0; i < maxPalavrasFrase; i++) {
//             //     frase += matrizPalavras[i,
//             //         r.Next (matrizPalavras.GetLength (0))] + " ";
//             // }

//             // System.Console.WriteLine ("Minha frase é: \n" + frase);

//         }
//     }

// }