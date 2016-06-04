using System;
using System.Collections.Generic;
using System.Linq;

public class Palindromes
{
    public static void Main()
    {
        string[] text = Console.ReadLine().Split(new char[] {' ', ',', '.','!', '?', ':', ';', '\\'}, StringSplitOptions.RemoveEmptyEntries);
        List<string> palindromes = new List<string>();

        foreach (var word in text)
        {
            if (word.Equals(string.Join("", word.Reverse())))
                palindromes.Add(word);
        }
        palindromes.Sort();
        Console.WriteLine("[" + string.Join(", ", palindromes) + "]");

    }
}