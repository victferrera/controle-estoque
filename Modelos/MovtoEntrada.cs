using System;

namespace EstoqueApp.Modelos
{
    internal class MovtoEntrada
    {
        public int MovtoNumero { get; set; }
        public DateTime DataEmissao { get; set; }
        public Cadastro CodigoParticipante { get; set; }
    }
}
