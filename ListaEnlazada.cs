//Creamos la lista que enlaza
ListaEnlazada lista = new ListaEnlazada();
lista.Agregar(10);          //Agregamos los datos 
lista.Agregar(20);          //Agregamos los datos 
lista.Agregar(30);          //Agregamos los datos 
lista.Agregar(40);          //Agregamos los datos 

Console.WriteLine();
Console.WriteLine("EJERCICIO 1");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Original:");         
lista.Mostrar();                        //Imprimimos la lista original

lista.Invertir();                       //Implementamos la función invertir

Console.WriteLine("Invertida:");
lista.Mostrar();                        //Imprimimos la lista invertida
Console.WriteLine();
Console.WriteLine();


