using System;
using System.Collections.Generic;
using System.Linq;

public class MaxElement
{
    public static void Main(string[] args)
    {
        int entries = int.Parse(Console.ReadLine());
        Stack<int> values = new Stack<int>();
        int maxNum = int.MinValue;

        for (int entry = 0; entry < entries; entry++)
        {
            string command = Console.ReadLine();
            switch (command[0])
            {
                case '1':
                    int[] input = command.Split(' ').Skip(1).Select(int.Parse).ToArray();
                    values.Push(input[0]);
                    if (maxNum < input[0])
                        maxNum = input[0];
                    break;
                case '2':
                    int removedNum = values.Pop();
                    if (maxNum == removedNum && values.Count == 0)
                        maxNum = 0;
                    else if (maxNum == removedNum)
                        maxNum = values.Max();
                    break;
                case '3': Console.WriteLine(maxNum); break;
            }
        }
    }
}