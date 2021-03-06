using Dapper;
using EstoqueApp.Modelos;
using System.Collections.Generic;
using System;
using Autofac;
using EstoqueApp.Interfaces;
using System.Linq;

namespace EstoqueApp.Repositories
{
    internal class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public override void Save(Produto produto)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();

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
                        cunidade = produto.Unidade.CodigoUnidade
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
                var connection = scope.Resolve<IConnectionService>().CreateConnection();

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
                        cunidade = produto.Unidade.CodigoUnidade
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
                var connection = scope.Resolve<IConnectionService>().CreateConnection();

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
                        produto.Unidade = unidade;
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
        public Produto ProcurarPorCodigoComUn(int codigo)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                try
                {
                    var connection = scope.Resolve<IConnectionService>().CreateConnection();

                    var query = "SELECT * FROM Produto p INNER JOIN Unidade U on p.CodigoUnidade = u.CodigoUnidade WHERE CodigoProduto = @p1";

                    var produtoResultado = connection.Query<Produto, Unidade, Produto>(query,(produto, unidade) =>
                    {
                        produto.Unidade = unidade;
                        return produto;
                    }, 
                    new {p1 = codigo},
                    splitOn: "Sigla").FirstOrDefault();

                    return produtoResultado;

                }catch(Exception)
                {
                    return null;
                }
            }
        }
    }
}
