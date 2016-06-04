using System;
using System.Collections.Generic;
using System.Linq;

public class StringLength
{
    public static void Main()
    {
        string data = Console.ReadLine();

        for (int i = 0; i < 20; i++)
        {
            try
            {
                Console.Write(data[i]);
            }
            catch
            {
                Console.Write("*");
            }
        }
        Console.WriteLine();
    }
}