using System;
using System.Collections.Generic;
using System.Linq;

public class ReverseString
{
    public static void Main()
    {
        string data = Console.ReadLine();
        Console.WriteLine(string.Join("", data.Reverse()));
    }

}