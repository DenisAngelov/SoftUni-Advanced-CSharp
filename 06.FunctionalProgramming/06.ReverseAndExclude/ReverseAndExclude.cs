using System;
using System.Collections.Generic;
using System.Linq;


public class ReverseAndExclude
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int divBy = int.Parse(Console.ReadLine());
        Predicate<int> isDiv = n => n % divBy == 0;
        string result = string.Empty;

        for (int num = numbers.Length - 1; num >= 0; num--)
        {
            if (!isDiv(numbers[num]))
                result += $" {numbers[num]}";
        }
        Console.WriteLine(result.Trim());
    }
}