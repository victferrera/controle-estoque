using System;

namespace EstoqueApp.Modelos
{
    internal class ProdutoSaldo
    {
        public int Id { get; set; }
        public long SaldoAnterior { get; set; }
        public long SaldoAtual { get; set; }
        public Produto CodigoProduto { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public LocalEstoque LocalEstoque { get; set; }
    }
}
