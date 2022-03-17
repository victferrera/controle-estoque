using EstoqueApp.Modelos;
using System.Collections.Generic;

namespace EstoqueApp.Interfaces
{
    internal interface ILocalEstoqueRepository : IBaseService<LocalEstoque>
    {
        public LocalEstoque ProcurarLocalPorCodigo(int codigo);
        public List<LocalEstoque> GetLocalByFilter(string filtro);
    }
}
