using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("======================================================");
        Console.WriteLine("|          Inheritance with Event Planning           |");
        Console.WriteLine("======================================================");
        Console.ResetColor();
        Console.WriteLine();

        Address address1 = new Address("University of Southampton", "Highfield Campus Building 100", "Southampton", "SO17 1BJ");
        Address address2 = new Address("City of Portsmouth College", "Tudor Crescent", "Portsmouth", "PO6 2SA");
        Address address3 = new Address("Queen Elizabeth Country Park", "Gravel Hill", "Horndean", "PO8 0QE");

        Event lectureEvent = new Lecture("Stem Cells and organoids", "a future for complex translational biology", new DateTime(2023, 7, 14), new TimeSpan(9, 0, 0), address1, "Ward Thomas", 100);
        Event receptionEvent = new Reception("Company Anniversary", "Celebrating 10 years of success", new DateTime(2023, 8, 15), new TimeSpan(19, 0, 0), address2, "wayne.herridge@copc.ac.uk");
        Event outdoorGatheringEvent = new OutdoorGathering("Summer Picnic", "Enjoy a fun-filled day in the park", new DateTime(2023, 7, 25), new TimeSpan(12, 0, 0), address3, "Sunny with a high of 80°F");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Standard Details");
        Console.WriteLine("================");
        Console.ResetColor();
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(outdoorGatheringEvent.GetStandardDetails());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nFull Details:");
        Console.WriteLine("================");
        Console.ResetColor();
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(outdoorGatheringEvent.GetFullDetails());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nShort Description:");
        Console.WriteLine("================");
        Console.ResetColor();
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine(outdoorGatheringEvent.GetShortDescription());

        Console.ReadLine();
    }
}
