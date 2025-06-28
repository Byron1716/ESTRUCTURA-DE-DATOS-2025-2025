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
    Console.WriteLine($"Ingrese la materia #{x+1}");            //Concatenamos el mensaje con la variable x
    materia = Console.ReadLine();           //Variable en donde se almacenará cada materia por el for recorrido
    lista_de_materias.Add(materia);         //Agregamos cada materia a la lista: lista_de_materias
}

Console.WriteLine();            //Imprimimos un espacio en blanco, para separar las secciones del código
Console.WriteLine("Las materias ingresadas son: ");         //Imprimimos un mensaje para que se imprima la lista
foreach (string materia in lista_de_materias)           //Hacemos un recorrido de todos los elementos de la lista
{
    Console.WriteLine("- " + materia);          //Finalmente imprimimos la lista con un salto de línea; para cada materia se imprima en una línea
}


