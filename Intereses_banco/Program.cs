using System;

namespace ProyeccionIntereses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario el capital inicial y leerlo desde la consola
            Console.WriteLine("Ingrese el capital inicial:");
            double capitalInicial = double.Parse(Console.ReadLine());

            // Solicitar al usuario el número de meses para la proyección y leerlo desde la consola
            Console.WriteLine("Ingrese el número de meses:");
            int numeroMeses = int.Parse(Console.ReadLine());

            // Declarar la tasa de interés mensual (0.7% es 0.007 en decimal)
            double tasaInteres = 0.007;

            // Inicializar el capital actual al capital inicial ingresado por el usuario
            double capitalActual = capitalInicial;

            // Mostrar la cabecera de la proyección
            Console.WriteLine("\nProyección de intereses mes a mes:");

            // Ciclo para calcular el capital mes a mes hasta el número de meses especificado
            for (int mes = 1; mes <= numeroMeses; mes++)
            {
                // Calcular el interés del mes y sumarlo al capital actual
                capitalActual += capitalActual * tasaInteres;

                // Mostrar el capital acumulado al final del mes actual con formato de moneda
                Console.WriteLine($"Mes {mes}: {capitalActual:C2}");
            }

            // Mostrar el capital final después del periodo de tiempo especificado
            Console.WriteLine($"\nCapital final después de {numeroMeses} meses: {capitalActual:C2}");

            // Pausar la consola para que no se cierre inmediatamente
            Console.WriteLine("\nPresione cualquier tecla para cerrar...");
            Console.ReadLine(); // Espera a que el usuario presione una tecla
        }
    }
}
