using System;
using System.Collections.Generic;

class GrafoNoDirigido
{
    private int V; // Número de vértices
    private List<int>[] adj; // Lista de adyacencia

    public GrafoNoDirigido(int vertices)
    {
        V = vertices;
        adj = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AgregarArista(int v, int w)
    {
        adj[v].Add(w);
        adj[w].Add(v); // Al ser un grafo no dirigido, se agrega en ambas direcciones
    }

    public void MostrarGrafo()
    {
        Console.WriteLine("Lista de Adyacencia del Grafo No Dirigido:");
        for (int i = 0; i < V; i++)
        {
            Console.Write("Nodo " + (char)('A' + i) + ": ");
            foreach (var nodo in adj[i])
            {
                Console.Write((char)('A' + nodo) + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        GrafoNoDirigido grafo = new GrafoNoDirigido(5);

        // Agregar aristas según el ejemplo del documento
        grafo.AgregarArista(0, 1); // A <-> B
        grafo.AgregarArista(0, 3); // A <-> D
        grafo.AgregarArista(1, 2); // B <-> C
        grafo.AgregarArista(1, 3); // B <-> D
        grafo.AgregarArista(2, 4); // C <-> E
        grafo.AgregarArista(3, 4); // D <-> E

        grafo.MostrarGrafo();
    }
}
