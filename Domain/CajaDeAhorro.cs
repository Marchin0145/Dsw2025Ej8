using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    public class CajaDeAhorro:CuentaBancaria
    {
        public CajaDeAhorro(string numero, decimal saldo,string[] titulares ): base(numero,saldo,TipoCuenta.CajaDeAhorro, titulares){ 
        
        }
        public override void Depositar(decimal monto) {
            _saldo += monto;
        }
        public override void Retirar(decimal monto)
        {
            _saldo -= monto;
        }
        public void AplicarInteres()
    {
        if (GetTipo() == TipoCuenta.CajaDeAhorro)
        {
            _saldo += _saldo *GetTasaDeInteres(;
        }
    }
    }
}
