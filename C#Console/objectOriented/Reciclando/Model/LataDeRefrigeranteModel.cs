using Reciclando.Interfaces;
using Reciclando.Util;
using Reciclando.Util.Enums;

namespace Reciclando.Model
{
    public class LataDeRefrigeranteModel : LixoModel, IMetal
    {
        public bool IrParaLixeiraAmarela()
        {
                BackgroundColor.MudarCorDeFundo($"O lixo foi jogado na lixeira amarela.", CoresEnum.AMARELO);
                return true;
        }
    }
}