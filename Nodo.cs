// EJERCICIO 1

public class Nodo           //Creamos la clase nodo (público)
{
    public int Dato;            //Definimos la variable "Dato" tipo entero
    public Nodo Siguiente;      //Creamos un nuevo nodo con el nombre siguiente

    public Nodo(int valor)      //Creamos el nodo con valor entero
    {
        Dato = valor;           //Dato será igual a lo que esté dentro de valor
        Siguiente = null;
    }
}

public class ListaEnlazada
{
    public Nodo Cabeza;

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

    // 🔁 Método que invierte los nodos de la lista
    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = Cabeza;
        Nodo siguiente = null;

        while (actual != null)
        {
            siguiente = actual.Siguiente; // Guarda el siguiente nodo
            actual.Siguiente = anterior;  // Invierte la dirección
            anterior = actual;           // Mueve el puntero anterior
            actual = siguiente;          // Avanza al siguiente nodo
        }

        Cabeza = anterior; // La nueva cabeza es el último nodo original
    }

    public void Mostrar()
    {
        Nodo actual = Cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " → ");     //Imprimimos el formato con el cual se va a imprimir 
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");                  //Imprimos la palabra "null" para expresar 
    }
}



