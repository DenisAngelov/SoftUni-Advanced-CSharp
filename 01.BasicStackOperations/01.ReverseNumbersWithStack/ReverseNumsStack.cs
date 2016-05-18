using System;
using System.Collections.Generic;
using System.Linq;

public class ReverseNumsStack
{
    public static void Main(string[] args)
    {
        Stack<int> numbers = new Stack<int>(Console.ReadLine().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
        Console.WriteLine(String.Join(" ", numbers));
    }
}