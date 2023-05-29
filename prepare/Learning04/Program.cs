using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Assignment step1 = new Assignment();
        Console.WriteLine(step1.GetSummary());
        
        Console.WriteLine();

        MathAssignment step4 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(step4.GetSummary());
        Console.WriteLine(step4.GetHomeWorkList());

        Console.WriteLine();

        WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());

        Console.WriteLine();
    }
}