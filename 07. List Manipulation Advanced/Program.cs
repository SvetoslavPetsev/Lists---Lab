using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main()
        {
            List<int> someNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool haveChangesList = false;

            while (true)
            {
                List<string> command = Console.ReadLine()
                    .Split()
                    .ToList();

                if (command[0] == "end")
                {
                    if (haveChangesList)
                    {
                        Console.WriteLine(string.Join(" ", someNumbers));
                    }
                    break;
                }

                List<int> result = new List<int>();

                if (command[0] == "Add" ||
                    command[0] == "Remove" ||
                    command[0] == "RemoveAt" ||
                    command[0] == "Insert")

                    haveChangesList = true;
                {
                    switch (command[0])
                    {
                        case "Add":
                            someNumbers.Add(int.Parse(command[1]));
                            break;
                        case "Remove":
                            someNumbers.Remove(int.Parse(command[1]));
                            break;
                        case "RemoveAt":
                            someNumbers.RemoveAt(int.Parse(command[1]));
                            break;
                        case "Insert":
                            someNumbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                            break;
                    }
                
                }
                switch (command[0])
                {
                    case "Contains":
                        int checkThisContains = int.Parse(command[1]);

                        if (someNumbers.Contains(checkThisContains) == true)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        continue;

                    case "PrintEven":
                        for (int i = 0; i < someNumbers.Count; i++)
                        {
                            if (someNumbers[i] % 2 == 0)
                            {
                                result.Add(someNumbers[i]);
                            }
                        }     
                        break;

                    case "PrintOdd":
                        for (int i = 0; i < someNumbers.Count; i++)
                        {
                            if (someNumbers[i] % 2 == 1)
                            {
                                result.Add(someNumbers[i]);
                            }
                        }
                        break;

                    case "GetSum":

                        result.Add(someNumbers.Sum());

                        break;

                    case "Filter":
                        string condition = command[1];
                        int number = int.Parse(command[2]);
                        switch (command[1])
                        {
                            case "<":
                                for (int i = 0; i < someNumbers.Count; i++)
                                {
                                    if (someNumbers[i] < number)
                                    {
                                        result.Add(someNumbers[i]);
                                    }
                                }
                                break;
                            case "<=":
                                for (int i = 0; i < someNumbers.Count; i++)
                                {
                                    if (someNumbers[i] <= number)
                                    {
                                        result.Add(someNumbers[i]);
                                    }
                                }
                                break;
                            case ">":
                                for (int i = 0; i < someNumbers.Count; i++)
                                {
                                    if (someNumbers[i] > number)
                                    {
                                        result.Add(someNumbers[i]);
                                    }
                                }
                                break;
                            case ">=":
                                for (int i = 0; i < someNumbers.Count; i++)
                                {
                                    if (someNumbers[i] >= number)
                                    {
                                        result.Add(someNumbers[i]);
                                    }
                                }
                                break;     
                        }
                        break;
                }
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
