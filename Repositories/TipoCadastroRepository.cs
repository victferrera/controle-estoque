using Autofac;
using Dapper;
using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EstoqueApp.Repositories
{
    internal class TipoCadastroRepository : BaseRepository<TipoCadastro> , ITipoCadastroRepository
    {
        public List<TipoCadastro> ProcurarPorFiltro(string filtro)
        {
            using(var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();

                var filtroFormatado = "%"+filtro+"%";

                var query = "SELECT * FROM [TipoCadastro] WHERE Id LIKE @p1 OR Sigla LIKE @p1 OR Descricao LIKE @p1";

                try
                {
                    var tiposCadastro = connection.Query<TipoCadastro>(query, new
                    {
                        p1 = filtroFormatado
                    });

                    return tiposCadastro.ToList();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
    }
}
