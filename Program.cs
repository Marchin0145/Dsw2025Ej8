using Dsw2025Ej8.Domain;

namespace Dsw2025Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] titulares1 = { "Juan Perez", "Maria Lopez" };
            string[] titulares2 = { "Carlos Garcia" };
            string[] titulares3 = { "Ana Lopez", "Pedro Ruiz" };
            string[] titulares4 = { "Luis Sanchez" };

            CuentaCorriente cuentaCorriente1 = new CuentaCorriente("123456", 1000m, titulares1);
            CuentaCorriente cuentaCorriente2 = new CuentaCorriente("654321", 500m, titulares2);

            CajaDeAhorro cajaDeAhorro1 = new CajaDeAhorro("789012", 2000m, titulares3) { _tasaDeInteres = 0.05m };
            CajaDeAhorro cajaDeAhorro2 = new CajaDeAhorro("210987", 1500m, titulares4) { _tasaDeInteres = 0.03m };

            cuentaCorriente1.Depositar(-200m);
            cuentaCorriente2.Depositar(50m);
           

            cuentaCorriente1.Retirar(100m);
            cuentaCorriente2.Retirar(100m);

            cajaDeAhorro1.Depositar(300m);
            cajaDeAhorro2.Depositar(150m);

            cajaDeAhorro1.Retirar(50000m);
            cajaDeAhorro2.Retirar(100m);



            cajaDeAhorro1.AplicarInteres();
            cajaDeAhorro2.AplicarInteres();

            /*Console.WriteLine($"Cuenta Corriente 1 saldo final: {cuentaCorriente1._saldo}");
            Console.WriteLine($"Cuenta Corriente 2 saldo final: {cuentaCorriente2._saldo}");
            Console.WriteLine($"Caja de Ahorro 1 saldo final: {cajaDeAhorro1._saldo}");
            Console.WriteLine($"Caja de Ahorro 2 saldo final: {cajaDeAhorro2._saldo}");
            */
            List<CuentaBancaria> cuentas = new List<CuentaBancaria>
            {
                cuentaCorriente1,
                cuentaCorriente2,
                cajaDeAhorro1,
                cajaDeAhorro2
            };

            foreach (var resumen in cuentas.Select(c => new { Numero = c._numero, Tipo = c._tipo, Saldo = c._saldo }))
            {
                Console.WriteLine($"Cuenta: {resumen.Numero} | Tipo: {resumen.Tipo} | Saldo: ${resumen.Saldo:F2}");
            }

        }
        


        }
    }

