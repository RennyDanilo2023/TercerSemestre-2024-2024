using System;
using System.Collections.Generic;

class Jugador
{
    public string Nombre { get; set; }
    public string Equipo { get; set; }
}

class TorneoFutbol
{
    // Usamos un diccionario donde la clave es el nombre del jugador y el valor es el objeto Jugador
    private Dictionary<string, Jugador> jugadores = new Dictionary<string, Jugador>();

    public void RegistrarJugador(string nombre, string equipo)
    {
        if (!jugadores.ContainsKey(nombre))
        {
            jugadores.Add(nombre, new Jugador { Nombre = nombre, Equipo = equipo });
            Console.WriteLine("Jugador registrado exitosamente.");
        }
        else
        {
            Console.WriteLine("El jugador ya está registrado.");
        }
    }

    public void MostrarJugadores()
    {
        Console.WriteLine("Lista de jugadores registrados:");
        foreach (var jugador in jugadores.Values)
        {
            Console.WriteLine($"Jugador: {jugador.Nombre}, Equipo: {jugador.Equipo}");
        }
    }

    public void EliminarJugador(string nombre)
    {
        if (jugadores.Remove(nombre))
        {
            Console.WriteLine("Jugador eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("No se encontró un jugador con ese nombre.");
        }
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
