using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_AEBS_1132721
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== CALCULADORA ===");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Multiplicación");
                Console.WriteLine("3. Raíz Cuadrada");
                Console.WriteLine("4. Porcentaje");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion.ToLower())
                {
                    case "1":
                        Suma();
                        break;
                    case "2":
                        Multiplicacion();
                        break;
                    case "3":
                        RaizCuadrada();
                        break;
                    case "4":
                        Porcentaje();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
                Console.Write("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        static void Suma()
        {
            Console.Clear();
            Console.WriteLine("=== SUMA ===");
            Console.Write("Ingrese el número de valores a sumar: ");
            int n = int.Parse(Console.ReadLine());
            double suma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el valor {i + 1}: ");
                double valor = double.Parse(Console.ReadLine());
                suma += valor;
            }
            Console.WriteLine($"El resultado de la suma es: {suma}");
        }

        static void Multiplicacion()
        {
            Console.Clear();
            Console.WriteLine("=== MULTIPLICACIÓN ===");
            Console.Write("Ingrese el primer valor: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo valor: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a * b;
            Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
        }

        static void RaizCuadrada()
        {
            Console.Clear();
            Console.WriteLine("=== RAÍZ CUADRADA ===");
            Console.Write("Ingrese el valor: ");
            double a = double.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"La raíz cuadrada de {a} es: {resultado}");
        }

        static void Porcentaje()
        {
            Console.Clear();
            Console.WriteLine("=== PORCENTAJE ===");
            Console.Write("Ingrese el valor: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el porcentaje (0-100): ");
            double p = double.Parse(Console.ReadLine()) / 100;
            double resultado = a * p;
            Console.WriteLine($"El {p * 100}% de {a} es: {resultado}");
        }
    }
    }

