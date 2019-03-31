using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter 5 or more numbers e.g. 5, 1, 9, 2, 10");

                string input = Console.ReadLine();

                numbers = input.Split(',').Select(int.Parse).ToList();

                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid list");
                    continue;
                }
                else
                {
                    numbers.Sort();
                    Console.WriteLine("Three smallest numbers: {0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);
                    break;
                }                
            }
            Console.ReadLine();
        }
    }
}
