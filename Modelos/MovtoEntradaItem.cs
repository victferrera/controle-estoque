using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstoqueApp.Modelos
{
    [Table("MovtoEntradaItem")]
    internal class MovtoEntradaItem
    {
        public int Id { get; set; }
        public List<int> CodigoProduto { get; set; }
        public int LocalEstoque { get; set; }
        public int QtdEntrada { get; set; }
        public int CodigoUnidade { get; set; }
        public int MovtoNumero { get; set; }
    }
}
