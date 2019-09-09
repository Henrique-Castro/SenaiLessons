using Senai.OpFlix.WebApi.Domains;
using Senai.OpFlix.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.OpFlix.WebApi.Repositories
{
    public class FormatosRepository : IFormatosRepository
    {
        public void Atualizar(FormatosLancamentos formatoModificado)
        {
            using (OpflixContext ctx = new OpflixContext())
            {
                FormatosLancamentos formatoBuscado = ctx.FormatosLancamentos.FirstOrDefault(x => x.IdFormatoLancamento == formatoModificado.IdFormatoLancamento);

                formatoBuscado.Nome = formatoModificado.Nome;

                ctx.FormatosLancamentos.Update(formatoBuscado);
                ctx.SaveChanges();
            }
        }

        public void Cadastrar(FormatosLancamentos novoFormato)
        {
            using(OpflixContext ctx = new OpflixContext())
            {
                ctx.FormatosLancamentos.Add(novoFormato);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public void Deletar(string titulo)
        {
            throw new NotImplementedException();
        }

        public List<FormatosLancamentos> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
