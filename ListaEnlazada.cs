public class Nodo           //Definimos la clase Nodo de manera pública
{
    public int Valor;           //Definimos la variable valor, misma que tendrá datos enteros
    public Nodo? Siguiente;         //Definimos el nodo Siguiente, para que pase al siguiente nodo

    public Nodo(int valor)          //Definimos el nodo Siguiente, para que pase al siguiente nodo
    {
        Valor = valor;
        Siguiente = null;
    }
}

public class ListaEnlazada          //Definimos la clase ListaEnlazada
{
    private Nodo? cabeza;           //Definimos la variable valor, misma que tendrá datos enteros

    public void AgregarAlFinal(int valor)           //Definimos la variable valor, mismo que tendrá datos enteros
    {
        Nodo nuevo = new Nodo(valor);
        if (cabeza == null)         //Agregamos un condicional para que cabeza tome la variable nuevo en caso de que cabeza se encuentre vacío
            cabeza = nuevo;
        else
        {
            Nodo actual = cabeza;           //En caso de que cabeza no sea "null" el nodo actual tomará el valor de cabeza 
            while (actual.Siguiente != null)            //Creamos un bucle en donde mientras el nodo actual apunte a algo que no se null, lo pase hasta que pase por todos los nodos
                actual = actual.Siguiente;
            actual.Siguiente = nuevo;           //Conecta el nuevo nodo al final de la lista, haciendo que el último nodo (actual) apunte hacia é
        }
    }

    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Valor + " → ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    // Aquí definimos el método necesario (Invertir)
    public void Invertir()
    {
        Nodo anterior = null;           //Nodo null o nulo
        Nodo actual = cabeza;           //Nodo actual
        Nodo siguiente = null;          //Nodo siguinete que toma el valor de nulo

        while (actual != null)
        {
            siguiente = actual.Siguiente;   // Guarda la referencia al siguiente nodo
            actual.Siguiente = anterior;    // Invierte el puntero
            anterior = actual;              // Avanza el puntero anterior
            actual = siguiente;             // Avanza en la lista
        }

        cabeza = anterior; // El último nodo procesado es la nueva cabeza
    }
}
