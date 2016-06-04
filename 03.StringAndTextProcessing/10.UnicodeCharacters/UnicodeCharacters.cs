using System;
using System.Collections.Generic;
using System.Linq;

public class UnicodeCharacters
{
    public static void Main(string[] args)
    {
        string data = Console.ReadLine();
        foreach (var chr in data)
        {
            Console.Write("\\u{0:x4}", (int)chr);
        }
        Console.WriteLine();
    }
}