using System;
using System.Collections.Generic;

class Deportista
{
    public string Nombre { get; set; }
    public string Disciplina { get; set; }
    public string Premio { get; set; }
}

class PremiacionDeportiva
{
    // Diccionario donde la clave es el nombre del deportista (único) y el valor es el objeto Deportista
    private Dictionary<string, Deportista> deportistas = new Dictionary<string, Deportista>();

    public void RegistrarPremio(string nombre, string disciplina, string premio)
    {
        if (!deportistas.ContainsKey(nombre))
        {
            deportistas.Add(nombre, new Deportista { Nombre = nombre, Disciplina = disciplina, Premio = premio });
            Console.WriteLine("Premio registrado exitosamente.");
        }
        else
        {
            Console.WriteLine("El deportista ya está registrado.");
        }
    }

    public void MostrarPremiados()
    {
        Console.WriteLine("Lista de deportistas premiados:");
        foreach (var deportista in deportistas.Values)
        {
            Console.WriteLine($"Deportista: {deportista.Nombre}, Disciplina: {deportista.Disciplina}, Premio: {deportista.Premio}");
        }
    }

    public void EliminarPremiado(string nombre)
    {
        if (deportistas.Remove(nombre))
        {
            Console.WriteLine("Premiado eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("No se encontró un deportista con ese nombre.");
        }
    }
}

class Programa
{
    static void Main()
    {
        PremiacionDeportiva premiacion = new PremiacionDeportiva();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("1. Registrar Deportista Premiado");
            Console.WriteLine("2. Mostrar Deportistas Premiados");
            Console.WriteLine("3. Eliminar Deportista Premiado");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Nombre del Deportista: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Disciplina del Deportista: ");
                    string disciplina = Console.ReadLine();
                    Console.Write("Premio del Deportista: ");
                    string premio = Console.ReadLine();
                    premiacion.RegistrarPremio(nombre, disciplina, premio);
                    break;
                case 2:
                    premiacion.MostrarPremiados();
                    break;
                case 3:
                    Console.Write("Nombre del Deportista a eliminar: ");
                    nombre = Console.ReadLine();
                    premiacion.EliminarPremiado(nombre);
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
