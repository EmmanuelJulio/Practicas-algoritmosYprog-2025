using System;

namespace Tp1_Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el numero 1..");
            var n1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese el numero 2..");
            var n2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado de la suma es: {n1 + n2}");
        }
    }
}
