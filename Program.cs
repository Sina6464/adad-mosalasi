using System;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows for the triangle pattern: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < n; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}