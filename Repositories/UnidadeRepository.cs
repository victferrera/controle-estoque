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
            if (unidade.Status == EStatus.ATIVO.ToString())
            {
                unidade.Status = EStatus.INATIVO.ToString();
                _connection.Update<UnidadeMedida>(unidade);
            }
            else
            {
                unidade.Status = EStatus.ATIVO.ToString();
                _connection.Update<UnidadeMedida>(unidade);
            }

        }
    }
}
