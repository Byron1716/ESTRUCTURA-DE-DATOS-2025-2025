//Creamos una clase usando el estilo PascalCase
class CatalogoRevistas
{
    //Ingresamos el punto de partida principal
    static void Main()
    {
        //Creamos una lista a la cual llamaremos "catalogo"
        List<string> catalogo = new List<string>();
        //Agregamos los elementos a la lista "catalogo"
        catalogo.Add("Nature");
        catalogo.Add("Science");
        catalogo.Add("The Lancet");
        catalogo.Add("New England Journal of Medicine");
        catalogo.Add("SciELO");
        catalogo.Add("Redalyc");
        catalogo.Add("Latindex");
        catalogo.Add("Scopus");
        catalogo.Add("Alteridad");
        catalogo.Add("DIALNET");

        //Creamos un menú de opciones
        Console.WriteLine("\n========== MENÚ DE OPCIONES ==========");
        Console.WriteLine();
        Console.WriteLine("\n1.- BUSCAR REVISTA");
        Console.WriteLine("2.- SALIR");
        Console.WriteLine();
        Console.WriteLine();
        //Preguntamos al usuario sobre que operación desea ralizar
        Console.WriteLine("¿Qué opción desea realizar?: ");
        //Almacenamos la respuesta en una varibale
        string respuesta = Console.ReadLine();

        //Cambiamos todos los elementos de la lista a minúscula para que la búsqueda sea mucho mas efectiva
        List<string> catalogoMinusculas = catalogo.Select(n => n.ToLower()).ToList();
        //Creamos un bucle para que el usuario no responda algo diferente a las opciones dadas
        while (respuesta != "1" && respuesta != "2")
        {
            Console.WriteLine("La opción seleccionada no existe");
            Console.WriteLine("¿Qué opción desea realizar?: ");
            respuesta = Console.ReadLine();
        }
        //Ceramos un condicional, para las respuestas al menú interactivo
        if (respuesta == "1")
        {
            //Pedimos al usuario que ingrese el nombre de la revista que deseamos buscar
            Console.WriteLine("¿Qué revista deseas buscar?: ");
            string revistaBuscada = Console.ReadLine();
            //Creamos una variable en donde se almacena el texto en minúsculos
            string revistaMinuscuala = revistaBuscada.ToLower();
            //Con el primer condicional verficamos si una de la variable ingresada se encuentra dentro de la lista principal
            if (catalogoMinusculas.Contains(revistaMinuscuala))
            {
                //Imprimimos la opción en caso de ser encontrada
                Console.WriteLine($"\nRevista {revistaBuscada} ENCONTRADA");
            }
            else
            {
                //Imprimimos la opción en caso de no ser encontrada
                Console.WriteLine($"\nRevista {revistaBuscada} NO FUE ENCONTRADA");
            }
        }

        //Ponemos un segundo if para la segunda opción del menú principal
        if (respuesta == "2")
        {
            //Imprimimos un mensaje de despedida para finalizar
            Console.WriteLine("Gracias por usar nuestro servicio");
        }

    }    
}
