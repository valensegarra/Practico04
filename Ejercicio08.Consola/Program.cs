namespace Ejercicio08.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sumaNumeros = 0;
            var contador = 0;
            do
            {
                Random r = new Random();
                int numeroAzar = r.Next(10, 100);
                Console.WriteLine($"Número generado: {numeroAzar}");
                sumaNumeros += numeroAzar;
                contador++;
                if (contador>1 && sumaNumeros<500)
                {
                    Console.WriteLine($"Resultado Parcial: {sumaNumeros}");
                }
                EsperarTecla();
            }
            while (sumaNumeros<=500);
            Console.WriteLine($"Cantidad de números generados: {contador}");
            Console.WriteLine($"Resultado Final: {sumaNumeros}");
        }

        private static void EsperarTecla()
        {
            Console.WriteLine("Presione <ENTER> para continuar");
            Console.ReadKey();
        }
    }
}
