using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();

        // Simulación de personas llegando en orden
        for (int i = 1; i <= 30; i++)
        {
            queue.Enqueue("Pasajero " + i);
        }

        // Asignación de asientos en orden de llegada
        int asiento = 1;
        while (queue.Count > 0)
        {
            string pasajero = queue.Dequeue();
            Console.WriteLine($"{pasajero} ha sido asignado al asiento {asiento}");
            asiento++;
        }
    }
}
