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

        public TipoCadastro ProcurarPorId(int id)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();

                var query = "SELECT * FROM [TipoCadastro] WHERE Id = @p1";

                try
                {
                    var tipoCadastro = connection.Query<TipoCadastro>(query, new
                    {
                        p1 = id
                    }).FirstOrDefault();

                    return tipoCadastro;

                }catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }
        }

        public void Remover(int id)
        {
            var tipoCadastro = ProcurarPorId(id);

            if(tipoCadastro == null)
            {
                MessageBox.Show("Cadastro não disponível na base para exclusão!","Alerta!");
                return;
            }

            try
            {
                using (var scope = Program.Container.BeginLifetimeScope())
                {

                    var connection = scope.Resolve<IConnectionService>().CreateConnection();

                    var query = "DELETE FROM [TipoCadastro] WHERE Id = @p1";

                    connection.Execute(query, new
                    {
                        p1 = id
                    });
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

        public List<TipoCadastro> GeraListaTipoCadastro()
        {
            var listaTipoCadastro = new List<TipoCadastro>();

            using (var scope = Program.Container.BeginLifetimeScope())
            {
                try
                {
                    var connection = scope.Resolve<IConnectionService>().CreateConnection();

                    var query = "SELECT Sigla FROM TipoCadastro";

                    listaTipoCadastro = connection.Query<TipoCadastro>(query).ToList();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return listaTipoCadastro;
                }
            }

            return listaTipoCadastro;
        }
    }
}
