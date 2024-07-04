using System;
using System.Collections.Generic;

namespace NumerosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                numeros.Add(i);
            }

            numeros.Reverse();

            Console.WriteLine("Números del 1 al 10 en orden inverso:");
            Console.WriteLine(string.Join(", ", numeros));
        }
    }
}
