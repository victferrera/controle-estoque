using EstoqueApp.Interfaces;
using EstoqueApp.Banco;
using Dapper;
using System;

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
            }catch(Exception e)
            {
                return e.Message;
            }
        }
    }
}
