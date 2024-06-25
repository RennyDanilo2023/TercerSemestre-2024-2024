using System;
using System.Collections.Generic;

namespace AsignaturasApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
            foreach (var asignatura in asignaturas)
            {
                Console.WriteLine($"Yo estudio {asignatura}");
            }
        }
    }
}
