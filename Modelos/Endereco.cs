﻿using Newtonsoft.Json;

namespace EstoqueApp.Modelos
{
    internal class Endereco
    {
        public string cep;
        public string logradouro;
        public string complemento;
        public string bairro;
        public string localidade;
        public string uf;
        public string? ibge;
        public string? gia;
        public string? ddd;
        public string? siafi;
        public int? numero;
    }
}
