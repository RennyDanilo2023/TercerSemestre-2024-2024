using System;
using System.Collections.Generic;

class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnioPublicacion { get; set; }
}

class Biblioteca
{
    private List<Libro> libros = new List<Libro>();

    public void RegistrarLibro(string titulo, string autor, int anio)
    {
        libros.Add(new Libro { Titulo = titulo, Autor = autor, AnioPublicacion = anio });
        Console.WriteLine("Libro registrado exitosamente.");
    }

    public void MostrarLibros()
    {
        Console.WriteLine("Lista de libros registrados:");
        foreach (var libro in libros)
        {
            Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, Año: {libro.AnioPublicacion}");
        }
    }

    public void EliminarLibro(string titulo)
    {
        libros.RemoveAll(l => l.Titulo == titulo);
        Console.WriteLine("Libro eliminado.");
    }
}

class Programa
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("1. Registrar Libro");
            Console.WriteLine("2. Mostrar Libros");
            Console.WriteLine("3. Eliminar Libro");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Título del Libro: ");
                    string titulo = Console.ReadLine();
                    Console.Write("Autor del Libro: ");
                    string autor = Console.ReadLine();
                    Console.Write("Año de Publicación: ");
                    int anio = int.Parse(Console.ReadLine());
                    biblioteca.RegistrarLibro(titulo, autor, anio);
                    break;
                case 2:
                    biblioteca.MostrarLibros();
                    break;
                case 3:
                    Console.Write("Título del Libro a eliminar: ");
                    titulo = Console.ReadLine();
                    biblioteca.EliminarLibro(titulo);
                    break;
                case 4:
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}
