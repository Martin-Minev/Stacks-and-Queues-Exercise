using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bullets = new Stack<int>(bulletsInput);

            int[] locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> locks = new Queue<int>(locksInput);

            int valueOfIntelligence = int.Parse(Console.ReadLine());
            int bulletsCount = 0;
            int currentGunBarrelSize = gunBarrelSize;
            while (bullets.Any() && locks.Any())
            {
                bulletsCount++;
                currentGunBarrelSize--;

                int currentBullet = bullets.Pop();
                int currentLock = locks.Peek();
                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (currentGunBarrelSize == 0 && bullets.Any())
                {
                    currentGunBarrelSize = gunBarrelSize;
                    Console.WriteLine("Reloading!");
                }
            }
            if (!locks.Any())
            {
                int moneyEarned = valueOfIntelligence - (bulletsCount * bulletPrice);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
