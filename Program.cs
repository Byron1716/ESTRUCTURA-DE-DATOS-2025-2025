class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        System.Random rnd = new System.Random();

        for (int i = 0; i < 50; i++)
        {
            int numero = rnd.Next(1, 1000); // entre 1 y 999
            lista.Agregar(numero);
        }

        Console.WriteLine();
        Console.WriteLine();
        System.Console.WriteLine("=== Lista original ===");
        lista.Mostrar();

        System.Console.Write("Ingrese el valor mínimo permitido: ");
        string minTexto = System.Console.ReadLine() ?? "1";
        int minimo = int.Parse(minTexto);

        System.Console.Write("Ingrese el valor máximo permitido: ");
        string maxTexto = System.Console.ReadLine() ?? "999";
        int maximo = int.Parse(maxTexto);

        lista.EliminarFueraDeRango(minimo, maximo);

        System.Console.WriteLine("=== Lista después del filtrado ===");
        lista.Mostrar();

        lista.Invertir();

        System.Console.WriteLine("=== Lista invertida ===");
        lista.Mostrar();
    }
}
