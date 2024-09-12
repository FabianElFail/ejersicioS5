internal class Program
{
    private static void Main(string[] args)
    {
        int i = 1;
        String contra = "",contra2;
        Console.WriteLine("Registre su contraseña");
        contra2 = Console.ReadLine();
        while (i<=3) {
            Console.WriteLine("Ingrese su contraseña");
            contra = Console.ReadLine();
            if (contra2 == contra)
            {
                Console.WriteLine("CONTRASEÑA CORRECTA");
                Console.WriteLine("BIENVENIDO");
                i = 4;
            } else if (contra2 != contra) {
                Console.WriteLine("Intento fallido");
                if (i == 3)
                {
                    Console.WriteLine("Intentos fallidos");
                    Console.WriteLine("Cerrando programa..");
                };
            }
            
            i ++;
        }
    }
}