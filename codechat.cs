using System;
using System.Linq;

class Program
{
    const int MAX = 100;

    static int Sum(int[] arr)
    {
        return arr.Sum();
    }

    static void Main()
    {
        Console.Write("Enter the number of elements (1-100): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1 || n > MAX)
        {
            Console.WriteLine("Invalid input. Please provide a digit ranging from 1 to 100.");
            return;
        }

        int[] arr = new int[n];

        Console.WriteLine($"Enter {n} integers:");
        foreach (int i in Enumerable.Range(0, n))
        {
            if (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
                return;
            }
        }

        int total = Sum(arr);

        Console.WriteLine($"Sum of the numbers: {total}");
    }
}