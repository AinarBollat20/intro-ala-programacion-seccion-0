internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("LABORATORIO 8");

        
        Console.WriteLine("Por favor seleccione una opción:");
        Console.WriteLine("a) Sumatoria");
        Console.WriteLine("b) Mostrar tablas de multiplicar");
        Console.WriteLine("c) Número Perfecto");

        
        Console.Write("Ingrese la letra correspondiente a la opción: ");
        char opcion = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (opcion)
        {
            case 'a':
                
                int numero;
                do
                {
                    Console.Write("Ingrese un número: ");
                } while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0);

                int suma = 0;
                for (int i = 1; i <= numero; i++)
                {
                    suma += i;
                }
                Console.WriteLine("La suma de los números de 1 a {0} es: {1}", numero, suma);
                break;

            case 'b':
                
                do
                {
                    Console.Write("Ingrese el número de tabla de multiplicar que desea mostrar: ");
                } while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0);

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
                }
                break;

            case 'c':
                
                do
                {
                    Console.Write("Ingrese un número mayor a 0: ");
                } while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0);

                int suma_factores = 0;
                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        suma_factores += i;
                    }
                }

                if (suma_factores == numero)
                {
                    Console.WriteLine("{0} es un número perfecto", numero);
                }
                else
                {
                    Console.WriteLine("{0} no es un número perfecto", numero);
                }
                break;

            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}

