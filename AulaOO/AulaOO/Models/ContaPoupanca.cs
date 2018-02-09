using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AulaOO.Models
{
    public class ContaPoupanca : Conta
    {
        public Double Rendimento { get; set; }

        public ContaPoupanca(Double Saldo) :base(Saldo)
        {

        }
    }
}