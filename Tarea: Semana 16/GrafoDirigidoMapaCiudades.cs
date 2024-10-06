using System;

class GrafoDirigido
{
    private int[,] adjMatrix;

    public GrafoDirigido(int vertices)
    {
        adjMatrix = new int[vertices, vertices];
    }

    public void AgregarArista(int v, int w)
    {
        adjMatrix[v, w] = 1; // Arista dirigida de v a w
    }

    public void MostrarGrafo()
    {
        Console.WriteLine("Matriz de Adyacencia del Grafo Dirigido:");
        for (int i = 0; i < adjMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < adjMatrix.GetLength(1); j++)
            {
                Console.Write(adjMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        GrafoDirigido grafo = new GrafoDirigido(4);

        // Agregar aristas según el ejemplo del documento
        grafo.AgregarArista(0, 1); // X -> Y
        grafo.AgregarArista(0, 2); // X -> Z
        grafo.AgregarArista(1, 2); // Y -> Z
        grafo.AgregarArista(2, 3); // Z -> W

        grafo.MostrarGrafo();
    }
}
