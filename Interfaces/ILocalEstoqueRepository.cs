using EstoqueApp.Modelos;
using System.Collections.Generic;

namespace EstoqueApp.Interfaces
{
    internal interface ILocalEstoqueRepository : IBaseService<LocalEstoque>
    {
        LocalEstoque ProcurarLocalPorCodigo(int codigo);
        LocalEstoque ProcurarLocalPorId(int id);
        List<LocalEstoque> GetLocalByFilter(string filtro);
        void EditaLocal(LocalEstoque local);
        void DeletaLocal(int id);
    }
}
