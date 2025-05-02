namespace Dsw2025Ej8.Domain;

public abstract class CuentaBancaria
{
    private TipoCuenta _tipo;
    private string _numero;
    public decimal _saldo { get; set;}
    private Estado _estado;
    private decimal _tasaDeInteres;
    private decimal _limiteDeDescubierto;
    private decimal _comision;
    private string[] _titulares;

    public CuentaBancaria(string numero, decimal saldo, TipoCuenta tipo, string[] titulares)
    {
        _numero = numero;
        _saldo = saldo;
        _tipo = tipo;
        _estado = Estado.Activa;
        _titulares = titulares;
    }
    #region Getters/Setters
    public string GetNumero()
    {
        return _numero;
    }

    public decimal GetSaldo()
    {
        return _saldo;
    }
    public TipoCuenta GetTipo()
    {
        return _tipo;
    }

    public Estado GetEstado()
    {
        return _estado;
    }

    public void SetEstado(Estado estado)
    {
        _estado = estado;
    }

    public decimal GetTasaDeInteres()
    {
        return _tasaDeInteres;
    }

    public void SetTasaDeInteres(decimal tasaDeInteres)
    {
        _tasaDeInteres = tasaDeInteres;
    }

    public decimal GetLimiteDeDescubierto()
    {
        return _limiteDeDescubierto;
    }

    public void SetLimiteDeDescubierto(decimal limiteDeDescubierto)
    {
        _limiteDeDescubierto = limiteDeDescubierto;
    }

    public decimal GetComision()
    {
        return _comision;
    }

    public void SetComision(decimal comision)
    {
        _comision = comision;
    }

    public string[] GetTitulares()
    {
        return _titulares;
    }
    #endregion

    public abstract void Depositar(decimal monto);

    public abstract void Retirar(decimal monto);

}
