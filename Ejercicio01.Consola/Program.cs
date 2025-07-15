namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double promedio = 0;
            int contador = 1;
            int SumaNumeros = 0;
            int ContadorDePares = 0;
            int ContadorMayorA5 = 0;
            do
            {
                Console.Write($"Ingrese el {contador} número: ");
                if (int.TryParse(Console.ReadLine(), out int numeroCualq))
                {
                    contador++;
                    SumaNumeros += numeroCualq;
                    promedio = SumaNumeros / 5;
                    if (EsPar(numeroCualq))
                    {
                        ContadorDePares++;
                    }
                    if (MayorQue5(numeroCualq))
                    {
                        ContadorMayorA5++;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Ingrese un número valido");
                }
            } while (contador <= 5);
            Console.WriteLine($"La suma de los números ingresados da como resultado: {SumaNumeros}");
            Console.WriteLine($"El promedio de la suma de los números da: {promedio}");
            Console.WriteLine($"La cantidad de números pares ingresados fueron: {ContadorDePares}");
            Console.WriteLine($"La cantidad de números mayores a 5 fueron: {ContadorMayorA5}");
        }
        private static bool MayorQue5(int num)
        {
            return num > 5;
        }

        private static bool EsPar(int num)
        {
            return num % 2 == 0;
        }
    }
}
