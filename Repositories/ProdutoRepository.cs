using Dapper;
using EstoqueApp.Modelos;
using System.Collections.Generic;
using System;
using Dapper.Contrib.Extensions;
using System.Linq;
using EstoqueApp.Enums;
using Autofac;
using EstoqueApp.Database;

namespace EstoqueApp.Repositories
{
    internal class ProdutoRepository : BaseRepository<Produto>
    {
        public override void Save(Produto produto)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<Connection>().CreateConnection();

                try
                {
                    var query = "INSERT INTO [Produto] VALUES(@nome, @descricao, @status, @pvenda, @pcompra, @cunidade)";

                    connection.Query<Produto>(query, new
                    {
                        nome = produto.Nome,
                        descricao = produto.Descricao,
                        status = produto.Status,
                        pvenda = produto.PrecoVenda,
                        pcompra = produto.PrecoCompra,
                        cunidade = produto.unidade.CodigoUnidade
                    });
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public override void Update(Produto produto)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<Connection>().CreateConnection();

                try
                {
                    var query = @"UPDATE [Produto] SET 
                    Nome = @nome,
                    Descricao = @descricao,
                    Status = @status,
                    PrecoVenda = @pvenda,
                    PrecoCompra = @pcompra,
                    CodigoUnidade = @cunidade
                    WHERE CodigoProduto = @cproduto";

                    connection.Query<Produto>(query, new
                    {
                        cproduto = produto.CodigoProduto,
                        nome = produto.Nome,
                        descricao = produto.Descricao,
                        status = produto.Status,
                        pvenda = produto.PrecoVenda,
                        pcompra = produto.PrecoCompra,
                        cunidade = produto.unidade.CodigoUnidade
                    });
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public IEnumerable<Produto> GetByFilter(string filtro)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<Connection>().CreateConnection();

                var param1 = "%" + filtro + "%";

                var query = @" 
                    SELECT * 
                    FROM [Produto] as Produto
                    INNER JOIN [Unidade] as Unidade ON
                    Unidade.CodigoUnidade = Produto.CodigoUnidade
                    WHERE
                    Produto.CodigoProduto like @prm1 OR
                    Produto.Nome like @prm1 OR
                    Produto.Descricao like @prm1
                    ";
                try
                {
                    var consulta = connection.Query<Produto, Unidade, Produto>(query, (produto, unidade) =>
                    {
                        produto.unidade = unidade;
                        return produto;
                    },
                    new { prm1 = param1 },
                    splitOn: "Sigla");

                    return consulta;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
    }
}
