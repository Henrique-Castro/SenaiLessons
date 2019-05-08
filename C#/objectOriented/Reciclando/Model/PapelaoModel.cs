using Reciclando.Interfaces;
using Reciclando.Util;
using Reciclando.Util.Enums;

namespace Reciclando.Model
{
    public class PapelaoModel : LixoModel, IPapel
    {
        public bool IrParaLixeiraAzul(LixosEnum lixo)
        {
            var nome = LixosEnum.GetName(typeof(LixosEnum), lixo);
            BackgroundColor.MudarCorDeFundo($"O {nome} foi jogado na composteira.",CoresEnum.AZUL);
            return true;
        }
    }
}