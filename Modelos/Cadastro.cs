using EstoqueApp.Enums;

namespace EstoqueApp.Modelos
{
    internal class Cadastro
    {
        public int Codigo { get; set; }
        public string TipoCadastro { get; set; }
        public EStatus Status { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
    }
}
