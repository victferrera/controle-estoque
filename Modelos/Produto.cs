using EstoqueApp.Enums;
using Dapper.Contrib.Extensions;

namespace EstoqueApp.Modelos
{
    [Table("Produto")]
    internal class Produto
    {
        [Key]
        public int CodigoProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public EStatus Status { get; set; }
        public Unidade Unidade { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal PrecoCompra { get; set; }
    }
}
