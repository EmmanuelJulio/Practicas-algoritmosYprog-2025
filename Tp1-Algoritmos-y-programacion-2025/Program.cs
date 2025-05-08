using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Tp1_Algoritmos_y_programacion_2025.Entidades;

namespace Tp1_Algoritmos_y_programacion_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userlist = new List<Usuario>();


            foreach (Usuario usuario in userlist) 
            {
                if (usuario.PagoLaCuenta())
                    Console.WriteLine($"Se procede a mandar mail de intimacion a {usuario.Nombre}");

            }

            Console.WriteLine("Ingrese el nombre de la persona numero 1..");
            var nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese su Edad..");
            var edad1 = Convert.ToInt32(Console.ReadLine());
            Usuario user1 = new Usuario(edad1, nombre1);

            Console.WriteLine("Ingrese el nombre de la persona numero 2..");
            var nombre2 = Console.ReadLine();
            Console.WriteLine("Ingrese su Edad..");
            var edad2 = Convert.ToInt32(Console.ReadLine());

            Usuario user2 = new Usuario(edad2, nombre2);

            Usuario olderUser;

            if (user1.Edad > user2.Edad)
                olderUser = user1;
            else
                olderUser = user2;


            Console.WriteLine($"El usuario mas grande es {olderUser.Nombre}");

            Console.WriteLine("Precione alguna tecla para salir..");
            Console.ReadKey();

            //Console.WriteLine("Ingrese el numero 1..");
            //var n1 = double.Parse(Console.ReadLine());


            //Console.WriteLine("Ingrese el numero 2..");
            //var n2 = double.Parse(Console.ReadLine());

            //Console.WriteLine($"El resultado de la suma es: {n1 + n2}");
        }
    }
}
