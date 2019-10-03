using System;
using System.Collections.Generic;
using System.Text;
using FluentBuilder.Models;

namespace FluentBuilder.Builder
{
    class CuentaFluentBuilder
    {
        private readonly Cuenta _cuenta;

        public static CuentaFluentBuilder Crear(TipoEnum tipo)
        {
            return new CuentaFluentBuilder(tipo);
        }

        private CuentaFluentBuilder(TipoEnum tipo)
        {
            _cuenta = new Cuenta { Tipo = tipo, Saldo = 0, Tasa = 0, Propietario = "" };
        }

        public CuentaFluentBuilder AgregarNumero(int numero)
        {
            _cuenta.Numero = numero;
            return this;
        }

        public CuentaFluentBuilder AgregarPropietario(string propietario)
        {
            _cuenta.Propietario = propietario;
            return this;
        }

        public CuentaFluentBuilder AgregarTasa(double tasa)
        {
            _cuenta.Tasa = tasa;
            return this;
        }

        public CuentaFluentBuilder AgregarSaldo(double saldo)
        {
            _cuenta.Saldo = saldo;
            return this;
        }

        public Cuenta Finalizar()
        {
            return _cuenta;
        }
    }
}