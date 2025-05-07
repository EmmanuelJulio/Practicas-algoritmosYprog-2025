using System;
using Tp1_Algoritmos_y_programacion_2025.Entidades;

namespace Tp1_Algoritmos_y_programacion_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su Nomrbre..");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido..");
            var apellido = Console.ReadLine();
            Usuario user = new Usuario(nombre, apellido);
            Console.WriteLine($"Su nombre es: {user.Nombre}, y tu apellido es {user.Apellido}");
            Console.WriteLine("Precione alguna tecla para salir..");
            Console.ReadKey();

        }
    }
}
