

namespace Ejercicio06.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ciclo = true;
            do
            {
                Console.Write("Ingrese un número cualquiera: ");
                if (int.TryParse(Console.ReadLine(), out int numeroCualquiera) && numeroCualquiera>0)
                { 
                    MenuOpcion();
                    do
                    {
                        Console.Write("Ingrese una opción del menú: ");
                        if (int.TryParse(Console.ReadLine(), out int opcionMenu) && opcionMenu == 1 || opcionMenu == 2)
                        {
                            ciclo = true;
                            if (opcionMenu == 1)
                            {
                                Multiplicar(numeroCualquiera, 1, 12);
                                ciclo = false;
                            }
                            else if (opcionMenu==2)
                            {
                                Console.Write("Ingrese el valor del primer extremo: ");
                                if (int.TryParse(Console.ReadLine(), out int primerExtremo))
                                {
                                    Console.Write("Ingrese el valor del segundo extremo: ");
                                    if (int.TryParse(Console.ReadLine(), out int segundoExtremo))
                                    {
                                        Multiplicar(numeroCualquiera, primerExtremo, segundoExtremo);
                                        ciclo = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERROR: Ingreso del segundo extremo no válido");

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("ERROR: Ingreso del primer extremo no válido");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("ERROR: Opcion del menú no válida");
                        }
                    }
                    while (ciclo == true);
                }
                else
                {
                    Console.WriteLine("ERROR: Ingreso de datos no válido");
                }
            }
            while (ciclo == true);
            

        }

        private static void Multiplicar(int nro, int exUno, int exDos)
        {
            Console.Clear();
            Console.WriteLine("Tabla de Multiplicación");
            if (exUno>exDos)
            {
                int auxiliar = exDos;
                exDos = exUno;
                exUno = auxiliar;
            }
            for (int i = exUno; i <= exDos; i++)
            {
                Console.WriteLine($"{nro} x {i} = {nro * i}");
            }
        }

        private static void MenuOpcion()
        {
            Console.WriteLine("Menú de Opciones");
            Console.WriteLine("1- Tabla de multiplicar entre 1 y 12");
            Console.WriteLine("2- Tabla de multiplicar entre dos números cualesquiera");
        }
    }
}
