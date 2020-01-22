using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int a = numbers.Count / 2;

            for (int i = 0; i < a; i++)
            {
                numbers[i] = numbers[i] + numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
