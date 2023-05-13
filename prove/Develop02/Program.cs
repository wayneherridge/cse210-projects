using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        int[] validNumbers = { 1, 2, 3, 4, 5 };
        int action = 0;

        //  Show the welcome message
        Console.WriteLine("\n-------------------------------");
        Console.WriteLine("Welcome to The Journal Program!");
        Console.WriteLine("-------------------------------\n");

        Journal journal = new Journal();
        JournalPrompt jp = new JournalPrompt();
    
        Console.WriteLine(" ** - Main Menu - **");
        Console.WriteLine("--------------------");

        while (action != 5)
        {
            action = Menu();

            switch (action)
            {
                case 1:
                    // Write Journal Entry
                    string entryId = GetEntryId();
                    string dateInfo = GetDateTime();
                    string prompt = jp.GeneratePrompt();

                    JournalEntry entry = new JournalEntry();
                    entry._entryNumber = entryId;
                    entry._currentDate = dateInfo;
                    entry._prompt = prompt;

                    Console.Write($"{prompt}\n");
                    Console.Write("> ");
                    string userEntry = Console.ReadLine();
                    entry._response = userEntry;

                    journal._journal.Add(entry);

                    break;
                case 2:
                    // Display Journal Entries
                    journal.DisplayEntries();
                    break;
                case 3:
                    // Load text file
                    journal.LoadEntries();
                    break;
                case 4:
                    // Save to text file
                    journal.SaveEntries();
                    break;
                case 5:
                    // Quit
                    Console.WriteLine("\nThank you for using the Journal App!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }

    static int Menu()
    // Method to display choices to user
    {
        string menuItems = @"
Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do? ";

        Console.Write(menuItems);
        string userInput = Console.ReadLine();
        int action = 0;
        // This block catches any non integer values that are entered
        try
        {
            action = int.Parse(userInput);
        }
        catch (FormatException)
        {
            action = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return action;
    }

    static string GetDateTime()
        // Method to get the date and time for journal record
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        return currentDateTime;
    }

        static string GetEntryId()
    {
        Guid entryuuid = Guid.NewGuid();
        string entryuuidAsString = entryuuid.ToString();

        return entryuuidAsString;
    }
}
