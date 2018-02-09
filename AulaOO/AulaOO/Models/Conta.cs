using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AulaOO.Models
{
    public class Conta
    {
        public Double Saldo { get; set; }
        public String Nome { get; set; }


        public Conta(Double saldo)
        {
            this.Saldo = saldo;
        }

        public virtual String Sacar(Double montante)
        {
            this.Saldo -= montante;
            return "Seu saldo é: "+this.Saldo.ToString();
        }
    }
}