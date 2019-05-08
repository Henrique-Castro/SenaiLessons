using Reciclando.Interfaces;
using Reciclando.Util;
using Reciclando.Util.Enums;

namespace Reciclando.Model
{
    public class GarrafaDeVidroModel : LixoModel, IVidro
    {

        public bool IrParaLixeiraVerde(LixosEnum lixo)
        {
            var nome = LixosEnum.GetName(typeof(LixosEnum), lixo);
            BackgroundColor.MudarCorDeFundo($"O {nome} foi jogado na composteira.",CoresEnum.VERDE);
            return true;
        }
    }
}