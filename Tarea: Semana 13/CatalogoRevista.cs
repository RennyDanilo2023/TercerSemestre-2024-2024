using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear el catálogo de revistas
        List<string> catalogoRevistas = new List<string>
        {
            "Revista de Ciencia",
            "Revista de Tecnología",
            "Revista de Historia",
            "Revista de Literatura",
            "Revista de Medicina",
            "Revista de Economía",
            "Revista de Ingeniería",
            "Revista de Psicología",
            "Revista de Sociología",
            "Revista de Matemáticas"
        };

        int opcion;
        do
        {
            // Mostrar el menú
            Console.WriteLine("\nMenú de búsqueda de revistas:");
            Console.WriteLine("1. Buscar título (Iterativo)");
            Console.WriteLine("2. Buscar título (Recursivo)");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1 || opcion == 2)
            {
                Console.Write("Ingrese el título de la revista a buscar: ");
                string tituloBuscado = Console.ReadLine();

                bool encontrado;
                if (opcion == 1)
                {
                    // Búsqueda iterativa
                    encontrado = BusquedaIterativa(catalogoRevistas, tituloBuscado);
                }
                else
                {
                    // Búsqueda recursiva
                    encontrado = BusquedaRecursiva(catalogoRevistas, tituloBuscado, 0);
                }

                if (encontrado)
                {
                    Console.WriteLine("Resultado: Encontrado");
                }
                else
                {
                    Console.WriteLine("Resultado: No encontrado");
                }
            }
        } while (opcion != 3);

        Console.WriteLine("Programa finalizado.");
    }

    // Método de búsqueda iterativa
    static bool BusquedaIterativa(List<string> catalogo, string titulo)
    {
        foreach (string revista in catalogo)
        {
            if (revista.Equals(titulo, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    // Método de búsqueda recursiva
    static bool BusquedaRecursiva(List<string> catalogo, string titulo, int indice)
    {
        if (indice >= catalogo.Count)
        {
            return false;
        }
        if (catalogo[indice].Equals(titulo, StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }
        return BusquedaRecursiva(catalogo, titulo, indice + 1);
    }
}
