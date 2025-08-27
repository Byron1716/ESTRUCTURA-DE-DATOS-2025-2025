class Program           //Creamos una clase Programa
{
    static void Main(string[] args)         //Creamos el punto de entrada principal
    {
        Dictionary<string, string> traduccion = new Dictionary<string, string>();           //Creamos un diccionario con el tipo de dato que tendrá la clave y el tipo de dato que tendrá el valor
        traduccion.Add("casa", "house");                                                    //Agregamos todas las claves y los valores
        traduccion.Add("cocina", "kitchen");
        traduccion.Add("ventana", "window");
        traduccion.Add("sala", "living room");
        traduccion.Add("año", "year");
        traduccion.Add("mes", "month");
        traduccion.Add("pais", "country");
        traduccion.Add("ciudad", "city");
        traduccion.Add("juego", "game");
        traduccion.Add("futbol", "soccer");
        traduccion.Add("carro", "car");
        traduccion.Add("botella de vino", "wine bottle");
        traduccion.Add("playa", "beach");
        traduccion.Add("arena", "sand");
        traduccion.Add("computadora", "computer");
        traduccion.Add("esfero", "pen");
        traduccion.Add("lapiz", "pencil");
        traduccion.Add("conejo", "rabbit");
        traduccion.Add("pato", "duck");
        traduccion.Add("cielo", "sky");

        Console.WriteLine("======================MENÚ=======================");             //Imprimos lo que queremos que se muestre en pantalla como mensaje inicial
        Console.WriteLine();
        Console.WriteLine("1. Traducir Frase");
        Console.WriteLine("2. Agregar palabras al Diccionario");
        Console.WriteLine("3. Salir");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Escribe una opción:");                                          //Le pedimos al usuario que ingrese el número de opción que desea realizar
        string seleccion = Console.ReadLine();

        if (seleccion == "1")                                                              //Configuramos la selección para el caso 1
        { 
            Console.WriteLine();
            Console.WriteLine("Frase a traducir:");
            Console.WriteLine("El dia de hoy hicimos un juego en donde un conejo y un pato dibujan una computadora en el cielo mientras están en la playa sentados sobre la arena");        //Imprimimos la frase que desamos traducir
            Console.WriteLine();
            string texto = "El dia de hoy hicimos un juego en donde un conejo y un pato dibujan una computadora en el cielo mientras están en la playa sentados sobre la arena";            //Definimos el texto que queremos que se traduzca
            string[] palabras = texto.Split(' ');                                          //Hacemos que la cadena separe palabra por palabra en una lsita de elementos

            Console.WriteLine("Traducción parcial:");                                      //Hacemos una impresión de la traducción parcial   
            foreach (string palabra in palabras)                                           //Hacemos un recorrido foreach, para recorra palabra por palabra buscando coincidencias
            {
                string palabraLimpia = palabra.ToLower().Trim(',', '.', ';', ':', '!', '?'); // Limpia signos
                if (traduccion.ContainsKey(palabraLimpia))                                 //Ponemos condiciones para ver si la frase contiene palabras del diccionario para traducirlas
                {
                    Console.Write(traduccion[palabraLimpia] + " ");                        //Hacemos una impresión de toda la frase aplicando la traducción de las palabras contenidas en el diccionario
                }
                else
                {
                    Console.Write(palabra + " ");                                          //En caso de no existan palabras contenidas dentro del diccionario se imprimirá la frase sin modificaciones
                }
            }
            Console.WriteLine();
        }
        else if (seleccion == "2")                                                         //Aquí damos la orden que hará si seleccionamos el número 2
        {
            Console.WriteLine("Escribe la palabra en español:");
            string esp = Console.ReadLine();                                                //Pedimos una palabra al usuario que estará en español
            Console.WriteLine("Escribe la traducción en inglés:");
            string eng = Console.ReadLine();                                                //Pedimos la traducción de la palabra que se ingresó anteriormente

            if (!traduccion.ContainsKey(esp.ToLower()))                                     //Ponemos una condición para que analice si la palabra llave es existente
            {
                traduccion.Add(esp.ToLower(), eng.ToLower());                               //En caso de nos existir el sistema agrega la nueva palabra
                Console.WriteLine("Palabra agregada correctamente.");
            }
            else
            {
                Console.WriteLine("La palabra ya existe en el diccionario.");               //Si la palabra ya existe, nos saldrá un mensaje en donde nos indica que dicha palabra ya existe
            }
        }
        else if (seleccion == "3")                                                          //Esta selcción nos saca del menú de selección
        {
            Console.WriteLine("¡Hasta luego!");
        }
        else
        {
            Console.WriteLine("Opción no válida.");                                         //Con esta selcción le decimos al usuario que si selecciona alguna otra opción nos dice que nuestra selección es incorrecta  
        }
    }
}
