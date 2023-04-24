using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su nombre:");
        string Nombre = Console.ReadLine();

        Console.WriteLine("Hola Mundo,");
        Console.WriteLine("soy" +  Nombre);

        /*COMENTARIOS*/

        Console.Write("Hola mundo,");
        Console.Write("soy"+  Nombre);
        Console.ReadKey();

        

        Console.WriteLine("Mi segundo programa");

        Console.WriteLine("Ingrese Nombre:");
            string sNombre = Console.ReadLine();
        Console.WriteLine("Ingrese Edad:");
        string sEdad = Console.ReadLine();
        Console.WriteLine("Ingrese Carrera:");
        string sCarrera = Console.ReadLine();
        Console.WriteLine("Ingrese Carne:");
        string sCarne = Console.ReadLine();

        Console.WriteLine("nombre:" + Nombre);
        Console.WriteLine("edad:" + sEdad);
        Console.WriteLine("carrera:" + sCarrera);
        Console.WriteLine("carne:" + sCarne);
        Console.ReadKey();
        

    }
}