using System.Data.SqlClient;
using EstoqueApp.Database;
using Dapper.Contrib.Extensions;
using Dapper;
using System;
using System.Collections.Generic;
using EstoqueApp.Modelos;

namespace EstoqueApp.Repositories
{
    internal class BaseRepository<T> where T: class
    {
        public SqlConnection _connection { get; set; }
        public BaseRepository()
        {
            _connection = new Connection().GetConnection();
        }
        public virtual void Save(T model)
        {
            try
            {
                _connection.Insert<T>(model);
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public virtual void Update(T model)
        {
            try
            {
                _connection.Update<T>(model);
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Remove(T model)
        {
            try
            {
                _connection.Delete<T>(model);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<T> GetByStatus(int statusId)
        {
            var query = @"SELECT [Sigla], [CodigoUnidade] FROM [Unidade] WHERE [Status] = @prm";

            return _connection.Query<T>(query, new {prm = statusId});
        }
    }
}
