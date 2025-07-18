﻿
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Ejercicio #1
        //Escribir un programa que almacene las asignaturas de un curso (por ejemplo Matemáticas, Física, Química, Historia y Lengua) en una lista y la muestre por pantalla.

        Console.WriteLine("EJERCICIO #1");
        Console.WriteLine();
        Console.WriteLine();

        //Ingresamos la estructura de para una lista
        List<string> lista_de_materias = new List<string>();
        int numero_de_materias; //Definimos el nombre de la variable que almacenará la cantidad de materias que deseamos ingresar
        Console.WriteLine("Ingrese la cantidad de materias que desea ingresar: ");          //Definimos el mensaje que va a aparecer en pantalla
        numero_de_materias = int.Parse(Console.ReadLine());         //Variable en la que se almacena el número que ingresó el usuario por consola
        Console.WriteLine();            //Imprimimos un espacio en blanco, para separar las secciones del código

        for (int x = 0; x < numero_de_materias; x++)            //Definimos un bucle for para ingresar el nombre de cada una de las materias ingresadas por el usuario
        {
            string materia;         //Definimos el nombre de la variable en donde se almacenará el nombre de cada una de las materias
            Console.WriteLine($"Ingrese la materia #{x + 1}");            //Concatenamos el mensaje con la variable x
            materia = Console.ReadLine();           //Variable en donde se almacenará cada materia por el for recorrido
            lista_de_materias.Add(materia);         //Agregamos cada materia a la lista: lista_de_materias
        }

        Console.WriteLine();            //Imprimimos un espacio en blanco, para separar las secciones del código
        Console.WriteLine("Las materias ingresadas son: ");         //Imprimimos un mensaje para que se imprima la lista
        foreach (string materia in lista_de_materias)           //Hacemos un recorrido de todos los elementos de la lista
        {
            Console.WriteLine("- " + materia);          //Finalmente imprimimos la lista con un salto de línea; para cada materia se imprima en una línea
        }

        Console.WriteLine();            //Imprimimos un espacio en blanco, para separar las secciones del código
        Console.WriteLine();            //Imprimimos un espacio en blanco, para separar las secciones del código
        // Ejercicio #2
        Console.WriteLine();            //Imprimimos un espacio en blanco, para separar las secciones del código
        Console.WriteLine("EJERCICIO #2");
        Console.WriteLine();            //Imprimimos un espacio en blanco, para separar las secciones del código
        Console.WriteLine();            //Imprimimos un espacio en blanco, para separar las secciones del código

        List<string> lista_nueva_de_materias = new List<string>();          //Creamos una nueva lista en donde se almacenan las materias del segundo ejercicio

        {
            lista_nueva_de_materias.Add("Estructura de Datos");         //Agregamos materias a nuestra lista
            lista_nueva_de_materias.Add("Instalaciones Eléctricas y Cableado Estructurado");            //Agregamos materias a nuestra lista
            lista_nueva_de_materias.Add("Fundamentos de Sistemas Digitales");           //Agregamos materias a nuestra lista
            lista_nueva_de_materias.Add("Administración de Sistemas Operativos");           //Agregamos materias a nuestra lista
            lista_nueva_de_materias.Add("Metodología de Investigación");            //Agregamos materias a nuestra lista
        }
        ;

        List<int> calificaciones = new List<int>();         //Creamos una nueva listra en donde se van a almacenar las calificaciones

        foreach (string materia in lista_nueva_de_materias)         //Recorremos la lista con un foreach para recorrer cada materia y pedir la nota al usuario
        {
            Console.WriteLine("Ingrese la calificación de " + materia);         //Pedimos al usuario que ingrese la nota para cada materia de la lista: lista_nueva_de_materias
            int nota = int.Parse(Console.ReadLine());           //Variable en la que se almacena el número que ingresó el usuario por consola
            calificaciones.Add(nota);           //Añadimos cada nota a la lista calificaciones
        }

        Console.WriteLine();            //Agregamos un salto de línea para separar el código

        for (int i = 0; i < lista_nueva_de_materias.Count; i++)     //Agregamos un for para recorrer cada una de las materias y poderlas imprimir junto con su nota respectiva
        {
            Console.WriteLine($"En la materia {lista_nueva_de_materias[i]} has sacado {calificaciones[i]}");           //Imprimimos la información de cada materia junto con su nota para que salga en pantalla
        }
        Console.WriteLine();            //Imprimimos un espacio en blanco, para separar las secciones del código
        Console.WriteLine();            //Imprimimos un espacio en blanco, para separar las secciones del código
                                        // Ejercicio #3 Escribir un programa que almacene en una lista los números del 1 al 10 y los muestre por pantalla en orden inverso separados por comas.
        Console.WriteLine();            //Imprimimos un espacio en blanco, para separar las secciones del código
        Console.WriteLine("EJERCICIO #3");
        Console.WriteLine();            //Imprimimos un espacio en blanco, para separar las secciones del código
        Console.WriteLine();            //Imprimimos un espacio en blanco, para separar las secciones del código
        List<int> numeros = new List<int>();         //Creamos una nueva listra en donde se van a almacenar los números del 1 al 10
        for (int x = 1; x <= 10; x++)
        {
            numeros.Add(x);
        }
        for (int i = 1; i <= numeros.Count; i++)
        {
            Console.Write(numeros[numeros.Count - i] + ", ");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("EJERCICIO #4");
        // Crear una lista con las letras del abecedario (A-Z)
        List<char> abecedario = new List<char>();
        for (char letra = 'A'; letra <= 'Z'; letra++)
        {
            abecedario.Add(letra);
        }

        // Crear una nueva lista eliminando las letras en posiciones múltiplos de 3
        List<char> resultado = new List<char>();
        for (int i = 0; i < abecedario.Count; i++)
        {
            if ((i + 1) % 3 != 0) // Posición humana: 1-based index
            {
                resultado.Add(abecedario[i]);
            }
        }

        // Mostrar la lista resultante
        Console.WriteLine();
        Console.WriteLine("Letras que no están en posiciones múltiplos de 3:");
        foreach (char letra in resultado)
        {
            Console.Write(letra + " ");
        }

        Console.WriteLine();
        ;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("EJERCICIO #5");          //Escribir un programa que almacene en una lista los siguientes precios, 50, 75, 46, 22, 80, 65, 8, y muestre por pantalla el menor y el mayor de los precios.
        List<int> precios = new List<int> { 50, 75, 46, 22, 80, 65, 8 };            // Agregamos la lista con los valores solicitados en el ejercicio
        int minimo = precios[0];            //Definimos la inicialización del valor mínimo
        int maximo = precios[0];            //Definimos la inicialización del valor máximo

        foreach (int precio in precios)         //Recorrer cada elemento de la lista precio
        {
            if (precio < minimo)            //definimos un condicional para comparar cada elemento para saber cuál es el menor
            {
                minimo = precio;            //imprimimos el valor mínimo de la lista
            }
            else if (precio > maximo)           //definimos un else para el caso en que no se cumpla la condición anterior
            {
                maximo = precio;            //imprimimos el valor mínimo de la lista            
            }
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("El valor mínimo es " + minimo);            //imprimimos el valor mínimo de la lista
        Console.WriteLine("El valor máximo es " + maximo);            //imprimimos el valor mínimo de la lista 

    }
}
