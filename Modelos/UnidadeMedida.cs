using Dapper.Contrib.Extensions;
using System.Collections;
using System.Collections.Generic;

namespace EstoqueApp.Modelos
{
    [Table("tbUnidadeMedida")]
    internal class UnidadeMedida
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string DescAbrev { get; set; }
        public string DescCompleta { get; set; }
        public int FatorConversao { get; set; }
        public string Status { get; set; }
    }
}
