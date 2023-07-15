using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("==========================================================");
        Console.WriteLine("|          Polymorphism with Exercise Tracking           |");
        Console.WriteLine("==========================================================");
        Console.ResetColor();
        Console.WriteLine();

        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(DateTime.Parse("2023-07-15"), 30, 3.0));
        activities.Add(new Cycling(DateTime.Parse("2023-07-14"), 30, 9.7));
        activities.Add(new Swimming(DateTime.Parse("2023-07-13"), 30, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}