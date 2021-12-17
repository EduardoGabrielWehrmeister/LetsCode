using System;

namespace aula01Ambev.Model
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}