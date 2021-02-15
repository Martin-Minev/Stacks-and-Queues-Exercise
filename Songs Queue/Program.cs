using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allSongsInput = Console.ReadLine().Split(", ");
            Queue<string> allSongs = new Queue<string>(allSongsInput);

            while (allSongs.Any())
            {
                string input = Console.ReadLine();
                string[] comms = input.Split();
                string command = comms[0];
                switch (command)
                {
                    case "Play":
                        allSongs.Dequeue();
                        break;
                    case "Add":
                        StringBuilder sb = new StringBuilder();
                        char charToTrim = ' ';
                        for (int i = 1; i < comms.Length; i++)
                        {
                            sb.Append(comms[i]);
                            sb.Append(" ");
                        }
                        string songToTrim = sb.ToString();
                        string currentSong = songToTrim.Trim(charToTrim);
                        if (allSongs.Contains(currentSong))
                        {
                            Console.WriteLine($"{currentSong} is already contained!");
                        }
                        else
                        {
                            allSongs.Enqueue(currentSong);
                        }
                        break;
                    case "Show":
                        Console.WriteLine($"{string.Join(", ", allSongs)}");
                        break;
                }
                if (!allSongs.Any())
                {
                    Console.WriteLine("No more songs!");
                }
            }
        }
    }
}
