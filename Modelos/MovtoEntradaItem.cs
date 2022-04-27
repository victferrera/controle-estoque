namespace EstoqueApp.Modelos
{
    internal class MovtoEntradaItem
    {
        public int Id { get; set; }
        public Produto CodigoProduto { get; set; }
        public LocalEstoque LocalEstoque { get; set; }
        public long QtdEntrada { get; set; }
        public Unidade CodigoUnidade { get; set; }
        public MovtoEntrada MovtoNumero { get; set; }
    }
}
