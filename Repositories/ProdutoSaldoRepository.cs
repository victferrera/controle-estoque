using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;
using Autofac;
using Dapper;
using System;
using System.Linq;

namespace EstoqueApp.Repositories
{
    internal class ProdutoSaldoRepository : BaseRepository<ProdutoSaldo>, IProdutoSaldoRepository
    {
        public decimal BuscarSaldoAnterior(int codigoProduto, int localEstoque)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();
                try
                {
                    var query = "SELECT CASE WHEN SUM(SaldoAtual) IS NULL THEN 0 WHEN SUM(SaldoAtual) is not null then SUM(SaldoAtual) END as SaldoAtual FROM ProdutoSaldo WHERE CodigoProduto = @p1 AND LocalEstoque = @p2";

                    decimal saldoAtual = connection.Query<decimal>(query, new { p1 = codigoProduto, p2 = localEstoque }).FirstOrDefault();

                    if (saldoAtual<= 0)
                    {
                        return 0;
                    }

                    return saldoAtual;

                }catch(Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
    }
}
