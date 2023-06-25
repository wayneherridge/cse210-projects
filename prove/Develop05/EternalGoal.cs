using System;

public class EternalGoal : Goal
{
    private int _totalRecordedEvents;

    public EternalGoal()
    {
        _totalRecordedEvents = 0;
    }

    public override void RecordEvent()
    {
        _totalRecordedEvents++;
    }

    public override string GetGoalStatus()
    {
        return "Never Complete";
    }

    public override string GetFormattedGoal()
    {
        return $"Name: {_goalName}\nDescription: {_goalDescription}\nStatus: {GetGoalStatus()}\nTotal Recorded Events: {_totalRecordedEvents}";
    }
}
