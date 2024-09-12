internal class Program
{
    private static void Main(string[] args)
    {
        String re = "s";
        double suma = 0,cant=0;   
        while (re == "s") {
            Console.WriteLine("Desea participar (s/n)?");
            re = Console.ReadLine();
            re = re.Trim();
            re = re.ToLower();
            if (re == "s") {
                Console.WriteLine("Ingrese edad");
                int edad = Convert.ToInt32(Console.ReadLine());
                suma += edad;
                cant += 1;
            }
            

        }
        double prom = suma / cant;
        Console.WriteLine($"El promedio de {cant} edades es {prom}");
    }
}