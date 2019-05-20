using Reciclando.Interfaces;
using Reciclando.Util;
using Reciclando.Util.Enums;

namespace Reciclando.Model
{
    public class PapelModel : LixoModel, IPapel, IOrganico
    {
        public bool IrParaAComposteira()
        {
            BackgroundColor.MudarCorDeFundo($"O lixo foi jogado na composteira (Orgânico).",CoresEnum.PRETO);
            return true;
        }

        public bool IrParaLixeiraAzul()
        {
            BackgroundColor.MudarCorDeFundo("O lixo foi jogado na lixeira azul (Papel).",CoresEnum.AZUL);
            return true;
        }
    }
}