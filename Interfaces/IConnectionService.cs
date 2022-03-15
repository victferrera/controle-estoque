using System.Data.SqlClient;

namespace EstoqueApp.Interfaces
{
    internal interface IConnectionService
    {
        SqlConnection CreateConnection();
    }
}
