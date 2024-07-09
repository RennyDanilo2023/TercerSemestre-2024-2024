using System;
using System.Collections.Generic;

public static class VerificacionBalanceo
{
    public static void Main(string[] args)
    {
        string formula = "{7+(8*5)-[(9-7)+(4+1)]}";
        bool estaBalanceada = VerificarBalanceo(formula);
        Console.WriteLine($"La fórmula '{formula}' está balanceada: {estaBalanceada}");
    }

    /**
     * VerificarBalanceo: Función para verificar si los paréntesis en una fórmula matemática están balanceados.
     */
    public static bool VerificarBalanceo(string formula)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in formula)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                pila.Push(c); // Agrega el carácter de apertura a la pila
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (pila.Count == 0)
                {
                    return false; // No hay paréntesis de apertura para el cierre actual
                }

                char top = pila.Pop(); // Saca el carácter de apertura de la pila

                if (!Coinciden(top, c))
                {
                    return false; // Los paréntesis no coinciden
                }
            }
        }

        return pila.Count == 0; // Verifica que no queden paréntesis sin cerrar en la pila
    }

    /**
     * Coinciden: Función auxiliar para verificar si un paréntesis de apertura y uno de cierre coinciden.
     */
    private static bool Coinciden(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '[' && cierre == ']') ||
               (apertura == '{' && cierre == '}');
    }
}
