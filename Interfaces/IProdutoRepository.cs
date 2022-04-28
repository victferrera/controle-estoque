using EstoqueApp.Modelos;
using System.Collections.Generic;

namespace EstoqueApp.Interfaces
{
    internal interface IProdutoRepository : IBaseService<Produto>
    {
        public IEnumerable<Produto> GetByFilter(string filtro);
        public Produto ProcurarPorCodigo(int Codigo);

    }
}
