using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

public class WordCount
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Read file number: 1,2 or 3?");
        int filenum = int.Parse(Console.ReadLine());
        string wordsFile = "words" + filenum + ".txt";
        string txtFile = "text" + filenum + ".txt";
        Dictionary<string, int> wordOcc = new Dictionary<string, int>();

        using (StreamReader wordsReader = new StreamReader (wordsFile))
        {
            string[] words = wordsReader.ReadLine().Split(' ');

            foreach (string word in words)
                wordOcc.Add(word, 0);
        }
        
        Queue<int> occs = new Queue<int>();

        using (StreamReader textReader = new StreamReader (txtFile))
        {
            string currLine = string.Empty;

            while (!string.IsNullOrEmpty(currLine = textReader.ReadLine()))
            {
                
                foreach (var word in wordOcc)
                {
                    occs.Enqueue(Regex.Matches(currLine, word.Key).Count);
                }

            }
        }

        foreach (var pair in wordOcc)
        {
            Console.WriteLine(pair.Key + "-" + pair.Value);
        }

    }
}