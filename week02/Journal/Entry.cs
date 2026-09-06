public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;

    public void Display()
    {
        System.Console.WriteLine($"Date: {_date} - Mood: {_mood}");
        System.Console.WriteLine($"Prompt: {_promptText}");
        System.Console.WriteLine($"{_entryText}\n");
    }
}
