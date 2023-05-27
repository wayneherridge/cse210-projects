using System;

class Program
{
    static void Main(string[] args)
    {
        // Clear the console
        Console.Clear();

        Reference reference = new Reference();
        reference.LoadRef();
        Scripture scripture = new Scripture();
        scripture.LoadScriptures();
        Word word = new Word();

        //  Show the welcome message
        Console.WriteLine("\n-----------------------------------------");
        Console.WriteLine("Welcome to The Scripture Memorizer Program!");
        Console.WriteLine("-------------------------------------------\n");

        int userChoice = 0;

        while (userChoice != 3)
        {
            userChoice = UserChoice();

            switch (userChoice)
            {
                case 1:
                    reference.DisplayRef();

                    break;
                case 2:
                    string script = scripture.RandomScripture();
                    string ref1 = reference.GetRef(scripture);
                    word.GetRenderedText(scripture);
                    word.GetRenderedRef(scripture);

                    while (word._hidden.Count < word._result.Length)
                    {
                        word.Show(ref1);
                        word.GetReadKey();
                    }
                    word.Show(ref1);
                    break;
                case 3:
                    Console.WriteLine("\n Come back to learn another verse soon! \n");
                    break;
                default:
                    Console.WriteLine($"\nPlease enter 1,2 or Q!");
                    break;
            }
        }
    }

    static int UserChoice()
    // Method to display choices to user
    {
        Reference reference = new Reference();

        string choices = $@"

Please select one of the following options:
1. Display all available scripture references
2. Randomly select a scripture to work on
Q. Quit

What would you like to do?  ";

        Console.Write(choices);

        string userInput = Console.ReadLine();
        userInput.ToLower();
        int userChoice = 0;
        try
        {
            if (userInput == "q")
            {
                userInput = "3";
            }
            userChoice = int.Parse(userInput);
        }
        catch (FormatException)
        {
            userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return userChoice;
    }
}