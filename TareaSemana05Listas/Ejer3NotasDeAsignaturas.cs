using System;
using System.Collections.Generic;

namespace AsignaturasApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
            Dictionary<string, int> notas = new Dictionary<string, int>();

            foreach (var asignatura in asignaturas)
            {
                Console.Write($"Introduce la nota de {asignatura}: ");
                int nota = int.Parse(Console.ReadLine());
                notas[asignatura] = nota;
            }

            foreach (var asignatura in asignaturas)
            {
                Console.WriteLine($"En {asignatura} has sacado {notas[asignatura]}");
            }
        }
    }
}
