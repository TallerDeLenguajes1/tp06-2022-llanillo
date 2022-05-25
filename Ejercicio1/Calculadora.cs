namespace Ejercicio1;

public class Calculadora
{

    private double _resultado;

    public Calculadora(double inicial)
    {
        _resultado = inicial;
    }

    public double Sumar(double termino)
    {
        _resultado += termino;
        return _resultado;
    }

    public double Restar(double termino)
    {
        _resultado -= termino;
        return _resultado;
    }

    public double Multiplicar(double termino)
    {
        _resultado *= termino;
        return _resultado;
    }

    public double Dividir(double termino)
    {
        _resultado /= termino;
        return _resultado;
    }

    public void Limpiar()
    {
        _resultado = 0;
    }

    public double VerResultado()
    {
        return _resultado;
    }
}
