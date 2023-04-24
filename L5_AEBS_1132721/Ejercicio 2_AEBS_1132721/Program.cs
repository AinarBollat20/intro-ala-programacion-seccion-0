internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 2 Ainar Estuardo Bollat Sam ");
        Console.Write("Ingrese el numero de dia: ");
        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 7");
                break;
        }
    }
}
