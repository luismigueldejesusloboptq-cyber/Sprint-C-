using System;
using System.Collections.Generic;
using System.Text;

namespace estudo_sprint.entities
{
    internal class Poupanca
    {
        public class ContaPoupanca : ContaBancaria
        {
            public override void Sacar(decimal valor)
            {
                Saldo = Saldo - valor;
            }
        }
    }
}
