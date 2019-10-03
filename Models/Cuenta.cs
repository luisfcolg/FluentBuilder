using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilder.Models
{
    class Cuenta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public string Propietario { get; set; }
        public double Tasa { get; set; }
        public TipoEnum Tipo { get; set; }
    }
}
