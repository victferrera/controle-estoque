using System.Data.SqlClient;
using EstoqueApp.Database;
using Dapper.Contrib.Extensions;
using System;

namespace EstoqueApp.Repositories
{
    internal class BaseRepository<T> where T: class
    {
        public SqlConnection _connection { get; set; }
        public BaseRepository()
        {
            _connection = new Connection().GetConnection();
        }
        public void Save(T model)
        {
            try
            {
                _connection.Insert<T>(model);
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Remove(T model)
        {

        }

        public void Get(T model)
        {

        }

        public void GetAll()
        {

        }
    }
}
