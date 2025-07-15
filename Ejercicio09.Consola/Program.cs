namespace Ejercicio09.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contador = 0;
            var menorDigito = 10d;
            var numeroAlReves = "";
            var sumaDigitos = 0d;
            do
            {
                Console.Write("Ingrese un número mayor a 100: ");
                if (double.TryParse(Console.ReadLine(), out double numeroElegido) && numeroElegido > 100)
                {
                    contador++;
                    string conversionNumero = numeroElegido.ToString();
                    int cantidadDigitos = conversionNumero.Length;
                    do
                    {
                        double digito = numeroElegido % 10;
                        numeroElegido = (Math.Round(numeroElegido / 10));
                        if (digito < menorDigito)
                        {
                            menorDigito = digito;
                        }
                        numeroAlReves += digito.ToString() + "";
                        sumaDigitos += digito;
                    }
                    while (numeroElegido > 0);
                    if (conversionNumero==numeroAlReves)
                    {
                        Console.WriteLine("El número ingresado es Capicua");
                    }
                    else
                    {
                        Console.WriteLine($"El número al reves es: {numeroAlReves}");
                    }
                    Console.WriteLine($"Cantidad de dígitos del número ingresado: {cantidadDigitos}");
                    Console.WriteLine($"El menor dígito es: {menorDigito}");
                    Console.WriteLine($"La suma de sus dígitos da como resultado: {sumaDigitos}");
                }
                else
                {
                    Console.WriteLine("ERROR: Seleccion no válida");
                }
            }
            while (contador==0);
        }
    }
}
