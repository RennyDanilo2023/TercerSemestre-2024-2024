using System;
using System.Collections.Generic;

public static class TorresDeHanoi
{
    static Stack<int> torreA = new Stack<int>();
    static Stack<int> torreB = new Stack<int>();
    static Stack<int> torreC = new Stack<int>();

    public static void Main(string[] args)
    {
        Console.Write("Cuántos discos contiene la torre: ");
        int numDiscos = int.Parse(Console.ReadLine());

        InicializarTorre(numDiscos);
        DibujarTorres();

        Resolver(numDiscos, torreA, torreC, torreB);
    }

    /**
     * Resolver: Función recursiva para resolver el problema de las Torres de Hanoi.
     */
    static void Resolver(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar)
    {
        if (n == 1)
        {
            MoverDisco(origen, destino);
            DibujarTorres();
        }
        else
        {
            Resolver(n - 1, origen, auxiliar, destino);
            MoverDisco(origen, destino);
            DibujarTorres();
            Resolver(n - 1, auxiliar, destino, origen);
        }
    }

    /**
     * MoverDisco: Función para mover un disco de una torre a otra.
     */
    static void MoverDisco(Stack<int> origen, Stack<int> destino)
    {
        destino.Push(origen.Pop());
    }

    /**
     * DibujarTorres: Función para mostrar el estado actual de las torres.
     */
    static void DibujarTorres()
    {
        Console.WriteLine("Estado de las Torres:");
        Console.WriteLine("Torre A: {0}", string.Join(", ", torreA.Reverse()));
        Console.WriteLine("Torre B: {0}", string.Join(", ", torreB.Reverse()));
        Console.WriteLine("Torre C: {0}", string.Join(", ", torreC.Reverse()));
        Console.WriteLine(new string('*', 30));
    }

    /**
     * InicializarTorre: Función para inicializar la torre con el número de discos dado.
     */
    static void InicializarTorre(int numDiscos)
    {
        torreA.Clear();
        torreB.Clear();
        torreC.Clear();

        for (int i = numDiscos; i >= 1; i--)
        {
            torreA.Push(i);
        }
    }
}
