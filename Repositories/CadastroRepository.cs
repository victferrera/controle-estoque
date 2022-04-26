using Autofac;
using EstoqueApp.Interfaces;
using EstoqueApp.Modelos;
using System;
using System.Windows.Forms;
using Dapper;

namespace EstoqueApp.Repositories
{
    internal class CadastroRepository : ICadastroRepository
    {
        public void Remove(Cadastro model)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Cadastro model)
        {
            using (var scope = Program.Container.BeginLifetimeScope())
            {
                var connection = scope.Resolve<IConnectionService>().CreateConnection();

                var enderecoRepository = scope.Resolve<IEnderecoRepository>();

                try
                {
                    enderecoRepository.Save(model.Endereco);
                    var lastId = enderecoRepository.GetLast();

                    var query = $@"
                    INSERT INTO [CadastroGeral] VALUES(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)";

                    connection.Execute(query, new
                    {
                        p1 = model.Codigo,
                        p2 = model.TipoCadastro,
                        p3 = Convert.ToInt32(model.Status),
                        p4 = model.RazaoSocial,
                        p5 = model.NomeFantasia,
                        p6 = model.Cnpj,
                        p7 = model.Telefone,
                        p8 = model.Email,
                        p9 = lastId
                    });
                    MessageBox.Show("Cadastro salvo com sucesso!");
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public void Update(Cadastro model)
        {
            throw new System.NotImplementedException();
        }
    }
}
