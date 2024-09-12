internal class Program
{
    private static void Main(string[] args)
    {
        int i = 0;
        Console.Write("Ingrese un número entero positivo: ");
        i = Convert.ToInt32(Console.ReadLine());
        while (i < 0) {
            Console.WriteLine("Error...");
            Console.Write("Ingrese un número entero positivo: ");
            i = Convert.ToInt32(Console.ReadLine());
        }
        while (i >= 0)
        {
            Console.WriteLine(i);
            i--;
        }

    }
}