using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Modelos.DTO
{
    internal class ProdutoDTO
    {
        public int CodigoProduto { get; set; }
        public string Nome { get; set; }
        public string UnidadeMedida { get; set; }
        public decimal Qtd { get; set; }
    }
}
