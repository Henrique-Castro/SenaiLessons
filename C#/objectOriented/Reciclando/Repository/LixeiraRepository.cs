using System.Collections.Generic;
using Reciclando.Interfaces;

namespace Reciclando.Repository
{
    public class LixeiraRepository
    {
        Dictionary<IMetal,string> lixeiraMetal = new Dictionary<IMetal, string>();
        Dictionary<IPlastico,string> lixeiraPlastico = new Dictionary<IPlastico, string>();
        Dictionary<IPapel,string> lixeiraPapel = new Dictionary<IPapel, string>();
        Dictionary<IOrganico,string> lixeiraOrganico = new Dictionary<IOrganico, string>();
        Dictionary<INaoDefinido,string> lixeiraIndefinida = new Dictionary<INaoDefinido, string>();
    }
}