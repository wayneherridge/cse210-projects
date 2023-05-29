using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public Assignment()
    {
        _studentName = "Samuel Bennett";
        _topic = "Multiplication";
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}