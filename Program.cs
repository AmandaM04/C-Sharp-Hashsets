using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string>Showroom = new HashSet<string>();
            {
            Showroom.Add("Avalon");
            Showroom.Add("Maxima");
            Showroom.Add("Denali");
            Showroom.Add("Escalade");
            Showroom.Add("Maxima");
            }
            Console.Write("Showroom contains {0} elements:", Showroom.Count);
            DisplaySet(Showroom);

            HashSet<string>UsedLot = new HashSet<string>();
            {
            UsedLot.Add("Sonata");
            UsedLot.Add("Impala");

            UsedLot.Remove("Impala");
            }
            Console.Write("Showroom contains {0} elements:", UsedLot.Count);
            DisplaySet(UsedLot);

            HashSet<string> Showroom2 = new HashSet<string>(Showroom);
        Console.WriteLine("Showroom2 UnionWith UsedLot...");
        Showroom2.UnionWith(UsedLot);

        Console.Write("numbers contains {0} elements: ", Showroom2.Count);
        DisplaySet(Showroom2);

        HashSet<string>Junkyard = new HashSet<string>();
            {
            Junkyard.Add("Impala");
            Junkyard.Add("Taurus");
            Junkyard.Add("Malibu");
            Junkyard.Add("Expedition");
            Junkyard.Add("Maxima");

            // UsedLot.Remove("Impala");
            }
            Console.Write("Showroom contains {0} elements:", Junkyard.Count);
            DisplaySet(Junkyard);

            HashSet<string> Junkyard2 = new HashSet<string>(Showroom);
        Console.WriteLine("Junkyard2 UnionWith UsedLot...");
        Junkyard2.IntersectWith(Junkyard);

        Console.Write("Junkyard2 contains {0} elements: ", Junkyard2.Count);
        DisplaySet(Junkyard2);

        }
        private static void DisplaySet(HashSet<string> Showroom)
    {
        Console.Write("{");
        foreach (string i in Showroom)
        {
            Console.Write(" {0}", i);
        }
        Console.WriteLine(" }");
    }
    }
}
