using Senai.AutoPecas.WebApi.Domains;
using Senai.AutoPecas.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.AutoPecas.WebApi.Repositories
{
    public class FornecedoresRepository : IFornecedoresRepository
    {
        public Fornecedores BuscarPorId(int id)
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                return ctx.Fornecedores.Find(id);
            }
        }

        public void Cadastrar(Fornecedores novoFornecedor)
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                ctx.Fornecedores.Add(novoFornecedor);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int IdFornecedor)
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                ctx.Fornecedores.Remove(BuscarPorId(IdFornecedor));
                ctx.SaveChanges();
            }
        }
    }
}
