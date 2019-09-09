using Senai.OpFlix.WebApi.Domains;
using Senai.OpFlix.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.OpFlix.WebApi.Repositories
{
    public class LancamentosRepository : ILancamentosRepository
    {
        public void Atualizar(Lancamentos lancamentoModificado)
        {
            using (OpflixContext ctx = new OpflixContext())
            {
                Lancamentos lancamentoBuscado = ctx.Lancamentos.FirstOrDefault(x => x.IdLancamento == lancamentoModificado.IdLancamento);

                lancamentoBuscado.Plataforma = lancamentoModificado.Plataforma;
                lancamentoBuscado.QtdEpisodios = lancamentoModificado.QtdEpisodios;
                lancamentoBuscado.Sinopse = lancamentoModificado.Sinopse;
                lancamentoBuscado.Titulo = lancamentoModificado.Titulo;
                lancamentoBuscado.Visivel = lancamentoModificado.Visivel;
                lancamentoBuscado.Categoria = lancamentoModificado.Categoria;
                lancamentoBuscado.Duracao = lancamentoModificado.Duracao;
                lancamentoBuscado.Estreia = lancamentoModificado.Estreia;
                lancamentoBuscado.Formato = lancamentoModificado.Formato;

                ctx.Lancamentos.Update(lancamentoBuscado);
                ctx.SaveChanges();
            }
        }

        public void Cadastrar(Lancamentos novoLancamento)
        {
            using(OpflixContext ctx = new OpflixContext())
            {
                ctx.Add(novoLancamento);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (OpflixContext ctx = new OpflixContext())
            {
                ctx.Lancamentos.Remove(ctx.Lancamentos.FirstOrDefault(x => x.IdLancamento == id));
                ctx.SaveChanges();
            }
        }

        public void Deletar(string titulo)
        {
            using (OpflixContext ctx = new OpflixContext())
            {
                ctx.Lancamentos.Remove(ctx.Lancamentos.FirstOrDefault(x => x.Titulo.Equals(titulo)));
                ctx.SaveChanges();
            }
        }

        public List<Lancamentos> ListarTodos()
        {
            using(OpflixContext ctx = new OpflixContext())
            {
                return ctx.Lancamentos.ToList();
            }
        }

        public List<Lancamentos> ListarVisiveis()
        {
            using (OpflixContext ctx = new OpflixContext())
            {
                return ctx.Lancamentos.Where(x => x.Visivel == true).ToList();
            }
        }
    }
}
