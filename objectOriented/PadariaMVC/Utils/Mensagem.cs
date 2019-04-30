using System;
using PadariaMVC.Utils.Enums;
namespace PadariaMVC.Utils
{
    public class Mensagem
    {
        
        public static void MostrarMensagem (string mensagem, TipoMensagemEnum tipoMensagem) {
            switch (tipoMensagem) {
                case TipoMensagemEnum.SUCESSO:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case TipoMensagemEnum.ERRO:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case TipoMensagemEnum.ALERTA:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case TipoMensagemEnum.DESTAQUE:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
            }
            System.Console.WriteLine (mensagem);
            Console.ResetColor ();

            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
            Console.ReadLine ();

        }
    }
}