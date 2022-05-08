using EstoqueApp.Modelos;
using System;
using System.Collections.Generic;

namespace EstoqueApp.Interfaces
{
    internal interface ICadastroRepository : IBaseService<Cadastro>
    {
        Cadastro GetCadastro(int Codigo);
    }
}
