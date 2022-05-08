using Autofac;
using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;
using Dapper;
using System;

namespace EstoqueApp.Repositories
{
    internal class MovtoEntradaItemRepository : BaseRepository<MovtoEntradaItem>, IMovtoEntradaItemRepository
    {
    }
}
