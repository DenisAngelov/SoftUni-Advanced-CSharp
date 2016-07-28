using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class LineNumbers
{
    public static void Main()
    {
        Console.WriteLine("Read file number: 1,2 or 3?");
        int fileNum = int.Parse(Console.ReadLine());
        string txtFile = "0" + fileNum + "_LinesIn.txt";
        string resultFile = "0" + fileNum + "LinesOut.txt";

        using (StreamReader reader = new StreamReader(txtFile))
        {
            string currLine = string.Empty;
            int lineCounter = 1;

            using (StreamWriter writer = new StreamWriter (resultFile))
            {
                while (!string.IsNullOrEmpty(currLine = reader.ReadLine()))
                {
                    writer.WriteLine(lineCounter + ". " + currLine);
                    lineCounter++;
                }
            }
        }
    }
}