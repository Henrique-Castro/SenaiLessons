using Reciclando.Interfaces;
using Reciclando.Util;
using Reciclando.Util.Enums;

namespace Reciclando.Model
{
    public class GarrafaDeVidroModel : LixoModel, IVidro
    {

        public bool IrParaLixeiraVerde()
        {
            BackgroundColor.MudarCorDeFundo($"O lixo foi jogado na lixeira verde.",CoresEnum.VERDE);
            return true;
        }
    }
}