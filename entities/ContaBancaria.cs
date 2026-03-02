using System;
using System.Collections.Generic;
using System.Text;

namespace estudo_sprint.entities
{
    public abstract class Contabancaria
    {
        public string NumeroConta { get; private set; }
        public string Senha { get; private set; }
        public decimal Saldo { get; set; }
        public  string Pessoatitular { get; private set; }

        public Contabancaria(string numeroConta, string senha, string pessoatitular)
        {
            NumeroConta = numeroConta;
            Senha = senha;
            Saldo = 0;
            Pessoatitular = pessoatitular;
        }
        public void Depositar(decimal valor)
        {
            if (valor > 0)
                Saldo += valor;
        }
        public abstract void Sacar(decimal valor);
    }
    
}
