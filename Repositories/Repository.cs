using EstoqueApp.Database;
using Dapper.Contrib.Extensions;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

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
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public IEnumerable<TModel> Pesquisar(string filtro)
        {
            string param = "%"+filtro+"%";

            var queryConsulta = @"
            SELECT * FROM [tbUnidadeMedida]
            WHERE 
            [Id] like @prm OR
            [Sigla] like @prm OR
            [DescAbrev] like @prm OR
            [DescCompleta] like @prm OR
            [Status] like @prm
            ";

            var retornoConsulta = _connection.Query<TModel>(queryConsulta, new { prm = param });
            return retornoConsulta;

        }

        public IEnumerable<TModel> Remover(int id)
        {
            var model = _connection.Get<TModel>(id);
            if (model != null)
                _connection.Delete<TModel>(model);
            return Pesquisar("");
        }

        public IEnumerable<TModel> Pesquisar()
        {
            return _connection.GetAll<TModel>();
        }
    }
}
