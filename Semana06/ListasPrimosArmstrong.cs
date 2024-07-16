using System;
using System.Collections.Generic;

public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{
    private Node head;

    public void Add(int data, bool addToEnd = true)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            if (addToEnd)
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }
    }

    public int Count()
    {
        int count = 0;
        Node current = head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }

    public void Print()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

public class Program
{
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    public static bool IsArmstrong(int number)
    {
        int sum = 0;
        int temp = number;
        int digits = number.ToString().Length;

        while (temp != 0)
        {
            int remainder = temp % 10;
            sum += (int)Math.Pow(remainder, digits);
            temp /= 10;
        }

        return sum == number;
    }

    static void Main()
    {
        LinkedList primeList = new LinkedList();
        LinkedList armstrongList = new LinkedList();

        Random random = new Random();
        for (int i = 0; i < 50; i++)
        {
            int number = random.Next(1, 1000);
            if (IsPrime(number))
            {
                primeList.Add(number);
            }
            if (IsArmstrong(number))
            {
                armstrongList.Add(number, addToEnd: false);
            }
        }

        Console.WriteLine("Prime List:");
        primeList.Print();
        Console.WriteLine("Armstrong List:");
        armstrongList.Print();

        Console.WriteLine($"Number of elements in Prime List: {primeList.Count()}");
        Console.WriteLine($"Number of elements in Armstrong List: {armstrongList.Count()}");

        if (primeList.Count() > armstrongList.Count())
        {
            Console.WriteLine("Prime List has more elements.");
        }
        else if (primeList.Count() < armstrongList.Count())
        {
            Console.WriteLine("Armstrong List has more elements.");
        }
        else
        {
            Console.WriteLine("Both lists have the same number of elements.");
        }
    }
}
