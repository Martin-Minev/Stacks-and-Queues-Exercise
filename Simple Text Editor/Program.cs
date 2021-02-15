using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            Stack<string> stackOfText = new Stack<string>();
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int numberOfCommand = int.Parse(input[0]);

                if (numberOfCommand == 1)
                {
                    string someText = input[1];

                    stackOfText.Push(text.ToString());
                    text.Append(someText);
                }
                else if (numberOfCommand == 2)
                {
                    int countOfElements = int.Parse(input[1]);
                    stackOfText.Push(text.ToString());
                    string newText = text.ToString().Substring(0, text.Length - countOfElements);
                    text.Clear();
                    text.Append(newText);
                }
                else if (numberOfCommand == 3)
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(text[index - 1].ToString());
                }
                else if (numberOfCommand == 4)
                {
                    string newText = stackOfText.Pop();
                    text.Clear();
                    text.Append(newText);
                }
            }
        }
    }
}
