using System.Data.SqlClient;

namespace EstoqueApp.Banco
{
    internal class Conexao
    {
        private const string user = "sa";
        private const string password = "123";
        private SqlConnection conexao = null;
        private string stringConexao = $@"Server=PC\SQLEXPRESS;Database=estoquedb;User Id={user};password={password}";

        public SqlConnection GetConexao()
        {
            if (conexao != null)
            {
                conexao.Dispose();
                conexao = new SqlConnection(stringConexao);
                return conexao;
            }
            else
            {
                conexao = new SqlConnection(stringConexao);
                return conexao;
            }
        }
    }
}
