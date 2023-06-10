using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void PerformActivity()
    {
        StartActivity();

        for (int i = 0; i < _duration; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(5);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountdown(5);
            Console.WriteLine();
            Console.WriteLine();
        }
        EndActivity();
    }
}
