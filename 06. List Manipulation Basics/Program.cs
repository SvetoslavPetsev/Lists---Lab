using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main()
        {
            List<int> someNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                if (input[0] == "end")
                {
                    break;
                }
                switch (input[0])
                {
                    case "Add":
                        someNumbers.Add(int.Parse(input[1]));
                        break;
                    case "Remove":
                        someNumbers.Remove(int.Parse(input[1]));
                        break;
                    case "RemoveAt":
                        someNumbers.RemoveAt(int.Parse(input[1]));
                        break;
                    case "Insert":
                        someNumbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", someNumbers));
        }
    }
}
