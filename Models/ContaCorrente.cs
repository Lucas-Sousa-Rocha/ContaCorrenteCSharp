using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrenteC_.Models
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }

        public ContaCorrente(int numeroConta, decimal saldoInicial = 0)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }
    }
}
