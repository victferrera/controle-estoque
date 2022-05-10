using EstoqueApp.Modelos;
using EstoqueApp.Interfaces;
using Dapper;
using Autofac;
using System;
using System.Linq;

namespace EstoqueApp.Repositories
{
    internal class MovtoSaidaRepository : BaseRepository<MovtoSaida>, IMovtoSaidaRepository
    {
        public int GetLastId()
        {
            var query = "SELECT case when MAX(MovtoNumero) is null then 0 when MAX(MovtoNumero)  is not null then MAX(MovtoNumero) end as MovtoNumero FROM MovtoSaida";

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();
                try
                {
                    var movtoNumeroRetorno = connection.Query<int>(query).FirstOrDefault();
                    return movtoNumeroRetorno;
                }catch(Exception)
                {
                    return -1;
                }
            }
        }
    }
}
