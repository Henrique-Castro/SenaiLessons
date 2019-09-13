using System;
using System.Collections.Generic;

namespace Senai.ShirtStore.WebApi.Domains
{
    public partial class Tamanhos
    {
        public Tamanhos()
        {
            Estoque = new HashSet<Estoque>();
        }

        public int TamanhoId { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }

        public ICollection<Estoque> Estoque { get; set; }
    }
}
