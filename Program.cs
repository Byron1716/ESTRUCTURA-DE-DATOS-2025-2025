partial class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        Random rnd = new Random();

        // 🔢 Generar 50 números aleatorios entre 1 y 999
        for (int i = 0; i < 50; i++)
        {
            int numero = rnd.Next(1, 1000);
            lista.Agregar(numero);
        }

        Console.WriteLine("=== Lista original ===");
        lista.Mostrar();

        // 📥 Leer rango permitido
        Console.Write("Ingrese el valor mínimo permitido: ");
        string minTexto = Console.ReadLine() ?? "1";
        int minimo = int.Parse(minTexto);

        Console.Write("Ingrese el valor máximo permitido: ");
        string maxTexto = Console.ReadLine() ?? "999";
        int maximo = int.Parse(maxTexto);

        // 🧹 Eliminar nodos fuera de rango
        lista.EliminarFueraDeRango(minimo, maximo);

        Console.WriteLine("=== Lista filtrada ===");
        lista.Mostrar();
    }
}
