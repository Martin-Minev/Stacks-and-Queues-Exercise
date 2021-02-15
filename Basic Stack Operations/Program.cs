using System;
using System.Linq;
using System.Collections.Generic;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = data[0];
            int s = data[1];
            int x = data[2];
            bool conatainsX = false;
            int[] numbersInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new Stack<int>();  // numbersInput
            for (int i = 0; i < n; i++)
            {
                numbers.Push(numbersInput[i]);
            }

            for (int i = 0; i < s; i++)
            {
                numbers.Pop();
            }
            if (numbers.Contains(x))
            {
                conatainsX = true;
                Console.WriteLine("true");
            }
            else if (!numbers.Any())
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}
