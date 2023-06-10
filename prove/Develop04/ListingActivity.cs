using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private static readonly Random random = new Random();
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who are the people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void PerformActivity()
    {
        StartActivity();

        Console.WriteLine("List as many responses you can to the following prompt:");
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"--- {prompt} ---");

        Console.Write("You may begin in: ");
        ShowCountdown(5);

        List<string> _items = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        Console.WriteLine();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            _items.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {_items.Count} items!");

        EndActivity();
    }
}
