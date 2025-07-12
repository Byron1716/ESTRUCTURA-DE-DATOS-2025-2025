class PilaManual
{
    char nombre;
    int[] pila;
    int tope;

    public PilaManual(char id, int capacidad)
    {
        nombre = id;
        pila = new int[capacidad];
        tope = -1;
    }

    public void Push(int valor)
    {
        pila[++tope] = valor;
    }

    public int Pop()
    {
        return pila[tope--];
    }

    public char Nombre()
    {
        return nombre;
    }
}
class Balanceador           //Definimos una clase llamada Balanceador, la cual contiene el método principal Main.
{
    public static void AnalizarExpresion()          //Creamos el punto de partida de entrada principal 
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("EJERCICIO 1");
        Console.WriteLine();
        Console.WriteLine();
        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";           //Se guarda la expresión matemática en un string llamado expresión
        Console.WriteLine("Expresión a analizar = {7 + (8 * 5) - [(9 - 7) + (4 + 1)]}");            //Imprimimos la expresión a analizar
        Console.WriteLine();        //Imprimimos un par de espacios
        Console.WriteLine();
        char[] pila = new char[expresion.Length];           //Se crea un arreglo tipo pila manual para almacenar los símbolos de apertura
        int tope = -1;          //Creamos una varibale "tope" que se inicializa en -1 para indicar que la pila está vacía.

        for (int i = 0; i < expresion.Length; i++)          //Creamos un for con una variable "i" que recorra desde 0 hasta la cantidad de elemnetos en la variable expresión 
        {
            char caracter = expresion[i];           //creamos una variable Caracter de tipo "Char" la cual va a ser igual a la posición que tome "i"

            if (caracter == '(' || caracter == '{' || caracter == '[')          //realizamos un if para comprobar si caracter inicia con "(", "[", ó "{"
            {
                pila[++tope] = caracter;            //En caso de encontrar un símbolo de apertura se guarda en pila y se incrementa "tope"
            }
            else if (caracter == ')' || caracter == '}' || caracter == ']')         //Creamos un Else if para evaluar si hay un símbolo de cierre y la pila está vacía (tope < 0), ya está desbalanceado.
            {
                if (tope < 0)           //evaluamos si tope es menor que 0 con base a lo anterior desarrollado
                {
                    Escribir($"La expresión {expresion} está desbalanceada");       //Definimos lo que queremos que se imprima
                    return;
                }

                char ultimo = pila[tope--];

                if ((caracter == ')' && ultimo != '(') ||           //Con este if analizamos si los símbolos de apertura y de cierre están invertidos
                    (caracter == '}' && ultimo != '{') ||
                    (caracter == ']' && ultimo != '['))
                {
                    Escribir($"La expresión {expresion} está desbalanceada");       //Guardamos la información que queremos que imprima
                    return;                                                         //Método return para devolver el valor
                }
            }
        }

        if (tope == -1)                                                             //Si tope queda en -1 significará que todos los símbolos fueron abiertos y cerrados correctamente
            Escribir($"La expresión {expresion} está balanceada");                  //Guardamos la inforamción que imprimiremos
        else
            Escribir($"La expresión {expresion} está desbalanceada");               //En caso de que no se cumpla lo antes mencionado guardará otra información
    }

    static void Escribir(string mensaje)                                            // definimos el método Escribir en el cual señalamos que es una variable de tipo "String"
    {
        Console.WriteLine(mensaje);                                                 //Imprimimos el mensaje
        Console.WriteLine();
        Console.WriteLine();
    }

}
class TorresDeHanoi                                 //Definimos la clase Torres de Hanoi
{
    public static void Ejecutar()
    {
        Console.WriteLine("EJERCICIO 2: TORRES DE HANOI");
        Console.WriteLine();
        int n = 5;
        //definimos la cantidad de barras con las que podamos mover los discos
        PilaManual origen = new PilaManual('A', n);         
        PilaManual auxiliar = new PilaManual('B', n);       
        PilaManual destino = new PilaManual('C', n);
        //Usamos un for para recorrer los discos selecionados 
        for (int i = n; i >= 1; i--)
        {
            origen.Push(i);         //Agregamos el números de discos
        }
        //Nombramos los nombres de los pilares entre los cuales se van a mover nuestros discos
        MoverTorres(n, origen, destino, auxiliar);
    }

    static void MoverTorres(int n, PilaManual origen, PilaManual destino, PilaManual auxiliar)
    {
        if (n == 1)
        {
            int disco = origen.Pop();           //Con esto cambiaremos entre los pilares de Hanoi
            destino.Push(disco);
            ImprimirMovimiento(disco, origen, destino);     //Imprimimos los movimientos
            return;
        }

        MoverTorres(n - 1, origen, auxiliar, destino);
        int discoCentral = origen.Pop();
        destino.Push(discoCentral);
        ImprimirMovimiento(discoCentral, origen, destino);
        MoverTorres(n - 1, auxiliar, destino, origen);
    }
        // definimos el como se van a mover los discos (punto de origen y punto de llegada)
    static void ImprimirMovimiento(int disco, PilaManual desde, PilaManual hacia)
    {
        Console.WriteLine("Mover disco " + disco + " de " + desde.Nombre() + " a " + hacia.Nombre());
    }
}

class Program
{
    static void Main()      //Definimos el método principal para ejecutar todos los métodos
    {
        //Ejecutamos ambos métodos
        Balanceador.AnalizarExpresion();            
        TorresDeHanoi.Ejecutar();
    }
}

