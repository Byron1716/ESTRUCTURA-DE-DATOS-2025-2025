//Creamos la clase Estudiante 
class Estudiante
//Definimos los parámetros de nuestra clase 
{
    public int Id;
    public string Nombres;
    public string Apellidos;
    public string Direccion;
    public string[] Telefonos = new string[3];
//Definimos los métodos para que sean mostrados en pantalla al finalizar el código
    public void MostrarDatos()
    {
        System.Console.WriteLine("ID: " + Id);
        System.Console.WriteLine("Nombres: " + Nombres);
        System.Console.WriteLine("Apellidos: " + Apellidos);
        System.Console.WriteLine("Dirección: " + Direccion);
        System.Console.WriteLine("Teléfonos:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            System.Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
        }
    }
}
//Definimos la clase Programa
class Programa
{

//Definimos el método para que pregunte al usuario
    static void Main(string[] args) //Vamos a definir la la variable respuesta para que se repita de manera indefinida hasta que usuario responda que no
    {
    
        string Respuesta; //Definimos un Do While para que se cumpla al menos una vez el bucle  
        do
        {
            Estudiante estudiante = new Estudiante(); //Definimos las preguntas que el usuario va a responder 
            System.Console.Write("Ingrese ID: ");
            estudiante.Id = int.Parse(System.Console.ReadLine());

            System.Console.Write("Ingrese nombres: ");
            estudiante.Nombres = System.Console.ReadLine();

            System.Console.Write("Ingrese apellidos: ");
            estudiante.Apellidos = System.Console.ReadLine();

            System.Console.Write("Ingrese dirección: ");
            estudiante.Direccion = System.Console.ReadLine();

            for (int i = 0; i < estudiante.Telefonos.Length; i++)
            {
                System.Console.Write($"Ingrese teléfono {i + 1}: ");
                estudiante.Telefonos[i] = System.Console.ReadLine();
            }
            
            System.Console.WriteLine("\n=== Datos del Estudiante ==="); //Llamamos a la función para que nos muestre los datos ingresados
            estudiante.MostrarDatos(); //Ingresamos la pregunta del blucle, (Siempre que el usuario responda con la S, se repetirá el bucle)
           
            System.Console.Write("\n¿Deseas agregar a otro estudiante? (Escribe S para Si o N para no): "); //Incluiremos este código para incluir a las letras mayúsculas en caso de ser ingresadas
            
            Respuesta = System.Console.ReadLine().ToLower(); //Creamos el bucle while para que se repita hasta que usuario ingrese cualquier otra letra que no sea la s
        
        } while (Respuesta == "s");
        System.Console.WriteLine("\nFin del programa");
    }
}
