using Senai.Ekips.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Ekips.WebApi.Repositories
{
    public class FuncionariosRepository
    {
        public void Cadastrar(Funcionarios funcionario)
        {
            using(EkipsContext ctx = new EkipsContext())
            {
                ctx.Funcionarios.Add(funcionario);
                ctx.SaveChanges();
            }
        }

        public List<Funcionarios> Listar()
        {
            using(EkipsContext ctx = new EkipsContext())
            {
                return ctx.Funcionarios.ToList();
            }
        }
    }
}
