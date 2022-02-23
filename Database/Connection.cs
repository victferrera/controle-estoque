using System.Data.SqlClient;

namespace EstoqueApp.Database
{
    internal class Connection
    {
        private const string USER = "sa";
        private const string PASSWORD = "123";

        private string CONNECTION_STRING = $@"Server=PC\SQLEXPRESS;Database=estoquedb;User Id={USER};password={PASSWORD}";
        private SqlConnection CONNECTION = null;

        public SqlConnection GetConnection()
        {
            if (CONNECTION == null)
                return CONNECTION = new SqlConnection(CONNECTION_STRING);
            else
                return CONNECTION;
        }
    }
}
