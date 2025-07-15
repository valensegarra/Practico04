


namespace Ejercicio10.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroUsuario, menuOpcion;
            bool ciclo = true;
            do
            {
                Console.Write("Ingresar un número cualquiera mayor a cero: ");
                if (int.TryParse(Console.ReadLine(), out numeroUsuario))
                {
                    if (numeroUsuario>0)
                    {
                        ciclo = false;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: Número ingresado no válido");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Conversión no válida");
                }
            }
            while (ciclo==true);
            MostrarMenu();
            do
            {
                Console.Write("Seleccionar una opción (1-2-3): ");
                if (int.TryParse(Console.ReadLine(), out menuOpcion))
                {
                    if (menuOpcion>=1 && menuOpcion<=3)
                    {
                        break;
                    }              
                }
                else
                {
                    Console.WriteLine("ERROR: Conversión no válida");
                }
            }
            while (true);
            switch (menuOpcion)
            {
                case 1:
                    EsPar(numeroUsuario);
                    break;
                case 2:
                    EsPrimo(numeroUsuario);
                    break;
                case 3:
                    EsPerfecto(numeroUsuario);
                    break;
            }
        }

        private static void EsPerfecto(int numeroUsuario)
        {
            var sumaDividores = 0;
            for (int i = 1; i <=numeroUsuario-1 ; i++)
            {
                if (numeroUsuario % i == 0)
                {
                    sumaDividores += i;
                }
            }
            if (sumaDividores==numeroUsuario)
            {
                Console.WriteLine($"El número {numeroUsuario} es Perfecto");
            }
            else
            {
                Console.WriteLine($"El número {numeroUsuario} no es Perfecto");
            }
        }

        private static void EsPrimo(int numeroUsuario)
        {
            var resultado = 0;
            var raizNro = Math.Sqrt(numeroUsuario);
            for (int i = 2; i <= raizNro; i++)
            {
                resultado = numeroUsuario % i;
            }
            if (resultado == 0)
            {
                Console.WriteLine($"El {numeroUsuario} no es un número Primo");
            }
            else
            {
                Console.WriteLine($"El {numeroUsuario} es un número Primo");
            }
        }

        private static void EsPar(int numeroUsuario)
        {
            if (numeroUsuario % 2 == 0)
            {
                Console.WriteLine($"El número {numeroUsuario} es Par");
            }
            else
            {
                Console.WriteLine($"El número {numeroUsuario} es Impar");

            }
        }

        private static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Menú de Opciones");
            Console.WriteLine("1- Informar si el número es par o impar");
            Console.WriteLine("2- Informar si el número es primo o no");
            Console.WriteLine("3- Informar si el número es perfecto");
        }
    }
}
