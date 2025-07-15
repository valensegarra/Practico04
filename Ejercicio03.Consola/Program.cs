
using ConsoleTables;

namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int numeroTabla = 2; numeroTabla <= 7; numeroTabla++)
            {
                Console.Clear();
                Console.WriteLine($"Esta es la tabla de Multiplicacion del número {numeroTabla}");
                var tabla = new ConsoleTable("Numero", "Multiplicador", "Resultado");
                for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
                {
                    tabla.AddRow(numeroTabla, multiplicador, numeroTabla*multiplicador);
                    
                }
                Console.WriteLine(tabla.ToString());
                EsperarTecla();
            }
        }
        private static void EsperarTecla()
        {
            Console.WriteLine("Presione <ENTER> para continuar");
            Console.ReadKey();
        }
    }
}
