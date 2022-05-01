using EstoqueApp.Modelos;
using System.Collections.Generic;

namespace EstoqueApp.Interfaces
{
    internal interface IMovtoEntradaRepository : IBaseService<MovtoEntrada>
    {
        int GetLastId();
    }
}
