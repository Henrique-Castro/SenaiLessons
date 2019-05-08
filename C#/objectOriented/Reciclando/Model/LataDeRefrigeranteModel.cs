using Reciclando.Interfaces;
using Reciclando.Util;
using Reciclando.Util.Enums;

namespace Reciclando.Model
{
    public class LataDeRefrigeranteModel : LixoModel, IMetal
    {
        public bool IrParaLixeiraAmarela(LixosEnum lixo)
        {
            var nome = LixosEnum.GetName(typeof(LixosEnum), lixo);
            BackgroundColor.MudarCorDeFundo($"O {nome} foi jogado na composteira.",CoresEnum.AMARELO);
            return true;
        }
    }
}