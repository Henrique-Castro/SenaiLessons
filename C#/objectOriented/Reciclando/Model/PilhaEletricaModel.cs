using Reciclando.Interfaces;
using Reciclando.Util;
using Reciclando.Util.Enums;

namespace Reciclando.Model
{
    public class PilhaEletricaModel : LixoModel, INaoDefinido
    {
        public bool IrParaLixeiraCinza()
        {
            BackgroundColor.MudarCorDeFundo("O lixo foi jogado na lixeira cinza (Indefinido).",CoresEnum.CINZA);
            return true;
        }
    }
}