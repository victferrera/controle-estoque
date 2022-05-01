using EstoqueApp.Modelos;
using System.Collections.Generic;

namespace EstoqueApp.Interfaces
{
    internal interface IProdutoRepository : IBaseService<Produto>
    {
         IEnumerable<Produto> GetByFilter(string filtro);

         Produto ProcurarPorCodigoComUn(int codigo);

    }
}
