class Program
{
    static void Main()
    {
        Console.WriteLine();
        Console.WriteLine();
        ListaEnlazada lista = new ListaEnlazada();
        lista.AgregarAlFinal(1);
        lista.AgregarAlFinal(2);
        lista.AgregarAlFinal(3);
        lista.AgregarAlFinal(4);
        lista.AgregarAlFinal(5);
        lista.AgregarAlFinal(6);
        lista.AgregarAlFinal(7);
        lista.AgregarAlFinal(8);
        lista.AgregarAlFinal(9);
        lista.AgregarAlFinal(10);
        lista.AgregarAlFinal(11);
        lista.AgregarAlFinal(12);
        lista.AgregarAlFinal(13);
        lista.AgregarAlFinal(14);
        lista.AgregarAlFinal(15);
        lista.AgregarAlFinal(16);
        lista.AgregarAlFinal(17);
        lista.AgregarAlFinal(18);
        lista.AgregarAlFinal(19);
        lista.AgregarAlFinal(20);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Lista Original:");
        lista.Mostrar();
        lista.Invertir();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Lista Invertida:");
        lista.Mostrar();
        Console.WriteLine();
        Console.WriteLine();
    }
}
