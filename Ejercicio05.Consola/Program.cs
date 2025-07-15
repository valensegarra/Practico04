namespace Ejercicio05.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ciclo="";
            var contadorTemperaturas = 0;
            var sumaTemperaturas = 0;
            var numeroMayor = 0;
            var numeroMenor = 0;
            double promedio = 0;
            do
            {
                Console.Write("Ingrese el valor de los Grados Celsius: ");
                if (int.TryParse(Console.ReadLine(), out int celsius))
                {
                    Console.WriteLine("Si desea ingresar mas datos seleccione la letra (S)");
                    Console.Write("Caso contrario presione cualquier letra: ");   
                    ciclo = Console.ReadLine();
                    contadorTemperaturas++;
                    sumaTemperaturas+= celsius;
                    promedio = sumaTemperaturas / contadorTemperaturas;
                    if (contadorTemperaturas==1)
                    {
                        numeroMayor=celsius;
                    }
                    else if (celsius > numeroMayor)
                    {
                        numeroMayor = celsius;
                    }
                    if (contadorTemperaturas == 1)
                    {
                        numeroMenor = celsius;
                    }
                    else if (celsius < numeroMenor)
                    {
                        numeroMenor = celsius;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Ingreso de datos no válido");
                }
            }
            while (ciclo.ToLower() == "s");
            Console.WriteLine($"Total de temperaturas ingresadas: {contadorTemperaturas}");
            Console.WriteLine($"Temperatura máxima: {numeroMayor}");
            Console.WriteLine($"Temperatura mínima: {numeroMenor}");
            Console.WriteLine($"Promedio de todas las temperaturas: {promedio}");

        }
    }
}
