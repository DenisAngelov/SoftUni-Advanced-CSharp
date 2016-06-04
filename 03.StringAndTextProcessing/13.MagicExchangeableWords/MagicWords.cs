using System;
using System.Collections.Generic;
using System.Linq;

public class MagicWords
{
    public static void Main()
    {
        string[] data = Console.ReadLine().Split(' ');
        string bigger = data[0].Length >= data[1].Length ? data[0] : data[1];
        string smaller = data[0].Length < data[1].Length ? data[0] : data[1];
        Dictionary<char, char> chars = new Dictionary<char, char>();
        bool magic = true;

        for (int i = 0; i < smaller.Length; i++)
        {
            if (!chars.ContainsKey(bigger[i]))
                chars.Add(bigger[i], smaller[i]);
            else if (chars[bigger[i]] != smaller[i])
            {
                magic = false;
                break;
            }
        }

        if (magic)
        {
            for (int i = smaller.Length; i < bigger.Length; i++)
            {
                if (!chars.ContainsKey(bigger[i]))
                {
                    magic = false;
                    break;
                }
            }
        }

        Console.WriteLine(magic.ToString().ToLower());

    }
}