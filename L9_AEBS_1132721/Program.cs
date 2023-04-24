using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_AEBS_1132721
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio No.9 ");
            Console.WriteLine();    
            Console.WriteLine("Ainar Estuardo Bollat Sam_1132721");
            Console.WriteLine();
            int opcion = 0;

            do
            {
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("1. Definición de try y catch");
                Console.WriteLine("2. Sumatoria de números pares");
                Console.WriteLine("3. Salir");

                try
                {
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("La sentencia try-catch se utiliza para manejar excepciones en C#. En un bloque try se coloca el código que podría generar una excepción, y en el bloque catch se maneja la excepción en caso de que se produzca. El bloque finally es opcional y se ejecuta siempre, independientemente de si se produjo o no una excepción.");
                            break;

                        case 2:
                            int sumatoria = 0;

                            for (int i = 2; i <= 1000; i += 2)
                            {
                                sumatoria += i;
                            }

                            Console.WriteLine("La sumatoria de números pares del 2 al 1000 es: " + sumatoria);
                            break;

                        case 3:
                            Console.WriteLine("Saliendo...");
                            break;

                        default:
                            Console.WriteLine("Opción inválida. Intente de nuevo.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe ingresar un número entero. Intente de nuevo.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ha ocurrido un error: " + ex.Message);
                }

                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (opcion != 3);
        }
    }
}
