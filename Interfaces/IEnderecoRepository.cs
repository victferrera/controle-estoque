using EstoqueApp.Modelos;

namespace EstoqueApp.Interfaces
{
    internal interface IEnderecoRepository : IBaseService<Endereco>
    {
        int GetLast();
    }
}
