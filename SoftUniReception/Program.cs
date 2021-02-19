using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstStudent = int.Parse(Console.ReadLine());
            int secondStudent = int.Parse(Console.ReadLine());
            int thirdStudent = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int studentsPerHour = firstStudent + secondStudent + thirdStudent;
            int hours = 0;
            while (studentsCount > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }
                studentsCount -= studentsPerHour;
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
