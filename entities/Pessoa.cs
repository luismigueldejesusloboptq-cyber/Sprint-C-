using System;
using System.Collections.Generic;
using System.Text;

namespace estudo_sprint.entities
{
    public  class Pessoa
    {
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento {  get; set; }
        public string CPF { get; set; }
        public string Rg { get; set; }
        public string Nacionalidade {  get; set; }
        public decimal Renda { get; set; }
    }
}
