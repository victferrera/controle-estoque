using EstoqueApp.Database;
using Dapper.Contrib.Extensions;
using System;
using System.Data.SqlClient;

namespace EstoqueApp.Repositories
{
    internal class Repository<TModel> where TModel : class
    {
        private readonly SqlConnection _connection;
        public Repository()
        {
            if (_connection == null)
                _connection = new Connection().GetConnection();
        }
        public string Salvar(TModel model)
        {
            try
            {
                _connection.Insert<TModel>(model);
                return "Salvo com sucesso!";
            }catch(Exception e)
            {
                return e.Message;
            }
        }
    }
}
