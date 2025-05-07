using System;
using System.Runtime.CompilerServices;

namespace tp1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un mes");
            var numberMonth = Convert.ToInt32(Console.ReadLine());

            var targetMonht = string.Empty;

            switch (numberMonth)
            {
                case 1:
                    targetMonht = "Enero";
                    break;
                case 2:
                    targetMonht = "Febrero";
                    break;
                case 3:
                    targetMonht = "Marzo";
                    break;
                case 4:
                    targetMonht = "Abril";
                    break;
                case 5:
                    targetMonht = "Mayo";
                    break;
                case 6:
                    targetMonht = "Junio";
                    break;
                case 7:
                    targetMonht = "Julio";
                    break;
                case 8:
                    targetMonht = "Agosto";
                    break;
                case 9:
                    targetMonht = "Septiembre";
                    break;
                case 10:
                    targetMonht = "Octubre";
                    break;
                case 11:
                    targetMonht = "Noviembre";
                    break;
                case 12:
                    targetMonht = "Diciembre";
                    break;

                default:
                    targetMonht = "invalid";
                    break;
            }

            if (targetMonht == "invalid")
                Console.WriteLine($"Mes inválido");
            else
                Console.WriteLine($"El mes seleccionado es {targetMonht}");
        }
    }
}
