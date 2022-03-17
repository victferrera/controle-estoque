using EstoqueApp.Modelos;

namespace EstoqueApp.Interfaces
{
    internal interface ILocalEstoqueRepository : IBaseService<LocalEstoque>
    {
        public LocalEstoque ProcurarLocalPorCodigo(int codigo);
    }
}
