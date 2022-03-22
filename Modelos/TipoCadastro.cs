using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EstoqueApp.Modelos
{
    [Table("TipoCadastro")]
    internal class TipoCadastro
    {
        [Key]
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
    }
}
