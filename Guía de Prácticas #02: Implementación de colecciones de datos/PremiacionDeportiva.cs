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
    private List<Deportista> deportistas = new List<Deportista>();

    public void RegistrarPremio(string nombre, string disciplina, string premio)
    {
        deportistas.Add(new Deportista { Nombre = nombre, Disciplina = disciplina, Premio = premio });
        Console.WriteLine("Premio registrado exitosamente.");
    }

    public void MostrarPremiados()
    {
        Console.WriteLine("Lista de deportistas premiados:");
        foreach (var deportista in deportistas)
        {
            Console.WriteLine($"Deportista: {deportista.Nombre}, Disciplina: {deportista.Disciplina}, Premio: {deportista.Premio}");
        }
    }

    public void EliminarPremiado(string nombre)
    {
        deportistas.RemoveAll(d => d.Nombre == nombre);
        Console.WriteLine("Premiado eliminado.");
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
