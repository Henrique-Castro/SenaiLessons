using System.Collections.Generic;
namespace Reciclando.Model
{
    public class LixeiraModel
    {
        string cor;
        Dictionary<string,LixoModel> conteudoDaLixeira = new Dictionary<string, LixoModel>();
    }
}