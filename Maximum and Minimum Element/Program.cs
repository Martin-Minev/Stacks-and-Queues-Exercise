using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> sequence = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] comms = input.Split();
                string command = comms[0];
                switch (command)
                {
                    case "1":
                        int digit = int.Parse(comms[1]);
                        sequence.Push(digit);
                        break;
                    case "2":
                        if (sequence.Any())
                        {
                            sequence.Pop();
                        }
                        break;
                    case "3":
                        if (sequence.Any())
                        {
                            Console.WriteLine(sequence.Max());
                        }
                        break;
                    case "4":
                        if (sequence.Any())
                        {
                            Console.WriteLine(sequence.Min());
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
