using Reciclando.Interfaces;
using Reciclando.Util;
using Reciclando.Util.Enums;

namespace Reciclando.Model
{
    public class PapelaoModel : LixoModel, IPapel
    {
        public bool IrParaLixeiraAzul()
        {
            BackgroundColor.MudarCorDeFundo($"O lixo foi jogado na lixeira azul (Papel).",CoresEnum.AZUL);
            return true;
        }
    }
}