using System;

public class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal()
    {
        isComplete = false;
    }

    public bool IsComplete
    {
        get { return isComplete; }
    }

    public override void RecordEvent()
    {
        isComplete = true;
    }

    public override string GetGoalStatus()
    {
        return isComplete ? "[X]" : "[ ]";
    }

    public override string GetFormattedGoal()
    {
        return $"Name: {_goalName}\nDescription: {_goalDescription}\nStatus: {GetGoalStatus()}";
    }
}
