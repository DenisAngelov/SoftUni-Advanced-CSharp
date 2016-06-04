using System;
using System.Collections.Generic;

public class CharMultiplier
{
    public static void Main()
    {
        string[] data = Console.ReadLine().Split(' ');
        string bigger = data[0].Length >= data[1].Length ? data[0] : data[1];
        string smaller = data[0].Length < data[1].Length ? data[0] : data[1];

        Console.WriteLine(MultiplyChars(bigger, smaller));

    }

    public static int MultiplyChars(string bigger, string smaller)
    {
        int sum = 0;

        for (int letter = 0; letter < smaller.Length; letter++)
            sum += bigger[letter] * smaller[letter];

        foreach (char letter in bigger.Substring(smaller.Length))
            sum += letter;

        return sum;
    }
}