using EstoqueApp.Interfaces;
using System.Data.SqlClient;

namespace EstoqueApp.Database
{
    internal class Connection : IConnectionService
    {
        private string Connection_String = $@"Server=PC\SQLEXPRESS;Database=EstoqueDB;Trusted_Connection=true";

        public SqlConnection CreateConnection()
        {
           var Connection = new SqlConnection(Connection_String);
           return Connection;
        }
    }
}
