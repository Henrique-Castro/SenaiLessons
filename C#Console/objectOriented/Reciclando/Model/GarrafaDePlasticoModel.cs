using Reciclando.Interfaces;
using Reciclando.Util;
using Reciclando.Util.Enums;

namespace Reciclando.Model
{
    public class GarrafaDePlasticoModel : LixoModel, IPlastico
    {
        public bool IrParaLixeiraVermelha()
        {
            BackgroundColor.MudarCorDeFundo("O lixo foi jogado na lixeira vermelha.",CoresEnum.VERMELHO);
            return true;
        }
    }
}