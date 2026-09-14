using System;
using System.Collections.Generic;

// EXCEEDING REQUIREMENTS:
// 1. Library of 3 scriptures with random selection
// 2. HideRandomWords only hides visible words (stretch challenge)
// 3. Hides 3 words at a time

class Program
{
    static void Main(string[] args)
    {
        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be and men are that they might have joy.")
        };

        Scripture scripture = scriptures[new Random().Next(scriptures.Count)];
        string input = "";
        while (input.ToLower()!= "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();
            if (input.ToLower()!= "quit") scripture.HideRandomWords(3);
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}
