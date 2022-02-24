using Dapper.Contrib.Extensions;
using EstoqueApp.Modelos;
using EstoqueApp.Database;
using System.Data.SqlClient;
using EstoqueApp.Enums;

namespace EstoqueApp.Repositories
{
    internal class UnidadeRepository
    {
        private SqlConnection _connection;
        public UnidadeRepository()
        {
            _connection = new Connection().GetConnection();
        }

        public void AlterarStatus(UnidadeMedida unidade)
        {
            if (unidade.Status == EStatusItem.ATIVO.ToString())
            {
                unidade.Status = EStatusItem.INATIVO.ToString();
                _connection.Update<UnidadeMedida>(unidade);
            }
            else
            {
                unidade.Status = EStatusItem.ATIVO.ToString();
                _connection.Update<UnidadeMedida>(unidade);
            }

        }
    }
}
