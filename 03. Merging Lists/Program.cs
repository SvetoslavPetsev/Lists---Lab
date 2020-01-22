using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main()
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int capacity = firstList.Count + secondList.Count;
            List<int> finalList = new List<int>(capacity);

            for (int i = 0; i < Math.Max(firstList.Count,secondList.Count); i++)
            {
                if (i < Math.Min(firstList.Count, secondList.Count))
                {
                    finalList.Add(firstList[i]);
                    finalList.Add(secondList[i]);
                    continue;
                }
                if (firstList.Count > secondList.Count)
                {
                    finalList.Add(firstList[i]);
                }
                else
                {
                    finalList.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
