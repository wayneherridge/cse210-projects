using System;
using System.IO;

public class JournalEntry
{
    public string _entryNumber = "";
    public string _prompt = "";
    public string _response = "";
    public string _currentDate = "";

    
    public void DisplayEntry()
    {
        Console.WriteLine($"\nid: {_entryNumber}");
        Console.WriteLine($"Date: {_currentDate}, Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_response}");
    }

    // constructor
    public JournalEntry()
    {

    }
}