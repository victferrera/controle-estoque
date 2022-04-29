using EstoqueApp.Modelos;
using System.Collections.Generic;

namespace EstoqueApp.Interfaces
{
    internal interface IProdutoSaldoRepository : IBaseService<ProdutoSaldo>
    {
        public decimal BuscarSaldoAnterior(int codigoProduto, int localEstoque);
    }
}
