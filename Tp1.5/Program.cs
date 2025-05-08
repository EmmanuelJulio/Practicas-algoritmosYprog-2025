using System;

namespace Tp1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos números desea ingresar? ");
            int cantidad;
            while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
            {
                Console.Write("Entrada inválida. Ingrese un número entero positivo: ");
            }

            double suma = 0;
            double numero;
            double maximo = double.MinValue;
            double minimo = double.MaxValue;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write("Ingrese el número {0}: ", i);
                while (!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("Entrada inválida. Ingrese un número válido: ");
                }

                suma += numero;
                if (numero > maximo) maximo = numero;
                if (numero < minimo) minimo = numero;
            }

            double promedio = suma / cantidad;

            Console.WriteLine();
            Console.WriteLine($"Valor máximo: {maximo}");
            Console.WriteLine($"Valor mínimo: {minimo}");
            Console.WriteLine($"Valor promedio: {promedio}");
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
