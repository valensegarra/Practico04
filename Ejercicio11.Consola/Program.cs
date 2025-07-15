using System.Diagnostics.CodeAnalysis;

namespace Ejercicio11.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ciclo = "";
            var seguir = true;
            var contadorPersonas = 0d;
            var personaAlta = 0d;
            var masAlta = "";
            var personaBaja = 300d;
            var masBaja = "";
            var promedioAltura = 0d;
            var alturaCentimetros = 0;
            var sumaAlturas = 0;
            do
            {
                string nombre;
                do
                {
                    Console.Write("Ingrese un nombre: ");
                    nombre = Console.ReadLine();
                    if (string.IsNullOrEmpty(nombre)) // SI EL STRING ES NULL
                    {
                        Console.WriteLine("Falta ingresar el nombre");
                    }
                    else
                    {
                        break;
                    }
                } while (true); 
                do
                {
                    Console.Write("Ingrese la altura (en cm.): ");
                    if (int.TryParse(Console.ReadLine(), out alturaCentimetros) && alturaCentimetros>0 && alturaCentimetros <= 230)
                    {
                        seguir = false;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: Conversión no válida");
                    }
                }
                while (seguir == true);
                var alturaPies = alturaCentimetros / 30.48;
                contadorPersonas++;
                sumaAlturas += alturaCentimetros;
                promedioAltura = sumaAlturas / contadorPersonas;
                if (alturaCentimetros > personaAlta)
                {
                    personaAlta = alturaCentimetros;
                    masAlta = nombre;
                }
                if (alturaCentimetros < personaBaja)
                {
                    personaBaja = alturaCentimetros;
                    masBaja = nombre;
                }
                Console.WriteLine($"La altura ingresada equivale a {alturaPies:F2} pies");
                Console.WriteLine("¿Desea seguir ingresando datos?");
                Console.Write("Presione <S> para continuar, presione cualquier otra para salir: ");
                ciclo = Console.ReadLine();
            }
            while (ciclo.ToUpper() == "S");
            Console.WriteLine($"Cantidad de personas ingresadas: {contadorPersonas}");
            if (contadorPersonas>1)
            {
                Console.WriteLine($"La persona mas alta es {masAlta} con una altura de {personaAlta}cm.");
                Console.WriteLine($"La persona mas baja es {masBaja} con una altura de {personaBaja}cm.");
            }
            Console.WriteLine($"El promedio de altura es de {promedioAltura}cm.");
        }
    }
}
