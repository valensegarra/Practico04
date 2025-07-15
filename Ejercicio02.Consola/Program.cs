using static System.Formats.Asn1.AsnWriter;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ciclo = true;
            var pesosIngresados = 0;
            var sumaPesos = 0;
            var promedio = 0;
            var mayorPeso = 0;
            do
            {
                Console.Write("Ingrese un valor de peso en kilogramos (INGRESE 0 PARA SALIR): ");
                if (int.TryParse(Console.ReadLine(), out int kilogramos))
                {
                    var libras = kilogramos * 2.20462;
                    var onzas = kilogramos * 35.274;
                    var stone = kilogramos / 6.35029;
                    if (kilogramos==0)
                    {
                        ciclo = false;
                    }
                    else
                    {
                        Console.WriteLine($"{kilogramos} kg equivalen a {libras:F2} lb, también a {onzas:F2} oz. y a {stone:F2} st.");
                        pesosIngresados++;
                        sumaPesos += kilogramos;
                        promedio = sumaPesos / pesosIngresados;
                        if (kilogramos>mayorPeso)
                        {
                            mayorPeso = kilogramos;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("ERROR: Conversión no válida");
                }
            }
            while (ciclo == true);
            Console.WriteLine($"Ingresaste {pesosIngresados} pesos en el sistema");
            Console.WriteLine($"El promedio de la suma de los pesos dio como resultado: {promedio}");
            Console.WriteLine($"La mayor cantidad de peso ingresado fue: {mayorPeso}");
        }
    }
}
