internal class Program
{
    private static void Main(string[] args)
    {
        int i = 0;
        Console.WriteLine("Ingrese un número entero positivo");
        i = Convert.ToInt32(Console.ReadLine());
        while (i < 0) {
            Console.WriteLine("Error...");
            Console.WriteLine("Ingrese un número entero positivo");
            i = Convert.ToInt32(Console.ReadLine());
            
        }
        while (i >= 0)
        {
            Console.WriteLine(i);
            i--;
        }

    }
}