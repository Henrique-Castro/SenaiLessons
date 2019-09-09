using Senai.OpFlix.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.OpFlix.WebApi.Interfaces
{
    public interface ILancamentosRepository
    {
        void Cadastrar(Lancamentos novoLancamento);
        List<Lancamentos> ListarVisiveis();
        List<Lancamentos> ListarTodos();
        void Deletar(int id);
        void Deletar(string titulo);
        void Atualizar(Lancamentos lancamentoModificado);
    }
}
