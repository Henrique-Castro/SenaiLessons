using Microsoft.EntityFrameworkCore;
using Senai.AutoPecas.WebApi.Domains;
using Senai.AutoPecas.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.AutoPecas.WebApi.Repositories
{
    public class PecasRepository : IPecasRepository
    {
        public void Atualizar(Pecas pecaModificada)
        {
            using(AutoPecasContext ctx = new AutoPecasContext())
            {
                Pecas pecaEncontrada = BuscarPecaPorCodigo(pecaModificada.PecaCodigo);
                if (pecaEncontrada == null)
                    throw new ArgumentNullException();
                else
                {
                    pecaEncontrada.PrecoVenda = pecaModificada.PrecoVenda;
                    pecaEncontrada.Descricao = pecaModificada.Descricao;
                    pecaEncontrada.Peso = pecaModificada.Peso;
                    pecaEncontrada.PrecoCusto = pecaModificada.PrecoCusto; 
                    //Se o código da peça for mudado e não existir um código igual ao que foi fornecido
                    if(pecaModificada.PecaCodigo != pecaEncontrada.PecaCodigo && !ctx.Pecas.Single().PecaCodigo.Equals(pecaModificada.PecaCodigo))
                    {
                        pecaEncontrada.PecaCodigo = pecaModificada.PecaCodigo;
                    }
                    ctx.Update(pecaEncontrada);
                    ctx.SaveChanges();
                }
            }
        }

        public Pecas BuscarPecaPorCodigo(int codigo)
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                return ctx.Pecas.First(x => x.PecaCodigo == codigo);
            }
        }

        public void Cadastrar(Pecas novaPeca)
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                if (ctx.Pecas.Contains(novaPeca))
                {
                    throw new SystemException(message: "Esta peça já existe.");
                }
                ctx.Pecas.Add(novaPeca);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int codigo)
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                Pecas pecaADeletar = BuscarPecaPorCodigo(codigo);
                if (ctx.Pecas.Contains(pecaADeletar))
                {
                    ctx.Pecas.Remove(pecaADeletar);
                    ctx.SaveChanges();
                }
                throw new SystemException(message: "Esta peça não existe.");
            }
        }

        public List<Pecas> ListarPecasPorFornecedor(int idFornecedor)
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                return ctx.Pecas.Include(x => x.FornecedorId == idFornecedor).ToList();
            }
        }

        public List<Pecas> ListarTodas()
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                return ctx.Pecas.ToList();
            }
        }
    }
}
