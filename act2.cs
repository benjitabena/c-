using System;

class Multiplos 
{
    static int SumMultiples(int[] numbers, int n)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            if (number % n == 0)
            {
                sum += number;
            }
        }
        return sum;
    }

    static void Main()
    {
        int[] arr = new int[4] { 16, 3, 5, 20 };
        int n = 4;

        int result = SumMultiples(arr, n);
        Console.WriteLine("La suma de los números múltiplos de " + n + " en el arreglo es: " + result);
    }
}
