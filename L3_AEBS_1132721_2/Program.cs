internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre y velocidad por kilómetro de los tres corredores:");
        string nombre1, nombre2, nombre3;
        double velocidad1, velocidad2, velocidad3;

        Console.Write("Nombre del corredor 1: ");
        nombre1 = Console.ReadLine();
        Console.Write("Velocidad del corredor 1 (en km/h): ");
        velocidad1 = double.Parse(Console.ReadLine());

        Console.Write("Nombre del corredor 2: ");
        nombre2 = Console.ReadLine();
        Console.Write("Velocidad del corredor 2 (en km/h): ");
        velocidad2 = double.Parse(Console.ReadLine());

        Console.Write("Nombre del corredor 3: ");
        nombre3 = Console.ReadLine();
        Console.Write("Velocidad del corredor 3 (en km/h): ");
        velocidad3 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad de kilómetros que se recorrerá en la carrera: ");
        double distancia = double.Parse(Console.ReadLine());

        double tiempo1 = distancia / velocidad1;
        double tiempo2 = distancia / velocidad2;
        double tiempo3 = distancia / velocidad3;

        Console.WriteLine("Tiempo de llegada de cada corredor:");
        Console.WriteLine("{0}: {1} horas", nombre1, tiempo1.ToString("F2"));
        Console.WriteLine("{0}: {1} horas", nombre2, tiempo2.ToString("F2"));
        Console.WriteLine("{0}: {1} horas", nombre3, tiempo3.ToString("F2"));

        double tiempo_ganador = Math.Min(Math.Min(tiempo1, tiempo2), tiempo3);
        string ganador;

        if (tiempo_ganador == tiempo1)
        {
            ganador = nombre1;
        }
        else if (tiempo_ganador == tiempo2)
        {
            ganador = nombre2;
        }
        else
        {
            ganador = nombre3;
        }

        Console.WriteLine("El ganador es {0} con un tiempo de {1} horas.", ganador, tiempo_ganador.ToString("F2"));

        if (tiempo_ganador == tiempo1)
        {
            if (tiempo2 < tiempo3)
            {
                Console.WriteLine("{0} llega en segundo lugar con una diferencia de {1} horas.", nombre2, (tiempo2 - tiempo_ganador).ToString("F2"));
                Console.WriteLine("{0} llega en tercer lugar con una diferencia de {1} horas.", nombre3, (tiempo3 - tiempo_ganador).ToString("F2"));
            }
            else
            {
                Console.WriteLine("{0} llega en segundo lugar con una diferencia de {1} horas.", nombre3, (tiempo3 - tiempo_ganador).ToString("F2"));
                Console.WriteLine("{0} llega en tercer lugar con una diferencia de {1} horas.", nombre2, (tiempo2 - tiempo_ganador).ToString("F2"));
            }
        }
        
  
}
}