using Dapper.Contrib.Extensions;
using EstoqueApp.Modelos;
using EstoqueApp.Enums;
using Autofac;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using EstoqueApp.Interfaces;

namespace EstoqueApp.Repositories
{
    internal class UnidadeRepository : BaseRepository<Unidade>,IUnidadeRepository
    {
        public UnidadeRepository()
        {

        }
        public void AlterarStatus(Unidade unidade)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();

                if (unidade.Status == EStatus.ATIVO)
                {
                    unidade.Status = EStatus.INATIVO;
                    connection.Update<Unidade>(unidade);
                }
                else
                {
                    unidade.Status = EStatus.ATIVO;
                    connection.Update<Unidade>(unidade);
                }
            }
        }

        public IEnumerable<Unidade> GetByFilter(string filter)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();

                var param = "%" + filter + "";

                var query = @"
                    SELECT * FROM [Unidade]
                    WHERE
                    [CodigoUnidade] like @prm OR
                    [Sigla] like @prm OR
                    [Descricao] like @prm
                    ";
                try
                {
                    var consulta = connection.Query<Unidade>(query, new { prm = param });
                    return consulta;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public IEnumerable<Unidade> GetByStatus(int statusId)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();

                var query = @"SELECT [Sigla], [CodigoUnidade] FROM [Unidade] WHERE [Status] = @prm";

                return connection.Query<Unidade>(query, new { prm = statusId });
            }
        }

        public int GetCodigoUnidadePorSigla(string sigla)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();
                try
                {
                    var query = "SELECT CodigoUnidade FROM Unidade WHERE Sigla = @p1";

                    var retornoId = connection.Query<int>(query, new { p1 = sigla }).FirstOrDefault();

                    return retornoId;

                }catch(Exception)
                {
                    return -1;
                }
            }
        }
    }
}

