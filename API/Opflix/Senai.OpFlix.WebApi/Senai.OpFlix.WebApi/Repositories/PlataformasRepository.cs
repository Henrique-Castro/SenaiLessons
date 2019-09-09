using Senai.OpFlix.WebApi.Domains;
using Senai.OpFlix.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.OpFlix.WebApi.Repositories
{
    public class PlataformasRepository : IPlataformasRepository
    {
        public void Cadastrar(Plataformas novaPlataforma)
        {
            using(OpflixContext ctx = new OpflixContext())
            {
                ctx.Plataformas.Add(novaPlataforma);
                ctx.SaveChanges();
            }
        }
    }
}
