using System;
using System.Collections.Generic;

public class Base10ToN
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int systemBase = int.Parse(input[0]);
        decimal decNumber = decimal.Parse(input[1]);
        string result = "";
        do
        {
            result = decNumber % systemBase + result;
            decNumber /= systemBase;
        } while (decNumber > 0);

        Console.WriteLine(result);
    }
}