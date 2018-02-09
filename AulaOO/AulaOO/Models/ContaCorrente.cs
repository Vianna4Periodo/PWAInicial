using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AulaOO.Models
{
    public class ContaCorrente:Conta
    {
        public Double ChequeEspecial { get; set; }

        public ContaCorrente(Double saldo): base(saldo)
        {
            this.ChequeEspecial = saldo / 2;
        }

        public override String Sacar(Double montante)
        {
            if(this.Saldo - montante <= 0)
            {
                this.Saldo += this.ChequeEspecial;
            }

            this.Saldo -= montante;
            return "Seu saldo é: " + this.Saldo.ToString();
        }
    }
}