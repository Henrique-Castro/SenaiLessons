using System.Collections.Generic;
using Reciclando.Interfaces;
using Reciclando.Model;

namespace Reciclando.Repository
{
    public class LixeiraRepository
    {
        public static Dictionary<int,LixoModel> lixeiraMetal = new Dictionary<int, LixoModel>{
            {0,new FrutaModel()},
            {1,new GarrafaDePlasticoModel()},
            {2,new GarrafaDeVidroModel()},
            {3,new IsoporModel()},
            {4,new LataDeRefrigeranteModel()},
            {5,new PapelaoModel()},
            {6,new PapelModel()},
            {7,new PilhaEletricaModel()}
        };
        
    }
}