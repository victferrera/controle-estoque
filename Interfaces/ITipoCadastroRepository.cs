using EstoqueApp.Modelos;
using System.Collections.Generic;

namespace EstoqueApp.Interfaces
{
    internal interface ITipoCadastroRepository : IBaseService<TipoCadastro>
    {
        public List<TipoCadastro> ProcurarPorFiltro(string filtro);
        public TipoCadastro ProcurarPorId(int id);
        public List<TipoCadastro> GeraListaTipoCadastro();
    }
}
