using EstoqueApp.Enums;

namespace EstoqueApp.Modelos
{
    internal class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public EStatusItem Status { get; set; }
        public string CodBarras { get; set; }
        public Unidade Unidade { get; set; }
        public decimal PrecoVenda { get; set; }
    }
}
