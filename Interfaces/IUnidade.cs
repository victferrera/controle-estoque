using EstoqueApp.Modelos;
using System.Collections.Generic;

namespace EstoqueApp.Interfaces
{
    internal interface IUnidade
    {
        string Salvar(string sigla, string descricao);
        IEnumerable<Unidade> Pesquisar(string prm);
    }
}
