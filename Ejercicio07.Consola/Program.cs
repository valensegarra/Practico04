
namespace Ejercicio07.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ciclo = true;
            var sumaNumeros = 0;
            var contadorPares = 0;
            var sumadorPares = 0;
            do
            {
                Console.Write("Ingrese el valor del primer extremo: ");
                if (int.TryParse(Console.ReadLine(), out int primerExtremo) && primerExtremo>0)
                {
                    ciclo = false;
                    do
                    {
                        Console.Clear();
                        Console.Write("Ingrese el valor del segundo extremo: ");
                        if (int.TryParse(Console.ReadLine(), out int segundoExtremo) && segundoExtremo > 0 && segundoExtremo>primerExtremo)
                        {
                            Console.Clear();
                            Console.WriteLine($"Los números encontrados entre los extremos {primerExtremo} y {segundoExtremo} son: ");
                            var contador = 0;
                            for (int numerosEncontrados=primerExtremo+1; numerosEncontrados<=segundoExtremo-1; numerosEncontrados++)
                            {
                                Console.WriteLine($"Número encontrado: {numerosEncontrados}");
                                sumaNumeros+=numerosEncontrados;
                                if (contador>0)
                                {
                                    Console.WriteLine($"Suma Parcial: {sumaNumeros}");
                                    Console.WriteLine("---");
                                }
                                if (EsPar(numerosEncontrados))
                                {
                                    contadorPares++;
                                    sumadorPares+=numerosEncontrados;
                                }
                                contador++;
                            }
                        }
                        else
                        {
                            MensajeError("ERROR: Ingreso de datos del extremo mayor no válido");
                        }
                    }
                    while (ciclo == true);
                }
                else
                {
                    MensajeError("ERROR: Ingreso de datos no válido");
                }
            }
            while (ciclo == true);
            Console.WriteLine($"Resultado Final: {sumaNumeros}");
            Console.WriteLine($"Cantidad de números pares: {contadorPares}");
            Console.WriteLine($"Suma de los números pares: {sumadorPares}");
        }
        private static bool EsPar(int nro)
        {
            return nro % 2 == 0;
        }

        private static void MensajeError(string msj)
        {
            Console.WriteLine(msj);
            Console.WriteLine("Presione <ENTER> para intentar de nuevo");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
