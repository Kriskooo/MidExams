using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopingList = Console.ReadLine().Split("!").ToList();

            List<string> command = Console.ReadLine().Split(' ').ToList();
            while (command[0] != "Go" && command[1] != "Shopping!")
            {
                if (command[0] == "Urgent")
                {
                    if (shopingList.Contains(command[1]))
                    {
                    }
                    else
                    {
                        shopingList.Insert(0, command[1]);
                    }
                }
                else if (command[0] == "Unnecessary")
                {
                    if (shopingList.Contains(command[1]))
                    {
                        shopingList.Remove(command[1]);
                    }
                }
                else if (command[0] == "Correct")
                {
                    if (shopingList.Contains(command[1]))
                    {

                        for (int i = 0; i < shopingList.Count; i++)
                        {
                            if (shopingList[i].Contains(command[1]))
                            {
                                shopingList.RemoveAt(i);
                                shopingList.Insert(i, command[2]);
                            }
                        }
                    }
                }
                else if (command[0] == "Rearrange")
                {
                    if (shopingList.Contains(command[1]))
                    {
                        for (int i = 0; i < shopingList.Count; i++)
                        {
                            if (shopingList[i].Contains(command[1]))
                            {
                                shopingList.RemoveAt(i);
                                shopingList.Add(command[1]);
                            }
                        }
                    }
                }
                command.Clear();
                command = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(", ", shopingList));
        }
    }
}
