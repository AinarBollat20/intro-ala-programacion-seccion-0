internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio No.1...");
        Console.WriteLine("Ingrese un numero:");
        int x = Convert.ToInt32(Console.ReadLine());
        ;
        switch (x)
        {
            case 1:
                 x < 0;
                Console.WriteLine("El numero es Negativo");
                break;
            case 2:
                x = 0;
                    Console.WriteLine("El Numero es 0 ");
                break;
            case 3:
                 x > 0;
                Console.WriteLine("El numero es positivo");
                break;

            default:
                Console.WriteLine("Ingresaste una letra :( ");
                break;



        }
    }
    }
            