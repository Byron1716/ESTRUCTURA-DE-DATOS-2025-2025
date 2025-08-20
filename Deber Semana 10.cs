class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        HashSet<string> ConjuntoPacientes = new HashSet<string>();

        while (numero < 500)
        {
            numero++;
            string paciente = $"Persona {numero}";
            ConjuntoPacientes.Add(paciente);
        }

        Console.WriteLine("\nLISTA DE TODOS LOS PACIENTES:");
        foreach (string paciente in ConjuntoPacientes)
        {
            Console.WriteLine(paciente);
        }

        int number = 0;
        HashSet<string> PersonasVacunadasPfizer = new HashSet<string>();

        while (number < 75)
        {
            number++;
            string paciente = $"Persona {number}";
            PersonasVacunadasPfizer.Add(paciente);
        }

        Console.WriteLine("\nPERSONAS VACUNADAS CON VACUNA PFIZER:");
        foreach (string pacient in PersonasVacunadasPfizer)
        {
            Console.WriteLine(pacient);
        }
        int number1 = 50;
        HashSet<string> PersonasVacunadasAztrazeneca = new HashSet<string>();

        while (number1 < 125)
        {
            number1++;
            string paciente2 = $"Persona {number1}";
            PersonasVacunadasAztrazeneca.Add(paciente2);
        }

        Console.WriteLine("\nPERSONAS VACUNADAS CON VACUNA AZTRAZENECA:");
        foreach (string pacient2 in PersonasVacunadasAztrazeneca)
        {
            Console.WriteLine(pacient2);
        }
        var pacientesVacunados = new HashSet<string>(PersonasVacunadasPfizer);

        Console.WriteLine("\nLos pacientes vacunados son:");
        int numeroPaciente = 0;
        pacientesVacunados.UnionWith(PersonasVacunadasAztrazeneca);
        foreach (string pacienteVacunado in pacientesVacunados)
        {
            Console.WriteLine(pacienteVacunado);
            numeroPaciente++;
        }

        Console.WriteLine($"\nLa cantidad total de pacientes vacunados son: {numeroPaciente} personas");

        var pacientesAmbasVacunas = new HashSet<string>(PersonasVacunadasPfizer);
        pacientesAmbasVacunas.IntersectWith(PersonasVacunadasAztrazeneca);
        Console.WriteLine("\nLos pacientes vacunados con ambas vacunas son:");
        int numero1 = 0;
        foreach (string pacientesConAmbasDosis in pacientesAmbasVacunas)
        {
            Console.WriteLine(pacientesConAmbasDosis);
            numero1++;
        }
        Console.WriteLine($"\nLa cantidad de pacientes vacunados con ambas dosis son: {numero1} personas");

        var soloPfizer = new HashSet<string>(PersonasVacunadasPfizer);
        soloPfizer.ExceptWith(PersonasVacunadasAztrazeneca);
        Console.WriteLine("\nLos pacientes vacunados solo con la vacuna Pfizer son:");
        int numero2 = 0;
        foreach (string pacienteVacunadosSoloConUnaDosisPfizer in soloPfizer)
        {
            Console.WriteLine(pacienteVacunadosSoloConUnaDosisPfizer);
            numero2++;
        }
        Console.WriteLine($"\nEl número de personas vacunadas con un solo tipo de vacuna (Pfizer) son: {numero2} personas");

        var soloAztrazeneca = new HashSet<string>(PersonasVacunadasAztrazeneca);
        soloAztrazeneca.ExceptWith(PersonasVacunadasPfizer);
        Console.WriteLine("\nLos paciente vacunados solo con la vacuna Aztrazeneca son:");
        int numero3 = 0;
        foreach (string pacienteVacunadosSoloConUnaDosisAztrazeneca in soloAztrazeneca)
        {
            Console.WriteLine(pacienteVacunadosSoloConUnaDosisAztrazeneca);
            numero3++;
        }
        Console.WriteLine($"\nEl número de personas vacunadas con un solo tipo de vacuna (Aztrazeneca) son: {numero3} personas");
        int personasSinVacunar = numero - numeroPaciente;
        Console.WriteLine();
        Console.WriteLine($"\nLa cantidad de personas que están sin vacunar son: {personasSinVacunar} personas");
        Console.WriteLine();
    }
}
