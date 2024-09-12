internal class Program
{
    private static void Main(string[] args)
    {
        int i = 1;
        String contra = "";
        
        while (i<=3) {
            Console.WriteLine("Ingrese su contraseña");
            contra = Console.ReadLine();
            if (contra == "casas")
            {
                Console.WriteLine("CONTRASEÑA CORRECTA");
                Console.WriteLine("BIENVENIDO");
                i = 4;
            } else if (contra != "casas") {
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