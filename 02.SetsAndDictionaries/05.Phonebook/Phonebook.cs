using System;
using System.Collections.Generic;
using System.Linq;

public class Phonebook
{
    public static void Main(string[] args)
    {
        string input;
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        while ((input = Console.ReadLine()) != "search")
        {
            
            string[] data = input.Split('-');
            if (!phoneBook.ContainsKey(data[0]))
                phoneBook.Add(data[0], data[1]);
            else
                phoneBook[data[0]] = data[1];
        }
        while ((input = Console.ReadLine()) != "stop")
        {
            
            string name = input;
            if (!phoneBook.ContainsKey(name))
                Console.WriteLine("Contact " + name + " does not exist.");
            else
                Console.WriteLine(name + " -> " + phoneBook[name]);
        }
    }
}