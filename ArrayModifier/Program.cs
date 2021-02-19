using System;
using System.Collections.Generic;
using System.Linq;
namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> command = new List<string>();
            while (command != "end")
            {
                string[] commands = command.Split().ToList;
                string first = command[0];
                if (input == "swap")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    int temp1 = numbers[index1];
                    numbers[index1] = numbers[index2];
                    numbers[index2] = temp1;
                }
                else if (input == "multiply")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    numbers[index1] = numbers[index2] * numbers[index1];
                }
                else if (input == "decrease")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] = numbers[i] - 1;
                    }
                }
            }
            input = Console.ReadLine();
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

