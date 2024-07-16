using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> history = new Stack<string>();

        // Simulación de visitar páginas
        history.Push("Página 1");
        history.Push("Página 2");
        history.Push("Página 3");

        // Funcionalidad del botón "retroceder"
        Console.WriteLine("Retrocediendo en el historial...");
        while (history.Count > 0)
        {
            string pagina = history.Pop();
            Console.WriteLine($"Retrocediendo a: {pagina}");
        }
    }
}
