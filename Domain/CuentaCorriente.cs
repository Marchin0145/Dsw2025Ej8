using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Dsw2025Ej8.Domain
{
    internal class CuentaCorriente : CuentaBancaria
    {

        public CuentaCorriente(string numero, decimal saldo, string[] titulares) : base(numero, saldo, TipoCuenta.CuentaCorriente, titulares)
        {

        }

        public override void Depositar(Decimal monto)
        {
            monto -= monto * _comision;
            _saldo += monto;
        }

        public override void Retirar(decimal monto)
        {

            try
            {

                if (_saldo - monto <= -_limiteDeDescubierto)
                {
                    _saldo -= monto;

                }
                else {
                    throw new SaldoInsuficiente("La cuenta no cuenta con saldo para la operacion solicitada.");
                }
                if (_saldo < 0)
                {

                    _estado = Estado.Suspendida;
                    throw new SaldoInsuficiente();
                }

            }
            catch (SaldoInsuficiente ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}