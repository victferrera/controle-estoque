using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstoqueApp.Modelos
{
    [Table("Endereco")]
    internal class Endereco
    {
        [Key]
        public int Id { get; set; }
        [JsonProperty("cep")]
        public string Cep { get; set; }
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty("complemento")]
        public string Complemento { get; set; }
        [JsonProperty("bairro")]
        public string Bairro { get; set; }
        [JsonProperty("localidade")]
        public string Localidade { get; set; }
        [JsonProperty("uf")]
        public string Uf { get; set; }
        public int numero { get; set; }
    }
}
