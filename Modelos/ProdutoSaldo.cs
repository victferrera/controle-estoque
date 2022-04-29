using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstoqueApp.Modelos
{
    [Table("ProdutoSaldo")]
    internal class ProdutoSaldo
    {
        public int Id { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal SaldoAtual { get; set; }
        public int CodigoProduto { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int LocalEstoque { get; set; }
    }
}
