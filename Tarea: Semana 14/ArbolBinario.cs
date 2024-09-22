using System;

public class Node
{
    public int Value;
    public Node Left, Right;

    public Node(int item)
    {
        Value = item;
        Left = Right = null;
    }
}

public class BinarySearchTree
{
    public Node Root;

    // Inserción en el árbol binario
    public void Insert(int value)
    {
        Root = InsertRec(Root, value);
    }

    private Node InsertRec(Node root, int value)
    {
        if (root == null)
        {
            root = new Node(value);
            return root;
        }

        if (value < root.Value)
            root.Left = InsertRec(root.Left, value);
        else if (value > root.Value)
            root.Right = InsertRec(root.Right, value);

        return root;
    }

    // Eliminación en el árbol binario
    public Node Delete(Node root, int value)
    {
        if (root == null) return root;

        if (value < root.Value)
            root.Left = Delete(root.Left, value);
        else if (value > root.Value)
            root.Right = Delete(root.Right, value);
        else
        {
            if (root.Left == null)
                return root.Right;
            else if (root.Right == null)
                return root.Left;

            root.Value = MinValue(root.Right);
            root.Right = Delete(root.Right, root.Value);
        }

        return root;
    }

    private int MinValue(Node root)
    {
        int minv = root.Value;
        while (root.Left != null)
        {
            minv = root.Left.Value;
            root = root.Left;
        }
        return minv;
    }

    // Búsqueda en el árbol binario
    public Node Search(Node root, int value)
    {
        if (root == null || root.Value == value)
            return root;

        if (value < root.Value)
            return Search(root.Left, value);

        return Search(root.Right, value);
    }

    // Recorrido Inorden
    public void InOrder(Node root)
    {
        if (root != null)
        {
            InOrder(root.Left);
            Console.Write(root.Value + " ");
            InOrder(root.Right);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Muestra un mensaje de inicio
        Console.WriteLine("Bienvenido al sistema de árboles binarios");

        // Llamar a la lógica del menú
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- Menú Árbol Binario ---");
            Console.WriteLine("1. Insertar un valor");
            Console.WriteLine("2. Eliminar un valor");
            Console.WriteLine("3. Buscar un valor");
            Console.WriteLine("4. Recorrer en Inorden");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Inserta un nuevo valor en el árbol
                    Console.Write("Ingrese el valor a insertar: ");
                    int insertValue = int.Parse(Console.ReadLine());
                    bst.Insert(insertValue);
                    Console.WriteLine("Valor insertado.");
                    break;
                case 2:
                    // Elimina un valor del árbol
                    Console.Write("Ingrese el valor a eliminar: ");
                    int deleteValue = int.Parse(Console.ReadLine());
                    bst.Root = bst.Delete(bst.Root, deleteValue);
                    Console.WriteLine("Valor eliminado.");
                    break;
                case 3:
                    // Busca un valor en el árbol
                    Console.Write("Ingrese el valor a buscar: ");
                    int searchValue = int.Parse(Console.ReadLine());
                    Node result = bst.Search(bst.Root, searchValue);
                    if (result != null)
                        Console.WriteLine("Valor encontrado: " + result.Value);
                    else
                        Console.WriteLine("Valor no encontrado.");
                    break;
                case 4:
                    // Recorre el árbol en inorden
                    Console.WriteLine("Recorrido Inorden:");
                    bst.InOrder(bst.Root);
                    Console.WriteLine();
                    break;
                case 5:
                    // Sale del programa
                    exit = true;
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    // Opción no válida
                    Console.WriteLine("Opción no válida, intente nuevamente.");
                    break;
            }
        }
    }
}
