using Dapper.Contrib.Extensions;
using EstoqueApp.Enums;
using System.Collections.Generic;

namespace EstoqueApp.Modelos
{
    [Table("Unidade")]
    internal class Unidade
    {
        [Key]
        public int CodigoUnidade { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public EStatus Status { get; set; }
        public IEnumerable<Produto> produtos { get; set; }
    }
}
