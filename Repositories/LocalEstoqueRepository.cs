using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;
using Dapper;
using Autofac;
using System;
using System.Linq;

namespace EstoqueApp.Repositories
{
    internal class LocalEstoqueRepository : ILocalEstoqueRepository
    {
        public void Remove(LocalEstoque model)
        {
            throw new System.NotImplementedException();
        }

        public void Save(LocalEstoque model)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();

                var query = @"
                    INSERT INTO [LocalEstoque] 
                    VALUES
                    (@p1, @p2, @p3)";

                try
                {
                    connection.Execute(query, new
                    {
                        p1 = model.Codigo,
                        p2 = model.Nome,
                        p3 = model.Descricao
                    });
                }catch(Exception e)
                {
                    throw new (e.Message);
                }
            }
        }

        public void Update(LocalEstoque model)
        {
            throw new System.NotImplementedException();
        }

        public LocalEstoque ProcurarLocalPorCodigo(int codigo)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();

                var query = @"
                SELECT * FROM
                [LocalEstoque]
                WHERE Codigo = @p1
                ";

                var local = connection.Query<LocalEstoque>(query, new
                {
                    p1 = codigo
                }).FirstOrDefault();

                return local;
            }
        }
    }
}
