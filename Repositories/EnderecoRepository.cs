using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;
using Dapper;
using Autofac;
using System;
using System.Windows.Forms;
using System.Linq;

namespace EstoqueApp.Repositories
{
    internal class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        public int GetLast()
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var query = "SELECT MAX(Id) FROM Endereco";

                var connection = scope.Resolve<IConnectionService>().CreateConnection();

                try
                {
                    int retorno = connection.Query<int>(query).FirstOrDefault();
                    return retorno;
                }catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                    return -1;
                }
            }
        }
    }
}
