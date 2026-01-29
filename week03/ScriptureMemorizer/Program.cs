using System;
using System.Collections.Generic;

class Program
{
    /*
     * EXCEEDING REQUIREMENTS:
     * - Program uses a library of scriptures and selects one at random
     * - Only hides words that are not already hidden (smarter randomization)
     */

    static void Main(string[] args)
    {
       List<Scripture> scriptures = new List<Scripture>
{
    new Scripture(
        new Reference("Joshua", 24, 15),
        "Choose you this day whom ye will serve whether the gods which your fathers served that were on the other side of the flood or the gods of the Amorites in whose land ye dwell but as for me and my house we will serve the Lord."
    ),
    new Scripture(
        new Reference("2 Nephi", 2, 25),
        "Adam fell that men might be and men are that they might have joy."
    )
};

        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}
