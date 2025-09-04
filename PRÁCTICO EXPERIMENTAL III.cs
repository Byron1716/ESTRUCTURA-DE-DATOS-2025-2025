//Crear un programa para el registro de jugadores y equipos en un torneo de futbol usando teorías de conjuntos y mapas

//Creamos la clase programa
class Program
{
    static void Main(string[] args)             //Creamos el punto de entrada principal
    {
        int numero = 0;
        HashSet<string> ConjuntoJugadores = new HashSet<string>();        //Creamos el conjunto que contendrá a diferentes jugadores

        while (numero < 264)                                            //Creamos un bucle para que se creen 264 jugadores, esto debido a que crearemos 12 equipos y en cada equipo se inscribiran a 22 jugadores
        {
            numero++;
            string jugador = $"Jugador #{numero}";                      //Agreagamos la palabra jugador junto a un número del 1 al 264
            ConjuntoJugadores.Add(jugador);                             //Agregamos cada jugador al conjunto "ConjuntoJugadores"
        }

        HashSet<string> ClubesdeFutbol = new HashSet<string>();         //Creamos un conjunto que se llama ClubesdeFutbol en donde se almacenarán el nombre de los clubes en donde inscribiremos a nuestros jugadores
        ClubesdeFutbol.Add("Barcelona F.C");
        ClubesdeFutbol.Add("Real Madrid");
        ClubesdeFutbol.Add("A.C Milán");
        ClubesdeFutbol.Add("Liverpool");
        ClubesdeFutbol.Add("Manchester United");
        ClubesdeFutbol.Add("Arsenal");
        ClubesdeFutbol.Add("Atlético de Madrid");
        ClubesdeFutbol.Add("Bayern München");
        ClubesdeFutbol.Add("PSG");
        ClubesdeFutbol.Add("Chelsea");
        ClubesdeFutbol.Add("Manchester City");
        ClubesdeFutbol.Add("Juventus");


        Dictionary<string, HashSet<string>> Equipos = new Dictionary<string, HashSet<string>>();         // Diccionario para asignar jugadores a cada equipo

        List<string> jugadoresDisponibles = ConjuntoJugadores.ToList();                                 // Convertir conjunto de jugadores a lista para acceso aleatorio
        Random rnd = new Random();                                                                      // Creamos un random para escoger jugadores al alzar para cada equipo

        foreach (string club in ClubesdeFutbol)                                                         //Hacemos un foreach 
        {
            Equipos[club] = new HashSet<string>();

            while (Equipos[club].Count < 22)                                    //Creamos un bucle para que se agreguen 22 jugadores por equipo sin que ningún jugador se repita en 2 clubes
            {
                int indice = rnd.Next(jugadoresDisponibles.Count);              //Creamos una variable de tipo entero en donde vamos a asignar un índice a cada elemento de la lista jugadoresDisponibles aleatoriamente
                string jugadorSeleccionado = jugadoresDisponibles[indice];      //Guardamos la selección anterior por índice en una variable de tipo entero 

                Equipos[club].Add(jugadorSeleccionado);                         //Agregamos a cada jugador que se elija de manera aleatoria y lo añadimos a un club
                jugadoresDisponibles.RemoveAt(indice);                          // Eliminar para evitar duplicados
            }
        }

        // Mostrar los equipos y sus jugadores
        List<string> torneoLigadeCampeones = new List<string>();
        foreach (var equipo in Equipos)                                             //Creamos un ciclo para que se impriman todas las listas de los equipos
        {
            int number = 0;
            Console.WriteLine();                                                        //Finalmente creamos una varibale de tipo número para enumerar a los jugadores de cada club
            Console.WriteLine($"\n{equipo.Key} tiene los siguientes jugadores:");    //Imprimimos los jugadores que cada equipo tienen
            foreach (var jugador in equipo.Value)
            {
                number++;                                                           //aumentamos en uno cada vez que la varibale haga este ciclo
                Console.WriteLine($" {number}.- {jugador}");                        //Finalemnte imprmimos el enumerado del equipo mas el nombre del jugador
            }
            torneoLigadeCampeones.Add(equipo.Key);                                  //agregamos cada equipo al Torneo
            Console.WriteLine($"\nEl equipo {equipo.Key} fue agregado correctamente al torneo LIGA DE CAMPEONES"); // imprimos la confirmación de que cada equipo fue agregado correctamente
        }
        Console.WriteLine();
    }
}

