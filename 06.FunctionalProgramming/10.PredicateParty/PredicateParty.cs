using System;
using System.Collections.Generic;
using System.Linq;

public class PredicateParty
{
    public static void Main()
    {
        List<string> people = Console.ReadLine().Split(' ').ToList();
        Predicate<string> startsCmd = s => s.Contains("Starts");
        Predicate<string> endsCmd = s => s.Contains("Ends");
        string command;

        while ((command = Console.ReadLine()) != "Party!")
        {
            string[] currComand = command.Split(' ');

            switch (currComand[0])
            {
                case "Remove":
                    if (startsCmd(currComand[1]))
                    {

                    }else if (endsCmd(currComand[1]))
                    {

                    }

                    break;
                case "Double":
                    if (startsCmd(currComand[1]))
                    {

                    }else if (endsCmd(currComand[1]))
                    {

                    }

                    break;
            }

        }
    }
}