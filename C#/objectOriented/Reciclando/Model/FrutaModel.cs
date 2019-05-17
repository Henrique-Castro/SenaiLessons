using Reciclando.Interfaces;
using Reciclando.Util;
using Reciclando.Util.Enums;

namespace Reciclando.Model
{
    public class FrutaModel :  LixoModel, IOrganico
    {
        public bool IrParaAComposteira()
        {
            BackgroundColor.MudarCorDeFundo("O lixo foi jogado na composteira.",CoresEnum.PRETO);
            return true;
        }
    }

}