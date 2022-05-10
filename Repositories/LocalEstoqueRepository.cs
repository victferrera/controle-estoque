using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;
using Dapper;
using Autofac;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

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
                }
                catch (Exception e)
                {
                    //throw new(e.Message);
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
        public List<LocalEstoque> GetLocalByFilter(string filtro = "")
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();

                var query =
                    @"SELECT * FROM 
                    [LocalEstoque] 
                    WHERE 
                    Codigo like @p1 OR 
                    Nome like @p1 OR 
                    Descricao like @p1";

                var localEstoqueList = connection.Query<LocalEstoque>(query, new
                {
                    p1 = "%" + filtro + "%"
                });

                return localEstoqueList.ToList();
            }
        }

        public void EditaLocal(LocalEstoque local)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();

                var localResult = ProcurarLocalPorCodigo(local.Codigo);

                var query = @"UPDATE [LocalEstoque] SET Codigo = @p1, Nome = @p2, Descricao = @p3 WHERE Id = @p4";
                try
                {
                    connection.Execute(query, new
                    {
                        p1 = local.Codigo,
                        p2 = local.Nome,
                        p3 = local.Descricao,
                        p4 = localResult.Codigo
                    });
                    MessageBox.Show("Informações alteradas com sucesso!", "Alerta");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public void DeletaLocal(int id)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();

                var local = ProcurarLocalPorCodigo(id);

                if (local != null)
                {
                    try
                    {
                        var query = "DELETE FROM [LocalEstoque] WHERE Id = @p1";

                        connection.Execute(query, new
                        {
                            p1 = id
                        });

                        MessageBox.Show("Local de Estoque removido!","Alerta!");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }
    }
}
