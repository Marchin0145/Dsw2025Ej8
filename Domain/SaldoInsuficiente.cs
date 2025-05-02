using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    internal class SaldoInsuficiente : Exception
    {
        public SaldoInsuficiente(string mensaje = "La cuenta no cuenta con saldo para la operación solicitada. Fue suspendida.")
         : base(mensaje) { }
    }
}
