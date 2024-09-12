internal class Program
{
    private static void Main(string[] args)
    {
        double n;
        Console.WriteLine("Ingrese un número");
        n = double.Parse(Console.ReadLine());
       
        while (n != 0) {
            Console.WriteLine("Ingrese un número");
            n = double.Parse(Console.ReadLine());
        }
        if (n == 0) { Console.WriteLine("Programa terminado"); }

    }
}