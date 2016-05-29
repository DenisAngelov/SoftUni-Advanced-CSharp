using System;
using System.Collections.Generic;
using System.Linq;

public class MinerTask
{
    public static void Main(string[] args)
    {
        string data;
        Dictionary<string, int> resources = new Dictionary<string, int>();
        int counter = 1;
        string resource = string.Empty;

        while ((data = Console.ReadLine()) != "stop")
        {
            if (counter % 2 != 0)
                resource = data;
            else
                if (!resources.ContainsKey(resource))
                    resources.Add(resource, int.Parse(data));
                else
                    resources[resource] += int.Parse(data);
            counter++;
        }

        foreach (var pair in resources)
        {
            Console.WriteLine(pair.Key + " -> " + pair.Value);
        }

    }
}