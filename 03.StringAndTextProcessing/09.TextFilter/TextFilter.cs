using System;
using System.Collections.Generic;

public class TextFilter
{
    public static void Main()
    {
        string[] words = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();

        foreach (var word in words)
        {
            string filter = new string('*', word.Length);
            text = text.Replace(word, filter);
        }
        Console.WriteLine(text);
    }
}