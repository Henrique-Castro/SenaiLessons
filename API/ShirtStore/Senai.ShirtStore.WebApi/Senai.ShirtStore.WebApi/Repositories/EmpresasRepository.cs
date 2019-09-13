using Senai.ShirtStore.WebApi.Domains;
using Senai.ShirtStore.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.ShirtStore.WebApi.Repositories
{
    public class EmpresasRepository : IEmpresasRepository
    {
        public void Atualizar(Empresas empresaModificada)
        {
            using (ShirtContext ctx = new ShirtContext())
            {
                Empresas EmpresaBuscada = BuscarPorId(empresaModificada.EmpresaId);
                if (EmpresaBuscada != null)
                {
                    EmpresaBuscada.Nome = empresaModificada.Nome != null ? empresaModificada.Nome : EmpresaBuscada.Nome;
                }
                else
                {
                    throw new Exception(message: "Este usuário não existe ou não pode ser encontrado.");
                }
            }
        }

        public Empresas BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Empresas novoUsuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Empresas> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
