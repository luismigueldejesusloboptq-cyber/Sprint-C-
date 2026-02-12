using System;
using System.Collections.Generic;
using System.Text;

namespace estudo_sprint.entities
{
   public class ContaCorrente : Contabancaria
    {
        public decimal TaxaSaque { get; private set; } = 2.00m;
        public ContaCorrente(string numeroConta, string senha, string Pessoatitular) : base(numeroConta, senha, Pessoatitular)
        {

        }

        public override void Sacar(decimal valor)
        {
            if(Saldo >= valor + TaxaSaque)
            {
                Saldo  -= valor + TaxaSaque;
            }
        }

    }
}
