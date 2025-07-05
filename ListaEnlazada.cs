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

    public void Mostrar()
    {
        Nodo actual = Cabeza;
        while (actual != null)
        {
            System.Console.Write(actual.Dato + " → ");
            actual = actual.Siguiente;
        }
        System.Console.WriteLine("null");
    }

    public void EliminarFueraDeRango(int minimo, int maximo)
    {
        while (Cabeza != null && (Cabeza.Dato < minimo || Cabeza.Dato > maximo))
        {
            Cabeza = Cabeza.Siguiente;
        }

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

    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = Cabeza;
        Nodo siguiente;

        while (actual != null)
        {
            siguiente = actual.Siguiente;
            actual.Siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }

        Cabeza = anterior;
    }
}



