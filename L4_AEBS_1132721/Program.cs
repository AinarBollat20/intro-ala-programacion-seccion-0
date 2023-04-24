internal class Program
{
    private static void Main(string[] args)
    {
        // Ejercicio 1: Operaciones aritméticas
        Console.WriteLine("Ejercicio 1: Operaciones aritméticas");

        // Permitir al usuario ingresar dos números
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Realizar las operaciones aritméticas y guardar el resultado en variables individuales
        double suma = num1 + num2;
        double resta = num1 - num2;
        double multiplicacion = num1 * num2;
        double division = num1 / num2;
        double div = (int)num1 / (int)num2;
        double mod = num1 % num2;

        // Mostrar los resultados en pantalla
        Console.WriteLine($"{num1} + {num2} = {suma}");
        Console.WriteLine($"{num1} - {num2} = {resta}");
        Console.WriteLine($"{num1} * {num2} = {multiplicacion}");
        Console.WriteLine($"{num1} / {num2} = {division}");
        Console.WriteLine($"{num1} div {num2} = {div}");
        Console.WriteLine($"{num1} mod {num2} = {mod}");

        // Ejercicio 2: Operaciones booleanas
        Console.WriteLine("\nEjercicio 2: Operaciones booleanas");

        // Mostrar los resultados de las operaciones booleanas
        Console.WriteLine($"{num1} > {num2} es {num1 > num2}");
        Console.WriteLine($"{num1} < {num2} es {num1 < num2}");
        Console.WriteLine($"{num1} = {num2} es {num1 == num2}");

        // Ejercicio 3: Jerarquía de operaciones
        Console.WriteLine("\nEjercicio 3: Jerarquía de operaciones");

        // Permitir al usuario ingresar tres números
        Console.Write("Ingrese el primer número: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Mostrar los resultados de las expresiones
        Console.WriteLine($"a * b + c = {a * b + c}");
        Console.WriteLine($"a * (b + c) = {a * (b + c)}");
        Console.WriteLine($"a * b * c = {a * b * c}");
        Console.WriteLine($"3 * a + 2 * b / c * 2 = {3 * a + 2 * b / c * 2}");

        // Resolver la expresión cuadrática
        Console.WriteLine("\nExpresión cuadrática");
        double discriminante = Math.Pow(b, 2) - 4 * a * c;

        if (a == 0 || discriminante < 0)
        {
            Console.WriteLine("No se puede calcular la expresión cuadrática debido a las condiciones ideales.");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            Console.WriteLine($"Las soluciones son: x1 = {x1}, x2 = {x2}");
        }
    }
}