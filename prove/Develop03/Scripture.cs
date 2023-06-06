using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string reference;
    private List<Word> words;

    public string Reference
    {
        get { return reference; }
        set { reference = value; }
    }

    public List<Word> Words
    {
        get { return words; }
        set { words = value; }
    }

    public void HideRandomWords()
    {
        var random = new Random();
        var hiddenWords = words.Where(w => !w.IsHidden).ToList();
        var count = Math.Min(3, hiddenWords.Count);
        
        for (int i = 0; i < count; i++)
        {
            var index = random.Next(hiddenWords.Count);
            hiddenWords[index].IsHidden = true;
            hiddenWords.RemoveAt(index);
        }
    }

    public string GetRenderedText()
    {
        var renderedText = "";
        foreach (var word in words)
        {
            if (word.IsHidden)
                renderedText += "___ ";
            else
                renderedText += word.Text + " ";
        }
        return renderedText.Trim();
    }
}