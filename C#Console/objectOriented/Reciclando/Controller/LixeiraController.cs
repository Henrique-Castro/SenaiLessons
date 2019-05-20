using System;
using Reciclando.Interfaces;
using Reciclando.Model;

namespace Reciclando.Controller
{
    public class LixeiraController
    {
        public static bool IrParaAComposteira()
        {
            System.Console.WriteLine("Lixos da categoria papel não podem ser reciclados caso estejam sujos ou molhados.");
            return true;
        }
        public static void InserirNaLixeira(IMetal lixo){
            lixo.IrParaLixeiraAmarela();
        }
        public static void InserirNaLixeira(INaoDefinido lixo){
            lixo.IrParaLixeiraCinza();
        }
        public static void InserirNaLixeira(IOrganico lixo){
            lixo.IrParaAComposteira();
        }
        public static void InserirNaLixeira(IPapel lixo){
            System.Console.WriteLine("O lixo está sujo ou molhado?");
            System.Console.WriteLine("          1- Sim          ");
            System.Console.WriteLine("          2- Não          ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    IrParaAComposteira();
                break;
                case 2:
                    lixo.IrParaLixeiraAzul();
                break;
                default:
                break;
            }
        }
        public static void InserirNaLixeira(IPlastico lixo){
            lixo.IrParaLixeiraVermelha();
        }
        public static void InserirNaLixeira(IVidro lixo){
            lixo.IrParaLixeiraVerde();
        }
    }
}