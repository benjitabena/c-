using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        string expresionPostfija = "3 4 + 5 *";
        string expresionSinRpn = ConvertirPostfijaAInfija(expresionPostfija);
        Console.WriteLine($"Expresión sin RPN: {expresionSinRpn}");
    }

    static string ConvertirPostfijaAInfija(string expresionPostfija)
    {
        Stack<string> pila = new Stack<string>();
        string[] elementos = expresionPostfija.Split(' ');

        foreach (string elemento in elementos)
        {
            if (EsOperando(elemento))
            {
                pila.Push(elemento);
            }
            else
            {
                if (pila.Count < 2)
                {
                    throw new InvalidOperationException("introduciste una expresion RPN que no es valida jaj.");
                }

                string operando2 = pila.Pop();
                string operando1 = pila.Pop();
                string expresionSinRpn = $"({operando1} {elemento} {operando2})";
                pila.Push(expresionSinRpn);
            }
        }

        if (pila.Count != 1)
        {
            throw new InvalidOperationException("Introduciste una expresion RPN que no es valida jsj.");
        }

        return pila.Pop();
    }

    static bool EsOperando(string elemento)
    {
        double result;
        return double.TryParse(elemento, out result);
    }
}
