using System;
using System.Collections.Generic;

namespace Translate
{
    class Translate {
        static void Main(string[] args)
        {
            Dictionary<string, string> EnFr =
                new Dictionary<string, string>();

            EnFr.Add("red", "rouge");
            EnFr.Add("white", "blanc");
            EnFr.Add("blue", "bleu");
            EnFr.Add("green", "vert");
            EnFr.Add("black", "noir");

            string EnWord = "";
            while (EnWord != "q"){   // quit
                Console.WriteLine("Please enter English word to Translate into French or (q)uit:");
                EnWord = Console.ReadLine();

                if (EnFr.TryGetValue(EnWord, out string Fr))
                {
                    Console.WriteLine(Fr);
                }
            }
        }
    }
}
