using EstoqueApp.Modelos;
using System.Collections.Generic;

namespace EstoqueApp.Interfaces
{
    internal interface ITipoCadastroRepository : IBaseService<TipoCadastro>
    {
         List<TipoCadastro> ProcurarPorFiltro(string filtro);
         TipoCadastro ProcurarPorId(int id);
         List<TipoCadastro> GeraListaTipoCadastro();
    }
}
