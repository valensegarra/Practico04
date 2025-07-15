using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio04.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var SumaNumeros = 0;
            var ContadorNumerosGenerados = 0;
            var promedio = 0;
            var numeroMayor = 0;
            var numeroMenor = 0;
            do
            {
                Random r = new Random();
                int numeroAzar = r.Next(1, 50);
                Console.WriteLine($"Número generado: {numeroAzar}");
                SumaNumeros += numeroAzar;
                ContadorNumerosGenerados++;
                promedio = SumaNumeros / ContadorNumerosGenerados;
                if (ContadorNumerosGenerados == 1)
                {
                    numeroMayor = numeroAzar;
                }
                else if (numeroAzar > numeroMayor)
                {
                    numeroMayor = numeroAzar;
                }
                if (ContadorNumerosGenerados == 1)
                {
                    numeroMenor = numeroAzar; 
                }
                else if (numeroAzar < numeroMenor)
                {
                    numeroMenor = numeroAzar;
                }
            }
            while (SumaNumeros<=100);
            Console.WriteLine($"La cantidad de números generados fueron: {ContadorNumerosGenerados}");
            Console.WriteLine($"Número mayor: {numeroMayor}");
            Console.WriteLine($"Número menor: {numeroMenor}");
            Console.WriteLine($"Promedio de la muestra: {promedio}");
        }       
    }
}
