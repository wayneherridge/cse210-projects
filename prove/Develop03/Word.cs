using System;


public class Word
{
    private string text;
    private bool isHidden;

    public string Text
    {
        get { return text; }
        set { text = value; }
    }

    public bool IsHidden
    {
        get { return isHidden; }
        set { isHidden = value; }
    }
}