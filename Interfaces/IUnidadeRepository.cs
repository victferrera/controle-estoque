using EstoqueApp.Modelos;
using System.Collections.Generic;

namespace EstoqueApp.Interfaces
{
    internal interface IUnidadeRepository : IBaseService<Unidade>
    {
        public void AlterarStatus(Unidade unidade);
        public IEnumerable<Unidade> GetByFilter(string filtro);
        public IEnumerable<Unidade> GetByStatus(int statusId);

    }
}
