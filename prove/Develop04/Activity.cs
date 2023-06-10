using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        this._name = name;
        this._description = description;
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
        Console.Write("|");
        Thread.Sleep(200);
        Console.Write("\b/");
        Thread.Sleep(200);
        Console.Write("\b-");
        Thread.Sleep(200);
        Console.Write("\b\\");
        Thread.Sleep(200);
        Console.Write("\b \b");
    }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }

    public void StartActivity()
    {
        Console.Clear();

        Console.WriteLine("Welcome to the {0} Activity.", _name);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.Write("Get ready...");
        ShowSpinner(6);
        Console.WriteLine();
        Console.WriteLine();

    }

    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(4);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
        ShowSpinner(5);

    }
}
