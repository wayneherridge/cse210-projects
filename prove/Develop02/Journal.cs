using System;
using System.IO;
using System.Collections.Generic;


public class Journal
{
    private string _userFileName;
    public List<JournalEntry> _journal = new List<JournalEntry>();

    public void DisplayEntries()
    {
        foreach (JournalEntry n in _journal)
        {
            n.DisplayEntry();
        }
    }

    public void SaveEntries()
{
        Console.Write("What would you like to name your file? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (JournalEntry entries in _journal)
            {
                outputFile.WriteLine($"{entries._entryNumber}, {entries._currentDate}, {entries._prompt}, {entries._response}");
            }
        }
        Console.WriteLine("Journal saved to " + _userFileName);
    }


    public void LoadEntries()
    {
        Console.Write("What your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (File.Exists(_userFileName))
        {
            List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split(", ");

                JournalEntry entry = new JournalEntry();

                entry._entryNumber = entries[0];
                entry._currentDate = entries[1];
                entry._prompt = entries[2];
                entry._response = entries[3];

                _journal.Add(entry);
            }
            Console.WriteLine(_userFileName + " sucessfully loaded!");
        }
        
    }
}
