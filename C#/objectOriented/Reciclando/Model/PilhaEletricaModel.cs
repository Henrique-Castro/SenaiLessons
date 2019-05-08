using Reciclando.Interfaces;
using Reciclando.Util;
using Reciclando.Util.Enums;

namespace Reciclando.Model
{
    public class PilhaEletricaModel : LixoModel, INaoDefinido
    {
        public bool IrParaLixeiraCinza(LixosEnum lixo)
        {
            var nome = LixosEnum.GetName(typeof(LixosEnum), lixo);
            BackgroundColor.MudarCorDeFundo($"O {nome} foi jogado na composteira.",CoresEnum.CINZA);
            return true;
        }
    }
}