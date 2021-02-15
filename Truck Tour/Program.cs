using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumpsCount = int.Parse(Console.ReadLine());
            Queue<string> pumpsData = new Queue<string>();

            for (int i = 0; i < pumpsCount; i++)
            {
                pumpsData.Enqueue(Console.ReadLine());
            }
            for (int i = 0; i < pumpsCount; i++)
            {
                bool isSuccessful = true;
                int currentFuel = 0;
                for (int j = 0; j < pumpsCount; j++)
                {
                    string dataElement = pumpsData.Dequeue();
                    int[] pumpData = dataElement.Split().Select(int.Parse).ToArray();
                    pumpsData.Enqueue(dataElement);

                    int fuel = pumpData[0];
                    int distance = pumpData[1];
                    currentFuel += fuel;
                    currentFuel -= distance;
                    if (currentFuel < 0)
                    {
                        isSuccessful = false;
                    }
                }
                if (isSuccessful)
                {
                    Console.WriteLine(i);
                    break;
                }
                string tempData = pumpsData.Dequeue();
                pumpsData.Enqueue(tempData);
            }
        }
    }
}

