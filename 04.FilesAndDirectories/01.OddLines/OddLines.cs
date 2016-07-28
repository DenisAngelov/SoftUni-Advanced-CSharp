using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class OddLines
{
    public static void Main()
    {
        Console.WriteLine("Read document: 1, 2 or 3?");
        int fileNum = int.Parse(Console.ReadLine());
        string txtFile = "0" + fileNum + "_OddLinesIn.txt";

        using (StreamReader reader = new StreamReader(txtFile))
        {
            string currLine = string.Empty;
            int lineCounter = 0;

            while (!string.IsNullOrEmpty(currLine = reader.ReadLine()))
            {
                if (lineCounter % 2 != 0)
                    Console.WriteLine(currLine);
                lineCounter++;
            }
        }
    }
}