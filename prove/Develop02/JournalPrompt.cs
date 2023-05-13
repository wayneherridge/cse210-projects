using System;

public class JournalPrompt
{
    List<string> promptList = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Did you read your scriptures today?",
        "Who inspired you today?",
        "What made you grateful today?",
        "Did you have any 'me time' today?",
        "What were two great things that happened today, and one not-so-great?",
        "What are you planning to do after dinner tonight?",
        "What's something difficult you had to do today?",
        "What was the most interesting thing I saw or heard today?",
        "What did I learn today?",
        "What was the most fun thing I did today?",
        "What was the most surprising thing that happened today?"
    };
    public string GeneratePrompt()
    {
        Random rand = new Random();
        int randomNumber = rand.Next(0,9);
        string prompt = promptList[randomNumber];
        return prompt;
    }
}