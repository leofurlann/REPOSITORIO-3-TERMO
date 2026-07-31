using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Bancario.Models
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca (string Titular, decimal saldoinicial) : base (Titular, saldoinicial)
        {
            
        }

        public override void Sacar(decimal valor)
        {
           if (valor >= 0)
            throw new ArgumentException("saque precisa ser positivo");

           if (valor > Saldo) 
            throw new ArgumentException("saldo insuficiente");

             Saldo -= valor; 
        }

    }
}
