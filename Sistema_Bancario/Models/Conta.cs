using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Bancario.Models
{
    public abstract class Conta
    {
        public string Titular{get;}
        public decimal Saldo {get; protected set;}

     protected Conta(string titular, decimal saldoinicial )
        {
            Titular = titular;
            Saldo = saldoinicial;
        }

        
        public void Depositar(decimal valor)
        {
            if (valor <=0)
            throw new ArgumentException("deposito precisa ser positivo");

             Saldo += valor;
            
        }

        public abstract void Sacar(decimal valor);


    }
}