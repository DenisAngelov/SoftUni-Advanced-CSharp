using System;
using System.Collections.Generic;
using System.Linq;

public class HandsOfCards
{
    public static void Main(string[] args)
    {
        string input = string.Empty;
        Dictionary<string, Dictionary<int, HashSet<int>>> handsOfCards = new Dictionary<string, Dictionary<int, HashSet<int>>>();

        while ((input = Console.ReadLine()) != "JOKER")
        {
            string[] currHand = input.Split(new char[] {':', ','}, StringSplitOptions.RemoveEmptyEntries);
            string name = currHand[0];

            if (!handsOfCards.ContainsKey(name))
            {
                handsOfCards.Add(name, new Dictionary<int, HashSet<int>>());
                for (int i = 1; i <= 4; i++)
                    handsOfCards[name].Add(i, new HashSet<int>());
            }

            int face = 0;
            int suite = 0;

            for (int card = 1; card < currHand.Length; card++)
            {
                string currCard = currHand[card].Trim();
                string newCard = currCard.Replace("0", "");
                face = GetFace(newCard[0].ToString());
                suite = GetSuite(newCard[1].ToString());

                if (!handsOfCards[name][suite].Contains(face))
                    handsOfCards[name][suite].Add(face);
            }
        }

        foreach (var player in handsOfCards)
        {
            int sumOfHand = 0;
            foreach (var suiteHand in player.Value)
                sumOfHand += suiteHand.Key * suiteHand.Value.Sum();

            Console.WriteLine("{0}: {1}", player.Key, sumOfHand);
        }
    }

    public static int GetSuite(string suite)
    {
        switch (suite)
        {
            case "S": return 4;
            case "H": return 3;
            case "D": return 2;
            case "C": return 1;
            default: return 0;
        }
    }

    public static int GetFace(string face)
    {
        switch (face)
        {
            case "1": return 10;
            case "J": return 11;
            case "Q": return 12;
            case "K": return 13;
            case "A": return 14;
            default: return int.Parse(face);
        }
    }

}