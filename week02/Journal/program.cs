using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        Console.WriteLine("Welcome to the Journal Program!");
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n1. Write  2. Display  3. Load  4. Save  5. Quit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                Console.Write("Mood? ");
                string mood = Console.ReadLine();
                Entry e = new Entry();
                e._date = DateTime.Now.ToShortDateString();
                e._promptText = prompt;
                e._entryText = response;
                e._mood = mood;
                theJournal.AddEntry(e);
            }
            else if (choice == "2") theJournal.DisplayAll();
            else if (choice == "3") { Console.Write("File to load: "); theJournal.LoadFromFile(Console.ReadLine()); }
            else if (choice == "4") { Console.Write("File to save: "); theJournal.SaveToFile(Console.ReadLine()); }
            else if (choice == "5") running = false;
        }
    }
}
