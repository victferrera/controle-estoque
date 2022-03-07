using Dapper.Contrib.Extensions;
using EstoqueApp.Modelos;
using EstoqueApp.Enums;
using Dapper;
using System;
using System.Collections.Generic;

namespace EstoqueApp.Repositories
{
    internal class UnidadeRepository : BaseRepository<Unidade>
    {
        public UnidadeRepository() : base()
        {
        }

        public void AlterarStatus(Unidade unidade)
        {
            if (unidade.Status == EStatus.ATIVO)
            {
                unidade.Status = EStatus.INATIVO;
                _connection.Update<Unidade>(unidade);
            }
            else
            {
                unidade.Status = EStatus.ATIVO;
                _connection.Update<Unidade>(unidade);
            }

        }

        public IEnumerable<dynamic> GetByFilter(string filter)
        {
            var param = "%"+filter+"";

            var query = @"
            SELECT * FROM [Unidade]
            WHERE
            [CodigoUnidade] like @prm OR
            [Sigla] like @prm OR
            [Descricao] like @prm
            ";
            try
            {
                var consulta = _connection.Query<Unidade>(query, new {prm = param});
                return consulta;
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
