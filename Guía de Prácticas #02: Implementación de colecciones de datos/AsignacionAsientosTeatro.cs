using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();

        // Simulación de personas llegando en orden
        for (int i = 1; i <= 100; i++)
        {
            queue.Enqueue("Asistente " + i);
        }

        // Asignación de asientos en orden de llegada
        int asiento = 1;
        while (queue.Count > 0)
        {
            string asistente = queue.Dequeue();
            Console.WriteLine($"{asistente} ha sido asignado al asiento {asiento}");
            asiento++;
        }
    }
}
