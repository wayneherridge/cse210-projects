using System;

class Program
{
    static void Main()
    {
        // Create event objects
        Event lectureEvent = new Lecture(
            "C# Basics",
            "Introduction to C# programming language",
            DateTime.Parse("2023-07-01"),
            "10:00 AM",
            new Address("123 Main St", "Cityville", "State", "12345"),
            "John Doe",
            100
        );

        Event receptionEvent = new Reception(
            "Company Anniversary",
            "Celebrating 10 years of success",
            DateTime.Parse("2023-07-05"),
            "6:00 PM",
            new Address("456 Elm St", "Townsville", "State", "54321"),
            "rsvp@example.com"
        );

        Event outdoorGatheringEvent = new OutdoorGathering(
            "Summer Picnic",
            "Enjoy a fun-filled day in the park",
            DateTime.Parse("2023-07-10"),
            "12:00 PM",
            new Address("789 Oak St", "Village", "State", "67890"),
            "Sunny with a high of 80°F"
        );

        // Generate and display marketing messages
        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Event:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event:");
        Console.WriteLine(outdoorGatheringEvent.GetStandardDetails());
        Console.WriteLine(outdoorGatheringEvent.GetFullDetails());
        Console.WriteLine(outdoorGatheringEvent.GetShortDescription());
    }
}
