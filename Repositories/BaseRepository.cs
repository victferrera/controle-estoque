using System.Data.SqlClient;
using EstoqueApp.Database;
using Dapper.Contrib.Extensions;
using System;
using Autofac;
using EstoqueApp.Interfaces;

namespace EstoqueApp.Repositories
{
    internal abstract class BaseRepository<T> : IBaseService<T> where T : class
    {
        public virtual void Save(T model)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<Connection>().CreateConnection();

                try
                {
                    connection.Insert<T>(model);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

        }

        public virtual void Update(T model)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<Connection>().CreateConnection();

                try
                {
                    connection.Update<T>(model);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public void Remove(T model)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<Connection>().CreateConnection();

                try
                {
                    connection.Update<T>(model);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
    }
}
