/*using System;
using System.Collections.Generic;

class Program
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
                    throw new InvalidOperationException("introduciste una expresion RPN que no es válida.");
                }

                string operando2 = pila.Pop();
                string operando1 = pila.Pop();
                string expresionSinRpn = $"({operando1} {elemento} {operando2})";
                pila.Push(expresionSinRpn);
            }
        }

        if (pila.Count != 1)
        {
            throw new InvalidOperationException("Introduciste una expresion RPN que no es válida.");
        }

        return pila.Pop();
    }

    static bool EsOperando(string elemento)
    {
        double result;
        return double.TryParse(elemento, out result);
    }
}*/
/*using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de valores que desea alojar en la cola: ");
        if (!int.TryParse(Console.ReadLine(), out int cantidadDeValores))
        {
            Console.WriteLine("Error: Debe ingresar un número entero.");
            return;
        }

        Queue<int> cola = new Queue<int>();

        for (int i = 0; i < cantidadDeValores; i++)
        {
            int valor;
            do
            {
                Console.Write($"Ingrese el valor {i + 1}: ");
            } while (!int.TryParse(Console.ReadLine(), out valor));

            cola.Enqueue(valor);
        }

        FiltrarValoresPares(cola);

        Console.WriteLine("Valores pares en la cola:");

        foreach (int valor in cola)
        {
            Console.WriteLine(valor);
        }
    }

    static void FiltrarValoresPares(Queue<int> cola)
    {
        int elementosOriginales = cola.Count;

        for (int i = 0; i < elementosOriginales; i++)
        {
            int valor = cola.Dequeue();
            if (valor % 2 == 0)
            {
                cola.Enqueue(valor);
            }
        }
    }
}*/

/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa una cadena: ");
        string input = Console.ReadLine();

        if (EsPalindromo(input))
        {
            Console.WriteLine("La cadena es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La cadena no es un palíndromo.");
        }
    }

    static bool EsPalindromo(string cadena)
    {
        cadena = cadena.Replace(" ", "").ToLower();
        char[] caracteres = cadena.ToCharArray();
        Array.Reverse(caracteres);
        string cadenaInvertida = new string(caracteres);
        return cadena == cadenaInvertida;
    }
}*/
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> cola = CargarColaDesdeConsola();
        Console.Write("Ingresa 1 para ordenar ascendente o -1 para ordenar descendente: ");
        int n = int.Parse(Console.ReadLine());

        Queue<int> colaOrdenada = OrdenarCola(cola, n);

        Console.WriteLine("Cola Ordenada:");
        foreach (int elemento in colaOrdenada)
        {
            Console.Write(elemento + " ");
        }
    }

    static Queue<int> CargarColaDesdeConsola()
    {
        Queue<int> cola = new Queue<int>();

        Console.Write("Ingresa una serie de números separados por espacios: ");
        string entrada = Console.ReadLine();
        string[] numeros = entrada.Split(' ');

        foreach (string numero in numeros)
        {
            if (int.TryParse(numero, out int valor))
            {
                cola.Enqueue(valor);
            }
        }

        return cola;
    }

    static Queue<int> OrdenarCola(Queue<int> cola, int n)
    {
        if (n == 1)
        {
            Queue<int> colaAscendente = new Queue<int>();

            while (cola.Count > 0)
            {
                int min = int.MaxValue;
                int count = cola.Count;

                for (int i = 0; i < count; i++)
                {
                    int elemento = cola.Dequeue();
                    min = Math.Min(min, elemento);
                    cola.Enqueue(elemento);
                }

                for (int i = 0; i < count; i++)
                {
                    int elemento = cola.Dequeue();
                    if (elemento == min)
                    {
                        colaAscendente.Enqueue(elemento);
                    }
                    else
                    {
                        cola.Enqueue(elemento);
                    }
                }
            }

            return colaAscendente;
        }
        else if (n == -1)
        {
            Queue<int> colaDescendente = new Queue<int>();

            while (cola.Count > 0)
            {
                int max = int.MinValue;
                int count = cola.Count;

                for (int i = 0; i < count; i++)
                {
                    int elemento = cola.Dequeue();
                    max = Math.Max(max, elemento);
                    cola.Enqueue(elemento);
                }

                for (int i = 0; i < count; i++)
                {
                    int elemento = cola.Dequeue();
                    if (elemento == max)
                    {
                        colaDescendente.Enqueue(elemento);
                    }
                    else
                    {
                        cola.Enqueue(elemento);
                    }
                }
            }

            return colaDescendente;
        }
        else
        {
            return new Queue<int>();
        }
    }
}
