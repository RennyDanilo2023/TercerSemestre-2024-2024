using System;
using System.Collections.Generic;

namespace LoteriaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numerosGanadores = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Introduce un número ganador de la lotería: ");
                int numero = int.Parse(Console.ReadLine());
                numerosGanadores.Add(numero);
            }

            numerosGanadores.Sort();

            Console.WriteLine("Números ganadores ordenados de menor a mayor:");
            foreach (var numero in numerosGanadores)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
