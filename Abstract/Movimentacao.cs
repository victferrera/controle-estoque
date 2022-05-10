using System;

namespace EstoqueApp.Abstract
{
    internal abstract class Movimentacao
    {
        public  int MovtoNumero { get; set; }
        public  DateTime DataEmissao { get; set; }
        public  int CodigoParticipante { get; set; }
    }
}
