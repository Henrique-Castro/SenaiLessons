using Reciclando.Interfaces;
using Reciclando.Util;
using Reciclando.Util.Enums;

namespace Reciclando.Model
{
    public class GarrafaDePlasticoModel : LixoModel, IPlastico
    {
        public bool IrParaLixeiraVermelha(LixosEnum lixo)
        {
            var nome = LixosEnum.GetName(typeof(LixosEnum), lixo);
            BackgroundColor.MudarCorDeFundo($"O {nome} foi jogado na composteira.",CoresEnum.VERMELHO);
            return true;
        }
    }
}