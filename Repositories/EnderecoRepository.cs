using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;
using Dapper;
using Autofac;
using System;
using System.Windows.Forms;
using System.Linq;

namespace EstoqueApp.Repositories
{
    internal class EnderecoRepository : IEnderecoRepository
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

        public void Remove(Endereco model)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Endereco model)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();

                var query = $@"
                INSERT INTO [Endereco]
                VALUES
                (@p1, @p2, @p3, @p4, @p5, @p6, @p7)
                ";
                try
                {
                    connection.Execute(query, new
                    {
                        p1 = model.cep,
                        p2 = model.logradouro,
                        p3 = model.numero,
                        p4 = model.bairro,
                        p5 = model.uf,
                        p6 = model.localidade,
                        p7 = model.complemento
                    });
                }catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public void Update(Endereco model)
        {
            throw new System.NotImplementedException();
        }
    }
}
