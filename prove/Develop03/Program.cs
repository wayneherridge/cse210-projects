using System;

class Program
{
    static void Main()
    {
        var scripture = new Scripture();
        var reference = new Reference();
        var words = new List<Word>();

        // Set the scripture reference
        reference.Book = "John";
        reference.Chapter = 3;
        reference.Verse = 16;

        scripture.Reference = $"{reference.Book} {reference.Chapter}:{reference.Verse}";

        // Set the scripture text
        var scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        var textWords = scriptureText.Split(' ');

        foreach (var wordText in textWords)
        {
            var word = new Word();
            word.Text = wordText;
            word.IsHidden = false;
            words.Add(word);
        }

        scripture.Words = words;

        // Display the complete scripture
        Console.Clear();
        Console.WriteLine($"{scripture.Reference}:");
        Console.WriteLine(scripture.GetRenderedText());

        while (true)
        {
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");

            var input = Console.ReadLine();
            if (input == "quit")
                break;
            Console.Clear();
            scripture.HideRandomWords();
            Console.WriteLine($"{scripture.Reference}:");
            Console.WriteLine(scripture.GetRenderedText());
        }
    }
}