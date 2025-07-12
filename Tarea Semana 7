class Balanceador           //Definimos una clase llamada Balanceador, la cual contiene el método principal Main.
{
    static void Main()          //Creamos el punto de partida de entrada principal 
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
