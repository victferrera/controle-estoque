namespace EstoqueApp.Abstract
{
    internal abstract class MovimentacaoItem
    {
        public int Id { get; set; }
        public int CodigoProduto { get; set; }
        public int LocalEstoque { get; set; }
        public decimal QtdItem { get; set; }
        public int CodigoUnidade { get; set; }
        public int MovtoNumero { get; set; }
    }
}
