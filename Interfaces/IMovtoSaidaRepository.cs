using EstoqueApp.Modelos;

namespace EstoqueApp.Interfaces
{
    internal interface IMovtoSaidaRepository : IBaseService<MovtoSaida>
    {
        int GetLastId();
    }
}
