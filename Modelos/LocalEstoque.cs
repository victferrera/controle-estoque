using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstoqueApp.Modelos
{
    [Table("LocalEstoque")]
    internal class LocalEstoque
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
