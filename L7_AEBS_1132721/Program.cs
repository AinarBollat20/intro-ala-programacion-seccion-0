using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace L7_AEBS_1132721
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero mayor que 0: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;
            int i = 0;

            Console.Write("Sucesión de Fibonacci: ");

            do
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
                i++;
            } while (i < n);

            Console.ReadLine();
        }
    }
   





        }
    

