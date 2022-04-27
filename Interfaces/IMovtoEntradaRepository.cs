using EstoqueApp.Modelos;

namespace EstoqueApp.Interfaces
{
    internal interface IMovtoEntradaRepository : IBaseService<MovtoEntrada>
    {
        int GetLastId();
    }
}
