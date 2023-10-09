using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "(())()"; 
        bool resultado = VerificarParentesis(input);
        
        if (resultado)
        {
            Console.WriteLine("Los paréntesis están balanceados.");
        }
        else
        {
            Console.WriteLine("Los paréntesis no están balanceados.");
        }
    }

    static bool VerificarParentesis(string input)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '(')
            {
                pila.Push(c);
            }
            else if (c == ')')
            {
                if (pila.Count == 0 || pila.Peek() != '(')
                {
                    return false;
                }
                pila.Pop();
            }
        }
        return pila.Count == 0;
    }
}
