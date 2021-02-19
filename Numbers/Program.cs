using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int avg = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                avg += numbers[i];
            }
            var middleNumbers = avg * 1.0 / numbers.Count;
            int counter = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > middleNumbers)
                {
                    result.Add(numbers[i]);
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
                return;
            }
            result.Sort();
            result.Reverse();

           
            Console.WriteLine(string.Join(" ", result.Skip(0).Take(5)));
        }
    }
}
