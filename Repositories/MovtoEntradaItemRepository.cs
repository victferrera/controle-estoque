using Autofac;
using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;
using Dapper;
using System;

namespace EstoqueApp.Repositories
{
    internal class MovtoEntradaItemRepository : BaseRepository<MovtoEntradaItem>, IMovtoEntradaItemRepository
    {
        public override void Save(MovtoEntradaItem novoMovto)
        {
            var query = "INSERT INTO MovtoEntradaItem VALUES(@p1,@p2,@p3,@p4,@p5)";

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();
                try
                {
                    foreach (int produtoId in novoMovto.CodigoProduto)
                    {
                        connection.Execute(query, new
                        {
                            p1 = produtoId,
                            p2 = novoMovto.LocalEstoque,
                            p3 = novoMovto.QtdItem,
                            p4 = novoMovto.CodigoUnidade,
                            p5 = novoMovto.MovtoNumero
                        });
                    }
                }catch(Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }
    }
}
