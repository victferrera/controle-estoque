using Dapper;
using EstoqueApp.Modelos;
using System.Linq;


namespace EstoqueApp.Repositories
{
    internal class ProdutoRepository : BaseRepository<Produto>
    {
        public ProdutoRepository() : base()
        { 
        }      
    }
}
