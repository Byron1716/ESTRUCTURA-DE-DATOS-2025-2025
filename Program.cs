using System;

class Circulo
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double CalcularArea()
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

class Rectangulo
{
    private double ancho;
    private double alto;

    public Rectangulo(double ancho, double alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    public double CalcularArea()
    {
        return ancho * alto;
    }

    public double CalcularPerimetro()
    {
        return 2 * (ancho + alto);
    }
}

class Program
{
    static void Main()
    {
        Circulo circulo = new Circulo(5);
        Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");
        Console.WriteLine($"Perímetro del círculo: {circulo.CalcularPerimetro()}");

        Rectangulo rectangulo = new Rectangulo(4, 7);
        Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
        Console.WriteLine($"Perímetro del rectángulo: {rectangulo.CalcularPerimetro()}");
    }
}
