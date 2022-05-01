using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstoqueApp.Modelos
{
    [Table("MovtoEntrada")]
    internal class MovtoEntrada
    {
        public int MovtoNumero { get; set; }
        public DateTime DataEmissao { get; set; }
        public int CodigoParticipante { get; set; }
        public List<MovtoEntradaItem> MovtoItem { get; set; }
    }
}
