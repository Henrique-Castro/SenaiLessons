using Reciclando.Interfaces;
using Reciclando.Util;
using Reciclando.Util.Enums;

namespace Reciclando.Model
{
    public class IsoporModel : LixoModel, IPlastico, INaoDefinido
    {
        public bool IrParaLixeiraCinza()
        {
            BackgroundColor.MudarCorDeFundo($"O foi jogado na lixeira cinza.",CoresEnum.CINZA);
            return true;
        }

        public bool IrParaLixeiraVermelha()
        {
            BackgroundColor.MudarCorDeFundo("O lixo foi jogado na lixeira vermelha.",CoresEnum.VERMELHO);
            return true;
        }
    }
}