using System;
using System.Collections.Generic;
using System.Linq;

public class CountSymbols
{
    public static void Main(string[] args)
    {
        char[] input = Console.ReadLine().ToCharArray();
        Dictionary<char, int> symbolCount = new Dictionary<char, int>();
        Array.Sort(input);

        for (int chara = 0; chara < input.Length; chara++)
        {
            char currChar = input[chara];
            if (!symbolCount.ContainsKey(currChar))
                symbolCount.Add(currChar, 0);
            symbolCount[currChar]++;
        }

        foreach (var pair in symbolCount)
            Console.WriteLine(pair.Key + ": " + pair.Value + " time/s");
    }
}