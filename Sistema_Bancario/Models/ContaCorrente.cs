using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Bancario.Models
{
    public class ContaCorrente : Conta
    {
        private const decimal Limite = 200;
        public ContaCorrente (string Titular, decimal saldoinicial) : base (Titular, saldoinicial)
        {
            
        }

        public override void Sacar(decimal valor)
        {
           if (valor >= 0)
            throw new ArgumentException("saque precisa ser positivo");

           if (valor > Saldo + Limite)
            throw new ArgumentException("saldo insuficiente");

             Saldo -= valor; 
        }

    }
}