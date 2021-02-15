using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] orderInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> orders = new Queue<int>(orderInput);

            Console.WriteLine(orders.Max());
            while (orders.Any())
            {
                int currentOrder = orders.Peek();
                if (food >= currentOrder)
                {
                    food -= currentOrder;
                    currentOrder = orders.Dequeue();
                }
               else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    break;
                }
            }
            if (!orders.Any())
            {
                Console.WriteLine("Orders complete");
            }
            
        }
    }
}
