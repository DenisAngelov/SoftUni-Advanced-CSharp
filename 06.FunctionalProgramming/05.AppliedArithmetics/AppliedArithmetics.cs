using System;
using System.Linq;


public class AppliedArithmetics
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string command = string.Empty;

        while ((command = Console.ReadLine()) != "end")
        {
            switch (command)
            {
                case "add": numbers = AddOne(numbers); break;
                case "multiply": numbers = MultiplyByTwo(numbers); break;
                case "subtract": numbers = SubstractOne(numbers); break;
                case "print": Console.WriteLine(string.Join(" ", numbers)); break;
            }
        }
    }

    public static int[] AddOne(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
            numbers[i]++;
        return numbers;
    }

    public static int[] MultiplyByTwo(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
            numbers[i] *= 2;
        return numbers;
    }

    public static int[] SubstractOne(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
            numbers[i]--;
        return numbers;
    }
}