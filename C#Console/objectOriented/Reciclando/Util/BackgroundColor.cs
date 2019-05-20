using System.Reflection.Emit;
using System;
using Reciclando.Util.Enums;

namespace Reciclando.Util {
        public class BackgroundColor {
                public static void MudarCorDeFundo (string mensagem, CoresEnum cor) {
                        switch (cor) {
                                case CoresEnum.AMARELO:
                                        Console.BackgroundColor = ConsoleColor.Yellow;
                                        break;
                                case CoresEnum.VERDE:
                                        Console.BackgroundColor = ConsoleColor.Green;
                                        break;
                                case CoresEnum.VERMELHO:
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        break;
                                case CoresEnum.CINZA:
                                        Console.BackgroundColor = ConsoleColor.Gray;
                                        break;
                                case CoresEnum.PRETO:
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                case CoresEnum.AZUL:
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        break;

                        }
                        System.Console.WriteLine(mensagem);
                        Console.ResetColor();
                }
        }
}