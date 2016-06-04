using System;
using System.Collections.Generic;
using System.Linq;

public class FormattingNumbers
{
    public static void Main(string[] args)
    {
        
        string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int a = int.Parse(input[0]);
        float b = float.Parse(input[1]);
        float c = float.Parse(input[2]);
        Console.WriteLine("|{0,-10}|{1,10}|{2,10:0.00}|{3,-10:0.000}|", a.ToString("X"), Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
    }
}