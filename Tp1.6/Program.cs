using System;
using System.Collections.Generic;

namespace Tp1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var TargetNumbers = new List<int>();
            for (int numero = 40; numero <= 352; numero++) 
            {
                if (numero % 2 != 0) {
                    if(numero % 3 == 0)
                        TargetNumbers.Add(numero);
                }
                    
            }
            Console.WriteLine("Los numeros que cumplen con ser impares y a la vez divisibles por 3 son los siguientes: ");
            foreach (int numero in TargetNumbers) {
                Console.Write(numero +", ");
            }
        }

    }
}
