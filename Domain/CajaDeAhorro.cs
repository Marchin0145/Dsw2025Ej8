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

            try
            {
                this.VerificarEstado();
                ValidarMonto(monto);
                _saldo += monto;
            }catch(CuentaNoActiva ex){Console.WriteLine($"ERROR:{ex.Message}");} catch (MontoNoValidoException ex)
            { Console.WriteLine(ex.Message);}


        }
        public override void Retirar(decimal monto)
        {
            try
            {

                this.VerificarEstado();
                ValidarMonto(monto);
                _saldo -= monto;
            }catch (MontoNoValidoException ex){ Console.WriteLine(ex.Message);} catch (CuentaNoActiva ex){Console.WriteLine($"ERROR:{ex.Message}"); }
                
             
        }

        public void AplicarInteres()
    {
            try
            {
                this.VerificarEstado();
                _saldo += _saldo * _tasaDeInteres;
            }
            catch (CuentaNoActiva ex) { Console.WriteLine(ex); }
    }
    }
}
