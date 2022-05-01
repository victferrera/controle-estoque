using EstoqueApp.Modelos;
using System.Collections.Generic;

namespace EstoqueApp.Interfaces
{
    internal interface IUnidadeRepository : IBaseService<Unidade>
    {
         void AlterarStatus(Unidade unidade);
         IEnumerable<Unidade> GetByFilter(string filtro);
         IEnumerable<Unidade> GetByStatus(int statusId);

         int GetCodigoUnidadePorSigla(string sigla);
    }
}
