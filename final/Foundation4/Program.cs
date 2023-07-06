using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create activity objects
        Activity runningActivity = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Activity cyclingActivity = new Cycling(new DateTime(2022, 11, 3), 30, 9.7);
        Activity swimmingActivity = new Swimming(new DateTime(2022, 11, 3), 30, 5);

        // Add activities to the list
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
