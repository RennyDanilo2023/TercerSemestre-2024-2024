using System;
using System.Collections.Generic;

class Jugador
{
    public string Nombre { get; set; }
    public string Equipo { get; set; }
}

class TorneoFutbol
{
    private List<Jugador> jugadores = new List<Jugador>();

    public void RegistrarJugador(string nombre, string equipo)
    {
        jugadores.Add(new Jugador { Nombre = nombre, Equipo = equipo });
        Console.WriteLine("Jugador registrado exitosamente.");
    }

    public void MostrarJugadores()
    {
        Console.WriteLine("Lista de jugadores registrados:");
        foreach (var jugador in jugadores)
        {
            Console.WriteLine($"Jugador: {jugador.Nombre}, Equipo: {jugador.Equipo}");
        }
    }

    public void EliminarJugador(string nombre)
    {
        jugadores.RemoveAll(j => j.Nombre == nombre);
        Console.WriteLine("Jugador eliminado.");
    }
}

class Programa
{
    static void Main()
    {
        TorneoFutbol torneo = new TorneoFutbol();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("1. Registrar Jugador");
            Console.WriteLine("2. Mostrar Jugadores");
            Console.WriteLine("3. Eliminar Jugador");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Nombre del Jugador: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Equipo del Jugador: ");
                    string equipo = Console.ReadLine();
                    torneo.RegistrarJugador(nombre, equipo);
                    break;
                case 2:
                    torneo.MostrarJugadores();
                    break;
                case 3:
                    Console.Write("Nombre del Jugador a eliminar: ");
                    nombre = Console.ReadLine();
                    torneo.EliminarJugador(nombre);
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
