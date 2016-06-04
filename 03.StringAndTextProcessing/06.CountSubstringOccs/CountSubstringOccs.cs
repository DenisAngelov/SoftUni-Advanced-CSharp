using System;
using System.Collections.Generic;
using System.Linq;

public class CountSubstringOccs
{
    public static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string pattern = Console.ReadLine().ToLower();
        int numOfOccs = 0;

        int indexOfOcc = text.IndexOf(pattern);
        while (indexOfOcc!= -1)
        {
            numOfOccs++;
            indexOfOcc = text.IndexOf(pattern, indexOfOcc + 1);
        }
        Console.WriteLine(numOfOccs);
    }
}