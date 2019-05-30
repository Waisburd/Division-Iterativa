using System;

namespace division_iterativa
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividendo, divisor;

            try
            {
                pedirParametros(out dividendo, out divisor);
                Console.WriteLine(dividendo + " / " + divisor + " = " + dividir(dividendo, divisor));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static int dividir(int dividendo, int divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException();
            int cociente = 0;
            for(int i = dividendo; i > divisor; i -= divisor, cociente++);
            return cociente;
        }

        static void pedirParametros(out int dividendo, out int divisor)
        {
            Console.Write("Dividendo: ");
            dividendo = int.Parse(Console.ReadLine());
            Console.Write("Divisor: ");
            divisor = int.Parse(Console.ReadLine());
        }
    }
}
