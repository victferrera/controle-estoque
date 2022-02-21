using EstoqueApp.Interfaces;
using EstoqueApp.Banco;
using Dapper;
using System;
using EstoqueApp.Modelos;
using System.Collections.Generic;

namespace EstoqueApp.Repository
{
    internal class UnidadeRepository : IUnidade
    {
        public string Salvar(string sigla, string descricao)
        {
            try
            {
                using (var conexao = new Conexao().GetConexao())
                {
                    var insertSql = @"
                INSERT INTO [tbUnidade] VALUES(
                @_sigla,
                @_descricao
                )";

                    var linhasAfetadas = conexao.Execute(insertSql, new
                    {
                        _sigla = sigla,
                        _descricao = descricao
                    });

                    return "Unidade salva com sucesso!";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public IEnumerable<Unidade> Pesquisar(string prm)
        {
            var param = "%"+prm+"%";

            var consulta = @"
            SELECT * FROM [tbUnidade]
            WHERE Sigla LIKE @filtro OR Descricao LIKE @filtro OR Id LIKE @filtro
            ";

            using (var conexao = new Conexao().GetConexao())
            {
                var retornoConsulta = conexao.Query<Unidade>(consulta, new
                {
                    filtro = param
                });

                return retornoConsulta;
            }
        }
    }
}
