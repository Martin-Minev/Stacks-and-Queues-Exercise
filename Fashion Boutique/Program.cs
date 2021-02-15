using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allClothesInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> allClothes = new Stack<int>(allClothesInput);
            int rackCapacity = int.Parse(Console.ReadLine());
            int currentRackCapacity = rackCapacity;
            int racksCount = 1;

            while (allClothes.Any())
            {
                int cloth = allClothes.Pop();
                currentRackCapacity -= cloth;
                if (currentRackCapacity < 0)
                {
                    racksCount++;
                    currentRackCapacity = rackCapacity - cloth;
                }
            }
            Console.WriteLine(racksCount);
        }
    }
}
