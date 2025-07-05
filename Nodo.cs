// EJERCICIO 1 — Lista enlazada con inversión y filtrado por rango

public class Nodo
{
    public int Dato;               // Valor almacenado en el nodo
    public Nodo Siguiente;        // Referencia al siguiente nodo

    public Nodo(int valor)
    {
        Dato = valor;
        Siguiente = null;
    }
}

public class ListaEnlazada
{
    public Nodo Cabeza;

    // Agregar un nuevo nodo al final de la lista
    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (Cabeza == null)
        {
            Cabeza = nuevo;
        }
        else
        {
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // Mostrar los valores de la lista enlazada
    public void Mostrar()
    {
        Nodo actual = Cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " → ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null"); // Indica el final de la lista
    }

    // Invertir el orden de los nodos en la lista
    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = Cabeza;
        Nodo siguiente = null;

        while (actual != null)
        {
            siguiente = actual.Siguiente;
            actual.Siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }

        Cabeza = anterior; // La nueva cabeza será el último nodo original
    }

    // Eliminar nodos fuera del rango definido por el usuario
    public void EliminarFueraDeRango(int minimo, int maximo)
    {
        // Eliminar desde la cabeza si no está dentro del rango
        while (Cabeza != null && (Cabeza.Dato < minimo || Cabeza.Dato > maximo))
        {
            Cabeza = Cabeza.Siguiente;
        }

        // Eliminar nodos intermedios fuera del rango
        Nodo actual = Cabeza;
        while (actual != null && actual.Siguiente != null)
        {
            if (actual.Siguiente.Dato < minimo || actual.Siguiente.Dato > maximo)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
            }
            else
            {
                actual = actual.Siguiente;
            }
        }
    }
}


