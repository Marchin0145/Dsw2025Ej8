namespace Dsw2025Ej8.Domain;

public abstract class CuentaBancaria
{
    public TipoCuenta _tipo { get;}
    public string _numero { get;}
    public decimal _saldo { get; set;}
    public Estado _estado { get; set;}
    public decimal _tasaDeInteres { get; set;}
    public decimal _limiteDeDescubierto { get; set;}
    public decimal _comision { get; set;}
    public string[] _titulares { get;}

    public CuentaBancaria(string numero, decimal saldo, TipoCuenta tipo, string[] titulares)
    {
        _numero = numero;
        _saldo = saldo;
        _tipo = tipo;
        _estado = Estado.Activa;
        _titulares = titulares;
    }

    public abstract void Depositar(decimal monto);

    public abstract void Retirar(decimal monto);

}
