using EstoqueApp.Modelos;
using Dapper;
using EstoqueApp.Interfaces;
using Autofac;
using System.Linq;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace EstoqueApp.Repositories
{
    internal class MovtoEntradaRepository : BaseRepository<MovtoEntrada>, IMovtoEntradaRepository
    {
        public int GetLastId()
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                try
                {
                    var connection = scope.Resolve<IConnectionService>().CreateConnection();

                    var query = "SELECT MAX(MovtoNumero) FROM MovtoEntrada";

                    int? retorno = connection.Query<int?>(query).FirstOrDefault();

                    if(retorno == null)
                    {
                        return 0;
                    }else
                    {
                        return retorno.Value;
                    }
                }catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                    return 0;
                }

            }
        }
    }
}
